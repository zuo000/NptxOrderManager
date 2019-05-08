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
    public partial class DeliverForm : Form
    {
        private string m_orderId = null;

        public DeliverForm(string orderId)
        {
            m_orderId = orderId;
            InitializeComponent();
        }

        private void SetHeaderCell()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = string.Format("{0}", i + 1);
            }
        }

        private void RefreshDataGrid(string orderId)
        {
            DataSet ds = BLL.Interface.GetDeliverItemsByOrderId(orderId);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.ClearSelection();

            SetHeaderCell();
        }

        private void RefreshDataGridAndSetSelection(string order_id, string deliver_id)
        {
            RefreshDataGrid(order_id);

            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == deliver_id)
                {
                    this.dataGridView1.CurrentCell = row.Cells[1];
                    this.dataGridView1.Rows[row.Index].Selected = true;
                    return;
                }
            }
        }

        private void DeliverForm_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(m_orderId);
        }

        private void ToolStripMenuItem_add_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];

            Model.DeliverItem item = new Model.DeliverItem();
            item.DeliverId = row.Cells[0].Value.ToString();
            item.OrderId = row.Cells[1].Value.ToString();
            item.CustomerName = row.Cells[2].Value.ToString();
            item.CustomerNickName = row.Cells[3].Value.ToString();
            item.CustomerDistrict = row.Cells[4].Value.ToString();
            item.CustomerAddress = row.Cells[5].Value.ToString();
            item.ProductBrand = row.Cells[6].Value.ToString();
            item.ProductName = row.Cells[7].Value.ToString();
            item.DeliverDate = row.Cells[8].Value.ToString();
            item.DeliverNumber = Convert.ToUInt16(row.Cells[9].Value.ToString());

            DeliverUpdateForm form = new DeliverUpdateForm(item, true);
            form.MyEvent += new DeliverUpdateForm.MyDelegate(RefreshDataGridAndSetSelection);
            form.ShowDialog();
        }

        private void ToolStripMenuItem_modify_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];

            Model.DeliverItem item = new Model.DeliverItem();
            item.DeliverId = row.Cells[0].Value.ToString();
            item.OrderId = row.Cells[1].Value.ToString();
            item.CustomerName = row.Cells[2].Value.ToString();
            item.CustomerNickName = row.Cells[3].Value.ToString();
            item.CustomerDistrict = row.Cells[4].Value.ToString();
            item.CustomerAddress = row.Cells[5].Value.ToString();
            item.ProductBrand = row.Cells[6].Value.ToString();
            item.ProductName = row.Cells[7].Value.ToString();
            item.DeliverDate = row.Cells[8].Value.ToString();
            item.DeliverNumber = Convert.ToUInt16(row.Cells[9].Value.ToString());

            DeliverUpdateForm form = new DeliverUpdateForm(item, false);
            form.MyEvent += new DeliverUpdateForm.MyDelegate(RefreshDataGridAndSetSelection);
            form.ShowDialog();
        }

        private void ToolStripMenuItem_delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string deliverId = row.Cells[0].Value.ToString();

                BLL.Interface.DeleteDeliverItem(deliverId);
            }

            RefreshDataGrid(m_orderId);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                foreach (ToolStripItem item in this.contextMenuStrip1.Items)
                {
                    item.Enabled = true;
                }

                if (dataGridView1.SelectedRows.Count > 1)
                {
                    foreach(ToolStripItem item in this.contextMenuStrip1.Items)
                    {
                        if (item.Text == "增加" ||
                            item.Text == "修改")
                        {
                            item.Enabled = false;
                        }
                    }
                }

                this.contextMenuStrip1.Show(MousePosition.X, MousePosition.Y); //MousePosition.X, MousePosition.Y 是为了让菜单在所选行的位置显示
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ToolStripMenuItem_modify_Click(sender, e);
        }

        private void ToolStripMenuItem_finished_Click(object sender, EventArgs e)
        {
            List<int> rowIndexArray = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int row_index = row.Index;
                rowIndexArray.Add(row_index);

                BLL.Interface.UpdateDeliverStatus(row.Cells[0].Value.ToString(), "已完成");
            }

            RefreshDataGrid(m_orderId);

            foreach(int index in rowIndexArray)
            {
                this.dataGridView1.Rows[index].Selected = true;
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            SetHeaderCell();
        }
    }
}
