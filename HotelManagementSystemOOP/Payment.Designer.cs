namespace HotelManagementSystemOOP
{
    partial class Payment
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
            ExitPayment = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            DiscountCoupon = new System.Windows.Forms.TextBox();
            PaymentMethodDDP = new System.Windows.Forms.ComboBox();
            PaymetStatusDDP = new System.Windows.Forms.ComboBox();
            SavePayment = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ExitPayment
            // 
            ExitPayment.BackColor = System.Drawing.Color.Transparent;
            ExitPayment.Location = new System.Drawing.Point(754, 18);
            ExitPayment.Name = "ExitPayment";
            ExitPayment.Size = new System.Drawing.Size(34, 29);
            ExitPayment.TabIndex = 0;
            ExitPayment.Text = "x";
            ExitPayment.UseVisualStyleBackColor = false;
            ExitPayment.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(63, 145);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(179, 23);
            label2.TabIndex = 2;
            label2.Text = "Discount Coupon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(63, 214);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(180, 23);
            label3.TabIndex = 3;
            label3.Text = "Payment Method";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(63, 293);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(162, 23);
            label4.TabIndex = 4;
            label4.Text = "Payment Status";
            // 
            // DiscountCoupon
            // 
            DiscountCoupon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DiscountCoupon.Location = new System.Drawing.Point(358, 145);
            DiscountCoupon.Name = "DiscountCoupon";
            DiscountCoupon.Size = new System.Drawing.Size(307, 27);
            DiscountCoupon.TabIndex = 6;
            DiscountCoupon.TextChanged += DiscountCoupon_TextChanged;
            // 
            // PaymentMethodDDP
            // 
            PaymentMethodDDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            PaymentMethodDDP.FormattingEnabled = true;
            PaymentMethodDDP.Location = new System.Drawing.Point(358, 217);
            PaymentMethodDDP.Name = "PaymentMethodDDP";
            PaymentMethodDDP.Size = new System.Drawing.Size(307, 28);
            PaymentMethodDDP.TabIndex = 7;
            PaymentMethodDDP.SelectedIndexChanged += PaymentMethodDDP_SelectedIndexChanged;
            // 
            // PaymetStatusDDP
            // 
            PaymetStatusDDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            PaymetStatusDDP.FormattingEnabled = true;
            PaymetStatusDDP.Location = new System.Drawing.Point(358, 288);
            PaymetStatusDDP.Name = "PaymetStatusDDP";
            PaymetStatusDDP.Size = new System.Drawing.Size(307, 28);
            PaymetStatusDDP.TabIndex = 8;
            // 
            // SavePayment
            // 
            SavePayment.BackColor = System.Drawing.Color.Black;
            SavePayment.FlatAppearance.BorderSize = 0;
            SavePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SavePayment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SavePayment.ForeColor = System.Drawing.Color.White;
            SavePayment.Location = new System.Drawing.Point(702, 399);
            SavePayment.Name = "SavePayment";
            SavePayment.Size = new System.Drawing.Size(76, 29);
            SavePayment.TabIndex = 9;
            SavePayment.Text = "SAVE";
            SavePayment.UseVisualStyleBackColor = false;
            SavePayment.Click += SavePayment_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(800, 450);
            ControlBox = false;
            Controls.Add(SavePayment);
            Controls.Add(PaymetStatusDDP);
            Controls.Add(PaymentMethodDDP);
            Controls.Add(DiscountCoupon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ExitPayment);
            ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            Name = "Payment";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ExitPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DiscountCoupon;
        private System.Windows.Forms.ComboBox PaymentMethodDDP;
        private System.Windows.Forms.ComboBox PaymetStatusDDP;
        private System.Windows.Forms.Button SavePayment;
    }
}