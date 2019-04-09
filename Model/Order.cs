using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        private string m_orderId = null;
        private string m_orderDateTime = null;
        private string m_customerName = null;
        private string m_customerNickName = null;
        private string m_customerPhoneNumber = null;
        private string m_customerDistrict = null;
        private string m_customerAddress = null;
        private string m_productBrand = null;
        private string m_productName = null;
        private ushort m_productOrderNumber = 0;
        private string m_deliverPeriod = null; //每周一周二，每3天
        private ushort m_deliverNumberEveryTime = 0;
        private string m_deliverBeginDate = null;
        private string m_additionalGifts = null;
        private string m_comments = null;

        public string CustomerName { get => m_customerName; set => m_customerName = value; }
        public string CustomerNickName { get => m_customerNickName; set => m_customerNickName = value; }
        public string CustomerPhoneNumber { get => m_customerPhoneNumber; set => m_customerPhoneNumber = value; }
        public string CustomerDistrict { get => m_customerDistrict; set => m_customerDistrict = value; }
        public string CustomerAddress { get => m_customerAddress; set => m_customerAddress = value; }
        public string ProductBrand { get => m_productBrand; set => m_productBrand = value; }
        public string ProductName { get => m_productName; set => m_productName = value; }
        public ushort ProductOrderNumber { get => m_productOrderNumber; set => m_productOrderNumber = value; }
        public ushort DeliverNumberEveryTime { get => m_deliverNumberEveryTime; set => m_deliverNumberEveryTime = value; }
        public string DeliverBeginDate { get => m_deliverBeginDate; set => m_deliverBeginDate = value; }
        public string AdditionalGifts { get => m_additionalGifts; set => m_additionalGifts = value; }
        public string DeliverPeriod { get => m_deliverPeriod; set => m_deliverPeriod = value; }
        public string Comments { get => m_comments; set => m_comments = value; }
        public string OrderDateTime { get => m_orderDateTime; set => m_orderDateTime = value; }
        public string OrderId { get => m_orderId; set => m_orderId = value; }
    }
}
