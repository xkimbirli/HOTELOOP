namespace HotelManagementSystemOOP
{
    partial class RevenueRate
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
            PrintOccupancyReport = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ExitOccupancyRate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PrintOccupancyReport
            // 
            PrintOccupancyReport.Location = new System.Drawing.Point(659, 519);
            PrintOccupancyReport.Name = "PrintOccupancyReport";
            PrintOccupancyReport.Size = new System.Drawing.Size(94, 29);
            PrintOccupancyReport.TabIndex = 6;
            PrintOccupancyReport.Text = "Print";
            PrintOccupancyReport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(739, 410);
            dataGridView1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(12, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(146, 23);
            label3.TabIndex = 10;
            label3.Text = "Revenue Rate";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(62, 55);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(396, 57);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            dateTimePicker2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 20);
            label1.TabIndex = 13;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(362, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 20);
            label2.TabIndex = 14;
            label2.Text = "To:";
            label2.Click += label2_Click;
            // 
            // ExitOccupancyRate
            // 
            ExitOccupancyRate.Location = new System.Drawing.Point(713, 18);
            ExitOccupancyRate.Name = "ExitOccupancyRate";
            ExitOccupancyRate.Size = new System.Drawing.Size(38, 29);
            ExitOccupancyRate.TabIndex = 15;
            ExitOccupancyRate.Text = "x";
            ExitOccupancyRate.UseVisualStyleBackColor = true;
            // 
            // RevenueRate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(765, 560);
            ControlBox = false;
            Controls.Add(ExitOccupancyRate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(PrintOccupancyReport);
            Name = "RevenueRate";
            Text = "RevenueRate";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button PrintOccupancyReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitOccupancyRate;
    }
}