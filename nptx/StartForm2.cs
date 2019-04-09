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
    public partial class StartForm2 : Form
    {
        public StartForm2()
        {
            InitializeComponent();
        }

        private void RefreshDataGrid()
        {
            DataSet ds = BLL.SingleInstance.GetAllOrderData();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.ClearSelection();
        }
               
        private void StartForm2_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {

        }

        private void button_cancelSearch_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void button_CheckinOrder_Click(object sender, EventArgs e)
        {
            CheckinForm checkinForm = new CheckinForm();
            checkinForm.MyEvent += new CheckinForm.MyDelegate(RefreshDataGrid);
            checkinForm.ShowDialog();
        }

        private void button_ImportOrder_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx|所有文件|*.*";
            ofd.ValidateNames = true;
            ofd.CheckPathExists = true;
            ofd.CheckFileExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string strFileName = ofd.FileName;
                //其他代码
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                this.contextMenuStrip1.Show(MousePosition.X, MousePosition.Y); //MousePosition.X, MousePosition.Y 是为了让菜单在所选行的位置显示
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ToolStripMenuItem_check_Click(sender, e);
        }

        private void ToolStripMenuItem_check_Click(object sender, EventArgs e)
        {
            //CheckinForm checkinForm = new CheckinForm();
            //checkinForm.MyEvent += new CheckinForm.MyDelegate(RefreshDataGrid);
            //checkinForm.ShowDialog();
        }

        private void ToolStripMenuItem_modify_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            string order_id = row.Cells[0].Value.ToString();

            CheckinForm checkinForm = new CheckinForm(BLL.SingleInstance.QueryOrderById(order_id));
            checkinForm.MyEvent += new CheckinForm.MyDelegate(RefreshDataGrid);
            checkinForm.ShowDialog();
        }

        private void ToolStripMenuItem_delete_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            string order_id = row.Cells[0].Value.ToString();

            if (BLL.SingleInstance.DeleteOrder(order_id))
            {
                MessageBox.Show("订单删除成功", "删除订单", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("订单删除失败", "删除订单", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGrid();
        }
    }
}
