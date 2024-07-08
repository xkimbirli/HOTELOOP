namespace HotelManagementSystemOOP
{
    partial class DiscountAndTaxes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            dataGridViewDiscount = new System.Windows.Forms.DataGridView();
            panel2 = new System.Windows.Forms.Panel();
            dataGridViewTax = new System.Windows.Forms.DataGridView();
            AddDiscount = new System.Windows.Forms.Button();
            AddTax = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            SuiteRate = new System.Windows.Forms.TextBox();
            DeluxeRate = new System.Windows.Forms.TextBox();
            StandardRate = new System.Windows.Forms.TextBox();
            SaveRoomRates = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiscount).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTax).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(188, 47);
            label1.TabIndex = 0;
            label1.Text = "Discount";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(25, 457);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(129, 47);
            label2.TabIndex = 1;
            label2.Text = "Taxes";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGray;
            panel1.Controls.Add(dataGridViewDiscount);
            panel1.Location = new System.Drawing.Point(22, 87);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(623, 311);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridViewDiscount
            // 
            dataGridViewDiscount.AllowUserToResizeColumns = false;
            dataGridViewDiscount.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewDiscount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDiscount.BackgroundColor = System.Drawing.Color.FromArgb(61, 41, 31);
            dataGridViewDiscount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewDiscount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDiscount.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewDiscount.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewDiscount.EnableHeadersVisualStyles = false;
            dataGridViewDiscount.GridColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewDiscount.Location = new System.Drawing.Point(0, 0);
            dataGridViewDiscount.Name = "dataGridViewDiscount";
            dataGridViewDiscount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewDiscount.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewDiscount.RowHeadersVisible = false;
            dataGridViewDiscount.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewDiscount.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewDiscount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViewDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDiscount.Size = new System.Drawing.Size(623, 311);
            dataGridViewDiscount.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.LightGray;
            panel2.Controls.Add(dataGridViewTax);
            panel2.Location = new System.Drawing.Point(22, 510);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(623, 311);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridViewTax
            // 
            dataGridViewTax.AllowUserToResizeColumns = false;
            dataGridViewTax.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewTax.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTax.BackgroundColor = System.Drawing.Color.FromArgb(61, 41, 31);
            dataGridViewTax.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewTax.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewTax.ColumnHeadersHeight = 40;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewTax.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTax.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewTax.EnableHeadersVisualStyles = false;
            dataGridViewTax.GridColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewTax.Location = new System.Drawing.Point(0, 0);
            dataGridViewTax.Name = "dataGridViewTax";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewTax.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewTax.RowHeadersVisible = false;
            dataGridViewTax.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewTax.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTax.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViewTax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTax.Size = new System.Drawing.Size(623, 311);
            dataGridViewTax.TabIndex = 0;
            // 
            // AddDiscount
            // 
            AddDiscount.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            AddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddDiscount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            AddDiscount.ForeColor = System.Drawing.Color.White;
            AddDiscount.Location = new System.Drawing.Point(605, 52);
            AddDiscount.Name = "AddDiscount";
            AddDiscount.Size = new System.Drawing.Size(31, 29);
            AddDiscount.TabIndex = 4;
            AddDiscount.Text = "+";
            AddDiscount.UseVisualStyleBackColor = false;
            AddDiscount.Click += AddDiscount_Click;
            // 
            // AddTax
            // 
            AddTax.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            AddTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddTax.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            AddTax.ForeColor = System.Drawing.Color.White;
            AddTax.Location = new System.Drawing.Point(605, 475);
            AddTax.Name = "AddTax";
            AddTax.Size = new System.Drawing.Size(31, 29);
            AddTax.TabIndex = 5;
            AddTax.Text = "+";
            AddTax.UseVisualStyleBackColor = false;
            AddTax.Click += AddTax_Click;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            panel3.Controls.Add(SuiteRate);
            panel3.Controls.Add(DeluxeRate);
            panel3.Controls.Add(StandardRate);
            panel3.Controls.Add(SaveRoomRates);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new System.Drawing.Point(678, 87);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(620, 310);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // SuiteRate
            // 
            SuiteRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            SuiteRate.Location = new System.Drawing.Point(191, 197);
            SuiteRate.Name = "SuiteRate";
            SuiteRate.Size = new System.Drawing.Size(349, 27);
            SuiteRate.TabIndex = 6;
            SuiteRate.TextChanged += SuiteRate_TextChanged;
            // 
            // DeluxeRate
            // 
            DeluxeRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DeluxeRate.Location = new System.Drawing.Point(191, 116);
            DeluxeRate.Name = "DeluxeRate";
            DeluxeRate.Size = new System.Drawing.Size(349, 27);
            DeluxeRate.TabIndex = 5;
            DeluxeRate.TextChanged += DeluxeRate_TextChanged;
            // 
            // StandardRate
            // 
            StandardRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            StandardRate.Location = new System.Drawing.Point(191, 51);
            StandardRate.Name = "StandardRate";
            StandardRate.Size = new System.Drawing.Size(349, 27);
            StandardRate.TabIndex = 4;
            StandardRate.TextChanged += StandardRate_TextChanged;
            // 
            // SaveRoomRates
            // 
            SaveRoomRates.Location = new System.Drawing.Point(505, 262);
            SaveRoomRates.Name = "SaveRoomRates";
            SaveRoomRates.Size = new System.Drawing.Size(94, 29);
            SaveRoomRates.TabIndex = 3;
            SaveRoomRates.Text = "SAVE";
            SaveRoomRates.UseVisualStyleBackColor = true;
            SaveRoomRates.Click += SaveRoomRates_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(53, 204);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 20);
            label6.TabIndex = 2;
            label6.Text = "Suite";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(53, 116);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 20);
            label5.TabIndex = 1;
            label5.Text = "Deluxe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(53, 51);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 0;
            label4.Text = "Standard";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(681, 37);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(270, 47);
            label3.TabIndex = 7;
            label3.Text = "ROOM RATES";
            // 
            // DiscountAndTaxes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            ClientSize = new System.Drawing.Size(1323, 868);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(AddTax);
            Controls.Add(AddDiscount);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new System.Drawing.Size(1341, 915);
            MinimumSize = new System.Drawing.Size(1341, 915);
            Name = "DiscountAndTaxes";
            Text = "DiscountAndTaxes";
            Load += DiscountAndTaxes_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiscount).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTax).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddDiscount;
        private System.Windows.Forms.Button AddTax;
        private System.Windows.Forms.DataGridView dataGridViewDiscount;
        private System.Windows.Forms.DataGridView dataGridViewTax;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox SuiteRate;
        private System.Windows.Forms.TextBox DeluxeRate;
        private System.Windows.Forms.TextBox StandardRate;
        private System.Windows.Forms.Button SaveRoomRates;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}