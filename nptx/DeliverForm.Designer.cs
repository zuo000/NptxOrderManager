namespace UI
{
    partial class DeliverForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_finished = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_modify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(983, 493);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_finished,
            this.ToolStripMenuItem_add,
            this.ToolStripMenuItem_modify,
            this.ToolStripMenuItem_delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 92);
            // 
            // ToolStripMenuItem_finished
            // 
            this.ToolStripMenuItem_finished.Name = "ToolStripMenuItem_finished";
            this.ToolStripMenuItem_finished.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItem_finished.Text = "已完成";
            this.ToolStripMenuItem_finished.Click += new System.EventHandler(this.ToolStripMenuItem_finished_Click);
            // 
            // ToolStripMenuItem_add
            // 
            this.ToolStripMenuItem_add.Name = "ToolStripMenuItem_add";
            this.ToolStripMenuItem_add.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItem_add.Text = "增加";
            this.ToolStripMenuItem_add.Click += new System.EventHandler(this.ToolStripMenuItem_add_Click);
            // 
            // ToolStripMenuItem_modify
            // 
            this.ToolStripMenuItem_modify.Name = "ToolStripMenuItem_modify";
            this.ToolStripMenuItem_modify.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItem_modify.Text = "修改";
            this.ToolStripMenuItem_modify.Click += new System.EventHandler(this.ToolStripMenuItem_modify_Click);
            // 
            // ToolStripMenuItem_delete
            // 
            this.ToolStripMenuItem_delete.Name = "ToolStripMenuItem_delete";
            this.ToolStripMenuItem_delete.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItem_delete.Text = "删除";
            this.ToolStripMenuItem_delete.Click += new System.EventHandler(this.ToolStripMenuItem_delete_Click);
            // 
            // DeliverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 493);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeliverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配送计划";
            this.Load += new System.EventHandler(this.DeliverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_modify;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_delete;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_finished;
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
    }
}