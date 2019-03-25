namespace UI
{
    partial class StartForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Checkin = new System.Windows.Forms.Button();
            this.button_Checkout = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Checkin
            // 
            this.button_Checkin.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Checkin.Location = new System.Drawing.Point(296, 104);
            this.button_Checkin.Name = "button_Checkin";
            this.button_Checkin.Size = new System.Drawing.Size(257, 72);
            this.button_Checkin.TabIndex = 0;
            this.button_Checkin.Text = "订单录入";
            this.button_Checkin.UseVisualStyleBackColor = true;
            this.button_Checkin.Click += new System.EventHandler(this.buttonCheckin_Click);
            // 
            // button_Checkout
            // 
            this.button_Checkout.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Checkout.Location = new System.Drawing.Point(296, 241);
            this.button_Checkout.Name = "button_Checkout";
            this.button_Checkout.Size = new System.Drawing.Size(257, 72);
            this.button_Checkout.TabIndex = 1;
            this.button_Checkout.Text = "订单出库";
            this.button_Checkout.UseVisualStyleBackColor = true;
            this.button_Checkout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Update.Location = new System.Drawing.Point(296, 374);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(257, 72);
            this.button_Update.TabIndex = 2;
            this.button_Update.Text = "订单更新";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 568);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Checkout);
            this.Controls.Add(this.button_Checkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "奶品天下订单管理系统 Version 0.1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Checkin;
        private System.Windows.Forms.Button button_Checkout;
        private System.Windows.Forms.Button button_Update;
    }
}

