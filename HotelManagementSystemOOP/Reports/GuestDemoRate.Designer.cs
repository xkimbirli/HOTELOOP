namespace HotelManagementSystemOOP
{
    partial class GuestDemoRate
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
            label3 = new System.Windows.Forms.Label();
            ExitGuestDemo = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            PrintOccupancyReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(12, 17);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(216, 23);
            label3.TabIndex = 8;
            label3.Text = "Guest Demographics";
            // 
            // ExitGuestDemo
            // 
            ExitGuestDemo.BackColor = System.Drawing.Color.White;
            ExitGuestDemo.Location = new System.Drawing.Point(715, 8);
            ExitGuestDemo.Name = "ExitGuestDemo";
            ExitGuestDemo.Size = new System.Drawing.Size(38, 29);
            ExitGuestDemo.TabIndex = 9;
            ExitGuestDemo.Text = "x";
            ExitGuestDemo.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(64, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(386, 57);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            dateTimePicker2.TabIndex = 11;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 62);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 20);
            label1.TabIndex = 12;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(352, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 20);
            label2.TabIndex = 13;
            label2.Text = "To:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(14, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(739, 410);
            dataGridView1.TabIndex = 14;
            // 
            // PrintOccupancyReport
            // 
            PrintOccupancyReport.Location = new System.Drawing.Point(659, 519);
            PrintOccupancyReport.Name = "PrintOccupancyReport";
            PrintOccupancyReport.Size = new System.Drawing.Size(94, 29);
            PrintOccupancyReport.TabIndex = 15;
            PrintOccupancyReport.Text = "Print";
            PrintOccupancyReport.UseVisualStyleBackColor = true;
            // 
            // GuestDemoRate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(765, 560);
            Controls.Add(PrintOccupancyReport);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(ExitGuestDemo);
            Controls.Add(label3);
            Name = "GuestDemoRate";
            Text = "GuestDemoRate";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExitGuestDemo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PrintOccupancyReport;
    }
}