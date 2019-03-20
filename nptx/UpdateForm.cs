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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void textBox_SearchContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Search_Click(object sender, EventArgs e)
        {

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows.Add(new DataGridViewRow());
            dataGridView1.Rows[index].Cells[0].Value = "张三";
            dataGridView1.Rows[index].Cells[1].Value = "亚东城";
            dataGridView1.Rows[index].Cells[2].Value = "50";
            dataGridView1.Rows[index].Cells[3].Value = "周一周五";
            dataGridView1.Rows[index].Cells[4].Value = "2019-01-01";
            dataGridView1.Rows[index].Cells[5].Value = "2020-01-01";

            index = dataGridView1.Rows.Add(new DataGridViewRow());
            dataGridView1.Rows[index].Cells[0].Value = "李四";
            dataGridView1.Rows[index].Cells[1].Value = "璞樾钟山";
            dataGridView1.Rows[index].Cells[2].Value = "100";
            dataGridView1.Rows[index].Cells[3].Value = "每2天";
            dataGridView1.Rows[index].Cells[4].Value = "2019-01-01";
            dataGridView1.Rows[index].Cells[5].Value = "2020-01-01";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                this.contextMenuStrip1.Show(MousePosition.X, MousePosition.Y); //MousePosition.X, MousePosition.Y 是为了让菜单在所选行的位置显示

            }
        }

        private void ToolStripMenuItem_Modify_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            string name = row.Cells[0].Value.ToString();
            string community = row.Cells[1].Value.ToString();
            string orderNum = row.Cells[2].Value.ToString();
            string deliverPeriod = row.Cells[3].Value.ToString();
            string startDate = row.Cells[4].Value.ToString();

            UpdateModifyForm updateModifyForm = new UpdateModifyForm(name, community, orderNum, deliverPeriod, startDate);
            updateModifyForm.Show();
        }

        private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }
    }
}
