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
            label3 = new System.Windows.Forms.Label();
            PaymentMethodDDP = new System.Windows.Forms.ComboBox();
            SavePayment = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            HotelNameP = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            CheckInDate = new System.Windows.Forms.Label();
            CheckOutDate = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            StayDuration = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            NumOfGuest = new System.Windows.Forms.Label();
            FloorNumber = new System.Windows.Forms.Label();
            RoomType = new System.Windows.Forms.Label();
            RoomNumber = new System.Windows.Forms.Label();
            CheckOutTime = new System.Windows.Forms.Label();
            CheckInTime = new System.Windows.Forms.Label();
            TotalRoomRate = new System.Windows.Forms.Label();
            RoomRate = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ExitPayment
            // 
            ExitPayment.BackColor = System.Drawing.Color.Transparent;
            ExitPayment.FlatAppearance.BorderSize = 0;
            ExitPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ExitPayment.ForeColor = System.Drawing.Color.White;
            ExitPayment.Location = new System.Drawing.Point(1093, 21);
            ExitPayment.Name = "ExitPayment";
            ExitPayment.Size = new System.Drawing.Size(41, 34);
            ExitPayment.TabIndex = 0;
            ExitPayment.Text = "x";
            ExitPayment.UseVisualStyleBackColor = false;
            ExitPayment.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(25, 171);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(180, 23);
            label3.TabIndex = 3;
            label3.Text = "Payment Method";
            // 
            // PaymentMethodDDP
            // 
            PaymentMethodDDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            PaymentMethodDDP.FormattingEnabled = true;
            PaymentMethodDDP.Location = new System.Drawing.Point(239, 171);
            PaymentMethodDDP.Name = "PaymentMethodDDP";
            PaymentMethodDDP.Size = new System.Drawing.Size(262, 28);
            PaymentMethodDDP.TabIndex = 7;
            PaymentMethodDDP.SelectedIndexChanged += PaymentMethodDDP_SelectedIndexChanged;
            // 
            // SavePayment
            // 
            SavePayment.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            SavePayment.FlatAppearance.BorderSize = 0;
            SavePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SavePayment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SavePayment.ForeColor = System.Drawing.Color.White;
            SavePayment.Location = new System.Drawing.Point(425, 222);
            SavePayment.Name = "SavePayment";
            SavePayment.Size = new System.Drawing.Size(76, 29);
            SavePayment.TabIndex = 9;
            SavePayment.Text = "PAID";
            SavePayment.UseVisualStyleBackColor = false;
            SavePayment.Click += SavePayment_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(HotelNameP);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(22, 76);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(548, 349);
            panel2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(17, 116);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 20);
            label5.TabIndex = 1;
            label5.Text = "label5";
            // 
            // HotelNameP
            // 
            HotelNameP.AutoSize = true;
            HotelNameP.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            HotelNameP.ForeColor = System.Drawing.Color.White;
            HotelNameP.Location = new System.Drawing.Point(224, 21);
            HotelNameP.Name = "HotelNameP";
            HotelNameP.Size = new System.Drawing.Size(140, 27);
            HotelNameP.TabIndex = 2;
            HotelNameP.Text = "HotelName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(17, 70);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(259, 27);
            label1.TabIndex = 0;
            label1.Text = "CANCELATION POLICY";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(22, 21);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(142, 34);
            label7.TabIndex = 13;
            label7.Text = "PAYMENT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(179, 19);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(144, 22);
            label6.TabIndex = 0;
            label6.Text = "Booking Details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(35, 72);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(152, 23);
            label8.TabIndex = 5;
            label8.Text = "Check In Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(35, 133);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(171, 23);
            label9.TabIndex = 6;
            label9.Text = "Check Out Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(35, 191);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(140, 23);
            label10.TabIndex = 7;
            label10.Text = "Stay Duration";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(35, 257);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(146, 23);
            label11.TabIndex = 8;
            label11.Text = "Check In Time";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.White;
            label12.Location = new System.Drawing.Point(35, 314);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(165, 23);
            label12.TabIndex = 9;
            label12.Text = "Check Out Time";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.Color.White;
            label13.Location = new System.Drawing.Point(35, 367);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(119, 23);
            label13.TabIndex = 10;
            label13.Text = "Room Type";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label14.ForeColor = System.Drawing.Color.White;
            label14.Location = new System.Drawing.Point(35, 433);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(152, 23);
            label14.TabIndex = 11;
            label14.Text = "Room Number";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label15.ForeColor = System.Drawing.Color.White;
            label15.Location = new System.Drawing.Point(25, 96);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(172, 23);
            label15.TabIndex = 12;
            label15.Text = "Total Room Rate";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label16.ForeColor = System.Drawing.Color.White;
            label16.Location = new System.Drawing.Point(23, 40);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(119, 23);
            label16.TabIndex = 13;
            label16.Text = "Room Rate";
            // 
            // CheckInDate
            // 
            CheckInDate.AutoSize = true;
            CheckInDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            CheckInDate.ForeColor = System.Drawing.Color.White;
            CheckInDate.Location = new System.Drawing.Point(332, 71);
            CheckInDate.Name = "CheckInDate";
            CheckInDate.Size = new System.Drawing.Size(49, 23);
            CheckInDate.TabIndex = 14;
            CheckInDate.Text = "TEXT";
            // 
            // CheckOutDate
            // 
            CheckOutDate.AutoSize = true;
            CheckOutDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            CheckOutDate.ForeColor = System.Drawing.Color.White;
            CheckOutDate.Location = new System.Drawing.Point(332, 133);
            CheckOutDate.Name = "CheckOutDate";
            CheckOutDate.Size = new System.Drawing.Size(49, 23);
            CheckOutDate.TabIndex = 15;
            CheckOutDate.Text = "TEXT";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label18.ForeColor = System.Drawing.Color.White;
            label18.Location = new System.Drawing.Point(35, 495);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(142, 23);
            label18.TabIndex = 16;
            label18.Text = "Floor Number";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label19.ForeColor = System.Drawing.Color.White;
            label19.Location = new System.Drawing.Point(35, 553);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(181, 23);
            label19.TabIndex = 17;
            label19.Text = "Number Of Guest";
            // 
            // StayDuration
            // 
            StayDuration.AutoSize = true;
            StayDuration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            StayDuration.ForeColor = System.Drawing.Color.White;
            StayDuration.Location = new System.Drawing.Point(332, 202);
            StayDuration.Name = "StayDuration";
            StayDuration.Size = new System.Drawing.Size(49, 23);
            StayDuration.TabIndex = 18;
            StayDuration.Text = "TEXT";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            panel1.Controls.Add(NumOfGuest);
            panel1.Controls.Add(FloorNumber);
            panel1.Controls.Add(RoomType);
            panel1.Controls.Add(RoomNumber);
            panel1.Controls.Add(CheckOutTime);
            panel1.Controls.Add(CheckInTime);
            panel1.Controls.Add(StayDuration);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(CheckOutDate);
            panel1.Controls.Add(CheckInDate);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Location = new System.Drawing.Point(594, 78);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(540, 654);
            panel1.TabIndex = 10;
            // 
            // NumOfGuest
            // 
            NumOfGuest.AutoSize = true;
            NumOfGuest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            NumOfGuest.ForeColor = System.Drawing.Color.White;
            NumOfGuest.Location = new System.Drawing.Point(332, 553);
            NumOfGuest.Name = "NumOfGuest";
            NumOfGuest.Size = new System.Drawing.Size(49, 23);
            NumOfGuest.TabIndex = 24;
            NumOfGuest.Text = "TEXT";
            // 
            // FloorNumber
            // 
            FloorNumber.AutoSize = true;
            FloorNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FloorNumber.ForeColor = System.Drawing.Color.White;
            FloorNumber.Location = new System.Drawing.Point(332, 495);
            FloorNumber.Name = "FloorNumber";
            FloorNumber.Size = new System.Drawing.Size(49, 23);
            FloorNumber.TabIndex = 23;
            FloorNumber.Text = "TEXT";
            // 
            // RoomType
            // 
            RoomType.AutoSize = true;
            RoomType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RoomType.ForeColor = System.Drawing.Color.White;
            RoomType.Location = new System.Drawing.Point(332, 377);
            RoomType.Name = "RoomType";
            RoomType.Size = new System.Drawing.Size(49, 23);
            RoomType.TabIndex = 22;
            RoomType.Text = "TEXT";
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSize = true;
            RoomNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RoomNumber.ForeColor = System.Drawing.Color.White;
            RoomNumber.Location = new System.Drawing.Point(332, 433);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new System.Drawing.Size(49, 23);
            RoomNumber.TabIndex = 21;
            RoomNumber.Text = "TEXT";
            // 
            // CheckOutTime
            // 
            CheckOutTime.AutoSize = true;
            CheckOutTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            CheckOutTime.ForeColor = System.Drawing.Color.White;
            CheckOutTime.Location = new System.Drawing.Point(332, 314);
            CheckOutTime.Name = "CheckOutTime";
            CheckOutTime.Size = new System.Drawing.Size(49, 23);
            CheckOutTime.TabIndex = 20;
            CheckOutTime.Text = "TEXT";
            // 
            // CheckInTime
            // 
            CheckInTime.AutoSize = true;
            CheckInTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            CheckInTime.ForeColor = System.Drawing.Color.White;
            CheckInTime.Location = new System.Drawing.Point(332, 257);
            CheckInTime.Name = "CheckInTime";
            CheckInTime.Size = new System.Drawing.Size(49, 23);
            CheckInTime.TabIndex = 19;
            CheckInTime.Text = "TEXT";
            // 
            // TotalRoomRate
            // 
            TotalRoomRate.AutoSize = true;
            TotalRoomRate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TotalRoomRate.ForeColor = System.Drawing.Color.White;
            TotalRoomRate.Location = new System.Drawing.Point(353, 96);
            TotalRoomRate.Name = "TotalRoomRate";
            TotalRoomRate.Size = new System.Drawing.Size(49, 23);
            TotalRoomRate.TabIndex = 26;
            TotalRoomRate.Text = "TEXT";
            // 
            // RoomRate
            // 
            RoomRate.AutoSize = true;
            RoomRate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RoomRate.ForeColor = System.Drawing.Color.White;
            RoomRate.Location = new System.Drawing.Point(353, 40);
            RoomRate.Name = "RoomRate";
            RoomRate.Size = new System.Drawing.Size(49, 23);
            RoomRate.TabIndex = 25;
            RoomRate.Text = "TEXT";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            panel3.Controls.Add(TotalRoomRate);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(RoomRate);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(SavePayment);
            panel3.Controls.Add(PaymentMethodDDP);
            panel3.Controls.Add(label15);
            panel3.Location = new System.Drawing.Point(22, 455);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(548, 277);
            panel3.TabIndex = 12;
            panel3.Paint += panel3_Paint;
            // 
            // Payment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            ClientSize = new System.Drawing.Size(1162, 791);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ExitPayment);
            ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "Payment";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += Payment_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ExitPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PaymentMethodDDP;
        private System.Windows.Forms.Button SavePayment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label CheckInDate;
        private System.Windows.Forms.Label CheckOutDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label StayDuration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalRoomRate;
        private System.Windows.Forms.Label RoomRate;
        private System.Windows.Forms.Label NumOfGuest;
        private System.Windows.Forms.Label FloorNumber;
        private System.Windows.Forms.Label RoomType;
        private System.Windows.Forms.Label RoomNumber;
        private System.Windows.Forms.Label CheckOutTime;
        private System.Windows.Forms.Label CheckInTime;
        private System.Windows.Forms.Label HotelNameP;
        private System.Windows.Forms.Panel panel3;
    }
}