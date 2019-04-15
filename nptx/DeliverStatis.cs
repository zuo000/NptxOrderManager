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
    public partial class DeliverStatis : Form
    {
        public class SearchTypeInfo
        {
            public string SearchType { get; set; }
            public string SearchName { get; set; }
        }

        public DeliverStatis()
        {
            InitializeComponent();
        }

        private void RefreshDataGrid()
        {
            DataSet ds = BLL.Interface.GetAllDeliverData();

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.ClearSelection();
        }

        private void DeliverStatis_Load(object sender, EventArgs e)
        {
            BindProductBrandComboBox();
            BindDistrictComboBox();
            RefreshDataGrid();
        }

        private void DeliverStatis_Activated(object sender, EventArgs e)
        {

        }

        private void BindProductBrandComboBox()
        {
            IList<SearchTypeInfo> infoList = new List<SearchTypeInfo>();
            List<string> brandList = BLL.Interface.GetAllProductBrands();

            SearchTypeInfo info2 = new SearchTypeInfo() { SearchType = "all", SearchName = "全部" };
            infoList.Add(info2);

            foreach (string brand in brandList)
            {
                SearchTypeInfo info = new SearchTypeInfo() { SearchType = brand, SearchName = brand };
                infoList.Add(info);
            }            

            this.comboBox_ProductBrand.DataSource = infoList;
            this.comboBox_ProductBrand.ValueMember = "SearchType";
            this.comboBox_ProductBrand.DisplayMember = "SearchName";
            this.comboBox_ProductBrand.SelectedIndex = 0;
        }

        private void BindDistrictComboBox()
        {
            IList<SearchTypeInfo> infoList = new List<SearchTypeInfo>();
            List<string> brandList = BLL.Interface.GetAllDistrictNames();

            SearchTypeInfo info2 = new SearchTypeInfo() { SearchType = "all", SearchName = "全部" };
            infoList.Add(info2);

            foreach (string brand in brandList)
            {
                SearchTypeInfo info = new SearchTypeInfo() { SearchType = brand, SearchName = brand };
                infoList.Add(info);
            }

            this.comboBox_District.DataSource = infoList;
            this.comboBox_District.ValueMember = "SearchType";
            this.comboBox_District.DisplayMember = "SearchName";
            this.comboBox_District.SelectedIndex = 0;
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = (e.Row.Index + 1).ToString();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            DataSet ds = BLL.Interface.GetDeliverItemsBySearch(this.comboBox_ProductBrand.SelectedValue.ToString(),
                this.comboBox_District.SelectedValue.ToString(), this.dateTimePicker1.Value.ToString("yyyy-MM-dd"));

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.ClearSelection();
        }

        private void button_ClearSearch_Click(object sender, EventArgs e)
        {
            this.comboBox_ProductBrand.SelectedValue = "all";
            this.comboBox_District.SelectedValue = "all";
            this.dateTimePicker1.Text = DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd");
            RefreshDataGrid();
        }
    }
}
