namespace UI
{
    partial class DeliverStatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_deliverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DeliverNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Finished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ProductBrand = new System.Windows.Forms.ComboBox();
            this.comboBox_District = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_ClearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_deliverId,
            this.Column_OrderId,
            this.Column_CustomerName,
            this.Column_NickName,
            this.Column_district,
            this.Column_Address,
            this.Column_Brand,
            this.Column_Name,
            this.Column_Data,
            this.Column_DeliverNumber,
            this.Column_Finished});
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 452);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // Column_deliverId
            // 
            this.Column_deliverId.DataPropertyName = "deliver_id";
            this.Column_deliverId.HeaderText = "deliverId";
            this.Column_deliverId.Name = "Column_deliverId";
            this.Column_deliverId.ReadOnly = true;
            this.Column_deliverId.Visible = false;
            // 
            // Column_OrderId
            // 
            this.Column_OrderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_OrderId.DataPropertyName = "order_id";
            this.Column_OrderId.HeaderText = "订单号";
            this.Column_OrderId.Name = "Column_OrderId";
            this.Column_OrderId.ReadOnly = true;
            // 
            // Column_CustomerName
            // 
            this.Column_CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_CustomerName.DataPropertyName = "customer_name";
            this.Column_CustomerName.HeaderText = "客户姓名";
            this.Column_CustomerName.Name = "Column_CustomerName";
            this.Column_CustomerName.ReadOnly = true;
            // 
            // Column_NickName
            // 
            this.Column_NickName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_NickName.DataPropertyName = "customer_nick_name";
            this.Column_NickName.HeaderText = "客户昵称";
            this.Column_NickName.Name = "Column_NickName";
            this.Column_NickName.ReadOnly = true;
            // 
            // Column_district
            // 
            this.Column_district.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_district.DataPropertyName = "customer_district";
            this.Column_district.HeaderText = "所在区域";
            this.Column_district.Name = "Column_district";
            this.Column_district.ReadOnly = true;
            // 
            // Column_Address
            // 
            this.Column_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Address.DataPropertyName = "customer_address";
            this.Column_Address.HeaderText = "送货地址";
            this.Column_Address.Name = "Column_Address";
            this.Column_Address.ReadOnly = true;
            // 
            // Column_Brand
            // 
            this.Column_Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Brand.DataPropertyName = "product_brand";
            this.Column_Brand.HeaderText = "商品";
            this.Column_Brand.Name = "Column_Brand";
            this.Column_Brand.ReadOnly = true;
            // 
            // Column_Name
            // 
            this.Column_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Name.DataPropertyName = "product_name";
            this.Column_Name.HeaderText = "型号";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Column_Data
            // 
            this.Column_Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Data.DataPropertyName = "deliver_date";
            this.Column_Data.HeaderText = "送货日期";
            this.Column_Data.Name = "Column_Data";
            this.Column_Data.ReadOnly = true;
            // 
            // Column_DeliverNumber
            // 
            this.Column_DeliverNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_DeliverNumber.DataPropertyName = "deliver_number";
            this.Column_DeliverNumber.HeaderText = "送货数量";
            this.Column_DeliverNumber.Name = "Column_DeliverNumber";
            this.Column_DeliverNumber.ReadOnly = true;
            // 
            // Column_Finished
            // 
            this.Column_Finished.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Finished.DataPropertyName = "deliver_status";
            this.Column_Finished.HeaderText = "完成情况";
            this.Column_Finished.Name = "Column_Finished";
            this.Column_Finished.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ClearSearch);
            this.groupBox1.Controls.Add(this.button_Search);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox_District);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_ProductBrand);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品";
            // 
            // comboBox_ProductBrand
            // 
            this.comboBox_ProductBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProductBrand.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_ProductBrand.FormattingEnabled = true;
            this.comboBox_ProductBrand.Location = new System.Drawing.Point(53, 18);
            this.comboBox_ProductBrand.Name = "comboBox_ProductBrand";
            this.comboBox_ProductBrand.Size = new System.Drawing.Size(121, 28);
            this.comboBox_ProductBrand.TabIndex = 1;
            // 
            // comboBox_District
            // 
            this.comboBox_District.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_District.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_District.FormattingEnabled = true;
            this.comboBox_District.Location = new System.Drawing.Point(292, 18);
            this.comboBox_District.Name = "comboBox_District";
            this.comboBox_District.Size = new System.Drawing.Size(121, 28);
            this.comboBox_District.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(217, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "所在区域";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Location = new System.Drawing.Point(452, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Search.Location = new System.Drawing.Point(681, 19);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 30);
            this.button_Search.TabIndex = 5;
            this.button_Search.Text = "查询";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_ClearSearch
            // 
            this.button_ClearSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ClearSearch.Location = new System.Drawing.Point(787, 19);
            this.button_ClearSearch.Name = "button_ClearSearch";
            this.button_ClearSearch.Size = new System.Drawing.Size(101, 30);
            this.button_ClearSearch.TabIndex = 6;
            this.button_ClearSearch.Text = "清除查询结果";
            this.button_ClearSearch.UseVisualStyleBackColor = true;
            this.button_ClearSearch.Click += new System.EventHandler(this.button_ClearSearch_Click);
            // 
            // DeliverStatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeliverStatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配送统计";
            this.Activated += new System.EventHandler(this.DeliverStatis_Activated);
            this.Load += new System.EventHandler(this.DeliverStatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_deliverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_district;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DeliverNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Finished;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ProductBrand;
        private System.Windows.Forms.ComboBox comboBox_District;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_ClearSearch;
    }
}