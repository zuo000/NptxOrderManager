using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DeliverItem
    {
        private string m_deliverId = null;
        private string m_orderId = null;
        private string m_customerName = null;
        private string m_customerNickName = null;
        private string m_customerDistrict = null;
        private string m_customerAddress = null;
        private string m_productBrand = null;
        private string m_productName = null;
        private string m_deliverDate = null;
        private ushort m_deliverNumber = 0;
        private string m_status = null;

        public string OrderId { get => m_orderId; set => m_orderId = value; }
        public string CustomerName { get => m_customerName; set => m_customerName = value; }
        public string CustomerNickName { get => m_customerNickName; set => m_customerNickName = value; }
        public string CustomerAddress { get => m_customerAddress; set => m_customerAddress = value; }
        public string ProductBrand { get => m_productBrand; set => m_productBrand = value; }
        public string ProductName { get => m_productName; set => m_productName = value; }
        public string DeliverDate { get => m_deliverDate; set => m_deliverDate = value; }
        public ushort DeliverNumber { get => m_deliverNumber; set => m_deliverNumber = value; }
        public string DeliverId { get => m_deliverId; set => m_deliverId = value; }
        public string Status { get => m_status; set => m_status = value; }
        public string CustomerDistrict { get => m_customerDistrict; set => m_customerDistrict = value; }
    }
}
