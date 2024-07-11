namespace HotelManagementSystemOOP
{
    partial class AddExtraAmountPayment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label7 = new System.Windows.Forms.Label();
            SaveEtraAddAmount = new System.Windows.Forms.Button();
            PaymentMethodAEA = new System.Windows.Forms.ComboBox();
            label13 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Location = new System.Drawing.Point(534, 13);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(42, 37);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(SaveEtraAddAmount);
            panel2.Controls.Add(PaymentMethodAEA);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label11);
            panel2.Location = new System.Drawing.Point(12, 58);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(564, 296);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(227, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(307, 27);
            dateTimePicker1.TabIndex = 31;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label7.Location = new System.Drawing.Point(126, 26);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(295, 37);
            label7.TabIndex = 30;
            label7.Text = "Add Extra Payment";
            label7.Click += label7_Click;
            // 
            // SaveEtraAddAmount
            // 
            SaveEtraAddAmount.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            SaveEtraAddAmount.FlatAppearance.BorderSize = 0;
            SaveEtraAddAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SaveEtraAddAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            SaveEtraAddAmount.ForeColor = System.Drawing.Color.White;
            SaveEtraAddAmount.Location = new System.Drawing.Point(438, 239);
            SaveEtraAddAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SaveEtraAddAmount.Name = "SaveEtraAddAmount";
            SaveEtraAddAmount.Size = new System.Drawing.Size(96, 31);
            SaveEtraAddAmount.TabIndex = 29;
            SaveEtraAddAmount.Text = "PAID";
            SaveEtraAddAmount.UseVisualStyleBackColor = false;
            SaveEtraAddAmount.Click += SaveEtraAddAmount_Click;
            // 
            // PaymentMethodAEA
            // 
            PaymentMethodAEA.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            PaymentMethodAEA.FormattingEnabled = true;
            PaymentMethodAEA.Location = new System.Drawing.Point(227, 184);
            PaymentMethodAEA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PaymentMethodAEA.Name = "PaymentMethodAEA";
            PaymentMethodAEA.Size = new System.Drawing.Size(307, 29);
            PaymentMethodAEA.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label13.Location = new System.Drawing.Point(26, 111);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(118, 21);
            label13.TabIndex = 16;
            label13.Text = "Added Date";
            label13.Click += label4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label11.Location = new System.Drawing.Point(26, 184);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(156, 21);
            label11.TabIndex = 20;
            label11.Text = "Payment Method";
            label11.Click += label6_Click;
            // 
            // AddExtraAmountPayment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            ClientSize = new System.Drawing.Size(596, 383);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(button1);
            ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "AddExtraAmountPayment";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += AddExtraAmountPayment_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveEtraAddAmount;
        private System.Windows.Forms.ComboBox PaymentMethodAEA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
