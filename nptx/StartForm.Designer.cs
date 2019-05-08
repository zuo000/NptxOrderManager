namespace UI
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_check = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_modify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox_SearchType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox_SearchContent = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton_Search = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_CancelSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Checkin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Import = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_DeliverStatistics = new System.Windows.Forms.ToolStripButton();
            this.Column_OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_OrderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ProductBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_OrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DeliverPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Gifts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.Column_OrderId,
            this.Column_OrderTime,
            this.Column1_Name,
            this.Column_NickName,
            this.Column_PhoneNumber,
            this.Column_District,
            this.Column_Address,
            this.Column_ProductBrand,
            this.Column_ProductName,
            this.Column_OrderNum,
            this.Column_DeliverPeriod,
            this.Column_StartDate,
            this.Column_Gifts});
            this.dataGridView1.Location = new System.Drawing.Point(3, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1175, 438);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_check,
            this.ToolStripMenuItem_modify,
            this.ToolStripMenuItem_delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // ToolStripMenuItem_check
            // 
            this.ToolStripMenuItem_check.Name = "ToolStripMenuItem_check";
            this.ToolStripMenuItem_check.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_check.Text = "查看配送计划";
            this.ToolStripMenuItem_check.Click += new System.EventHandler(this.ToolStripMenuItem_check_Click);
            // 
            // ToolStripMenuItem_modify
            // 
            this.ToolStripMenuItem_modify.Name = "ToolStripMenuItem_modify";
            this.ToolStripMenuItem_modify.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_modify.Text = "修改订单";
            this.ToolStripMenuItem_modify.Click += new System.EventHandler(this.ToolStripMenuItem_modify_Click);
            // 
            // ToolStripMenuItem_delete
            // 
            this.ToolStripMenuItem_delete.Name = "ToolStripMenuItem_delete";
            this.ToolStripMenuItem_delete.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_delete.Text = "删除订单";
            this.ToolStripMenuItem_delete.Click += new System.EventHandler(this.ToolStripMenuItem_delete_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_SearchType,
            this.toolStripTextBox_SearchContent,
            this.toolStripButton_Search,
            this.toolStripButton_CancelSearch,
            this.toolStripSeparator1,
            this.toolStripButton_Checkin,
            this.toolStripButton_Import,
            this.toolStripSeparator2,
            this.toolStripButton_DeliverStatistics});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1182, 28);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox_SearchType
            // 
            this.toolStripComboBox_SearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_SearchType.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripComboBox_SearchType.Name = "toolStripComboBox_SearchType";
            this.toolStripComboBox_SearchType.Size = new System.Drawing.Size(90, 28);
            // 
            // toolStripTextBox_SearchContent
            // 
            this.toolStripTextBox_SearchContent.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTextBox_SearchContent.Name = "toolStripTextBox_SearchContent";
            this.toolStripTextBox_SearchContent.Size = new System.Drawing.Size(90, 28);
            // 
            // toolStripButton_Search
            // 
            this.toolStripButton_Search.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_Search.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Search.Image")));
            this.toolStripButton_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Search.Name = "toolStripButton_Search";
            this.toolStripButton_Search.Size = new System.Drawing.Size(57, 25);
            this.toolStripButton_Search.Text = "查询";
            this.toolStripButton_Search.Click += new System.EventHandler(this.toolStripButton_Search_Click);
            // 
            // toolStripButton_CancelSearch
            // 
            this.toolStripButton_CancelSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_CancelSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_CancelSearch.Image")));
            this.toolStripButton_CancelSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CancelSearch.Name = "toolStripButton_CancelSearch";
            this.toolStripButton_CancelSearch.Size = new System.Drawing.Size(113, 25);
            this.toolStripButton_CancelSearch.Text = "清除查询结果";
            this.toolStripButton_CancelSearch.Click += new System.EventHandler(this.toolStripButton_CancelSearch_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton_Checkin
            // 
            this.toolStripButton_Checkin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_Checkin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Checkin.Image")));
            this.toolStripButton_Checkin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Checkin.Name = "toolStripButton_Checkin";
            this.toolStripButton_Checkin.Size = new System.Drawing.Size(85, 25);
            this.toolStripButton_Checkin.Text = "订单录入";
            this.toolStripButton_Checkin.Click += new System.EventHandler(this.toolStripButton_Checkin_Click);
            // 
            // toolStripButton_Import
            // 
            this.toolStripButton_Import.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_Import.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Import.Image")));
            this.toolStripButton_Import.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Import.Name = "toolStripButton_Import";
            this.toolStripButton_Import.Size = new System.Drawing.Size(85, 25);
            this.toolStripButton_Import.Text = "订单导入";
            this.toolStripButton_Import.Click += new System.EventHandler(this.toolStripButton_Import_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton_DeliverStatistics
            // 
            this.toolStripButton_DeliverStatistics.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_DeliverStatistics.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_DeliverStatistics.Image")));
            this.toolStripButton_DeliverStatistics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DeliverStatistics.Name = "toolStripButton_DeliverStatistics";
            this.toolStripButton_DeliverStatistics.Size = new System.Drawing.Size(85, 25);
            this.toolStripButton_DeliverStatistics.Text = "配送统计";
            this.toolStripButton_DeliverStatistics.Click += new System.EventHandler(this.toolStripButton_DeliverStatistics_Click);
            // 
            // Column_OrderId
            // 
            this.Column_OrderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_OrderId.DataPropertyName = "order_id";
            this.Column_OrderId.FillWeight = 105.999F;
            this.Column_OrderId.HeaderText = "订单号";
            this.Column_OrderId.Name = "Column_OrderId";
            this.Column_OrderId.ReadOnly = true;
            // 
            // Column_OrderTime
            // 
            this.Column_OrderTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_OrderTime.DataPropertyName = "order_time";
            this.Column_OrderTime.FillWeight = 105.999F;
            this.Column_OrderTime.HeaderText = "订单时间";
            this.Column_OrderTime.Name = "Column_OrderTime";
            this.Column_OrderTime.ReadOnly = true;
            // 
            // Column1_Name
            // 
            this.Column1_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1_Name.DataPropertyName = "customer_name";
            this.Column1_Name.FillWeight = 95F;
            this.Column1_Name.HeaderText = "客户姓名";
            this.Column1_Name.Name = "Column1_Name";
            this.Column1_Name.ReadOnly = true;
            // 
            // Column_NickName
            // 
            this.Column_NickName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_NickName.DataPropertyName = "customer_nick_name";
            this.Column_NickName.HeaderText = "客户昵称";
            this.Column_NickName.Name = "Column_NickName";
            this.Column_NickName.ReadOnly = true;
            // 
            // Column_PhoneNumber
            // 
            this.Column_PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_PhoneNumber.DataPropertyName = "customer_phone_number";
            this.Column_PhoneNumber.FillWeight = 105.999F;
            this.Column_PhoneNumber.HeaderText = "联系电话";
            this.Column_PhoneNumber.Name = "Column_PhoneNumber";
            this.Column_PhoneNumber.ReadOnly = true;
            // 
            // Column_District
            // 
            this.Column_District.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_District.DataPropertyName = "customer_district";
            this.Column_District.FillWeight = 80F;
            this.Column_District.HeaderText = "所在区域";
            this.Column_District.Name = "Column_District";
            this.Column_District.ReadOnly = true;
            // 
            // Column_Address
            // 
            this.Column_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Address.DataPropertyName = "customer_address";
            this.Column_Address.FillWeight = 105.999F;
            this.Column_Address.HeaderText = "配送地址";
            this.Column_Address.Name = "Column_Address";
            this.Column_Address.ReadOnly = true;
            // 
            // Column_ProductBrand
            // 
            this.Column_ProductBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_ProductBrand.DataPropertyName = "product_brand";
            this.Column_ProductBrand.HeaderText = "商品";
            this.Column_ProductBrand.Name = "Column_ProductBrand";
            this.Column_ProductBrand.ReadOnly = true;
            // 
            // Column_ProductName
            // 
            this.Column_ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_ProductName.DataPropertyName = "product_name";
            this.Column_ProductName.FillWeight = 80F;
            this.Column_ProductName.HeaderText = "型号";
            this.Column_ProductName.Name = "Column_ProductName";
            this.Column_ProductName.ReadOnly = true;
            // 
            // Column_OrderNum
            // 
            this.Column_OrderNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_OrderNum.DataPropertyName = "product_order_number";
            this.Column_OrderNum.FillWeight = 80F;
            this.Column_OrderNum.HeaderText = "订奶数量";
            this.Column_OrderNum.Name = "Column_OrderNum";
            this.Column_OrderNum.ReadOnly = true;
            // 
            // Column_DeliverPeriod
            // 
            this.Column_DeliverPeriod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_DeliverPeriod.DataPropertyName = "deliver_plan";
            this.Column_DeliverPeriod.FillWeight = 115.999F;
            this.Column_DeliverPeriod.HeaderText = "送奶计划";
            this.Column_DeliverPeriod.Name = "Column_DeliverPeriod";
            this.Column_DeliverPeriod.ReadOnly = true;
            // 
            // Column_StartDate
            // 
            this.Column_StartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_StartDate.DataPropertyName = "deliver_begin_date";
            this.Column_StartDate.FillWeight = 105.999F;
            this.Column_StartDate.HeaderText = "开始送奶日期";
            this.Column_StartDate.Name = "Column_StartDate";
            this.Column_StartDate.ReadOnly = true;
            // 
            // Column_Gifts
            // 
            this.Column_Gifts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Gifts.DataPropertyName = "additional_gifts";
            this.Column_Gifts.FillWeight = 70F;
            this.Column_Gifts.HeaderText = "赠品";
            this.Column_Gifts.Name = "Column_Gifts";
            this.Column_Gifts.ReadOnly = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 486);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "奶品天下订单管理系统 Version 0.1";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_check;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_modify;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_delete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_SearchType;
        private System.Windows.Forms.ToolStripButton toolStripButton_Search;
        private System.Windows.Forms.ToolStripButton toolStripButton_CancelSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Checkin;
        private System.Windows.Forms.ToolStripButton toolStripButton_Import;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_SearchContent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_DeliverStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OrderTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_District;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ProductBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DeliverPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Gifts;
    }
}