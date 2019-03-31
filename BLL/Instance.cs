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
            string cmdBase = "insert into `order_table` (`order_time`, `customer_name`, `customer_nick_name`, `customer_phone_number`, `customer_district`, `customer_community`, `customer_address`, `product_brand`, `product_name`, `product_order_number`, `deliver_period`, `deliver_number_everytime`, `deliver_begin_date`, `additional_gifts`, `comments`) values";
            string sqlCommand = cmdBase + "('" + order.OrderDateTime + "','" + order.CustomerName + "','" + order.CustomerNickName
                                + "','" + order.CustomerPhoneNumber + "','" + order.CustomerDistrict + "','" + order.CustomerCommunity
                                + "','" + order.CustomerAddress + "','" + order.ProductBrand + "','" + order.ProductName + "','" + order.ProductOrderNumber.ToString()
                                + "','" + order.DeliverPeriod + "','" + order.DeliverNumberEveryTime.ToString() + "','" + order.DeliverBeginDate
                                + "','" + order.AdditionalGifts + "','" + order.Comments + "')";
            return DAL.MySQLHelper.ExecuteSql(sqlCommand);
        }

        public static DataSet QueryOne(string conn)
        {
            return DAL.MySQLHelper.QueryOne(conn);
        }
    }
}
