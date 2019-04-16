using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.dataGridView1.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd  HH:mm:ss";
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
            this.dataGridView1.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd  HH:mm:ss";
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
            const int OrderIdColIndex = 1;
            const int OrderTimeColIndex = 2;
            const int CustomerNameColIndex = 17;
            const int CustomerNickNameColIndex = 16;
            const int CustomerPhoneNumberColIndex = 18;
            const int CustomerAddressColIndex = 19;
            //第24列为空
            const int ProductBrandColIndex = 23;
            const int ProductNameColIndex = 24;
            const int ProductOrderNumberColIndex = 26;
            const int CommentsColIndex = 22;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx|所有文件|*.*";
            ofd.ValidateNames = true;
            ofd.CheckPathExists = true;
            ofd.CheckFileExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string strFileName = ofd.FileName;
                FileStream fs = null;                
                try
                {
                    int orderNum = 0;
                    using (fs = File.OpenRead(strFileName))
                    {
                        IWorkbook workbook = null;

                        // 2007版本
                        if (strFileName.IndexOf(".xlsx") > 0)
                        {
                            workbook = new XSSFWorkbook(fs);
                        }
                        // 2003版本
                        else if (strFileName.IndexOf(".xls") > 0)
                        {
                            workbook = new HSSFWorkbook(fs);
                        }

                        if (workbook != null)
                        {
                            ISheet sheet = workbook.GetSheet("商品订单");
                            if (sheet != null)
                            {
                                int rowCount = sheet.LastRowNum;
                                if (rowCount >= 1)
                                {
                                    for (short rowIndex = 1; rowIndex <= rowCount; ++rowIndex)
                                    {
                                        IRow row = sheet.GetRow(rowIndex);
                                        int lastCol = row.LastCellNum;
                                        if (lastCol % 4 != 0)
                                        {
                                            MessageBox.Show("订单导入失败\r\n第" + (rowIndex + 1).ToString() + "行商品数量错误", "订单导入", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }

                                        //多个商品,分成多条order_table记录
                                        int productNum = (lastCol - 24) / 4;
                                        for (int productIndex = 0; productIndex < productNum; ++productIndex)
                                        {
                                            Model.Order order = new Model.Order();
                                            order.OrderId = row.Cells[OrderIdColIndex].StringCellValue;
                                            if (productNum > 1)
                                            {
                                                order.OrderId += "-" + (productIndex + 1).ToString();
                                            }
                                            order.OrderDateTime = row.Cells[OrderTimeColIndex].DateCellValue.ToString();
                                            order.CustomerName = row.Cells[CustomerNameColIndex].StringCellValue;
                                            order.CustomerNickName = row.Cells[CustomerNickNameColIndex].StringCellValue;
                                            order.CustomerPhoneNumber = row.Cells[CustomerPhoneNumberColIndex].StringCellValue;
                                            //order.CustomerDistrict 
                                            order.CustomerAddress = row.Cells[CustomerAddressColIndex].StringCellValue;
                                            int index = order.CustomerAddress.IndexOf("区");
                                            if (index > 1)
                                            {
                                                order.CustomerDistrict = order.CustomerAddress.Substring(index - 2, 3);
                                            }
                                            order.ProductBrand = row.Cells[ProductBrandColIndex + productIndex * 4].StringCellValue;
                                            order.ProductName = row.Cells[ProductNameColIndex + productIndex * 4].StringCellValue;
                                            order.ProductOrderNumber = Convert.ToUInt16(row.Cells[ProductOrderNumberColIndex + productIndex * 4].NumericCellValue);
                                            order.DeliverNumberEveryTime = order.ProductOrderNumber;
                                            order.DeliverBeginDate = Convert.ToDateTime(order.OrderDateTime).ToString("yyyy-MM-dd");
                                            order.Comments = row.Cells[CommentsColIndex].StringCellValue;

                                            orderNum += BLL.Interface.CheckinOrder(order);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    MessageBox.Show(orderNum.ToString() + "条订单导入成功", "订单导入", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGrid();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message, "订单导入", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
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
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                ToolStripMenuItem_check_Click(sender, e);
            }
        }

        private void ToolStripMenuItem_check_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                return;
            }

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

        private void toolStripButton_DeliverStatistics_Click(object sender, EventArgs e)
        {
            DeliverStatis form = new DeliverStatis();
            form.ShowDialog();
        }
    }
}
