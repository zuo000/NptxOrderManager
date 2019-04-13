using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Interface
    {
        public static List<string> GetAllDistrictNames()
        {
            var ds = DAL.MySQLHelper.QueryOrderTable("select distinct customer_district from order_table");

            List<string> list = new List<string>();
            foreach(DataRow dis in ds.Tables[0].Rows)
            {
                list.Add(dis[0].ToString());
            }

            return list;
        }

        public static List<string> GetAllProductBrands()
        {
            var ds = DAL.MySQLHelper.QueryOrderTable("select distinct product_brand from order_table");

            List<string> list = new List<string>();
            foreach (DataRow dis in ds.Tables[0].Rows)
            {
                list.Add(dis[0].ToString());
            }

            return list;
        }

        public static List<string> GetAllProductName()
        {
            var ds = DAL.MySQLHelper.QueryOrderTable("select distinct product_name from order_table");

            List<string> list = new List<string>();
            foreach (DataRow dis in ds.Tables[0].Rows)
            {
                list.Add(dis[0].ToString());
            }

            return list;
        }

        public static int CheckinDeliverItem(Model.DeliverItem item)
        {
            string sql = "insert into `deliver_table` (`order_id`, `customer_name`, `customer_nick_name`, `customer_address`, `product_brand`, `product_name`, `deliver_date`, `deliver_number`) values ('"
                         + item.OrderId + "','" + item.CustomerName + "','" + item.CustomerNickName + "','"
                         + item.CustomerAddress + "','" + item.ProductBrand + "','" + item.ProductName + "','"
                         + item.DeliverDate + "','" + item.DeliverNumber.ToString() + "')";
            return DAL.MySQLHelper.ExecuteSqlNonQuery(sql);
        }

        public static int CheckinOrder(Model.Order order)
        {
            if (DAL.MySQLHelper.Exists("select * from `order_table` where (`order_id` = '" + order.OrderId + "')"))
            {
                DeleteOrder(order.OrderId);
            }

            Model.DeliverItem item = new Model.DeliverItem();
            item.OrderId = order.OrderId;
            item.CustomerName = order.CustomerName;
            item.CustomerNickName = order.CustomerNickName;
            item.CustomerAddress = order.CustomerAddress;
            item.ProductBrand = order.ProductBrand;
            item.ProductName = order.ProductName;

            if (order.DeliverPeriod.EndsWith("天")) //每3天
            {
                string intervalStr = order.DeliverPeriod.Replace("每", string.Empty).Replace("天", string.Empty);
                ushort interval = Convert.ToUInt16(intervalStr);

                DateTime nextDeliverDate = Convert.ToDateTime(order.DeliverBeginDate);
                ushort alreadyDeliveredNumber = 0;
                ushort deliverNumber = order.DeliverNumberEveryTime;
                bool deliverEnd = false;
                do
                {
                    if (deliverNumber + alreadyDeliveredNumber >= order.ProductOrderNumber)
                    {
                        deliverNumber = Convert.ToUInt16(order.ProductOrderNumber - alreadyDeliveredNumber);
                        deliverEnd = true;
                    }

                    item.DeliverDate = nextDeliverDate.ToString("yyyy-MM-dd");
                    item.DeliverNumber = deliverNumber;
                    //string sql = "insert into `deliver_table` (`order_id`, `customer_name`, `customer_nick_name`, `customer_address`, `product_brand`, `product_name`, `deliver_date`, `deliver_number`) values ('"
                    //             + order.OrderId + "','" + order.CustomerName + "','" + order.CustomerNickName + "','"
                    //             + order.CustomerAddress + "','" + order.ProductBrand + "','" + order.ProductName + "','"
                    //             + nextDeliverDate.ToString("yyyy-MM-dd") + "','" + deliverNumber.ToString() + "')";
                    //DAL.MySQLHelper.ExecuteSqlNonQuery(sql);
                    CheckinDeliverItem(item);

                    alreadyDeliveredNumber += deliverNumber;
                    nextDeliverDate = nextDeliverDate.AddDays(interval);
                } while (!deliverEnd);
            }
            else //每周一周二
            {
                List<DayOfWeek> deliverDayofWeek = new List<DayOfWeek>();
                if (order.DeliverPeriod.Contains("周日"))
                {
                    deliverDayofWeek.Add(DayOfWeek.Sunday);
                }
                if (order.DeliverPeriod.Contains("周一"))
                {
                    deliverDayofWeek.Add(DayOfWeek.Monday);
                }
                if (order.DeliverPeriod.Contains("周二"))
                {
                    deliverDayofWeek.Add(DayOfWeek.Tuesday);
                }
                if (order.DeliverPeriod.Contains("周三"))
                {
                    deliverDayofWeek.Add(DayOfWeek.Wednesday);
                }
                if (order.DeliverPeriod.Contains("周四"))
                {
                    deliverDayofWeek.Add(DayOfWeek.Thursday);
                }
                if (order.DeliverPeriod.Contains("周五"))
                {
                    deliverDayofWeek.Add(DayOfWeek.Friday);
                }
                if (order.DeliverPeriod.Contains("周六"))
                {
                    deliverDayofWeek.Add(DayOfWeek.Saturday);
                }


                ushort deliverNumber = order.DeliverNumberEveryTime;
                ushort alreadyDeliveredNumber = 0;
                bool deliverEnd = false;
                DateTime deliverBeginDate = Convert.ToDateTime(order.DeliverBeginDate);
                DayOfWeek deliverBeginDayofWeek = deliverBeginDate.DayOfWeek;
                foreach(var dow in deliverDayofWeek)
                {
                    if (deliverEnd) break;
                    if (dow >= deliverBeginDayofWeek)//先把本周的牛奶送了
                    {
                        if (deliverNumber + alreadyDeliveredNumber >= order.ProductOrderNumber)
                        {
                            deliverNumber = Convert.ToUInt16(order.ProductOrderNumber - alreadyDeliveredNumber);
                            deliverEnd = true;
                        }
                        //string sql = "insert into `deliver_table` (`order_id`, `customer_name`, `customer_nick_name`, `customer_address`, `product_brand`, `product_name`, `deliver_date`, `deliver_number`) values ('"
                        //             + order.OrderId + "','" + order.CustomerName + "','" + order.CustomerNickName + "','"
                        //             + order.CustomerAddress + "','" + order.ProductBrand + "','" + order.ProductName + "','"
                        //             + deliverBeginDate.AddDays(dow - deliverBeginDayofWeek).ToString("yyyy-MM-dd") + "','" + deliverNumber.ToString() + "')";
                        //DAL.MySQLHelper.ExecuteSqlNonQuery(sql);

                        item.DeliverDate = deliverBeginDate.AddDays(dow - deliverBeginDayofWeek).ToString("yyyy-MM-dd");
                        item.DeliverNumber = deliverNumber;
                        CheckinDeliverItem(item);

                        alreadyDeliveredNumber += deliverNumber;
                    }
                }

                ushort weekIndex = 1;
                while (!deliverEnd)
                {               
                    foreach (var dow in deliverDayofWeek)
                    {
                        if (deliverEnd) break;
                        if (deliverNumber + alreadyDeliveredNumber >= Convert.ToInt32(order.ProductOrderNumber))
                        {
                            deliverNumber = Convert.ToUInt16(order.ProductOrderNumber - alreadyDeliveredNumber);
                            deliverEnd = true;
                        }
                        //string sql = "insert into `deliver_table` (`order_id`, `customer_name`, `customer_nick_name`, `customer_address`, `product_brand`, `product_name`, `deliver_date`, `deliver_number`) values ('"
                        //             + order.OrderId + "','" + order.CustomerName + "','" + order.CustomerNickName + "','"
                        //             + order.CustomerAddress + "','" + order.ProductBrand + "','" + order.ProductName + "','"
                        //             + deliverBeginDate.AddDays(weekIndex*7 + dow - deliverBeginDayofWeek).ToString("yyyy-MM-dd") + "','" + deliverNumber.ToString() + "')";
                        //DAL.MySQLHelper.ExecuteSqlNonQuery(sql);

                        item.DeliverDate = deliverBeginDate.AddDays(weekIndex * 7 + dow - deliverBeginDayofWeek).ToString("yyyy-MM-dd");
                        item.DeliverNumber = deliverNumber;
                        CheckinDeliverItem(item);

                        alreadyDeliveredNumber += deliverNumber;
                    }
                    weekIndex++;
                }
            }

            string cmdBase = "insert into `order_table` (`order_id`, `order_time`, `customer_name`, `customer_nick_name`, `customer_phone_number`, `customer_district`, `customer_address`, `product_brand`, `product_name`, `product_order_number`, `deliver_period`, `deliver_number_everytime`, `deliver_begin_date`, `additional_gifts`, `comments`) values";
            string sqlCommand = cmdBase + "('" + order.OrderId + "','" + order.OrderDateTime + "','" + order.CustomerName + "','"
                                + order.CustomerNickName + "','" + order.CustomerPhoneNumber + "','" + order.CustomerDistrict + "','"
                                + order.CustomerAddress + "','" + order.ProductBrand + "','" + order.ProductName + "','"
                                + order.ProductOrderNumber.ToString() + "','" + order.DeliverPeriod + "','"
                                + order.DeliverNumberEveryTime.ToString() + "','" + order.DeliverBeginDate + "','"
                                + order.AdditionalGifts + "','" + order.Comments + "')";
            return DAL.MySQLHelper.ExecuteSqlNonQuery(sqlCommand);
        }

        public static DataSet GetAllOrderData()
        {
            return DAL.MySQLHelper.QueryOrderTable("select * from order_table");
        }

        public static DataSet GetDeliverItemsByOrderId(string orderId)
        {
            return DAL.MySQLHelper.QueryDeliverTable("select * from deliver_table where (`order_id` = '" + orderId + "')");
        }

        public static DataSet GetOrderDataByColumn(string column_name, string column_content)
        {
            string sqlCmd = "select * from `order_table` where `" + column_name + "` like '%" + column_content + "%'";
            return DAL.MySQLHelper.QueryOrderTable(sqlCmd);
        }

        public static bool DeleteOrder(string order_id)
        {
            string sqlCommand = "delete from `order_table` where (`order_id` = '" + order_id + "')";
            if (DAL.MySQLHelper.ExecuteSqlNonQuery(sqlCommand) != 1)
            {
                return false;
            }

            sqlCommand = "delete from `deliver_table` where (`order_id` = '" + order_id + "')";
            DAL.MySQLHelper.ExecuteSqlNonQuery(sqlCommand);
            return true;
        }

        public static Model.Order QueryOrderById(string order_id)
        {
            Model.Order order = new Model.Order();

            DataSet ds = DAL.MySQLHelper.QueryOrderTable("select * from `order_table` where (`order_id` = '" + order_id + "')");
            order.OrderId = ds.Tables[0].Rows[0][1].ToString();
            order.OrderDateTime = ds.Tables[0].Rows[0][2].ToString();
            order.CustomerName = ds.Tables[0].Rows[0][3].ToString();
            order.CustomerNickName = ds.Tables[0].Rows[0][4].ToString();
            order.CustomerPhoneNumber = ds.Tables[0].Rows[0][5].ToString(); 
            order.CustomerDistrict = ds.Tables[0].Rows[0][6].ToString();
            order.CustomerAddress = ds.Tables[0].Rows[0][7].ToString();
            order.ProductBrand = ds.Tables[0].Rows[0][8].ToString();
            order.ProductName = ds.Tables[0].Rows[0][9].ToString();
            order.ProductOrderNumber = Convert.ToUInt16(ds.Tables[0].Rows[0][10].ToString());
            order.DeliverPeriod = ds.Tables[0].Rows[0][11].ToString();
            order.DeliverNumberEveryTime = Convert.ToUInt16(ds.Tables[0].Rows[0][12].ToString());
            order.DeliverBeginDate = ds.Tables[0].Rows[0][13].ToString();
            order.AdditionalGifts = ds.Tables[0].Rows[0][14].ToString();
            order.Comments = ds.Tables[0].Rows[0][15].ToString();

            return order;
        }
    }
}
