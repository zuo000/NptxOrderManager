namespace UI
{
    partial class CheckoutForm
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
            this.radioButton_ByCustomerName = new System.Windows.Forms.RadioButton();
            this.radioButton_ByCustomerCommunity = new System.Windows.Forms.RadioButton();
            this.comboBox_SearchContent = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button_Submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_ByCustomerName
            // 
            this.radioButton_ByCustomerName.AutoSize = true;
            this.radioButton_ByCustomerName.Checked = true;
            this.radioButton_ByCustomerName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_ByCustomerName.Location = new System.Drawing.Point(19, 13);
            this.radioButton_ByCustomerName.Name = "radioButton_ByCustomerName";
            this.radioButton_ByCustomerName.Size = new System.Drawing.Size(97, 24);
            this.radioButton_ByCustomerName.TabIndex = 0;
            this.radioButton_ByCustomerName.TabStop = true;
            this.radioButton_ByCustomerName.Text = "按客户姓名";
            this.radioButton_ByCustomerName.UseVisualStyleBackColor = true;
            this.radioButton_ByCustomerName.CheckedChanged += new System.EventHandler(this.radioButton_ByCustomerName_CheckedChanged);
            this.radioButton_ByCustomerName.Enter += new System.EventHandler(this.radioButton_ByCustomerName_Enter);
            // 
            // radioButton_ByCustomerCommunity
            // 
            this.radioButton_ByCustomerCommunity.AutoSize = true;
            this.radioButton_ByCustomerCommunity.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_ByCustomerCommunity.Location = new System.Drawing.Point(136, 13);
            this.radioButton_ByCustomerCommunity.Name = "radioButton_ByCustomerCommunity";
            this.radioButton_ByCustomerCommunity.Size = new System.Drawing.Size(125, 24);
            this.radioButton_ByCustomerCommunity.TabIndex = 1;
            this.radioButton_ByCustomerCommunity.Text = "按客户所在小区";
            this.radioButton_ByCustomerCommunity.UseVisualStyleBackColor = true;
            this.radioButton_ByCustomerCommunity.CheckedChanged += new System.EventHandler(this.radioButton_ByCustomerCommunity_CheckedChanged);
            this.radioButton_ByCustomerCommunity.Enter += new System.EventHandler(this.radioButton_ByCustomerCommunity_Enter);
            // 
            // comboBox_SearchContent
            // 
            this.comboBox_SearchContent.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_SearchContent.FormattingEnabled = true;
            this.comboBox_SearchContent.Location = new System.Drawing.Point(75, 70);
            this.comboBox_SearchContent.Name = "comboBox_SearchContent";
            this.comboBox_SearchContent.Size = new System.Drawing.Size(118, 28);
            this.comboBox_SearchContent.TabIndex = 2;
            this.comboBox_SearchContent.TextUpdate += new System.EventHandler(this.comboBox_SearchContent_TextUpdate);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthCalendar1.Location = new System.Drawing.Point(28, 61);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Submit.Location = new System.Drawing.Point(100, 423);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(118, 36);
            this.button_Submit.TabIndex = 5;
            this.button_Submit.Text = "提交";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_SearchContent);
            this.groupBox1.Controls.Add(this.radioButton_ByCustomerCommunity);
            this.groupBox1.Controls.Add(this.radioButton_ByCustomerName);
            this.groupBox1.Location = new System.Drawing.Point(25, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 131);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Location = new System.Drawing.Point(25, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 250);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(104, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "送货日期";
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出库";
            this.Activated += new System.EventHandler(this.CheckoutForm_Activated);
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_ByCustomerName;
        private System.Windows.Forms.RadioButton radioButton_ByCustomerCommunity;
        private System.Windows.Forms.ComboBox comboBox_SearchContent;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}