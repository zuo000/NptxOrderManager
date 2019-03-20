namespace UI
{
    partial class UpdateModifyForm
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
            this.label_CustomerName = new System.Windows.Forms.Label();
            this.label_Community = new System.Windows.Forms.Label();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.comboBox_Community = new System.Windows.Forms.ComboBox();
            this.label_OrderNum = new System.Windows.Forms.Label();
            this.textBox_OrderNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_DeliverPeriod = new System.Windows.Forms.Label();
            this.radioButton_ByWeek = new System.Windows.Forms.RadioButton();
            this.radioButton_ByDay = new System.Windows.Forms.RadioButton();
            this.panel_DeliverWeekly = new System.Windows.Forms.Panel();
            this.checkBox_Sunday = new System.Windows.Forms.CheckBox();
            this.checkBox_Saturday = new System.Windows.Forms.CheckBox();
            this.checkBox_Friday = new System.Windows.Forms.CheckBox();
            this.checkBox_Thursday = new System.Windows.Forms.CheckBox();
            this.checkBox_Wednesday = new System.Windows.Forms.CheckBox();
            this.checkBox_Tuesday = new System.Windows.Forms.CheckBox();
            this.checkBox_Monday = new System.Windows.Forms.CheckBox();
            this.panel_DeliverDaily = new System.Windows.Forms.Panel();
            this.textBox_DeliverInterval = new System.Windows.Forms.TextBox();
            this.label_DeliverDay = new System.Windows.Forms.Label();
            this.label_DeliverEvery = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_DeliverWeekly.SuspendLayout();
            this.panel_DeliverDaily.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CustomerName
            // 
            this.label_CustomerName.AutoSize = true;
            this.label_CustomerName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_CustomerName.Location = new System.Drawing.Point(21, 32);
            this.label_CustomerName.Name = "label_CustomerName";
            this.label_CustomerName.Size = new System.Drawing.Size(65, 20);
            this.label_CustomerName.TabIndex = 0;
            this.label_CustomerName.Text = "客户姓名";
            // 
            // label_Community
            // 
            this.label_Community.AutoSize = true;
            this.label_Community.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Community.Location = new System.Drawing.Point(250, 35);
            this.label_Community.Name = "label_Community";
            this.label_Community.Size = new System.Drawing.Size(65, 20);
            this.label_Community.TabIndex = 2;
            this.label_Community.Text = "所在小区";
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_CustomerName.Location = new System.Drawing.Point(108, 32);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(100, 26);
            this.textBox_CustomerName.TabIndex = 5;
            this.textBox_CustomerName.TextChanged += new System.EventHandler(this.textBox_CustomerName_TextChanged);
            // 
            // comboBox_Community
            // 
            this.comboBox_Community.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Community.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_Community.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_Community.FormattingEnabled = true;
            this.comboBox_Community.Location = new System.Drawing.Point(337, 32);
            this.comboBox_Community.Name = "comboBox_Community";
            this.comboBox_Community.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Community.TabIndex = 6;
            this.comboBox_Community.TextUpdate += new System.EventHandler(this.comboBox_Community_TextUpdate);
            // 
            // label_OrderNum
            // 
            this.label_OrderNum.AutoSize = true;
            this.label_OrderNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OrderNum.Location = new System.Drawing.Point(22, 78);
            this.label_OrderNum.Name = "label_OrderNum";
            this.label_OrderNum.Size = new System.Drawing.Size(65, 20);
            this.label_OrderNum.TabIndex = 7;
            this.label_OrderNum.Text = "订奶数量";
            // 
            // textBox_OrderNum
            // 
            this.textBox_OrderNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_OrderNum.Location = new System.Drawing.Point(109, 78);
            this.textBox_OrderNum.Name = "textBox_OrderNum";
            this.textBox_OrderNum.Size = new System.Drawing.Size(56, 26);
            this.textBox_OrderNum.TabIndex = 8;
            this.textBox_OrderNum.TextChanged += new System.EventHandler(this.textBox_OrderNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(171, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "袋";
            // 
            // label_DeliverPeriod
            // 
            this.label_DeliverPeriod.AutoSize = true;
            this.label_DeliverPeriod.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DeliverPeriod.Location = new System.Drawing.Point(10, 17);
            this.label_DeliverPeriod.Name = "label_DeliverPeriod";
            this.label_DeliverPeriod.Size = new System.Drawing.Size(65, 20);
            this.label_DeliverPeriod.TabIndex = 10;
            this.label_DeliverPeriod.Text = "送奶计划";
            // 
            // radioButton_ByWeek
            // 
            this.radioButton_ByWeek.AutoSize = true;
            this.radioButton_ByWeek.Checked = true;
            this.radioButton_ByWeek.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_ByWeek.Location = new System.Drawing.Point(85, 17);
            this.radioButton_ByWeek.Name = "radioButton_ByWeek";
            this.radioButton_ByWeek.Size = new System.Drawing.Size(55, 24);
            this.radioButton_ByWeek.TabIndex = 14;
            this.radioButton_ByWeek.TabStop = true;
            this.radioButton_ByWeek.Text = "按周";
            this.radioButton_ByWeek.UseVisualStyleBackColor = true;
            this.radioButton_ByWeek.CheckedChanged += new System.EventHandler(this.radioButton_ByWeek_CheckedChanged);
            this.radioButton_ByWeek.Enter += new System.EventHandler(this.radioButton_ByWeek_Enter);
            // 
            // radioButton_ByDay
            // 
            this.radioButton_ByDay.AutoSize = true;
            this.radioButton_ByDay.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_ByDay.Location = new System.Drawing.Point(151, 17);
            this.radioButton_ByDay.Name = "radioButton_ByDay";
            this.radioButton_ByDay.Size = new System.Drawing.Size(55, 24);
            this.radioButton_ByDay.TabIndex = 15;
            this.radioButton_ByDay.Text = "按天";
            this.radioButton_ByDay.UseVisualStyleBackColor = true;
            this.radioButton_ByDay.CheckedChanged += new System.EventHandler(this.radioButton_ByDay_CheckedChanged);
            this.radioButton_ByDay.Enter += new System.EventHandler(this.radioButton_ByDay_Enter);
            // 
            // panel_DeliverWeekly
            // 
            this.panel_DeliverWeekly.Controls.Add(this.checkBox_Sunday);
            this.panel_DeliverWeekly.Controls.Add(this.checkBox_Saturday);
            this.panel_DeliverWeekly.Controls.Add(this.checkBox_Friday);
            this.panel_DeliverWeekly.Controls.Add(this.checkBox_Thursday);
            this.panel_DeliverWeekly.Controls.Add(this.checkBox_Wednesday);
            this.panel_DeliverWeekly.Controls.Add(this.checkBox_Tuesday);
            this.panel_DeliverWeekly.Controls.Add(this.checkBox_Monday);
            this.panel_DeliverWeekly.Location = new System.Drawing.Point(17, 59);
            this.panel_DeliverWeekly.Name = "panel_DeliverWeekly";
            this.panel_DeliverWeekly.Size = new System.Drawing.Size(197, 192);
            this.panel_DeliverWeekly.TabIndex = 16;
            // 
            // checkBox_Sunday
            // 
            this.checkBox_Sunday.AutoSize = true;
            this.checkBox_Sunday.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Sunday.Location = new System.Drawing.Point(62, 160);
            this.checkBox_Sunday.Name = "checkBox_Sunday";
            this.checkBox_Sunday.Size = new System.Drawing.Size(56, 24);
            this.checkBox_Sunday.TabIndex = 6;
            this.checkBox_Sunday.Text = "周日";
            this.checkBox_Sunday.UseVisualStyleBackColor = true;
            // 
            // checkBox_Saturday
            // 
            this.checkBox_Saturday.AutoSize = true;
            this.checkBox_Saturday.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Saturday.Location = new System.Drawing.Point(62, 134);
            this.checkBox_Saturday.Name = "checkBox_Saturday";
            this.checkBox_Saturday.Size = new System.Drawing.Size(56, 24);
            this.checkBox_Saturday.TabIndex = 5;
            this.checkBox_Saturday.Text = "周六";
            this.checkBox_Saturday.UseVisualStyleBackColor = true;
            // 
            // checkBox_Friday
            // 
            this.checkBox_Friday.AutoSize = true;
            this.checkBox_Friday.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Friday.Location = new System.Drawing.Point(62, 106);
            this.checkBox_Friday.Name = "checkBox_Friday";
            this.checkBox_Friday.Size = new System.Drawing.Size(56, 24);
            this.checkBox_Friday.TabIndex = 4;
            this.checkBox_Friday.Text = "周五";
            this.checkBox_Friday.UseVisualStyleBackColor = true;
            // 
            // checkBox_Thursday
            // 
            this.checkBox_Thursday.AutoSize = true;
            this.checkBox_Thursday.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Thursday.Location = new System.Drawing.Point(62, 79);
            this.checkBox_Thursday.Name = "checkBox_Thursday";
            this.checkBox_Thursday.Size = new System.Drawing.Size(56, 24);
            this.checkBox_Thursday.TabIndex = 3;
            this.checkBox_Thursday.Text = "周四";
            this.checkBox_Thursday.UseVisualStyleBackColor = true;
            // 
            // checkBox_Wednesday
            // 
            this.checkBox_Wednesday.AutoSize = true;
            this.checkBox_Wednesday.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Wednesday.Location = new System.Drawing.Point(62, 54);
            this.checkBox_Wednesday.Name = "checkBox_Wednesday";
            this.checkBox_Wednesday.Size = new System.Drawing.Size(56, 24);
            this.checkBox_Wednesday.TabIndex = 2;
            this.checkBox_Wednesday.Text = "周三";
            this.checkBox_Wednesday.UseVisualStyleBackColor = true;
            // 
            // checkBox_Tuesday
            // 
            this.checkBox_Tuesday.AutoSize = true;
            this.checkBox_Tuesday.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Tuesday.Location = new System.Drawing.Point(62, 29);
            this.checkBox_Tuesday.Name = "checkBox_Tuesday";
            this.checkBox_Tuesday.Size = new System.Drawing.Size(56, 24);
            this.checkBox_Tuesday.TabIndex = 1;
            this.checkBox_Tuesday.Text = "周二";
            this.checkBox_Tuesday.UseVisualStyleBackColor = true;
            // 
            // checkBox_Monday
            // 
            this.checkBox_Monday.AutoSize = true;
            this.checkBox_Monday.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Monday.Location = new System.Drawing.Point(62, 4);
            this.checkBox_Monday.Name = "checkBox_Monday";
            this.checkBox_Monday.Size = new System.Drawing.Size(56, 24);
            this.checkBox_Monday.TabIndex = 0;
            this.checkBox_Monday.Text = "周一";
            this.checkBox_Monday.UseVisualStyleBackColor = true;
            // 
            // panel_DeliverDaily
            // 
            this.panel_DeliverDaily.Controls.Add(this.textBox_DeliverInterval);
            this.panel_DeliverDaily.Controls.Add(this.label_DeliverDay);
            this.panel_DeliverDaily.Controls.Add(this.label_DeliverEvery);
            this.panel_DeliverDaily.Location = new System.Drawing.Point(20, 59);
            this.panel_DeliverDaily.Name = "panel_DeliverDaily";
            this.panel_DeliverDaily.Size = new System.Drawing.Size(200, 100);
            this.panel_DeliverDaily.TabIndex = 17;
            this.panel_DeliverDaily.Visible = false;
            // 
            // textBox_DeliverInterval
            // 
            this.textBox_DeliverInterval.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_DeliverInterval.Location = new System.Drawing.Point(76, 26);
            this.textBox_DeliverInterval.Name = "textBox_DeliverInterval";
            this.textBox_DeliverInterval.Size = new System.Drawing.Size(39, 26);
            this.textBox_DeliverInterval.TabIndex = 2;
            // 
            // label_DeliverDay
            // 
            this.label_DeliverDay.AutoSize = true;
            this.label_DeliverDay.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DeliverDay.Location = new System.Drawing.Point(121, 26);
            this.label_DeliverDay.Name = "label_DeliverDay";
            this.label_DeliverDay.Size = new System.Drawing.Size(23, 20);
            this.label_DeliverDay.TabIndex = 1;
            this.label_DeliverDay.Text = "天";
            // 
            // label_DeliverEvery
            // 
            this.label_DeliverEvery.AutoSize = true;
            this.label_DeliverEvery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DeliverEvery.Location = new System.Drawing.Point(47, 26);
            this.label_DeliverEvery.Name = "label_DeliverEvery";
            this.label_DeliverEvery.Size = new System.Drawing.Size(23, 20);
            this.label_DeliverEvery.TabIndex = 0;
            this.label_DeliverEvery.Text = "每";
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Submit.Location = new System.Drawing.Point(228, 451);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(105, 42);
            this.button_Submit.TabIndex = 18;
            this.button_Submit.Text = "提交";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_DeliverDaily);
            this.groupBox1.Controls.Add(this.panel_DeliverWeekly);
            this.groupBox1.Controls.Add(this.radioButton_ByDay);
            this.groupBox1.Controls.Add(this.radioButton_ByWeek);
            this.groupBox1.Controls.Add(this.label_DeliverPeriod);
            this.groupBox1.Location = new System.Drawing.Point(25, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 268);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Location = new System.Drawing.Point(302, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 268);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(4, 64);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(66, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "送奶开始日期";
            // 
            // UpdateModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_OrderNum);
            this.Controls.Add(this.label_OrderNum);
            this.Controls.Add(this.textBox_CustomerName);
            this.Controls.Add(this.comboBox_Community);
            this.Controls.Add(this.label_Community);
            this.Controls.Add(this.label_CustomerName);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改";
            this.Load += new System.EventHandler(this.UpdateModifyForm_Load);
            this.panel_DeliverWeekly.ResumeLayout(false);
            this.panel_DeliverWeekly.PerformLayout();
            this.panel_DeliverDaily.ResumeLayout(false);
            this.panel_DeliverDaily.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CustomerName;
        private System.Windows.Forms.Label label_Community;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private System.Windows.Forms.ComboBox comboBox_Community;
        private System.Windows.Forms.Label label_OrderNum;
        private System.Windows.Forms.TextBox textBox_OrderNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_DeliverPeriod;
        private System.Windows.Forms.RadioButton radioButton_ByWeek;
        private System.Windows.Forms.RadioButton radioButton_ByDay;
        private System.Windows.Forms.Panel panel_DeliverWeekly;
        private System.Windows.Forms.CheckBox checkBox_Monday;
        private System.Windows.Forms.CheckBox checkBox_Tuesday;
        private System.Windows.Forms.CheckBox checkBox_Sunday;
        private System.Windows.Forms.CheckBox checkBox_Saturday;
        private System.Windows.Forms.CheckBox checkBox_Friday;
        private System.Windows.Forms.CheckBox checkBox_Thursday;
        private System.Windows.Forms.CheckBox checkBox_Wednesday;
        private System.Windows.Forms.Panel panel_DeliverDaily;
        private System.Windows.Forms.Label label_DeliverEvery;
        private System.Windows.Forms.Label label_DeliverDay;
        private System.Windows.Forms.TextBox textBox_DeliverInterval;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
    }
}