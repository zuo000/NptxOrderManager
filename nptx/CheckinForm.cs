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
        private Model.Order m_orderInfo;

        private List<string> m_districtList = BLL.Instance.GetAllDistrictNames();
        private List<string> m_districtListNew = new List<string>();

        private List<string> m_communityNameList = BLL.Instance.GetAllCommunityNames();
        private List<string> m_communityNameListNew = new List<string>();

        private List<string> m_productBrandList = BLL.Instance.GetAllProductBrands();
        private List<string> m_productBrandListNew = new List<string>();

        private List<string> m_productNameList = BLL.Instance.GetAllProductName();
        private List<string> m_productNameListNew = new List<string>();

        public CheckinForm()
        {
            InitializeComponent();
        }

        private void CheckinForm_Load(object sender, EventArgs e)
        {
            this.comboBox_CustomerDistrict.Items.AddRange(this.m_districtList.ToArray());
            this.comboBox_Community.Items.AddRange(this.m_communityNameList.ToArray());
            this.comboBox_ProductBrand.Items.AddRange(this.m_productBrandList.ToArray());
            this.comboBox_ProductName.Items.AddRange(this.m_productNameList.ToArray());
        }

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

        private void comboBox_Community_TextUpdate(object sender, EventArgs e)
        {
            ComboBoxUpdate(ref this.comboBox_Community, ref this.m_communityNameList, ref this.m_communityNameListNew);
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

        private void button_Submit_Click(object sender, EventArgs e)
        {
            m_orderInfo.CustomerName = this.textBox_CustomerName.Text;
            m_orderInfo.CustomerNickName = this.textBox_NickName.Text;
            m_orderInfo.CustomerPhoneNumber = this.textBox_PhoneNO.Text;
            m_orderInfo.CustomerDistrict = this.comboBox_CustomerDistrict.Text;
            m_orderInfo.CustomerCommunity = this.comboBox_Community.Text;
            m_orderInfo.CustomerAddress = this.textBox_CustomerAddr.Text;
            m_orderInfo.ProductBrand = this.comboBox_ProductBrand.Text;
            m_orderInfo.ProductName = this.comboBox_ProductName.Text;
            m_orderInfo.ProductOrderNumber = Convert.ToUInt16(this.textBox_OrderNum.Text);
            if (radioButton_ByDay.Checked)
            {
                m_orderInfo.DeliverType = Model.DeliverType.Daily;
            }
            else
            {
                m_orderInfo.DeliverType = Model.DeliverType.Weekly;
            }
            //deliverInterval
            m_orderInfo.DeliverNumberEveryTime = Convert.ToUInt16(this.textBox_DeliverNumEveryTime.Text);
            m_orderInfo.DeliverBeginDate = this.monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            m_orderInfo.AdditionalGifts = this.textBox_AdditionalGifts.Text;
            m_orderInfo.Timestamp = DateTime.Now.ToLocalTime().ToString();

            BLL.Instance.AddOrder(m_orderInfo);
        }
    }
}
