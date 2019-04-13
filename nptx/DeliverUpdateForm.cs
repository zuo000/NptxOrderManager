using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class DeliverUpdateForm : Form
    {
        private Model.DeliverItem m_item = null;
        private bool m_isAdd = false;

        public DeliverUpdateForm(Model.DeliverItem item, bool isAdd)
        {
            m_item = item;
            m_isAdd = isAdd;
            InitializeComponent();
        }

        private void DeliverUpdateForm_Load(object sender, EventArgs e)
        {
            this.textBox_OrderId.Text = m_item.OrderId;
            this.textBox_CustomerAddr.Text = m_item.CustomerAddress;
            this.textBox_CustomerName.Text = m_item.CustomerName;
            this.textBox_NickName.Text = m_item.CustomerNickName;
            this.textBox_productBrand.Text = m_item.ProductBrand;
            this.textBox_productName.Text = m_item.ProductName;
            this.monthCalendar1.SetDate(Convert.ToDateTime(m_item.DeliverDate));
            this.textBox_deliverNumber.Text = m_item.DeliverNumber.ToString();
        }
    }
}
