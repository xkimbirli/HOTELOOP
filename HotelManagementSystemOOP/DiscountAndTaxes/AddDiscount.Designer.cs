namespace HotelManagementSystemOOP
{
    partial class AddDiscount
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
            ExitAddDiscount = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            DiscountPercentage = new System.Windows.Forms.TextBox();
            DiscountDescription = new System.Windows.Forms.TextBox();
            DiscountName = new System.Windows.Forms.TextBox();
            SaveAddDiscount = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ExitAddDiscount
            // 
            ExitAddDiscount.BackColor = System.Drawing.Color.Transparent;
            ExitAddDiscount.Location = new System.Drawing.Point(525, 32);
            ExitAddDiscount.Name = "ExitAddDiscount";
            ExitAddDiscount.Size = new System.Drawing.Size(33, 29);
            ExitAddDiscount.TabIndex = 6;
            ExitAddDiscount.Text = "x";
            ExitAddDiscount.UseVisualStyleBackColor = false;
            ExitAddDiscount.Click += ExitAddDiscount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(12, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(224, 34);
            label1.TabIndex = 9;
            label1.Text = "ADD DISCOUNT";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            panel2.Controls.Add(DiscountPercentage);
            panel2.Controls.Add(DiscountDescription);
            panel2.Controls.Add(DiscountName);
            panel2.Controls.Add(SaveAddDiscount);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Location = new System.Drawing.Point(12, 84);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(546, 296);
            panel2.TabIndex = 10;
            // 
            // DiscountPercentage
            // 
            DiscountPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DiscountPercentage.Location = new System.Drawing.Point(202, 167);
            DiscountPercentage.Name = "DiscountPercentage";
            DiscountPercentage.Size = new System.Drawing.Size(328, 27);
            DiscountPercentage.TabIndex = 7;
            // 
            // DiscountDescription
            // 
            DiscountDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DiscountDescription.Location = new System.Drawing.Point(202, 100);
            DiscountDescription.Name = "DiscountDescription";
            DiscountDescription.Size = new System.Drawing.Size(328, 27);
            DiscountDescription.TabIndex = 6;
            // 
            // DiscountName
            // 
            DiscountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DiscountName.Location = new System.Drawing.Point(202, 34);
            DiscountName.Name = "DiscountName";
            DiscountName.Size = new System.Drawing.Size(328, 27);
            DiscountName.TabIndex = 5;
            // 
            // SaveAddDiscount
            // 
            SaveAddDiscount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SaveAddDiscount.Location = new System.Drawing.Point(436, 247);
            SaveAddDiscount.Name = "SaveAddDiscount";
            SaveAddDiscount.Size = new System.Drawing.Size(94, 29);
            SaveAddDiscount.TabIndex = 3;
            SaveAddDiscount.Text = "SAVE";
            SaveAddDiscount.UseVisualStyleBackColor = true;
            SaveAddDiscount.Click += SaveAddDiscount_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            label5.Location = new System.Drawing.Point(21, 169);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(173, 20);
            label5.TabIndex = 2;
            label5.Text = "DISCOUNT PERCENTAGE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(18, 104);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(128, 20);
            label6.TabIndex = 1;
            label6.Text = "DISCOUNT CODE ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label7.Location = new System.Drawing.Point(18, 41);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(127, 20);
            label7.TabIndex = 0;
            label7.Text = "DISCOUNT NAME";
            // 
            // AddDiscount
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            ClientSize = new System.Drawing.Size(586, 454);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(ExitAddDiscount);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximumSize = new System.Drawing.Size(588, 456);
            MinimumSize = new System.Drawing.Size(588, 456);
            Name = "AddDiscount";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += AddDiscount_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ExitAddDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox DiscountPercentage;
        private System.Windows.Forms.TextBox DiscountDescription;
        private System.Windows.Forms.TextBox DiscountName;
        private System.Windows.Forms.Button SaveAddDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}