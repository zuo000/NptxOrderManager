namespace UI
{
    partial class UpdateForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_SearchContent = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.ToolStripMenuItem_Modify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Community = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_OrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DeliverNumEveryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DeliverPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_Community,
            this.Column_OrderNum,
            this.Column_DeliverNumEveryTime,
            this.Column_DeliverPeriod,
            this.Column_StartDate,
            this.Column_EndDate});
            this.dataGridView1.Location = new System.Drawing.Point(35, 95);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 395);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Search);
            this.groupBox1.Controls.Add(this.textBox_SearchContent);
            this.groupBox1.Location = new System.Drawing.Point(35, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "可按照客户姓名或者所在小区查询,右键进行修改或删除";
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Search.Location = new System.Drawing.Point(194, 20);
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
            this.textBox_SearchContent.Size = new System.Drawing.Size(139, 26);
            this.textBox_SearchContent.TabIndex = 1;
            this.textBox_SearchContent.TextChanged += new System.EventHandler(this.textBox_SearchContent_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Modify,
            this.ToolStripMenuItem_Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // ToolStripMenuItem_Modify
            // 
            this.ToolStripMenuItem_Modify.Name = "ToolStripMenuItem_Modify";
            this.ToolStripMenuItem_Modify.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_Modify.Text = "修改";
            this.ToolStripMenuItem_Modify.Click += new System.EventHandler(this.ToolStripMenuItem_Modify_Click);
            // 
            // ToolStripMenuItem_Delete
            // 
            this.ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
            this.ToolStripMenuItem_Delete.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_Delete.Text = "删除";
            this.ToolStripMenuItem_Delete.Click += new System.EventHandler(this.ToolStripMenuItem_Delete_Click);
            // 
            // Column_Name
            // 
            this.Column_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Name.HeaderText = "姓名";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Column_Community
            // 
            this.Column_Community.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Community.HeaderText = "小区";
            this.Column_Community.Name = "Column_Community";
            this.Column_Community.ReadOnly = true;
            // 
            // Column_OrderNum
            // 
            this.Column_OrderNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_OrderNum.HeaderText = "订奶袋数";
            this.Column_OrderNum.Name = "Column_OrderNum";
            this.Column_OrderNum.ReadOnly = true;
            // 
            // Column_DeliverNumEveryTime
            // 
            this.Column_DeliverNumEveryTime.HeaderText = "每次送奶数量";
            this.Column_DeliverNumEveryTime.Name = "Column_DeliverNumEveryTime";
            // 
            // Column_DeliverPeriod
            // 
            this.Column_DeliverPeriod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_DeliverPeriod.HeaderText = "送奶计划";
            this.Column_DeliverPeriod.Name = "Column_DeliverPeriod";
            this.Column_DeliverPeriod.ReadOnly = true;
            // 
            // Column_StartDate
            // 
            this.Column_StartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_StartDate.HeaderText = "开始送奶日期";
            this.Column_StartDate.Name = "Column_StartDate";
            this.Column_StartDate.ReadOnly = true;
            // 
            // Column_EndDate
            // 
            this.Column_EndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_EndDate.HeaderText = "结束送奶日期";
            this.Column_EndDate.Name = "Column_EndDate";
            this.Column_EndDate.ReadOnly = true;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_SearchContent;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Modify;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Community;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DeliverNumEveryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DeliverPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_EndDate;
    }
}