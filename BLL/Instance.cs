using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class SingleInstance
    {
        public static List<string> GetAllDistrictNames()
        {
            return new List<string>
            {
                "栖霞区",
                "玄武区",
                "秦淮区",
                "建邺区",
                "鼓楼区",
                "浦口区",
                "雨花台区",
                "江宁区",
                "六合区"
            };
        }

        public static List<string> GetAllCommunityNames()
        {
            return new List<string>
            {
                "高科荣境",
                "东方天郡",
                "钟山府",
                "亚东城",
                "康桥圣菲",
                "璞樾钟山",
                "雁鸣山庄",
                "羊山湖花园",
                "仙林新村"
            };
        }

        public static List<string> GetAllProductBrands()
        {
            return new List<string>
            {
                "伊利",
                "蒙牛",
                "君乐宝",
                "金典",
                "特仑苏",
                "光明",
                "圣牧",
                "完达山",
                "卫岗"
            };
        }

        public static List<string> GetAllProductName()
        {
            return new List<string>
            {
                "有机纯牛奶",
                "无菌纯牛奶",
                "儿童成长牛奶",
                "脱脂牛奶"
            };
        }

        public static int CheckinOrder(Model.Order order)
        {
            if (order.DeliverPeriod.EndsWith("天")) //每3天
            {
                string intervalStr = order.DeliverPeriod.Replace("每", string.Empty).Replace("天", string.Empty);
                int interval = Convert.ToInt32(intervalStr);

                DateTime nextDeliverDate = Convert.ToDateTime(order.DeliverBeginDate);
                int alreadyDeliveredNumber = 0;
                int deliverNumber = Convert.ToInt32(order.DeliverNumberEveryTime);
                bool deliverEnd = false;
                do
                {
                    if (deliverNumber + alreadyDeliveredNumber >= Convert.ToInt32(order.ProductOrderNumber))
                    {
                        deliverNumber = Convert.ToInt32(order.ProductOrderNumber) - alreadyDeliveredNumber;
                        deliverEnd = true;
                    }
                    string sql = "insert into `deliver_table` (`order_id`, `customer_name`, `customer_nick_name`, `customer_community`, `customer_district`, `product_brand`, `product_name`, `deliver_date`, `deliver_number`) values ('"
                                 + order.OrderId + "','" + order.CustomerName + "','" + order.CustomerNickName + "','" + order.CustomerCommunity + "','"
                                 + order.CustomerDistrict + "','" + order.ProductBrand + "','" + order.ProductName + "','"
                                 + nextDeliverDate.ToString("yyyy-MM-dd") + "','" + deliverNumber.ToString() + "')";
                    DAL.MySQLHelper.ExecuteSql(sql);

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


                int deliverNumber = Convert.ToInt32(order.DeliverNumberEveryTime);
                int alreadyDeliveredNumber = 0;
                bool deliverEnd = false;
                DateTime deliverBeginDate = Convert.ToDateTime(order.DeliverBeginDate);
                DayOfWeek deliverBeginDayofWeek = deliverBeginDate.DayOfWeek;
                foreach(var dow in deliverDayofWeek)
                {
                    if (deliverEnd) break;
                    if (dow >= deliverBeginDayofWeek)//先把本周的牛奶送了
                    {
                        if (deliverNumber + alreadyDeliveredNumber >= Convert.ToInt32(order.ProductOrderNumber))
                        {
                            deliverNumber = Convert.ToInt32(order.ProductOrderNumber) - alreadyDeliveredNumber;
                            deliverEnd = true;
                        }
                        string sql = "insert into `deliver_table` (`order_id`, `customer_name`, `customer_nick_name`, `customer_community`, `customer_district`, `product_brand`, `product_name`, `deliver_date`, `deliver_number`) values ('"
                                     + order.OrderId + "','" + order.CustomerName + "','" + order.CustomerNickName + "','" + order.CustomerCommunity + "','"
                                     + order.CustomerDistrict + "','" + order.ProductBrand + "','" + order.ProductName + "','"
                                     + deliverBeginDate.AddDays(dow - deliverBeginDayofWeek).ToString("yyyy-MM-dd") + "','" + deliverNumber.ToString() + "')";
                        DAL.MySQLHelper.ExecuteSql(sql);

                        alreadyDeliveredNumber += deliverNumber;
                    }
                }

                int weekIndex = 1;
                while (!deliverEnd)
                {               
                    foreach (var dow in deliverDayofWeek)
                    {
                        if (deliverEnd) break;
                        if (deliverNumber + alreadyDeliveredNumber >= Convert.ToInt32(order.ProductOrderNumber))
                        {
                            deliverNumber = Convert.ToInt32(order.ProductOrderNumber) - alreadyDeliveredNumber;
                            deliverEnd = true;
                        }
                        string sql = "insert into `deliver_table` (`order_id`, `customer_name`, `customer_nick_name`, `customer_community`, `customer_district`, `product_brand`, `product_name`, `deliver_date`, `deliver_number`) values ('"
                                     + order.OrderId + "','" + order.CustomerName + "','" + order.CustomerNickName + "','" + order.CustomerCommunity + "','"
                                     + order.CustomerDistrict + "','" + order.ProductBrand + "','" + order.ProductName + "','"
                                     + deliverBeginDate.AddDays(weekIndex*7 + dow - deliverBeginDayofWeek).ToString("yyyy-MM-dd") + "','" + deliverNumber.ToString() + "')";
                        DAL.MySQLHelper.ExecuteSql(sql);

                        alreadyDeliveredNumber += deliverNumber;
                    }
                    weekIndex++;
                }
            }

            string cmdBase = "insert into `order_table` (`order_id`, `order_time`, `customer_name`, `customer_nick_name`, `customer_phone_number`, `customer_district`, `customer_community`, `customer_address`, `product_brand`, `product_name`, `product_order_number`, `deliver_period`, `deliver_number_everytime`, `deliver_begin_date`, `additional_gifts`, `comments`) values";
            string sqlCommand = cmdBase + "('" + order.OrderId + "','" + order.OrderDateTime + "','" + order.CustomerName + "','" + order.CustomerNickName
                                + "','" + order.CustomerPhoneNumber + "','" + order.CustomerDistrict + "','" + order.CustomerCommunity
                                + "','" + order.CustomerAddress + "','" + order.ProductBrand + "','" + order.ProductName + "','" + order.ProductOrderNumber.ToString()
                                + "','" + order.DeliverPeriod + "','" + order.DeliverNumberEveryTime.ToString() + "','" + order.DeliverBeginDate
                                + "','" + order.AdditionalGifts + "','" + order.Comments + "')";
            return DAL.MySQLHelper.ExecuteSql(sqlCommand);
        }

        public static DataSet GetAllOrderData()
        {
            return DAL.MySQLHelper.QueryOrder("select * from order_table");
        }
    }
}
