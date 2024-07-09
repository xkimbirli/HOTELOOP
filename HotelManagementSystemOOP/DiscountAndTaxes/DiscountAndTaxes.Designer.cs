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
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dataGridViewTax = new System.Windows.Forms.DataGridView();
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
            button1 = new System.Windows.Forms.Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTax).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(12, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(129, 47);
            label2.TabIndex = 1;
            label2.Text = "Taxes";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.LightGray;
            panel2.Controls.Add(dataGridViewTax);
            panel2.Location = new System.Drawing.Point(12, 87);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(623, 311);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridViewTax
            // 
            dataGridViewTax.AllowUserToResizeColumns = false;
            dataGridViewTax.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewTax.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTax.BackgroundColor = System.Drawing.Color.FromArgb(61, 41, 31);
            dataGridViewTax.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewTax.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTax.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewTax.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTax.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewTax.EnableHeadersVisualStyles = false;
            dataGridViewTax.GridColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewTax.Location = new System.Drawing.Point(0, 0);
            dataGridViewTax.Name = "dataGridViewTax";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewTax.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTax.RowHeadersVisible = false;
            dataGridViewTax.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewTax.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTax.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViewTax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTax.Size = new System.Drawing.Size(623, 311);
            dataGridViewTax.TabIndex = 0;
            // 
            // AddTax
            // 
            AddTax.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            AddTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddTax.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            AddTax.ForeColor = System.Drawing.Color.White;
            AddTax.Location = new System.Drawing.Point(592, 37);
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
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(1259, 28);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(39, 29);
            button1.TabIndex = 8;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = false;
            // 
            // DiscountAndTaxes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            ClientSize = new System.Drawing.Size(1323, 868);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(AddTax);
            Controls.Add(panel2);
            Controls.Add(label2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximumSize = new System.Drawing.Size(1341, 915);
            Name = "DiscountAndTaxes";
            Load += DiscountAndTaxes_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTax).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddTax;
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
        private System.Windows.Forms.Button button1;
    }
}