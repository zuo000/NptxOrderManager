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

        private void RefreshDataGrid(string orderId)
        {
            DataSet ds = BLL.Interface.GetDeliverItemsByOrderId(orderId);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.ClearSelection();
        }

        private void DeliverForm_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(m_orderId);
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
            e.Row.HeaderCell.Value = (e.Row.Index + 1).ToString();
        }

        private void ToolStripMenuItem_add_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_modify_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_delete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                this.contextMenuStrip1.Show(MousePosition.X, MousePosition.Y); //MousePosition.X, MousePosition.Y 是为了让菜单在所选行的位置显示
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ToolStripMenuItem_modify_Click(sender, e);
        }
    }
}
