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
    public enum DeliverType
    {
        Weekly = 0,
        Daily = 1
    }

    public partial class UpdateModifyForm : Form
    {
        private OrderInfo orderInfo;
        private List<string> listOnit = new List<string>();
        private List<string> listNew = new List<string>();

        public UpdateModifyForm(string name, string community, string orderNum, string deliverNumEveryTime, string deliverPeriod, string startDate)
        {
            this.orderInfo = new OrderInfo(name, community, orderNum, deliverNumEveryTime, deliverPeriod, startDate);
            InitializeComponent();
        }

        private void UpdateModifyForm_Load(object sender, EventArgs e)
        {
            BindComboBox();
            this.textBox_CustomerName.Text = this.orderInfo.name;
            this.comboBox_Community.Text = this.orderInfo.community;
            this.textBox_OrderNum.Text = this.orderInfo.orderNum;
            this.textBox_DeliverNumEveryTime.Text = this.orderInfo.deliverNumEveryTime;
            if (this.orderInfo.deliverType == DeliverType.Weekly)
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

                if (this.orderInfo.deliverPeriod.Contains("一"))
                {
                    this.checkBox_Monday.Checked = true;
                }

                if (this.orderInfo.deliverPeriod.Contains("二"))
                {
                    this.checkBox_Tuesday.Checked = true;
                }

                if (this.orderInfo.deliverPeriod.Contains("三"))
                {
                    this.checkBox_Wednesday.Checked = true;
                }

                if (this.orderInfo.deliverPeriod.Contains("四"))
                {
                    this.checkBox_Thursday.Checked = true;
                }

                if (this.orderInfo.deliverPeriod.Contains("五"))
                {
                    this.checkBox_Friday.Checked = true;
                }

                if (this.orderInfo.deliverPeriod.Contains("六"))
                {
                    this.checkBox_Saturday.Checked = true;
                }

                if (this.orderInfo.deliverPeriod.Contains("日"))
                {
                    this.checkBox_Sunday.Checked = true;
                }
            }
            else
            {
                this.radioButton_ByWeek.Checked = false;
                this.radioButton_ByDay.Checked = true;
                this.textBox_DeliverInterval.Text = this.orderInfo.deliverPeriod;
            }

            this.monthCalendar1.SetDate(Convert.ToDateTime(this.orderInfo.startDate));
        }

        private void BindComboBox()
        {
            listOnit.Add("高科荣境");
            listOnit.Add("东方天郡");
            listOnit.Add("钟山府");
            listOnit.Add("亚东城");
            listOnit.Add("康桥圣菲");
            listOnit.Add("璞樾钟山");
            listOnit.Add("雁鸣山庄");
            listOnit.Add("羊山湖花园");
            listOnit.Add("仙林新村");

            /*
             * 1.注意用Item.Add(obj)或者Item.AddRange(obj)方式添加
             * 2.如果用DataSource绑定，后面再进行绑定是不行的，即便是Add或者Clear也不行
             */
            this.comboBox_Community.Items.AddRange(listOnit.ToArray());
        }

        private void comboBox_Community_TextUpdate(object sender, EventArgs e)
        {
            if (comboBox_Community.Text.Length == 0)
            {
                if (this.comboBox_Community.DroppedDown)
                {
                    this.comboBox_Community.DroppedDown = false;
                }
                return;
            }
            //清空combobox
            this.comboBox_Community.Items.Clear();
            //清空listNew
            listNew.Clear();
            //遍历全部备查数据
            foreach (var item in listOnit)
            {
                if (item.Contains(this.comboBox_Community.Text))
                {
                    //符合，插入ListNew
                    listNew.Add(item);
                }
            }

            if (listNew.Count == 0)
            {
                //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
                this.comboBox_Community.SelectionStart = this.comboBox_Community.Text.Length;

                if (this.comboBox_Community.DroppedDown)
                {
                    this.comboBox_Community.DroppedDown = false;
                }

                return;
            }

            //combobox添加已经查到的关键词
            this.comboBox_Community.Items.AddRange(listNew.ToArray());
            //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
            this.comboBox_Community.SelectionStart = this.comboBox_Community.Text.Length;
            //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
            Cursor = Cursors.Default;
            //自动弹出下拉框
            this.comboBox_Community.DroppedDown = true;
        }

        private void textBox_OrderNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CustomerName_TextChanged(object sender, EventArgs e)
        {

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

        }

        private void textBox_DeliverNumEveryTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

    public class OrderInfo
    {
        public string name;
        public string community;
        public string orderNum;
        public string deliverNumEveryTime;
        public DeliverType deliverType;
        public string deliverPeriod;
        public string startDate;

        public OrderInfo(string name, string community, string orderNum, string deliverNumEveryTime, string deliverPeriod, string startDate)
        {
            this.name = name;
            this.community = community;
            this.orderNum = orderNum;
            this.deliverNumEveryTime = deliverNumEveryTime;
            this.startDate = startDate;

            if (deliverPeriod.Contains("周"))
            {
                this.deliverType = DeliverType.Weekly;
                this.deliverPeriod = deliverPeriod.Replace("周", string.Empty);
            }
            else
            {
                this.deliverType = DeliverType.Daily;
                this.deliverPeriod = deliverPeriod.Replace("每", string.Empty).Replace("天", string.Empty);
            }
        }
    }
}
