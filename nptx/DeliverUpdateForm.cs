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

        //定义委托
        public delegate void MyDelegate(string orderId, string deliverId);
        //定义事件
        public event MyDelegate MyEvent;

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

        private void button_Submit_Click(object sender, EventArgs e)
        {
            m_item.DeliverDate = this.monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            m_item.DeliverNumber = Convert.ToUInt16(this.textBox_deliverNumber.Text);


            if (m_isAdd)
            {
                m_item.Status = "未完成";
                if( BLL.Interface.CheckinDeliverItem(m_item) == 1)
                {
                    MessageBox.Show("配送计划增加成功", "配送计划增加", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_item.DeliverId = BLL.Interface.QueryLastInsertId();
                }
                else
                {
                    MessageBox.Show("配送计划增加失败", "配送计划增加", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (BLL.Interface.UpdateDeliverItem(m_item) == 1)
                {
                    MessageBox.Show("配送计划修改成功", "配送计划修改", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("配送计划修改失败", "配送计划修改", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (MyEvent != null)
            {
                MyEvent(m_item.OrderId, m_item.DeliverId);
            }
            this.Close();
        }

        private void textBox_deliverNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DeliverUpdateForm_Activated(object sender, EventArgs e)
        {
            this.textBox_deliverNumber.Focus();
            this.textBox_deliverNumber.Select(this.textBox_deliverNumber.Text.Length, 0);
        }
    }
}
