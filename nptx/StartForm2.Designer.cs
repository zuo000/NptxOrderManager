namespace UI
{
    partial class StartForm2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ImportOrder = new System.Windows.Forms.Button();
            this.button_CheckinOrder = new System.Windows.Forms.Button();
            this.button_cancelSearch = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_SearchContent = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_check = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_modify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.Column_OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_OrderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ProductBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_OrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DeliverPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DeliverNumEveryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Refresh);
            this.groupBox1.Controls.Add(this.button_ImportOrder);
            this.groupBox1.Controls.Add(this.button_CheckinOrder);
            this.groupBox1.Controls.Add(this.button_cancelSearch);
            this.groupBox1.Controls.Add(this.button_Search);
            this.groupBox1.Controls.Add(this.textBox_SearchContent);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "可按照客户姓名或者所在小区或者区域查询,右键进行修改或删除";
            // 
            // button_ImportOrder
            // 
            this.button_ImportOrder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ImportOrder.Location = new System.Drawing.Point(569, 22);
            this.button_ImportOrder.Name = "button_ImportOrder";
            this.button_ImportOrder.Size = new System.Drawing.Size(85, 27);
            this.button_ImportOrder.TabIndex = 5;
            this.button_ImportOrder.Text = "订单导入";
            this.button_ImportOrder.UseVisualStyleBackColor = true;
            this.button_ImportOrder.Click += new System.EventHandler(this.button_ImportOrder_Click);
            // 
            // button_CheckinOrder
            // 
            this.button_CheckinOrder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_CheckinOrder.Location = new System.Drawing.Point(445, 22);
            this.button_CheckinOrder.Name = "button_CheckinOrder";
            this.button_CheckinOrder.Size = new System.Drawing.Size(85, 27);
            this.button_CheckinOrder.TabIndex = 4;
            this.button_CheckinOrder.Text = "订单录入";
            this.button_CheckinOrder.UseVisualStyleBackColor = true;
            this.button_CheckinOrder.Click += new System.EventHandler(this.button_CheckinOrder_Click);
            // 
            // button_cancelSearch
            // 
            this.button_cancelSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_cancelSearch.Location = new System.Drawing.Point(326, 22);
            this.button_cancelSearch.Name = "button_cancelSearch";
            this.button_cancelSearch.Size = new System.Drawing.Size(85, 27);
            this.button_cancelSearch.TabIndex = 3;
            this.button_cancelSearch.Text = "取消查询";
            this.button_cancelSearch.UseVisualStyleBackColor = true;
            this.button_cancelSearch.Click += new System.EventHandler(this.button_cancelSearch_Click);
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Search.Location = new System.Drawing.Point(219, 22);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(69, 27);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "查询";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_SearchContent
            // 
            this.textBox_SearchContent.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_SearchContent.Location = new System.Drawing.Point(19, 22);
            this.textBox_SearchContent.Name = "textBox_SearchContent";
            this.textBox_SearchContent.Size = new System.Drawing.Size(173, 26);
            this.textBox_SearchContent.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_OrderId,
            this.Column_OrderTime,
            this.Column_Name,
            this.Column_NickName,
            this.Column_PhoneNumber,
            this.Column_District,
            this.Column_Address,
            this.Column_ProductBrand,
            this.Column_ProductName,
            this.Column_OrderNum,
            this.Column_DeliverPeriod,
            this.Column_DeliverNumEveryTime,
            this.Column_StartDate});
            this.dataGridView1.Location = new System.Drawing.Point(3, 79);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 492);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_check,
            this.ToolStripMenuItem_modify,
            this.ToolStripMenuItem_delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // ToolStripMenuItem_check
            // 
            this.ToolStripMenuItem_check.Name = "ToolStripMenuItem_check";
            this.ToolStripMenuItem_check.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_check.Text = "查看";
            this.ToolStripMenuItem_check.Click += new System.EventHandler(this.ToolStripMenuItem_check_Click);
            // 
            // ToolStripMenuItem_modify
            // 
            this.ToolStripMenuItem_modify.Name = "ToolStripMenuItem_modify";
            this.ToolStripMenuItem_modify.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_modify.Text = "修改";
            this.ToolStripMenuItem_modify.Click += new System.EventHandler(this.ToolStripMenuItem_modify_Click);
            // 
            // ToolStripMenuItem_delete
            // 
            this.ToolStripMenuItem_delete.Name = "ToolStripMenuItem_delete";
            this.ToolStripMenuItem_delete.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_delete.Text = "删除";
            this.ToolStripMenuItem_delete.Click += new System.EventHandler(this.ToolStripMenuItem_delete_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Refresh.Location = new System.Drawing.Point(691, 22);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(85, 27);
            this.button_Refresh.TabIndex = 6;
            this.button_Refresh.Text = "刷新";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
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
            // Column_Name
            // 
            this.Column_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Name.DataPropertyName = "customer_name";
            this.Column_Name.FillWeight = 68.02077F;
            this.Column_Name.HeaderText = "姓名";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Column_NickName
            // 
            this.Column_NickName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_NickName.DataPropertyName = "customer_nick_name";
            this.Column_NickName.FillWeight = 65.98985F;
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
            this.Column_District.FillWeight = 105.999F;
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
            this.Column_ProductBrand.FillWeight = 105.999F;
            this.Column_ProductBrand.HeaderText = "商品";
            this.Column_ProductBrand.Name = "Column_ProductBrand";
            this.Column_ProductBrand.ReadOnly = true;
            // 
            // Column_ProductName
            // 
            this.Column_ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_ProductName.DataPropertyName = "product_name";
            this.Column_ProductName.FillWeight = 105.999F;
            this.Column_ProductName.HeaderText = "型号";
            this.Column_ProductName.Name = "Column_ProductName";
            this.Column_ProductName.ReadOnly = true;
            // 
            // Column_OrderNum
            // 
            this.Column_OrderNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_OrderNum.DataPropertyName = "product_order_number";
            this.Column_OrderNum.FillWeight = 105.999F;
            this.Column_OrderNum.HeaderText = "订奶袋数";
            this.Column_OrderNum.Name = "Column_OrderNum";
            this.Column_OrderNum.ReadOnly = true;
            // 
            // Column_DeliverPeriod
            // 
            this.Column_DeliverPeriod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_DeliverPeriod.DataPropertyName = "deliver_period";
            this.Column_DeliverPeriod.FillWeight = 105.999F;
            this.Column_DeliverPeriod.HeaderText = "送奶计划";
            this.Column_DeliverPeriod.Name = "Column_DeliverPeriod";
            this.Column_DeliverPeriod.ReadOnly = true;
            // 
            // Column_DeliverNumEveryTime
            // 
            this.Column_DeliverNumEveryTime.DataPropertyName = "deliver_number_everytime";
            this.Column_DeliverNumEveryTime.FillWeight = 105.999F;
            this.Column_DeliverNumEveryTime.HeaderText = "每次送奶数量";
            this.Column_DeliverNumEveryTime.Name = "Column_DeliverNumEveryTime";
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
            // StartForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 574);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "StartForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "奶品天下订单管理系统 Version 0.1";
            this.Load += new System.EventHandler(this.StartForm2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_SearchContent;
        private System.Windows.Forms.Button button_cancelSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ImportOrder;
        private System.Windows.Forms.Button button_CheckinOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_check;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_modify;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_delete;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OrderTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_District;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ProductBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DeliverPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DeliverNumEveryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_StartDate;
    }
}