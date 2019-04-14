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
    public partial class StartForm : Form
    {
        public class SearchTypeInfo
        {
            public string SearchType { get; set; }
            public string SearchName { get; set; }

        }

        public StartForm()
        {
            InitializeComponent();
        }

        private void RefreshDataGrid()
        {
            DataSet ds = BLL.Interface.GetAllOrderData();

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.ClearSelection();
        }

        private void RefreshDataGridAndSetSelection(string order_id)
        {
            RefreshDataGrid();

            foreach(DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == order_id)
                {
                    this.dataGridView1.CurrentCell = row.Cells[0];
                    this.dataGridView1.Rows[row.Index].Selected = true;
                    return;
                }
            }
        }

        private void BindSearchTypeComboBox()
        {
            IList<SearchTypeInfo> infoList = new List<SearchTypeInfo>();
            SearchTypeInfo info1 = new SearchTypeInfo() { SearchType = "customer_name", SearchName = "客户姓名" };
            SearchTypeInfo info2 = new SearchTypeInfo() { SearchType = "customer_nick_name", SearchName = "客户昵称" };
            SearchTypeInfo info3 = new SearchTypeInfo() { SearchType = "customer_phone_number", SearchName = "联系电话" };
            SearchTypeInfo info4 = new SearchTypeInfo() { SearchType = "customer_district", SearchName = "所在区域" };
            SearchTypeInfo info5 = new SearchTypeInfo() { SearchType = "customer_address", SearchName = "配送地址" };
            SearchTypeInfo info6 = new SearchTypeInfo() { SearchType = "product_brand", SearchName = "商品" };
            infoList.Add(info1);
            infoList.Add(info2);
            infoList.Add(info3);
            infoList.Add(info4);
            infoList.Add(info5);
            infoList.Add(info6);
            this.toolStripComboBox_SearchType.ComboBox.DataSource = infoList;
            this.toolStripComboBox_SearchType.ComboBox.ValueMember = "SearchType";
            this.toolStripComboBox_SearchType.ComboBox.DisplayMember = "SearchName";
            this.toolStripComboBox_SearchType.ComboBox.SelectedIndex = 0;
        }
               
        private void StartForm2_Load(object sender, EventArgs e)
        {
            BindSearchTypeComboBox();
            RefreshDataGrid();
        }

        private void toolStripButton_Search_Click(object sender, EventArgs e)
        {
            string content = this.toolStripTextBox_SearchContent.Text;
            if (content.Length == 0)
            {
                return;
            }

            string column_name = this.toolStripComboBox_SearchType.ComboBox.SelectedValue.ToString();
            DataSet ds = BLL.Interface.GetOrderDataByColumn(column_name, content);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.ClearSelection();
        }

        private void toolStripButton_CancelSearch_Click(object sender, EventArgs e)
        {
            this.toolStripTextBox_SearchContent.Clear();
            RefreshDataGrid();
        }

        private void toolStripButton_Checkin_Click(object sender, EventArgs e)
        {
            CheckinForm checkinForm = new CheckinForm();
            checkinForm.MyEvent += new CheckinForm.MyDelegate(RefreshDataGridAndSetSelection);
            checkinForm.ShowDialog();
        }

        private void toolStripButton_Import_Click(object sender, EventArgs e)
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
            var row = dataGridView1.SelectedRows[0];
            string order_id = row.Cells[0].Value.ToString();

            DeliverForm form = new DeliverForm(order_id);
            form.ShowDialog();
        }

        private void ToolStripMenuItem_modify_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            string order_id = row.Cells[0].Value.ToString();

            CheckinForm checkinForm = new CheckinForm(BLL.Interface.QueryOrderById(order_id));
            checkinForm.MyEvent += new CheckinForm.MyDelegate(RefreshDataGridAndSetSelection);
            checkinForm.ShowDialog();
        }

        private void ToolStripMenuItem_delete_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            string order_id = row.Cells[0].Value.ToString();

            if (BLL.Interface.DeleteOrder(order_id))
            {
                MessageBox.Show("订单删除成功", "删除订单", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("订单删除失败", "删除订单", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGrid();
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //e.Row.HeaderCell.Value = (e.Row.Index + 1).ToString();
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
    }
}
