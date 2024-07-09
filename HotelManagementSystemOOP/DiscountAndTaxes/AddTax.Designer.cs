namespace HotelManagementSystemOOP
{
    partial class AddTax
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
            ExitAddTax = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            TaxPercentage = new System.Windows.Forms.TextBox();
            TaxDescription = new System.Windows.Forms.TextBox();
            TaxName = new System.Windows.Forms.TextBox();
            SaveAddTax = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ExitAddTax
            // 
            ExitAddTax.BackColor = System.Drawing.Color.Transparent;
            ExitAddTax.Location = new System.Drawing.Point(536, 37);
            ExitAddTax.Name = "ExitAddTax";
            ExitAddTax.Size = new System.Drawing.Size(33, 29);
            ExitAddTax.TabIndex = 6;
            ExitAddTax.Text = "x";
            ExitAddTax.UseVisualStyleBackColor = false;
            ExitAddTax.Click += ExitAddTax_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label1.Location = new System.Drawing.Point(12, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(136, 34);
            label1.TabIndex = 8;
            label1.Text = "ADD TAX";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            panel1.Controls.Add(TaxPercentage);
            panel1.Controls.Add(TaxDescription);
            panel1.Controls.Add(TaxName);
            panel1.Controls.Add(SaveAddTax);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(23, 92);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(546, 296);
            panel1.TabIndex = 9;
            // 
            // TaxPercentage
            // 
            TaxPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TaxPercentage.Location = new System.Drawing.Point(202, 167);
            TaxPercentage.Name = "TaxPercentage";
            TaxPercentage.Size = new System.Drawing.Size(328, 27);
            TaxPercentage.TabIndex = 7;
            // 
            // TaxDescription
            // 
            TaxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TaxDescription.Location = new System.Drawing.Point(202, 100);
            TaxDescription.Name = "TaxDescription";
            TaxDescription.Size = new System.Drawing.Size(328, 27);
            TaxDescription.TabIndex = 6;
            // 
            // TaxName
            // 
            TaxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TaxName.Location = new System.Drawing.Point(202, 34);
            TaxName.Name = "TaxName";
            TaxName.Size = new System.Drawing.Size(328, 27);
            TaxName.TabIndex = 5;
            // 
            // SaveAddTax
            // 
            SaveAddTax.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SaveAddTax.Location = new System.Drawing.Point(436, 247);
            SaveAddTax.Name = "SaveAddTax";
            SaveAddTax.Size = new System.Drawing.Size(94, 29);
            SaveAddTax.TabIndex = 3;
            SaveAddTax.Text = "SAVE";
            SaveAddTax.UseVisualStyleBackColor = true;
            SaveAddTax.Click += SaveAddTax_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            label4.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label4.Location = new System.Drawing.Point(21, 169);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(127, 20);
            label4.TabIndex = 2;
            label4.Text = "TAX PERCENTAGE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label3.Location = new System.Drawing.Point(18, 102);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(130, 20);
            label3.TabIndex = 1;
            label3.Text = "TAX DESCRIPTION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label2.Location = new System.Drawing.Point(18, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 20);
            label2.TabIndex = 0;
            label2.Text = "TAX NAME";
            // 
            // AddTax
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            ClientSize = new System.Drawing.Size(588, 428);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(ExitAddTax);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximumSize = new System.Drawing.Size(588, 456);
            Name = "AddTax";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += AddTax_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ExitAddTax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TaxPercentage;
        private System.Windows.Forms.TextBox TaxDescription;
        private System.Windows.Forms.TextBox TaxName;
        private System.Windows.Forms.Button SaveAddTax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}