namespace HotelManagementSystemOOP
{
    partial class GenerateReport
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
            label1 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            FemaleGuestTotal = new System.Windows.Forms.Label();
            MaleGuestTotal = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            AdultsTotal = new System.Windows.Forms.Label();
            KidsTotal = new System.Windows.Forms.Label();
            GuestTotal = new System.Windows.Forms.Label();
            TotalOccupancyRate = new System.Windows.Forms.Label();
            TotalRevenue = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(33, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(200, 51);
            label1.TabIndex = 0;
            label1.Text = "REPORTS";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(148, 118, 95);
            dateTimePicker1.Location = new System.Drawing.Point(322, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(285, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(148, 118, 95);
            dateTimePicker2.Location = new System.Drawing.Point(691, 42);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(285, 27);
            dateTimePicker2.TabIndex = 2;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(148, 118, 95);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(148, 118, 95);
            dataGridView1.Location = new System.Drawing.Point(33, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(943, 305);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(148, 118, 95);
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = System.Drawing.Color.FromArgb(148, 118, 95);
            dataGridView2.Location = new System.Drawing.Point(33, 519);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new System.Drawing.Size(943, 305);
            dataGridView2.TabIndex = 4;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(251, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 22);
            label2.TabIndex = 5;
            label2.Text = "FROM:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(647, 47);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 22);
            label3.TabIndex = 6;
            label3.Text = "TO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(33, 107);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 19);
            label4.TabIndex = 7;
            label4.Text = "GUEST";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(33, 487);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(210, 18);
            label5.TabIndex = 8;
            label5.Text = "Occupancy And Revuenue";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(1003, 152);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(76, 19);
            label6.TabIndex = 9;
            label6.Text = "GENDER";
            // 
            // FemaleGuestTotal
            // 
            FemaleGuestTotal.AutoSize = true;
            FemaleGuestTotal.Location = new System.Drawing.Point(1217, 187);
            FemaleGuestTotal.Name = "FemaleGuestTotal";
            FemaleGuestTotal.Size = new System.Drawing.Size(42, 20);
            FemaleGuestTotal.TabIndex = 10;
            FemaleGuestTotal.Text = "TEXT";
            FemaleGuestTotal.Click += FemaleGuestTotal_Click;
            // 
            // MaleGuestTotal
            // 
            MaleGuestTotal.AutoSize = true;
            MaleGuestTotal.Location = new System.Drawing.Point(1217, 226);
            MaleGuestTotal.Name = "MaleGuestTotal";
            MaleGuestTotal.Size = new System.Drawing.Size(42, 20);
            MaleGuestTotal.TabIndex = 11;
            MaleGuestTotal.Text = "TEXT";
            MaleGuestTotal.Click += MaleGuestTotal_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(1003, 187);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(62, 20);
            label9.TabIndex = 12;
            label9.Text = "FEMALE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(1007, 226);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(47, 20);
            label10.TabIndex = 13;
            label10.Text = "MALE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(1007, 284);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(193, 19);
            label7.TabIndex = 14;
            label7.Text = "Total Number Of Guest";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(1007, 315);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(51, 20);
            label8.TabIndex = 15;
            label8.Text = "Adults";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(1007, 355);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(37, 20);
            label11.TabIndex = 16;
            label11.Text = "Kids";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(1007, 396);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(83, 20);
            label12.TabIndex = 17;
            label12.Text = "Total Guest";
            // 
            // AdultsTotal
            // 
            AdultsTotal.AutoSize = true;
            AdultsTotal.Location = new System.Drawing.Point(1217, 324);
            AdultsTotal.Name = "AdultsTotal";
            AdultsTotal.Size = new System.Drawing.Size(42, 20);
            AdultsTotal.TabIndex = 18;
            AdultsTotal.Text = "TEXT";
            AdultsTotal.Click += AdultsTotal_Click;
            // 
            // KidsTotal
            // 
            KidsTotal.AutoSize = true;
            KidsTotal.Location = new System.Drawing.Point(1217, 367);
            KidsTotal.Name = "KidsTotal";
            KidsTotal.Size = new System.Drawing.Size(42, 20);
            KidsTotal.TabIndex = 19;
            KidsTotal.Text = "TEXT";
            // 
            // GuestTotal
            // 
            GuestTotal.AutoSize = true;
            GuestTotal.Location = new System.Drawing.Point(1217, 406);
            GuestTotal.Name = "GuestTotal";
            GuestTotal.Size = new System.Drawing.Size(42, 20);
            GuestTotal.TabIndex = 20;
            GuestTotal.Text = "TEXT";
            // 
            // TotalOccupancyRate
            // 
            TotalOccupancyRate.AutoSize = true;
            TotalOccupancyRate.Location = new System.Drawing.Point(1007, 614);
            TotalOccupancyRate.Name = "TotalOccupancyRate";
            TotalOccupancyRate.Size = new System.Drawing.Size(144, 20);
            TotalOccupancyRate.TabIndex = 21;
            TotalOccupancyRate.Text = "TotalOccupancyRate";
            TotalOccupancyRate.Click += TotalOccupancyRate_Click;
            // 
            // TotalRevenue
            // 
            TotalRevenue.AutoSize = true;
            TotalRevenue.Location = new System.Drawing.Point(1008, 714);
            TotalRevenue.Name = "TotalRevenue";
            TotalRevenue.Size = new System.Drawing.Size(102, 20);
            TotalRevenue.TabIndex = 22;
            TotalRevenue.Text = "Total Revenue";
            TotalRevenue.Click += TotalRevenue_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label15.Location = new System.Drawing.Point(1007, 579);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(149, 19);
            label15.TabIndex = 23;
            label15.Text = "Occupancy Rate";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label16.Location = new System.Drawing.Point(1008, 671);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(82, 19);
            label16.TabIndex = 24;
            label16.Text = "Revenue";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(1208, 795);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 25;
            button1.Text = "PRINT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(882, 87);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 29);
            button2.TabIndex = 26;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Location = new System.Drawing.Point(1269, 12);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(42, 29);
            button3.TabIndex = 27;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            // 
            // GenerateReport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            ClientSize = new System.Drawing.Size(1323, 868);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(TotalRevenue);
            Controls.Add(TotalOccupancyRate);
            Controls.Add(GuestTotal);
            Controls.Add(KidsTotal);
            Controls.Add(AdultsTotal);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(MaleGuestTotal);
            Controls.Add(FemaleGuestTotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "GenerateReport";
            Text = "GenerateReport";
            Load += GenerateReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FemaleGuestTotal;
        private System.Windows.Forms.Label MaleGuestTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label AdultsTotal;
        private System.Windows.Forms.Label KidsTotal;
        private System.Windows.Forms.Label GuestTotal;
        private System.Windows.Forms.Label TotalOccupancyRate;
        private System.Windows.Forms.Label TotalRevenue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}