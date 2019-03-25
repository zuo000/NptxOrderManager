using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum DeliverType
    {
        Weekly = 0,
        Daily = 1
    }

    public class Order
    {
        private string m_customerName;
        private string m_customerNickName;
        private string m_customerPhoneNumber;
        private string m_customerDistrict;
        private string m_customerCommunity;
        private string m_customerAddress;
        private string m_productBrand;
        private string m_productName;
        private ushort m_productOrderNumber;
        private DeliverType m_deliverType;
        //deliverInterval
        private ushort m_deliverNumberEveryTime;
        private string m_deliverBeginDate;
        private string m_additionalGifts;
        private string m_timestamp;

        public string CustomerName { get => m_customerName; set => m_customerName = value; }
        public string CustomerNickName { get => m_customerNickName; set => m_customerNickName = value; }
        public string CustomerPhoneNumber { get => m_customerPhoneNumber; set => m_customerPhoneNumber = value; }
        public string CustomerDistrict { get => m_customerDistrict; set => m_customerDistrict = value; }
        public string CustomerCommunity { get => m_customerCommunity; set => m_customerCommunity = value; }
        public string CustomerAddress { get => m_customerAddress; set => m_customerAddress = value; }
        public string ProductBrand { get => m_productBrand; set => m_productBrand = value; }
        public string ProductName { get => m_productName; set => m_productName = value; }
        public ushort ProductOrderNumber { get => m_productOrderNumber; set => m_productOrderNumber = value; }
        public DeliverType DeliverType { get => m_deliverType; set => m_deliverType = value; }
        public ushort DeliverNumberEveryTime { get => m_deliverNumberEveryTime; set => m_deliverNumberEveryTime = value; }
        public string DeliverBeginDate { get => m_deliverBeginDate; set => m_deliverBeginDate = value; }
        public string AdditionalGifts { get => m_additionalGifts; set => m_additionalGifts = value; }
        public string Timestamp { get => m_timestamp; set => m_timestamp = value; }
    }
}
