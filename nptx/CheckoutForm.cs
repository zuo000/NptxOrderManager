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
    public partial class CheckoutForm : Form
    {
        private List<string> listOnit = new List<string>();
        private List<string> listNew = new List<string>();

        public CheckoutForm()
        {
            InitializeComponent();
        }

        private void radioButton_ByCustomerName_Enter(object sender, EventArgs e)
        {
            radioButton_ByCustomerName.Checked = true;
        }

        private void radioButton_ByCustomerCommunity_Enter(object sender, EventArgs e)
        {
            radioButton_ByCustomerCommunity.Checked = true;
        }

        private void radioButton_ByCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ByCustomerCommunity.Checked)
            {
                radioButton_ByCustomerCommunity.Checked = false;
            }

            comboBox_SearchContent.ResetText();
            BindComboBoxByCutomerName();
        }

        private void radioButton_ByCustomerCommunity_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ByCustomerName.Checked)
            {
                radioButton_ByCustomerName.Checked = false;
            }

            comboBox_SearchContent.ResetText();
            BindComboBoxByCutomerCommunity();
        }

        private void comboBox_SearchContent_TextUpdate(object sender, EventArgs e)
        {
            if (comboBox_SearchContent.Text.Length == 0)
            {
                if (this.comboBox_SearchContent.DroppedDown)
                {
                    this.comboBox_SearchContent.DroppedDown = false;
                }
                return;
            }
            //清空combobox
            this.comboBox_SearchContent.Items.Clear();
            //清空listNew
            listNew.Clear();
            //遍历全部备查数据
            foreach (var item in listOnit)
            {
                if (item.Contains(this.comboBox_SearchContent.Text))
                {
                    //符合，插入ListNew
                    listNew.Add(item);
                }
            }

            if (listNew.Count == 0)
            {
                //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
                this.comboBox_SearchContent.SelectionStart = this.comboBox_SearchContent.Text.Length;
                if (this.comboBox_SearchContent.DroppedDown)
                {
                    this.comboBox_SearchContent.DroppedDown = false;
                }
                return;
            }

            //combobox添加已经查到的关键词
            this.comboBox_SearchContent.Items.AddRange(listNew.ToArray());
            //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
            this.comboBox_SearchContent.SelectionStart = this.comboBox_SearchContent.Text.Length;
            //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
            Cursor = Cursors.Default;
            //自动弹出下拉框
            this.comboBox_SearchContent.DroppedDown = true;
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            BindComboBoxByCutomerName();
        }

        private void BindComboBoxByCutomerCommunity()
        {
            listOnit.Clear();
            this.comboBox_SearchContent.Items.Clear();

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
            this.comboBox_SearchContent.Items.AddRange(listOnit.ToArray());
        }

        private void BindComboBoxByCutomerName()
        {
            listOnit.Clear();
            this.comboBox_SearchContent.Items.Clear();

            listOnit.Add("张三");
            listOnit.Add("李四");
            listOnit.Add("王五");
            listOnit.Add("张东");
            listOnit.Add("李西");
            listOnit.Add("邓萍");

            /*
             * 1.注意用Item.Add(obj)或者Item.AddRange(obj)方式添加
             * 2.如果用DataSource绑定，后面再进行绑定是不行的，即便是Add或者Clear也不行
             */
            this.comboBox_SearchContent.Items.AddRange(listOnit.ToArray());
        }

        private void CheckoutForm_Activated(object sender, EventArgs e)
        {
            comboBox_SearchContent.Focus();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button_Submit_Click(object sender, EventArgs e)
        {

        }
    }
}
