﻿using System;
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

        private List<string> m_districtList = BLL.Interface.GetAllDistrictNames();
        private List<string> m_districtListNew = new List<string>();
        private string m_districtText = null;

        private List<string> m_productBrandList = BLL.Interface.GetAllProductBrands();
        private List<string> m_productBrandListNew = new List<string>();
        private string m_productBrandText = null;

        private List<string> m_productNameList = BLL.Interface.GetAllProductName();
        private List<string> m_productNameListNew = new List<string>();
        private string m_productNameText = null;

        public CheckinForm()
        {            
            InitializeComponent();
            this.radioButton_ByWeek.Checked = true;
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
            //this.textBox_DeliverNumEveryTime.Text = order.DeliverNumberEveryTime.ToString();
            this.textBox_Comments.Text = order.Comments;
            this.monthCalendar1.SetDate(Convert.ToDateTime(order.DeliverBeginDate));

            if (!order.IsDeliveredOnlyOnce)
            {
                if (order.DeliverPlan.Contains("天"))
                {
                    this.radioButton_ByDay.Checked = true;
                    this.radioButton_ByWeek.Checked = false;

                    this.textBox_DeliverInterval.Text = order.DeliverPlan.Substring(
                        order.DeliverPlan.IndexOf("每") + 1, 
                        order.DeliverPlan.IndexOf("天") - order.DeliverPlan.IndexOf("每") - 1);                    

                    this.textBox_DeliveryNumberEveryTime.Text = order.DeliverPlan.Substring(
                        order.DeliverPlan.IndexOf("天") + 1, 
                        order.DeliverPlan.IndexOf("袋") - order.DeliverPlan.IndexOf("天") - 1);
                }
                else
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

                    if (order.DeliverPlan.Contains("一"))
                    {
                        this.checkBox_Monday.Checked = true;

                        string subDeliverPlan = order.DeliverPlan.Substring(order.DeliverPlan.IndexOf("一"));
                        this.textBox_Monday.Text = subDeliverPlan.Substring(subDeliverPlan.IndexOf("一") + 1,
                            subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("一") - 1);

                    }

                    if (order.DeliverPlan.Contains("二"))
                    {
                        this.checkBox_Tuesday.Checked = true;

                        string subDeliverPlan = order.DeliverPlan.Substring(order.DeliverPlan.IndexOf("二"));
                        this.textBox_Tuesday.Text = subDeliverPlan.Substring(subDeliverPlan.IndexOf("二") + 1,
                            subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("二") - 1);
                    }

                    if (order.DeliverPlan.Contains("三"))
                    {
                        this.checkBox_Wednesday.Checked = true;

                        string subDeliverPlan = order.DeliverPlan.Substring(order.DeliverPlan.IndexOf("三"));
                        this.textBox_Wednesday.Text = subDeliverPlan.Substring(subDeliverPlan.IndexOf("三") + 1,
                            subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("三") - 1);
                    }

                    if (order.DeliverPlan.Contains("四"))
                    {
                        this.checkBox_Thursday.Checked = true;

                        string subDeliverPlan = order.DeliverPlan.Substring(order.DeliverPlan.IndexOf("四"));
                        this.textBox_Thursday.Text = subDeliverPlan.Substring(subDeliverPlan.IndexOf("四") + 1,
                            subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("四") - 1);
                    }

                    if (order.DeliverPlan.Contains("五"))
                    {
                        this.checkBox_Friday.Checked = true;

                        string subDeliverPlan = order.DeliverPlan.Substring(order.DeliverPlan.IndexOf("五"));
                        this.textBox_Friday.Text = subDeliverPlan.Substring(subDeliverPlan.IndexOf("五") + 1,
                            subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("五") - 1);
                    }

                    if (order.DeliverPlan.Contains("六"))
                    {
                        this.checkBox_Saturday.Checked = true;

                        string subDeliverPlan = order.DeliverPlan.Substring(order.DeliverPlan.IndexOf("六"));
                        this.textBox_Saturday.Text = subDeliverPlan.Substring(subDeliverPlan.IndexOf("六") + 1,
                            subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("六") - 1);
                    }

                    if (order.DeliverPlan.Contains("日"))
                    {
                        this.checkBox_Sunday.Checked = true;

                        string subDeliverPlan = order.DeliverPlan.Substring(order.DeliverPlan.IndexOf("日"));
                        this.textBox_Sunday.Text = subDeliverPlan.Substring(subDeliverPlan.IndexOf("日") + 1,
                            subDeliverPlan.IndexOf("袋") - subDeliverPlan.IndexOf("日") - 1);
                    }
                }
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

            //if (box.Text.Length == 0)
            //{
            //    if (box.DroppedDown)
            //    {
            //        box.DroppedDown = false;
            //    }
            //    return;
            //}
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
                box.SelectedIndex = -1;
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
            m_productBrandText = this.comboBox_ProductBrand.Text;
            ComboBoxUpdate(ref this.comboBox_ProductBrand, ref this.m_productBrandList, ref this.m_productBrandListNew);
        }

        private void comboBox_ProductName_TextUpdate(object sender, EventArgs e)
        {
            m_productNameText = this.comboBox_ProductName.Text;
            ComboBoxUpdate(ref this.comboBox_ProductName, ref this.m_productNameList, ref this.m_productNameListNew);
        }

        private void comboBox_CustomerDistrict_TextUpdate(object sender, EventArgs e)
        {
            m_districtText = this.comboBox_CustomerDistrict.Text;
            ComboBoxUpdate(ref this.comboBox_CustomerDistrict, ref this.m_districtList, ref this.m_districtListNew);
        }

        //private void checkedListBox_DeliverPeriod_ItemCheck(object sender, ItemCheckEventArgs e)
        //{
        //    if (e.CurrentValue == CheckState.Checked) return;//取消选中就不用进行以下操作
        //    for (int i = 0; i < ((CheckedListBox)sender).Items.Count; i++)
        //    {
        //        ((CheckedListBox)sender).SetItemChecked(i, false);//将所有选项设为不选中
        //    }
        //    e.NewValue = CheckState.Checked;//刷新
        //}

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

        private bool isInvalid(CheckBox checkBox, TextBox textBox)
        {
            if (checkBox.Checked)
            {
                if (textBox.Text.Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (textBox.Text.Length != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
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

            if (this.textBox_OrderNum.Text.Length == 0)
            {
                MessageBox.Show("订购数量错误", m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox_OrderNum.Focus();
                this.textBox_OrderNum.Select(0, this.textBox_OrderNum.Text.Length);
                return false;
            }

            if (GetCheckedBoxNumber() > 2)
            {
                MessageBox.Show("每周只能最多选择2天配送", m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (this.radioButton_ByDay.Checked)
            {
                //不能只填一个
                if (this.textBox_DeliverInterval.Text.Length * this.textBox_DeliveryNumberEveryTime.Text.Length == 0 &&
                    this.textBox_DeliverInterval.Text.Length + this.textBox_DeliveryNumberEveryTime.Text.Length > 0)
                {
                    string text = null;
                    if (this.textBox_DeliverInterval.Text.Length == 0)
                    {
                        text = "请输入配送时间间隔";
                        this.textBox_DeliverInterval.Focus();
                    }
                    else
                    {
                        text = "请输入每次配送数量";
                        this.textBox_DeliveryNumberEveryTime.Focus();
                    }
                    MessageBox.Show(text, m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (this.radioButton_ByWeek.Checked)
            {
                if (isInvalid(this.checkBox_Monday, this.textBox_Monday))
                {
                    string text = null; 
                    if (!this.checkBox_Monday.Checked)
                    {
                        text = "请勾选周一";
                    }
                    else
                    {
                        text = "请输入周一配送数量";
                        this.textBox_Monday.Focus();
                    }
                    MessageBox.Show(text, m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (isInvalid(this.checkBox_Tuesday, this.textBox_Tuesday))
                {
                    string text = null;
                    if (!this.checkBox_Tuesday.Checked)
                    {
                        text = "请勾选周二";
                    }
                    else
                    {
                        text = "请输入周二配送数量";
                        this.textBox_Tuesday.Focus();
                    }
                    MessageBox.Show(text, m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (isInvalid(this.checkBox_Wednesday, this.textBox_Wednesday))
                {
                    string text = null;
                    if (!this.checkBox_Wednesday.Checked)
                    {
                        text = "请勾选周三";
                    }
                    else
                    {
                        text = "请输入周三配送数量";
                        this.textBox_Wednesday.Focus();
                    }
                    MessageBox.Show(text, m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (isInvalid(this.checkBox_Thursday, this.textBox_Thursday))
                {
                    string text = null;
                    if (!this.checkBox_Thursday.Checked)
                    {
                        text = "请勾选周四";
                    }
                    else
                    {
                        text = "请输入周四配送数量";
                        this.textBox_Thursday.Focus();
                    }
                    MessageBox.Show(text, m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (isInvalid(this.checkBox_Friday, this.textBox_Friday))
                {
                    string text = null;
                    if (!this.checkBox_Friday.Checked)
                    {
                        text = "请勾选周五";
                    }
                    else
                    {
                        text = "请输入周五配送数量";
                        this.textBox_Friday.Focus();
                    }
                    MessageBox.Show(text, m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (isInvalid(this.checkBox_Saturday, this.textBox_Saturday))
                {
                    string text = null;
                    if (!this.checkBox_Saturday.Checked)
                    {
                        text = "请勾选周六";
                    }
                    else
                    {
                        text = "请输入周六配送数量";
                        this.textBox_Saturday.Focus();
                    }
                    MessageBox.Show(text, m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (isInvalid(this.checkBox_Sunday, this.textBox_Sunday))
                {
                    string text = null;
                    if (!this.checkBox_Sunday.Checked)
                    {
                        text = "请勾选周日";
                    }
                    else
                    {
                        text = "请输入周日配送数量";
                        this.textBox_Sunday.Focus();
                    }
                    MessageBox.Show(text, m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            //if (this.textBox_DeliverNumEveryTime.Text.Length > 0)
            //{
            //    if (this.radioButton_ByDay.Checked)
            //    {
            //        if (this.textBox_DeliverInterval.Text.Length == 0)
            //        {
            //            MessageBox.Show("请输入送奶计划", m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            this.textBox_DeliverInterval.Focus();
            //            this.textBox_DeliverInterval.Select(0, 0);
            //            return false;
            //        }
            //    }
            //    else if (this.radioButton_ByWeek.Checked)
            //    {
            //        if (!this.checkBox_Monday.Checked &&
            //            !this.checkBox_Tuesday.Checked &&
            //            !this.checkBox_Wednesday.Checked &&
            //            !this.checkBox_Thursday.Checked &&
            //            !this.checkBox_Friday.Checked &&
            //            !this.checkBox_Saturday.Checked &&
            //            !this.checkBox_Sunday.Checked)
            //        {
            //            MessageBox.Show("请选择送奶计划", m_messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return false;
            //        }
            //    }                
            //}

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
            m_orderInfo.IsDeliveredOnlyOnce = false;

            //一次性配送
            if (this.radioButton_ByDay.Checked && this.textBox_DeliveryNumberEveryTime.Text.Length == 0)
            {
                m_orderInfo.IsDeliveredOnlyOnce = true;
                m_orderInfo.DeliverPlan = "";
            }

            //一次性配送
            if (this.radioButton_ByWeek.Checked &&
                this.textBox_Monday.Text.Length == 0 &&
                this.textBox_Tuesday.Text.Length == 0 &&
                this.textBox_Wednesday.Text.Length == 0 &&
                this.textBox_Thursday.Text.Length == 0 &&
                this.textBox_Friday.Text.Length == 0 &&
                this.textBox_Saturday.Text.Length == 0 &&
                this.textBox_Sunday.Text.Length == 0)
            {
                m_orderInfo.IsDeliveredOnlyOnce = true;
                m_orderInfo.DeliverPlan = "";
            }

            //if (this.textBox_DeliverNumEveryTime.Text.Length == 0 || this.textBox_DeliverNumEveryTime.Text == this.textBox_OrderNum.Text)
            //{
            //    m_orderInfo.DeliverNumberEveryTime = m_orderInfo.ProductOrderNumber;
            //    m_orderInfo.DeliverPeriod = "";
            //}
            //else
            //周期性配送
            if (!m_orderInfo.IsDeliveredOnlyOnce)
            {
                if (radioButton_ByDay.Checked)
                {
                    string plan = "每" + this.textBox_DeliverInterval.Text + "天" +
                        this.textBox_DeliveryNumberEveryTime.Text + "袋";
                    m_orderInfo.DeliverPlan = plan;
                }
                else
                {
                    string interval = "每";

                    if (this.checkBox_Monday.Checked)
                    {
                        interval = interval + "周一" + this.textBox_Monday.Text + "袋";
                    }
                    if (this.checkBox_Tuesday.Checked)
                    {
                        interval = interval + "周二" + this.textBox_Tuesday.Text + "袋"; ;
                    }
                    if (this.checkBox_Wednesday.Checked)
                    {
                        interval = interval + "周三" + this.textBox_Wednesday.Text + "袋";
                    }
                    if (this.checkBox_Thursday.Checked)
                    {
                        interval = interval + "周四" + this.textBox_Tuesday.Text + "袋";
                    }
                    if (this.checkBox_Friday.Checked)
                    {
                        interval = interval + "周五" + this.textBox_Friday.Text + "袋";
                    }
                    if (this.checkBox_Saturday.Checked)
                    {
                        interval = interval + "周六" + this.textBox_Saturday.Text + "袋";
                    }
                    if (this.checkBox_Sunday.Checked)
                    {
                        interval = interval + "周日" + this.textBox_Sunday.Text + "袋";
                    }

                    m_orderInfo.DeliverPlan = interval;
                }
            }
            
            m_orderInfo.DeliverBeginDate = this.monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            m_orderInfo.AdditionalGifts = this.textBox_AdditionalGifts.Text;
            m_orderInfo.Comments = this.textBox_Comments.Text;
            m_orderInfo.OrderDateTime = DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");

            if (BLL.Interface.CheckinOrder(m_orderInfo) == 1)
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

        private void textBox_DeliverInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private int GetCheckedBoxNumber()
        {
            int n = 0;

            if (this.checkBox_Monday.Checked)
            {
                n++;
            }

            if (this.checkBox_Tuesday.Checked)
            {
                n++;
            }

            if (this.checkBox_Wednesday.Checked)
            {
                n++;
            }

            if (this.checkBox_Thursday.Checked)
            {
                n++;
            }

            if (this.checkBox_Friday.Checked)
            {
                n++;
            }

            if (this.checkBox_Saturday.Checked)
            {
                n++;
            }

            if (this.checkBox_Sunday.Checked)
            {
                n++;
            }

            return n;
        }

        private void textBox_Monday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Tuesday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Wednesday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Thursday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Friday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Saturday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Sunday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_DeliveryNumberEveryTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox_ProductBrand_DropDownClosed(object sender, EventArgs e)
        {
            if (this.comboBox_ProductBrand.Items.Count == 0 &&
                this.comboBox_ProductBrand.SelectedIndex == 0)
            {
                this.comboBox_ProductBrand.SelectedIndex = -1;
                this.comboBox_ProductBrand.Text = m_productBrandText;
                this.comboBox_ProductBrand.SelectionStart = m_productBrandText.Length;
            }
        }

        private void comboBox_CustomerDistrict_DropDownClosed(object sender, EventArgs e)
        {
            if (this.comboBox_CustomerDistrict.Items.Count == 0 &&
                this.comboBox_CustomerDistrict.SelectedIndex == 0)
            {
                this.comboBox_CustomerDistrict.SelectedIndex = -1;
                this.comboBox_CustomerDistrict.Text = m_districtText;
                this.comboBox_CustomerDistrict.SelectionStart = m_districtText.Length;
            }
        }

        private void comboBox_ProductName_DropDownClosed(object sender, EventArgs e)
        {
            if (this.comboBox_ProductName.Items.Count == 0 &&
                this.comboBox_ProductName.SelectedIndex == 0)
            {
                this.comboBox_ProductName.SelectedIndex = -1;
                this.comboBox_ProductName.Text = m_productNameText;
                this.comboBox_ProductName.SelectionStart = m_productNameText.Length;
            }
        }

        //private void textBox_DeliverNumEveryTime_MouseHover(object sender, EventArgs e)
        //{
        //    ToolTip toolTip1 = new ToolTip();
        //    // 设置显示样式
        //    toolTip1.AutoPopDelay = 5000;//提示信息的可见时间
        //    toolTip1.InitialDelay = 200;//事件触发多久后出现提示
        //    toolTip1.ReshowDelay = 500;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
        //    toolTip1.ShowAlways = true;//是否显示提示框
        //    //  设置伴随的对象.
        //    toolTip1.SetToolTip(this.textBox_DeliverNumEveryTime, "留空则为一次性配送");//设置提示按钮和提示内容
        //}

        //private void label4_MouseHover(object sender, EventArgs e)
        //{
        //    ToolTip toolTip1 = new ToolTip();
        //    // 设置显示样式
        //    toolTip1.AutoPopDelay = 5000;//提示信息的可见时间
        //    toolTip1.InitialDelay = 400;//事件触发多久后出现提示
        //    toolTip1.ReshowDelay = 400;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
        //    toolTip1.ShowAlways = true;//是否显示提示框
        //    //  设置伴随的对象.
        //    toolTip1.SetToolTip(this.label4, "留空则为一次性配送");//设置提示按钮和提示内容
        //}
    }
}
