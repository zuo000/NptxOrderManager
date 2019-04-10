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
    public partial class CheckinForm : Form
    {
        private bool m_initFromModify = false;
        private string m_messageBoxTitle = "订单录入";
        private Model.Order m_orderInfo = new Model.Order();

        private List<string> m_districtList = BLL.SingleInstance.GetAllDistrictNames();
        private List<string> m_districtListNew = new List<string>();
        
        private List<string> m_productBrandList = BLL.SingleInstance.GetAllProductBrands();
        private List<string> m_productBrandListNew = new List<string>();

        private List<string> m_productNameList = BLL.SingleInstance.GetAllProductName();
        private List<string> m_productNameListNew = new List<string>();

        public CheckinForm()
        {
            InitializeComponent();
        }

        public CheckinForm(Model.Order order)
        {
            InitializeComponent();
            this.textBox_CustomerName.Text = order.CustomerName;
            this.textBox_NickName.Text = order.CustomerNickName;
            this.textBox_PhoneNO.Text = order.CustomerPhoneNumber;
            this.comboBox_CustomerDistrict.Text = order.CustomerDistrict;
            this.textBox_CustomerAddr.Text = order.CustomerAddress;
            this.comboBox_ProductBrand.Text = order.ProductBrand;
            this.comboBox_ProductName.Text = order.ProductName;
            this.textBox_AdditionalGifts.Text = order.AdditionalGifts;
            this.textBox_OrderNum.Text = order.ProductOrderNumber.ToString();
            this.textBox_DeliverNumEveryTime.Text = order.DeliverNumberEveryTime.ToString();
            this.textBox_Comments.Text = order.Comments;
            this.monthCalendar1.SetDate(Convert.ToDateTime(order.DeliverBeginDate));

            if (order.DeliverPeriod.Contains("周"))
            {
                this.radioButton_ByWeek.Checked = true;
                this.radioButton_ByDay.Checked = false;

                this.checkBox_Monday.Checked = false;
                this.checkBox_Tuesday.Checked = false;
                this.checkBox_Wednesday.Checked = false;
                this.checkBox_Thursday.Checked = false;
                this.checkBox_Friday.Checked = false;
                this.checkBox_Saturday.Checked = false;
                this.checkBox_Sunday.Checked = false;

                if (order.DeliverPeriod.Contains("一"))
                {
                    this.checkBox_Monday.Checked = true;
                }

                if (order.DeliverPeriod.Contains("二"))
                {
                    this.checkBox_Tuesday.Checked = true;
                }

                if (order.DeliverPeriod.Contains("三"))
                {
                    this.checkBox_Wednesday.Checked = true;
                }

                if (order.DeliverPeriod.Contains("四"))
                {
                    this.checkBox_Thursday.Checked = true;
                }

                if (order.DeliverPeriod.Contains("五"))
                {
                    this.checkBox_Friday.Checked = true;
                }

                if (order.DeliverPeriod.Contains("六"))
                {
                    this.checkBox_Saturday.Checked = true;
                }

                if (order.DeliverPeriod.Contains("日"))
                {
                    this.checkBox_Sunday.Checked = true;
                }
            }
            else
            {
                this.radioButton_ByDay.Checked = true;
                this.radioButton_ByWeek.Checked = false;
                this.textBox_DeliverInterval.Text = order.DeliverPeriod.Replace("每", string.Empty).Replace("天", string.Empty);
            }

            this.button_Submit.TabIndex = 0;

            this.m_initFromModify = true;
            this.m_messageBoxTitle = "订单修改";
            this.m_orderInfo.OrderId = order.OrderId;
        }

        private void CheckinForm_Load(object sender, EventArgs e)
        {
            this.Text = m_messageBoxTitle;
            this.comboBox_CustomerDistrict.Items.AddRange(this.m_districtList.ToArray());
            this.comboBox_ProductBrand.Items.AddRange(this.m_productBrandList.ToArray());
            this.comboBox_ProductName.Items.AddRange(this.m_productNameList.ToArray());
        }

        //定义委托
        public delegate void MyDelegate(string order_id);
        //定义事件
        public event MyDelegate MyEvent;

        private void ComboBoxUpdate(ref ComboBox box, ref List<string> listInit, ref List<string> listNew)
        {
            if (box.Text.Length == 0)
            {
                if (box.DroppedDown)
                {
                    box.DroppedDown = false;
                }
                return;
            }
            //清空combobox
            box.Items.Clear();
            //清空listNew
            listNew.Clear();
            //遍历全部备查数据
            foreach (var item in listInit)
            {
                if (item.Contains(box.Text))
                {
                    //符合，插入ListNew
                    listNew.Add(item);
                }
            }

            if (listNew.Count == 0)
            {
                //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
                box.SelectionStart = box.Text.Length;

                if (box.DroppedDown)
                {
                    box.DroppedDown = false;
                }

                return;
            }

            //combobox添加已经查到的关键词
            box.Items.AddRange(listNew.ToArray());
            //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
            box.SelectionStart = box.Text.Length;
            //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
            this.Cursor = Cursors.Default;
            //自动弹出下拉框
            box.DroppedDown = true;
        }

        private void comboBox_ProductBrand_TextUpdate(object sender, EventArgs e)
        {
            ComboBoxUpdate(ref this.comboBox_ProductBrand, ref this.m_productBrandList, ref this.m_productBrandListNew);
        }

        private void comboBox_ProductName_TextUpdate(object sender, EventArgs e)
        {
            ComboBoxUpdate(ref this.comboBox_ProductName, ref this.m_productNameList, ref this.m_productNameListNew);
        }

        private void comboBox_CustomerDistrict_TextUpdate(object sender, EventArgs e)
        {
            ComboBoxUpdate(ref this.comboBox_CustomerDistrict, ref this.m_districtList, ref this.m_districtListNew);
        }

        private void checkedListBox_DeliverPeriod_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Checked) return;//取消选中就不用进行以下操作
            for (int i = 0; i < ((CheckedListBox)sender).Items.Count; i++)
            {
                ((CheckedListBox)sender).SetItemChecked(i, false);//将所有选项设为不选中
            }
            e.NewValue = CheckState.Checked;//刷新
        }

        private void radioButton_ByWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ByDay.Checked)
            {
                radioButton_ByDay.Checked = false;
            }

            if (panel_DeliverDaily.Visible)
            {
                panel_DeliverDaily.Visible = false;
            }

            if (!panel_DeliverWeekly.Visible)
            {
                panel_DeliverWeekly.Visible = true;
            }

        }

        private void radioButton_ByDay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ByWeek.Checked)
            {
                radioButton_ByWeek.Checked = false;
            }

            if (panel_DeliverWeekly.Visible)
            {
                panel_DeliverWeekly.Visible = false;
            }

            if (!panel_DeliverDaily.Visible)
            {
                panel_DeliverDaily.Visible = true;
            }
        }

        private void radioButton_ByWeek_Enter(object sender, EventArgs e)
        {
            radioButton_ByWeek.Checked = true;
        }

        private void radioButton_ByDay_Enter(object sender, EventArgs e)
        {
            radioButton_ByDay.Checked = true;
        }

        private bool checkInputInfo()
        {
            if (this.textBox_PhoneNO.Text.Length > 11)
            {
                MessageBox.Show("联系电话错误", m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox_PhoneNO.Focus();
                this.textBox_PhoneNO.Select(0, this.textBox_PhoneNO.Text.Length);
                return false;
            }

            return true;
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (!checkInputInfo())
            {
                return;
            }

            if (!m_initFromModify)
            {
                m_orderInfo.OrderId = UniqueOrderId.Gener("B");
            }
            m_orderInfo.CustomerName = this.textBox_CustomerName.Text;
            m_orderInfo.CustomerNickName = this.textBox_NickName.Text;
            m_orderInfo.CustomerPhoneNumber = this.textBox_PhoneNO.Text;
            m_orderInfo.CustomerDistrict = this.comboBox_CustomerDistrict.Text;
            m_orderInfo.CustomerAddress = this.textBox_CustomerAddr.Text;
            m_orderInfo.ProductBrand = this.comboBox_ProductBrand.Text;
            m_orderInfo.ProductName = this.comboBox_ProductName.Text;
            m_orderInfo.ProductOrderNumber = Convert.ToUInt16(this.textBox_OrderNum.Text);
            if (radioButton_ByDay.Checked)
            {
                string interval = "每" + this.textBox_DeliverInterval.Text + "天";
                m_orderInfo.DeliverPeriod = interval;
            }
            else
            {
                string interval = "每";

                if (this.checkBox_Monday.Checked)
                {
                    interval = interval + "周一";
                }
                if (this.checkBox_Tuesday.Checked)
                {
                    interval = interval + "周二";
                }
                if (this.checkBox_Wednesday.Checked)
                {
                    interval = interval + "周三";
                }
                if (this.checkBox_Thursday.Checked)
                {
                    interval = interval + "周四";
                }
                if (this.checkBox_Friday.Checked)
                {
                    interval = interval + "周五";
                }
                if (this.checkBox_Saturday.Checked)
                {
                    interval = interval + "周六";
                }
                if (this.checkBox_Sunday.Checked)
                {
                    interval = interval + "周日";
                }

                m_orderInfo.DeliverPeriod = interval;
            }
            m_orderInfo.DeliverNumberEveryTime = Convert.ToUInt16(this.textBox_DeliverNumEveryTime.Text);
            m_orderInfo.DeliverBeginDate = this.monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            m_orderInfo.AdditionalGifts = this.textBox_AdditionalGifts.Text;
            m_orderInfo.Comments = this.textBox_Comments.Text;
            m_orderInfo.OrderDateTime = DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");

            if (BLL.SingleInstance.CheckinOrder(m_orderInfo) == 1)
            {
                MessageBox.Show(m_messageBoxTitle + "成功", m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(m_messageBoxTitle + "失败", m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (MyEvent != null)
            {
                MyEvent(m_orderInfo.OrderId);
            }
            this.Close();
        }

        private void textBox_PhoneNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_OrderNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_DeliverNumEveryTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_DeliverInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
