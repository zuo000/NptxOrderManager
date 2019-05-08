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
        private struct DeliverInfoWeekly
        {
            DayOfWeek day;
            ushort number;

            public DayOfWeek Day { get => day; set => day = value; }
            public ushort Number { get => number; set => number = value; }
        };

        public static List<string> GetAllDistrictNames()
        {
            var ds = DAL.MySQLHelper.QueryOrderTable("select distinct customer_district from order_table");

            List<string> list = new List<string>();
            foreach(DataRow dis in ds.Tables[0].Rows)
            {
                if (dis[0].ToString().Length > 0)
                {
                    list.Add(dis[0].ToString());
                }
            }

            return list;
        }

        public static List<string> GetAllProductBrands()
        {
            var ds = DAL.MySQLHelper.QueryOrderTable("select distinct product_brand from order_table");

            List<string> list = new List<string>();
            foreach (DataRow dis in ds.Tables[0].Rows)
            {
                if (dis[0].ToString().Length > 0)
                {
                    list.Add(dis[0].ToString());
                }
            }

            return list;
        }

        public static List<string> GetAllProductName()
        {
            var ds = DAL.MySQLHelper.QueryOrderTable("select distinct product_name from order_table");

            List<string> list = new List<string>();
            foreach (DataRow dis in ds.Tables[0].Rows)
            {
                if (dis[0].ToString().Length > 0)
                {
                    list.Add(dis[0].ToString());
                }
            }

            return list;
        }

        public static List<string> GetAllStatusName()
        {
            var ds = DAL.MySQLHelper.QueryDeliverTable("select distinct deliver_status from deliver_table");

            List<string> list = new List<string>();
            foreach (DataRow dis in ds.Tables[0].Rows)
            {
                if (dis[0].ToString().Length > 0)
                {
                    list.Add(dis[0].ToString());
                }
            }

            return list;
        }

        public static int CheckinDeliverItem(Model.DeliverItem item)
        {
            string sql = "insert into `deliver_table` (`order_id`, `customer_name`, `customer_nick_name`, `customer_district`, `customer_address`, `product_brand`, `product_name`, `deliver_date`, `deliver_number`, `deliver_status`) values ('"
                         + item.OrderId + "','" + item.CustomerName + "','" + item.CustomerNickName + "','" + item.CustomerDistrict + "','"
                         + item.CustomerAddress + "','" + item.ProductBrand + "','" + item.ProductName + "','"
                         + item.DeliverDate + "','" + item.DeliverNumber.ToString() + "','" + item.Status + "')";
            return DAL.MySQLHelper.ExecuteSqlNonQuery(sql);
        }

        private static void GetDailyDeliverIntervalAndNumber(string deliverPlan, ref ushort interval, ref ushort number)
        {
            string intervalStr = deliverPlan.Substring(deliverPlan.IndexOf("每") + 1,
                deliverPlan.IndexOf("天") - deliverPlan.IndexOf("每") - 1);
            interval = Convert.ToUInt16(intervalStr);

            string numStr = deliverPlan.Substring(deliverPlan.IndexOf("天") + 1,
                deliverPlan.IndexOf("袋") - deliverPlan.IndexOf("天") - 1);
            number = Convert.ToUInt16(numStr);
        }

        private static void GetWeeklyDeliverInfo(string deliverPlan, ref List<DeliverInfoWeekly> deliverInfo)
        {
            if (deliverPlan.Contains("周日"))
            {
                string subDeliverPlan = deliverPlan.Substring(deliverPlan.IndexOf("日"));
                string numStr = subDeliverPlan.Substring(subDeliverPlan.IndexOf("日") + 1,
                    subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("日") - 1);
                ushort number = Convert.ToUInt16(numStr);

                DeliverInfoWeekly deliver = new DeliverInfoWeekly
                {
                    Day = DayOfWeek.Sunday,
                    Number = number
                };

                deliverInfo.Add(deliver);
            }
            if (deliverPlan.Contains("周一"))
            {
                string subDeliverPlan = deliverPlan.Substring(deliverPlan.IndexOf("一"));
                string numStr = subDeliverPlan.Substring(subDeliverPlan.IndexOf("一") + 1,
                    subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("一") - 1);
                ushort number = Convert.ToUInt16(numStr);

                DeliverInfoWeekly deliver = new DeliverInfoWeekly
                {
                    Day = DayOfWeek.Monday,
                    Number = number
                };

                deliverInfo.Add(deliver);
            }
            if (deliverPlan.Contains("周二"))
            {
                string subDeliverPlan = deliverPlan.Substring(deliverPlan.IndexOf("二"));
                string numStr = subDeliverPlan.Substring(subDeliverPlan.IndexOf("二") + 1,
                    subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("二") - 1);
                ushort number = Convert.ToUInt16(numStr);

                DeliverInfoWeekly deliver = new DeliverInfoWeekly
                {
                    Day = DayOfWeek.Tuesday,
                    Number = number
                };

                deliverInfo.Add(deliver);
            }
            if (deliverPlan.Contains("周三"))
            {
                string subDeliverPlan = deliverPlan.Substring(deliverPlan.IndexOf("三"));
                string numStr = subDeliverPlan.Substring(subDeliverPlan.IndexOf("三") + 1,
                    subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("三") - 1);
                ushort number = Convert.ToUInt16(numStr);

                DeliverInfoWeekly deliver = new DeliverInfoWeekly
                {
                    Day = DayOfWeek.Wednesday,
                    Number = number
                };

                deliverInfo.Add(deliver);
            }
            if (deliverPlan.Contains("周四"))
            {
                string subDeliverPlan = deliverPlan.Substring(deliverPlan.IndexOf("四"));
                string numStr = subDeliverPlan.Substring(subDeliverPlan.IndexOf("四") + 1,
                    subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("四") - 1);
                ushort number = Convert.ToUInt16(numStr);

                DeliverInfoWeekly deliver = new DeliverInfoWeekly
                {
                    Day = DayOfWeek.Thursday,
                    Number = number
                };

                deliverInfo.Add(deliver);
            }
            if (deliverPlan.Contains("周五"))
            {
                string subDeliverPlan = deliverPlan.Substring(deliverPlan.IndexOf("五"));
                string numStr = subDeliverPlan.Substring(subDeliverPlan.IndexOf("五") + 1,
                    subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("五") - 1);
                ushort number = Convert.ToUInt16(numStr);

                DeliverInfoWeekly deliver = new DeliverInfoWeekly
                {
                    Day = DayOfWeek.Friday,
                    Number = number
                };

                deliverInfo.Add(deliver);
            }
            if (deliverPlan.Contains("周六"))
            {
                string subDeliverPlan = deliverPlan.Substring(deliverPlan.IndexOf("六"));
                string numStr = subDeliverPlan.Substring(subDeliverPlan.IndexOf("六") + 1,
                    subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("六") - 1);
                ushort number = Convert.ToUInt16(numStr);

                DeliverInfoWeekly deliver = new DeliverInfoWeekly
                {
                    Day = DayOfWeek.Saturday,
                    Number = number
                };

                deliverInfo.Add(deliver);
            }
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
            item.CustomerDistrict = order.CustomerDistrict;
            item.CustomerAddress = order.CustomerAddress;
            item.ProductBrand = order.ProductBrand;
            item.ProductName = order.ProductName;
            item.Status = "未完成";

            //if (order.DeliverNumberEveryTime == order.ProductOrderNumber)
            if (order.IsDeliveredOnlyOnce)
            {
                item.DeliverDate = Convert.ToDateTime(order.DeliverBeginDate).ToString("yyyy-MM-dd");
                item.DeliverNumber = order.ProductOrderNumber;
                CheckinDeliverItem(item);
            }
            else
            {
                if (order.DeliverPlan.Contains("天")) //每3天2袋
                {
                    DateTime nextDeliverDate = Convert.ToDateTime(order.DeliverBeginDate);
                    ushort alreadyDeliveredNumber = 0;
                    ushort deliverNumber = 0;
                    ushort interval = 0;
                    bool deliverEnd = false;

                    GetDailyDeliverIntervalAndNumber(order.DeliverPlan, ref interval, ref deliverNumber);
                    
                    do
                    {
                        if (deliverNumber + alreadyDeliveredNumber >= order.ProductOrderNumber)
                        {
                            deliverNumber = Convert.ToUInt16(order.ProductOrderNumber - alreadyDeliveredNumber);
                            deliverEnd = true;
                        }

                        item.DeliverDate = nextDeliverDate.ToString("yyyy-MM-dd");
                        item.DeliverNumber = deliverNumber;
                        CheckinDeliverItem(item);

                        alreadyDeliveredNumber += deliverNumber;
                        nextDeliverDate = nextDeliverDate.AddDays(interval);
                    } while (!deliverEnd);
                }
                else //每周一3袋周二4袋
                {
                    List<DeliverInfoWeekly> deliverInfo = new List<DeliverInfoWeekly>();
                    GetWeeklyDeliverInfo(order.DeliverPlan, ref deliverInfo);

                    //ushort deliverNumber = order.DeliverNumberEveryTime;
                    ushort alreadyDeliveredNumber = 0;
                    bool deliverEnd = false;
                    DateTime deliverBeginDate = Convert.ToDateTime(order.DeliverBeginDate);
                    DayOfWeek deliverBeginDayofWeek = deliverBeginDate.DayOfWeek;

                    ////先把起始日期的送了
                    //if (deliverNumber + alreadyDeliveredNumber >= order.ProductOrderNumber)
                    //{
                    //    deliverNumber = Convert.ToUInt16(order.ProductOrderNumber - alreadyDeliveredNumber);
                    //    deliverEnd = true;
                    //}

                    //item.DeliverDate = deliverBeginDate.ToString("yyyy-MM-dd");
                    //item.DeliverNumber = deliverNumber;
                    //CheckinDeliverItem(item);

                    //alreadyDeliveredNumber += deliverNumber;

                    //先把本周的牛奶送了
                    foreach (var dow in deliverInfo)
                    {
                        if (deliverEnd)
                        {
                            break;
                        }

                        ushort deliverNumber = dow.Number;
                        if (dow.Day >= deliverBeginDayofWeek)
                        {
                            if (deliverNumber + alreadyDeliveredNumber >= order.ProductOrderNumber)
                            {
                                deliverNumber = Convert.ToUInt16(order.ProductOrderNumber - alreadyDeliveredNumber);
                                deliverEnd = true;
                            }

                            item.DeliverDate = deliverBeginDate.AddDays(dow.Day - deliverBeginDayofWeek).ToString("yyyy-MM-dd");
                            item.DeliverNumber = deliverNumber;
                            CheckinDeliverItem(item);

                            alreadyDeliveredNumber += deliverNumber;
                        }
                    }

                    //再送后面的
                    ushort weekIndex = 1;
                    while (!deliverEnd && deliverInfo.Count != 0)
                    {
                        foreach (var dow in deliverInfo)
                        {
                            if (deliverEnd)
                            {
                                break;
                            }

                            ushort deliverNumber = dow.Number;
                            if (deliverNumber + alreadyDeliveredNumber >= Convert.ToInt32(order.ProductOrderNumber))
                            {
                                deliverNumber = Convert.ToUInt16(order.ProductOrderNumber - alreadyDeliveredNumber);
                                deliverEnd = true;
                            }

                            item.DeliverDate = deliverBeginDate.AddDays(weekIndex * 7 + dow.Day - deliverBeginDayofWeek).ToString("yyyy-MM-dd");
                            item.DeliverNumber = deliverNumber;
                            CheckinDeliverItem(item);

                            alreadyDeliveredNumber += deliverNumber;
                        }
                        weekIndex++;
                    }
                }
            }            

            string cmdBase = "insert into `order_table` (`order_id`, `order_time`, `customer_name`, `customer_nick_name`, `customer_phone_number`, `customer_district`, `customer_address`, `product_brand`, `product_name`, `product_order_number`, `deliver_plan`, `deliver_begin_date`, `additional_gifts`, `comments`) values";
            string sqlCommand = cmdBase + "('" + order.OrderId + "','" + order.OrderDateTime + "','" + order.CustomerName + "','"
                                + order.CustomerNickName + "','" + order.CustomerPhoneNumber + "','" + order.CustomerDistrict + "','"
                                + order.CustomerAddress + "','" + order.ProductBrand + "','" + order.ProductName + "','"
                                + order.ProductOrderNumber.ToString() + "','" + order.DeliverPlan + "','"
                                + order.DeliverBeginDate + "','" + order.AdditionalGifts + "','" + order.Comments + "')";
            return DAL.MySQLHelper.ExecuteSqlNonQuery(sqlCommand);
        }

        public static DataSet GetAllOrderData()
        {
            return DAL.MySQLHelper.QueryOrderTable("select * from order_table");
        }

        public static DataSet GetAllDeliverData()
        {
            return DAL.MySQLHelper.QueryDeliverTable("select * from deliver_table");
        }

        public static DataSet GetDeliverItemsByOrderId(string orderId)
        {
            return DAL.MySQLHelper.QueryDeliverTable("select * from deliver_table where (`order_id` = '" + orderId + "')");
        }

        public static DataSet GetDeliverItemsBySearch(string productBrand, string district, string status, string datetime)
        {
            string sql = "select * from deliver_table where (`deliver_date` = '" + datetime + "'";
            if (productBrand != "all")
            {
                sql += " and `product_brand` = '" + productBrand + "'";
            }

            if (district != "all")
            {
                sql += " and `customer_district` = '" + district + "'";
            }

            if (status != "all")
            {
                sql += " and `deliver_status` = '" + status + "'";
            }

            sql += ")";

            return DAL.MySQLHelper.QueryDeliverTable(sql);
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

        public static void DeleteDeliverItem(string deliverId)
        {
            string sqlCommand = "delete from `deliver_table` where (`deliver_id` = '" + deliverId + "')" ;
            DAL.MySQLHelper.ExecuteSqlNonQuery(sqlCommand);
        }

        public static int UpdateDeliverItem(Model.DeliverItem item)
        {
            string sqlCommand = "update `deliver_table` set `deliver_date` = '" + item.DeliverDate + "', `deliver_number` = '" + item.DeliverNumber.ToString() + "' where (`deliver_id` = '" + item.DeliverId + "')";
            return DAL.MySQLHelper.ExecuteSqlNonQuery(sqlCommand);
        }

        public static int UpdateDeliverStatus(string deliverId, string st)
        {
            string sqlCommand = "update `deliver_table` set `deliver_status` = '" + st + "' where (`deliver_id` = '" + deliverId + "')";
            return DAL.MySQLHelper.ExecuteSqlNonQuery(sqlCommand);
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
            order.DeliverPlan = ds.Tables[0].Rows[0][11].ToString();
            order.DeliverBeginDate = ds.Tables[0].Rows[0][12].ToString();
            order.AdditionalGifts = ds.Tables[0].Rows[0][13].ToString();
            order.Comments = ds.Tables[0].Rows[0][14].ToString();

            if (order.DeliverPlan.Length == 0)
            {
                order.IsDeliveredOnlyOnce = true;
            }
            else
            {
                order.IsDeliveredOnlyOnce = false;
            }

            return order;
        }

        public static string QueryLastInsertId()
        {
            DataSet ds = DAL.MySQLHelper.QueryOrderTable("select last_insert_id()");
            return ds.Tables[0].Rows[0][0].ToString();
        }
    }
}
