using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nptx
{
    public partial class UpdateModifyForm : Form
    {
        private List<string> listOnit = new List<string>();
        private List<string> listNew = new List<string>();

        public UpdateModifyForm()
        {
            InitializeComponent();
        }

        private void UpdateModifyForm_Load(object sender, EventArgs e)
        {
            BindComboBox();
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
    }
}
