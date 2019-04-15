namespace UI
{
    partial class CheckinForm
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
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DeliverNumEveryTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_NickName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_PhoneNO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_CustomerDistrict = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_CustomerAddr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_ProductBrand = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_ProductName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_AdditionalGifts = new System.Windows.Forms.TextBox();
            this.textBox_Comments = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
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
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_CustomerName.Location = new System.Drawing.Point(91, 29);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(100, 26);
            this.textBox_CustomerName.TabIndex = 1;
            // 
            // label_OrderNum
            // 
            this.label_OrderNum.AutoSize = true;
            this.label_OrderNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OrderNum.Location = new System.Drawing.Point(20, 184);
            this.label_OrderNum.Name = "label_OrderNum";
            this.label_OrderNum.Size = new System.Drawing.Size(65, 20);
            this.label_OrderNum.TabIndex = 18;
            this.label_OrderNum.Text = "订奶数量";
            // 
            // textBox_OrderNum
            // 
            this.textBox_OrderNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_OrderNum.Location = new System.Drawing.Point(91, 181);
            this.textBox_OrderNum.Name = "textBox_OrderNum";
            this.textBox_OrderNum.Size = new System.Drawing.Size(56, 26);
            this.textBox_OrderNum.TabIndex = 19;
            this.textBox_OrderNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_OrderNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(153, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "袋";
            // 
            // label_DeliverPeriod
            // 
            this.label_DeliverPeriod.AutoSize = true;
            this.label_DeliverPeriod.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DeliverPeriod.Location = new System.Drawing.Point(10, 17);
            this.label_DeliverPeriod.Name = "label_DeliverPeriod";
            this.label_DeliverPeriod.Size = new System.Drawing.Size(65, 20);
            this.label_DeliverPeriod.TabIndex = 0;
            this.label_DeliverPeriod.Text = "送奶计划";
            // 
            // radioButton_ByWeek
            // 
            this.radioButton_ByWeek.AutoSize = true;
            this.radioButton_ByWeek.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_ByWeek.Location = new System.Drawing.Point(85, 17);
            this.radioButton_ByWeek.Name = "radioButton_ByWeek";
            this.radioButton_ByWeek.Size = new System.Drawing.Size(55, 24);
            this.radioButton_ByWeek.TabIndex = 1;
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
            this.radioButton_ByDay.TabIndex = 2;
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
            this.panel_DeliverWeekly.TabIndex = 3;
            this.panel_DeliverWeekly.Visible = false;
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
            this.panel_DeliverDaily.TabIndex = 4;
            this.panel_DeliverDaily.Visible = false;
            // 
            // textBox_DeliverInterval
            // 
            this.textBox_DeliverInterval.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_DeliverInterval.Location = new System.Drawing.Point(76, 26);
            this.textBox_DeliverInterval.Name = "textBox_DeliverInterval";
            this.textBox_DeliverInterval.Size = new System.Drawing.Size(39, 26);
            this.textBox_DeliverInterval.TabIndex = 1;
            this.textBox_DeliverInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_DeliverInterval_KeyPress);
            // 
            // label_DeliverDay
            // 
            this.label_DeliverDay.AutoSize = true;
            this.label_DeliverDay.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DeliverDay.Location = new System.Drawing.Point(121, 26);
            this.label_DeliverDay.Name = "label_DeliverDay";
            this.label_DeliverDay.Size = new System.Drawing.Size(23, 20);
            this.label_DeliverDay.TabIndex = 2;
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
            this.button_Submit.Location = new System.Drawing.Point(334, 540);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(105, 42);
            this.button_Submit.TabIndex = 26;
            this.button_Submit.Text = "提交";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_DeliverDaily);
            this.groupBox1.Controls.Add(this.radioButton_ByDay);
            this.groupBox1.Controls.Add(this.radioButton_ByWeek);
            this.groupBox1.Controls.Add(this.label_DeliverPeriod);
            this.groupBox1.Controls.Add(this.panel_DeliverWeekly);
            this.groupBox1.Location = new System.Drawing.Point(458, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 268);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Location = new System.Drawing.Point(94, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 268);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(66, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "开始送奶日期";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(4, 64);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(392, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "袋";
            // 
            // textBox_DeliverNumEveryTime
            // 
            this.textBox_DeliverNumEveryTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_DeliverNumEveryTime.Location = new System.Drawing.Point(330, 181);
            this.textBox_DeliverNumEveryTime.Name = "textBox_DeliverNumEveryTime";
            this.textBox_DeliverNumEveryTime.Size = new System.Drawing.Size(56, 26);
            this.textBox_DeliverNumEveryTime.TabIndex = 22;
            this.textBox_DeliverNumEveryTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_DeliverNumEveryTime_KeyPress);
            this.textBox_DeliverNumEveryTime.MouseHover += new System.EventHandler(this.textBox_DeliverNumEveryTime_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(271, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "每次送";
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // textBox_NickName
            // 
            this.textBox_NickName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_NickName.Location = new System.Drawing.Point(330, 29);
            this.textBox_NickName.Name = "textBox_NickName";
            this.textBox_NickName.Size = new System.Drawing.Size(94, 26);
            this.textBox_NickName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(257, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "客户昵称";
            // 
            // textBox_PhoneNO
            // 
            this.textBox_PhoneNO.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_PhoneNO.Location = new System.Drawing.Point(548, 29);
            this.textBox_PhoneNO.Name = "textBox_PhoneNO";
            this.textBox_PhoneNO.Size = new System.Drawing.Size(100, 26);
            this.textBox_PhoneNO.TabIndex = 5;
            this.textBox_PhoneNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PhoneNO_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(472, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "客户电话";
            // 
            // comboBox_CustomerDistrict
            // 
            this.comboBox_CustomerDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_CustomerDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_CustomerDistrict.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_CustomerDistrict.FormattingEnabled = true;
            this.comboBox_CustomerDistrict.Location = new System.Drawing.Point(91, 77);
            this.comboBox_CustomerDistrict.Name = "comboBox_CustomerDistrict";
            this.comboBox_CustomerDistrict.Size = new System.Drawing.Size(100, 28);
            this.comboBox_CustomerDistrict.TabIndex = 7;
            this.comboBox_CustomerDistrict.TextUpdate += new System.EventHandler(this.comboBox_CustomerDistrict_TextUpdate);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "所属行政区";
            // 
            // textBox_CustomerAddr
            // 
            this.textBox_CustomerAddr.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_CustomerAddr.Location = new System.Drawing.Point(330, 77);
            this.textBox_CustomerAddr.Name = "textBox_CustomerAddr";
            this.textBox_CustomerAddr.Size = new System.Drawing.Size(218, 26);
            this.textBox_CustomerAddr.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(257, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "客户地址";
            // 
            // comboBox_ProductBrand
            // 
            this.comboBox_ProductBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_ProductBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_ProductBrand.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_ProductBrand.FormattingEnabled = true;
            this.comboBox_ProductBrand.Location = new System.Drawing.Point(91, 128);
            this.comboBox_ProductBrand.Name = "comboBox_ProductBrand";
            this.comboBox_ProductBrand.Size = new System.Drawing.Size(100, 28);
            this.comboBox_ProductBrand.TabIndex = 13;
            this.comboBox_ProductBrand.TextUpdate += new System.EventHandler(this.comboBox_ProductBrand_TextUpdate);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(20, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "订购商品";
            // 
            // comboBox_ProductName
            // 
            this.comboBox_ProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_ProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_ProductName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_ProductName.FormattingEnabled = true;
            this.comboBox_ProductName.Location = new System.Drawing.Point(330, 128);
            this.comboBox_ProductName.Name = "comboBox_ProductName";
            this.comboBox_ProductName.Size = new System.Drawing.Size(109, 28);
            this.comboBox_ProductName.TabIndex = 15;
            this.comboBox_ProductName.TextUpdate += new System.EventHandler(this.comboBox_ProductName_TextUpdate);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(257, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "商品类型";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(500, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "赠品";
            // 
            // textBox_AdditionalGifts
            // 
            this.textBox_AdditionalGifts.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_AdditionalGifts.Location = new System.Drawing.Point(548, 133);
            this.textBox_AdditionalGifts.Name = "textBox_AdditionalGifts";
            this.textBox_AdditionalGifts.Size = new System.Drawing.Size(100, 26);
            this.textBox_AdditionalGifts.TabIndex = 17;
            // 
            // textBox_Comments
            // 
            this.textBox_Comments.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Comments.Location = new System.Drawing.Point(548, 181);
            this.textBox_Comments.Name = "textBox_Comments";
            this.textBox_Comments.Size = new System.Drawing.Size(100, 26);
            this.textBox_Comments.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(471, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "配送要求";
            // 
            // CheckinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 594);
            this.Controls.Add(this.textBox_Comments);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_AdditionalGifts);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox_ProductName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_ProductBrand);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_CustomerAddr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_CustomerDistrict);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_PhoneNO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_NickName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_DeliverNumEveryTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_OrderNum);
            this.Controls.Add(this.label_OrderNum);
            this.Controls.Add(this.textBox_CustomerName);
            this.Controls.Add(this.label_CustomerName);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CheckinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.CheckinForm_Activated);
            this.Load += new System.EventHandler(this.CheckinForm_Load);
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
        private System.Windows.Forms.TextBox textBox_CustomerName;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DeliverNumEveryTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_NickName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_PhoneNO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_CustomerDistrict;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_CustomerAddr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_ProductBrand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_ProductName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_AdditionalGifts;
        private System.Windows.Forms.TextBox textBox_Comments;
        private System.Windows.Forms.Label label12;
    }
}