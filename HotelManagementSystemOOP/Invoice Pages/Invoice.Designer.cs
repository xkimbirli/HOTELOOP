namespace HotelManagementSystemOOP
{
    partial class Invoice
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
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            CheckOut = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            InvoicePanelDisplay = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Discount = new System.Windows.Forms.Label();
            CheckOutDate = new System.Windows.Forms.Label();
            label39 = new System.Windows.Forms.Label();
            label38 = new System.Windows.Forms.Label();
            RoomNumber = new System.Windows.Forms.Label();
            CheckIndate = new System.Windows.Forms.Label();
            RoomType = new System.Windows.Forms.Label();
            BookingID = new System.Windows.Forms.Label();
            GuestKidsNum = new System.Windows.Forms.Label();
            GuestAdultNum = new System.Windows.Forms.Label();
            GuestEmail = new System.Windows.Forms.Label();
            GuestPhoneNumber = new System.Windows.Forms.Label();
            GuestName = new System.Windows.Forms.Label();
            Email = new System.Windows.Forms.Label();
            PhoneNumber = new System.Windows.Forms.Label();
            Address = new System.Windows.Forms.Label();
            CompanyName = new System.Windows.Forms.Label();
            TotalAmount = new System.Windows.Forms.Label();
            ExtraAmount = new System.Windows.Forms.Label();
            PaymentMehod = new System.Windows.Forms.Label();
            PaymentStatus = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            PaymentMet = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            GuestKids = new System.Windows.Forms.Label();
            GuestAdults = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ExitButtonCheckOut = new System.Windows.Forms.Button();
            panel2.SuspendLayout();
            InvoicePanelDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(8, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(171, 44);
            label1.TabIndex = 0;
            label1.Text = "INVOICE";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            panel2.Controls.Add(CheckOut);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(18, 58);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1217, 62);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // CheckOut
            // 
            CheckOut.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            CheckOut.FlatAppearance.BorderSize = 0;
            CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CheckOut.ForeColor = System.Drawing.Color.White;
            CheckOut.Location = new System.Drawing.Point(1048, 17);
            CheckOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            CheckOut.Name = "CheckOut";
            CheckOut.Size = new System.Drawing.Size(154, 29);
            CheckOut.TabIndex = 4;
            CheckOut.Text = "CHECK OUT";
            CheckOut.UseVisualStyleBackColor = false;
            CheckOut.Click += CheckOut_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            button1.Location = new System.Drawing.Point(25, 667);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(97, 29);
            button1.TabIndex = 2;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            // 
            // InvoicePanelDisplay
            // 
            InvoicePanelDisplay.BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            InvoicePanelDisplay.Controls.Add(dataGridView1);
            InvoicePanelDisplay.Controls.Add(Discount);
            InvoicePanelDisplay.Controls.Add(CheckOutDate);
            InvoicePanelDisplay.Controls.Add(label39);
            InvoicePanelDisplay.Controls.Add(label38);
            InvoicePanelDisplay.Controls.Add(RoomNumber);
            InvoicePanelDisplay.Controls.Add(CheckIndate);
            InvoicePanelDisplay.Controls.Add(RoomType);
            InvoicePanelDisplay.Controls.Add(BookingID);
            InvoicePanelDisplay.Controls.Add(GuestKidsNum);
            InvoicePanelDisplay.Controls.Add(GuestAdultNum);
            InvoicePanelDisplay.Controls.Add(GuestEmail);
            InvoicePanelDisplay.Controls.Add(GuestPhoneNumber);
            InvoicePanelDisplay.Controls.Add(GuestName);
            InvoicePanelDisplay.Controls.Add(Email);
            InvoicePanelDisplay.Controls.Add(PhoneNumber);
            InvoicePanelDisplay.Controls.Add(Address);
            InvoicePanelDisplay.Controls.Add(CompanyName);
            InvoicePanelDisplay.Controls.Add(TotalAmount);
            InvoicePanelDisplay.Controls.Add(ExtraAmount);
            InvoicePanelDisplay.Controls.Add(PaymentMehod);
            InvoicePanelDisplay.Controls.Add(PaymentStatus);
            InvoicePanelDisplay.Controls.Add(label26);
            InvoicePanelDisplay.Controls.Add(label25);
            InvoicePanelDisplay.Controls.Add(label24);
            InvoicePanelDisplay.Controls.Add(PaymentMet);
            InvoicePanelDisplay.Controls.Add(label21);
            InvoicePanelDisplay.Controls.Add(GuestKids);
            InvoicePanelDisplay.Controls.Add(GuestAdults);
            InvoicePanelDisplay.Controls.Add(label15);
            InvoicePanelDisplay.Controls.Add(label14);
            InvoicePanelDisplay.Controls.Add(label13);
            InvoicePanelDisplay.Controls.Add(label12);
            InvoicePanelDisplay.Controls.Add(label11);
            InvoicePanelDisplay.Controls.Add(label10);
            InvoicePanelDisplay.Controls.Add(label9);
            InvoicePanelDisplay.Controls.Add(label8);
            InvoicePanelDisplay.Controls.Add(label7);
            InvoicePanelDisplay.Controls.Add(label6);
            InvoicePanelDisplay.Controls.Add(label5);
            InvoicePanelDisplay.Controls.Add(label4);
            InvoicePanelDisplay.Controls.Add(label3);
            InvoicePanelDisplay.Controls.Add(label2);
            InvoicePanelDisplay.Location = new System.Drawing.Point(18, 120);
            InvoicePanelDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            InvoicePanelDisplay.Name = "InvoicePanelDisplay";
            InvoicePanelDisplay.Size = new System.Drawing.Size(1217, 536);
            InvoicePanelDisplay.TabIndex = 1;
            InvoicePanelDisplay.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(207, 185, 163);
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(207, 185, 163);
            dataGridView1.Location = new System.Drawing.Point(570, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(622, 191);
            dataGridView1.TabIndex = 49;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Discount
            // 
            Discount.AutoSize = true;
            Discount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Discount.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            Discount.Location = new System.Drawing.Point(1108, 343);
            Discount.Name = "Discount";
            Discount.Size = new System.Drawing.Size(51, 21);
            Discount.TabIndex = 48;
            Discount.Text = "Total";
            // 
            // CheckOutDate
            // 
            CheckOutDate.AutoSize = true;
            CheckOutDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            CheckOutDate.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            CheckOutDate.Location = new System.Drawing.Point(277, 495);
            CheckOutDate.Name = "CheckOutDate";
            CheckOutDate.Size = new System.Drawing.Size(44, 21);
            CheckOutDate.TabIndex = 47;
            CheckOutDate.Text = "Text";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label39.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label39.Location = new System.Drawing.Point(16, 438);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(128, 21);
            label39.TabIndex = 46;
            label39.Text = "Room Number";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label38.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label38.Location = new System.Drawing.Point(17, 414);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(101, 21);
            label38.TabIndex = 45;
            label38.Text = "Room Type";
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSize = true;
            RoomNumber.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RoomNumber.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            RoomNumber.Location = new System.Drawing.Point(277, 439);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new System.Drawing.Size(44, 21);
            RoomNumber.TabIndex = 44;
            RoomNumber.Text = "Text";
            // 
            // CheckIndate
            // 
            CheckIndate.AutoSize = true;
            CheckIndate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            CheckIndate.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            CheckIndate.Location = new System.Drawing.Point(17, 468);
            CheckIndate.Name = "CheckIndate";
            CheckIndate.Size = new System.Drawing.Size(122, 21);
            CheckIndate.TabIndex = 43;
            CheckIndate.Text = "CheckIndate";
            // 
            // RoomType
            // 
            RoomType.AutoSize = true;
            RoomType.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RoomType.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            RoomType.Location = new System.Drawing.Point(277, 415);
            RoomType.Name = "RoomType";
            RoomType.Size = new System.Drawing.Size(44, 21);
            RoomType.TabIndex = 42;
            RoomType.Text = "Text";
            // 
            // BookingID
            // 
            BookingID.AutoSize = true;
            BookingID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BookingID.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            BookingID.Location = new System.Drawing.Point(277, 390);
            BookingID.Name = "BookingID";
            BookingID.Size = new System.Drawing.Size(44, 21);
            BookingID.TabIndex = 41;
            BookingID.Text = "Text";
            // 
            // GuestKidsNum
            // 
            GuestKidsNum.AutoSize = true;
            GuestKidsNum.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            GuestKidsNum.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            GuestKidsNum.Location = new System.Drawing.Point(277, 325);
            GuestKidsNum.Name = "GuestKidsNum";
            GuestKidsNum.Size = new System.Drawing.Size(44, 21);
            GuestKidsNum.TabIndex = 40;
            GuestKidsNum.Text = "Text";
            // 
            // GuestAdultNum
            // 
            GuestAdultNum.AutoSize = true;
            GuestAdultNum.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            GuestAdultNum.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            GuestAdultNum.Location = new System.Drawing.Point(277, 298);
            GuestAdultNum.Name = "GuestAdultNum";
            GuestAdultNum.Size = new System.Drawing.Size(44, 21);
            GuestAdultNum.TabIndex = 39;
            GuestAdultNum.Text = "Text";
            GuestAdultNum.Click += GuestAdultNum_Click;
            // 
            // GuestEmail
            // 
            GuestEmail.AutoSize = true;
            GuestEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            GuestEmail.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            GuestEmail.Location = new System.Drawing.Point(277, 270);
            GuestEmail.Name = "GuestEmail";
            GuestEmail.Size = new System.Drawing.Size(44, 21);
            GuestEmail.TabIndex = 38;
            GuestEmail.Text = "Text";
            GuestEmail.Click += GuestEmail_Click;
            // 
            // GuestPhoneNumber
            // 
            GuestPhoneNumber.AutoSize = true;
            GuestPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            GuestPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            GuestPhoneNumber.Location = new System.Drawing.Point(277, 241);
            GuestPhoneNumber.Name = "GuestPhoneNumber";
            GuestPhoneNumber.Size = new System.Drawing.Size(44, 21);
            GuestPhoneNumber.TabIndex = 37;
            GuestPhoneNumber.Text = "Text";
            // 
            // GuestName
            // 
            GuestName.AutoSize = true;
            GuestName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            GuestName.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            GuestName.Location = new System.Drawing.Point(277, 215);
            GuestName.Name = "GuestName";
            GuestName.Size = new System.Drawing.Size(44, 21);
            GuestName.TabIndex = 36;
            GuestName.Text = "Text";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Email.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            Email.Location = new System.Drawing.Point(277, 139);
            Email.Name = "Email";
            Email.Size = new System.Drawing.Size(44, 21);
            Email.TabIndex = 35;
            Email.Text = "Text";
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            PhoneNumber.Location = new System.Drawing.Point(277, 112);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new System.Drawing.Size(44, 21);
            PhoneNumber.TabIndex = 34;
            PhoneNumber.Text = "Text";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Address.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            Address.Location = new System.Drawing.Point(277, 84);
            Address.Name = "Address";
            Address.Size = new System.Drawing.Size(44, 21);
            Address.TabIndex = 33;
            Address.Text = "Text";
            // 
            // CompanyName
            // 
            CompanyName.AutoSize = true;
            CompanyName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            CompanyName.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            CompanyName.Location = new System.Drawing.Point(277, 57);
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new System.Drawing.Size(44, 21);
            CompanyName.TabIndex = 32;
            CompanyName.Text = "Text";
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSize = true;
            TotalAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TotalAmount.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            TotalAmount.Location = new System.Drawing.Point(1108, 415);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Size = new System.Drawing.Size(51, 21);
            TotalAmount.TabIndex = 30;
            TotalAmount.Text = "Total";
            // 
            // ExtraAmount
            // 
            ExtraAmount.AutoSize = true;
            ExtraAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ExtraAmount.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            ExtraAmount.Location = new System.Drawing.Point(1108, 378);
            ExtraAmount.Name = "ExtraAmount";
            ExtraAmount.Size = new System.Drawing.Size(51, 21);
            ExtraAmount.TabIndex = 29;
            ExtraAmount.Text = "Total";
            // 
            // PaymentMehod
            // 
            PaymentMehod.AutoSize = true;
            PaymentMehod.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            PaymentMehod.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            PaymentMehod.Location = new System.Drawing.Point(1111, 307);
            PaymentMehod.Name = "PaymentMehod";
            PaymentMehod.Size = new System.Drawing.Size(44, 21);
            PaymentMehod.TabIndex = 28;
            PaymentMehod.Text = "Text";
            // 
            // PaymentStatus
            // 
            PaymentStatus.AutoSize = true;
            PaymentStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            PaymentStatus.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            PaymentStatus.Location = new System.Drawing.Point(1111, 275);
            PaymentStatus.Name = "PaymentStatus";
            PaymentStatus.Size = new System.Drawing.Size(44, 21);
            PaymentStatus.TabIndex = 27;
            PaymentStatus.Text = "Text";
            PaymentStatus.Click += PaymentStatus_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label26.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label26.Location = new System.Drawing.Point(561, 408);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(125, 22);
            label26.TabIndex = 24;
            label26.Text = "Total Amount";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label25.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label25.Location = new System.Drawing.Point(560, 371);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(126, 22);
            label25.TabIndex = 23;
            label25.Text = "Extra Amount";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label24.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label24.Location = new System.Drawing.Point(560, 339);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(86, 22);
            label24.TabIndex = 22;
            label24.Text = "Discount";
            // 
            // PaymentMet
            // 
            PaymentMet.AutoSize = true;
            PaymentMet.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PaymentMet.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            PaymentMet.Location = new System.Drawing.Point(561, 306);
            PaymentMet.Name = "PaymentMet";
            PaymentMet.Size = new System.Drawing.Size(160, 22);
            PaymentMet.TabIndex = 21;
            PaymentMet.Text = "Payment Method";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label21.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label21.Location = new System.Drawing.Point(563, 26);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(61, 22);
            label21.TabIndex = 19;
            label21.Text = "TAXES";
            label21.Click += label21_Click;
            // 
            // GuestKids
            // 
            GuestKids.AutoSize = true;
            GuestKids.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            GuestKids.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            GuestKids.Location = new System.Drawing.Point(17, 326);
            GuestKids.Name = "GuestKids";
            GuestKids.Size = new System.Drawing.Size(42, 21);
            GuestKids.TabIndex = 15;
            GuestKids.Text = "Kids";
            // 
            // GuestAdults
            // 
            GuestAdults.AutoSize = true;
            GuestAdults.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            GuestAdults.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            GuestAdults.Location = new System.Drawing.Point(17, 297);
            GuestAdults.Name = "GuestAdults";
            GuestAdults.Size = new System.Drawing.Size(62, 21);
            GuestAdults.TabIndex = 14;
            GuestAdults.Text = "Adults";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label15.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label15.Location = new System.Drawing.Point(561, 275);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(142, 22);
            label15.TabIndex = 13;
            label15.Text = "Payment Status";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label14.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label14.Location = new System.Drawing.Point(17, 495);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(150, 21);
            label14.TabIndex = 12;
            label14.Text = "Check Out Date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label13.Location = new System.Drawing.Point(277, 467);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(133, 21);
            label13.TabIndex = 11;
            label13.Text = "Check In Date";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label12.Location = new System.Drawing.Point(16, 389);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(98, 21);
            label12.TabIndex = 10;
            label12.Text = "Booking ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label11.Location = new System.Drawing.Point(16, 270);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(52, 21);
            label11.TabIndex = 9;
            label11.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label10.Location = new System.Drawing.Point(15, 241);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(133, 21);
            label10.TabIndex = 8;
            label10.Text = "Phone Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label9.Location = new System.Drawing.Point(15, 215);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(61, 21);
            label9.TabIndex = 7;
            label9.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label8.Location = new System.Drawing.Point(16, 139);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(52, 21);
            label8.TabIndex = 6;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label7.Location = new System.Drawing.Point(16, 112);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(133, 21);
            label7.TabIndex = 5;
            label7.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label6.Location = new System.Drawing.Point(15, 84);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(77, 21);
            label6.TabIndex = 4;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label5.Location = new System.Drawing.Point(16, 57);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(148, 21);
            label5.TabIndex = 3;
            label5.Text = "Company Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label4.Location = new System.Drawing.Point(15, 361);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(124, 22);
            label4.TabIndex = 2;
            label4.Text = "Room Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label3.Location = new System.Drawing.Point(13, 187);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(124, 22);
            label3.TabIndex = 1;
            label3.Text = "Guest Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(61, 41, 31);
            label2.Location = new System.Drawing.Point(16, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 22);
            label2.TabIndex = 0;
            label2.Text = "Hotel Details";
            // 
            // ExitButtonCheckOut
            // 
            ExitButtonCheckOut.BackColor = System.Drawing.Color.Transparent;
            ExitButtonCheckOut.FlatAppearance.BorderSize = 0;
            ExitButtonCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ExitButtonCheckOut.ForeColor = System.Drawing.Color.FromArgb(207, 185, 163);
            ExitButtonCheckOut.Location = new System.Drawing.Point(1179, 13);
            ExitButtonCheckOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ExitButtonCheckOut.Name = "ExitButtonCheckOut";
            ExitButtonCheckOut.Size = new System.Drawing.Size(53, 29);
            ExitButtonCheckOut.TabIndex = 5;
            ExitButtonCheckOut.Text = "x";
            ExitButtonCheckOut.UseVisualStyleBackColor = false;
            ExitButtonCheckOut.Click += ExitButtonCheckOut_Click;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            ClientSize = new System.Drawing.Size(1252, 745);
            ControlBox = false;
            Controls.Add(ExitButtonCheckOut);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(InvoicePanelDisplay);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Invoice";
            Load += Invoice_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            InvoicePanelDisplay.ResumeLayout(false);
            InvoicePanelDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel InvoicePanelDisplay;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.Button ExitButtonCheckOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GuestKids;
        private System.Windows.Forms.Label GuestAdults;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.Label ExtraAmount;
        private System.Windows.Forms.Label PaymentMehod;
        private System.Windows.Forms.Label PaymentStatus;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label PaymentMet;
        private System.Windows.Forms.Label GuestAdultNum;
        private System.Windows.Forms.Label GuestEmail;
        private System.Windows.Forms.Label GuestPhoneNumber;
        private System.Windows.Forms.Label GuestName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label CheckOutDate;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label RoomNumber;
        private System.Windows.Forms.Label CheckIndate;
        private System.Windows.Forms.Label RoomType;
        private System.Windows.Forms.Label BookingID;
        private System.Windows.Forms.Label GuestKidsNum;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
