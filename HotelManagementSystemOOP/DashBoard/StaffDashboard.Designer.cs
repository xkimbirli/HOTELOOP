namespace HotelManagementSystemOOP
{
    partial class StaffDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            FastReport.DataVisualization.Charting.ChartArea chartArea1 = new FastReport.DataVisualization.Charting.ChartArea();
            FastReport.DataVisualization.Charting.Series series1 = new FastReport.DataVisualization.Charting.Series();
            SearchBarSD = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            NewBooking = new System.Windows.Forms.Label();
            NewBookingTodayNumber = new System.Windows.Forms.Label();
            ArrvingTodayNumber = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            ArrivingToday = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            CurrentlyStaying = new System.Windows.Forms.Label();
            CurrentStaying = new System.Windows.Forms.Label();
            CurrentlyStayingNumber = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            DepartingToday = new System.Windows.Forms.Label();
            DepartingTodayNumber = new System.Windows.Forms.Label();
            ArrvingListPanelSD = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            TodaysArrivingLabel = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            HotelInfoPanel = new System.Windows.Forms.Panel();
            HotelInfoViewbuttonDB = new System.Windows.Forms.Button();
            HotelNameLabel = new System.Windows.Forms.Label();
            MenuRoomButtonSD = new System.Windows.Forms.Button();
            MenuBookingButtonSD = new System.Windows.Forms.Button();
            MenuDashboardButtonSD = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            chart1 = new FastReport.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ArrvingListPanelSD.SuspendLayout();
            panel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            HotelInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // SearchBarSD
            // 
            SearchBarSD.AcceptsReturn = true;
            SearchBarSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            SearchBarSD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SearchBarSD.Location = new System.Drawing.Point(530, 36);
            SearchBarSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SearchBarSD.MaximumSize = new System.Drawing.Size(500, 35);
            SearchBarSD.MinimumSize = new System.Drawing.Size(2, 35);
            SearchBarSD.Name = "SearchBarSD";
            SearchBarSD.PlaceholderText = "search..";
            SearchBarSD.Size = new System.Drawing.Size(418, 35);
            SearchBarSD.TabIndex = 1;
            SearchBarSD.TextChanged += SearchBarSD_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(NewBooking);
            panel1.Controls.Add(NewBookingTodayNumber);
            panel1.Location = new System.Drawing.Point(19, 100);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(221, 100);
            panel1.TabIndex = 2;
            // 
            // NewBooking
            // 
            NewBooking.AutoSize = true;
            NewBooking.BackColor = System.Drawing.Color.Transparent;
            NewBooking.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            NewBooking.ForeColor = System.Drawing.Color.White;
            NewBooking.Location = new System.Drawing.Point(45, 59);
            NewBooking.Name = "NewBooking";
            NewBooking.Size = new System.Drawing.Size(118, 21);
            NewBooking.TabIndex = 2;
            NewBooking.Text = "New Booking";
            // 
            // NewBookingTodayNumber
            // 
            NewBookingTodayNumber.AutoSize = true;
            NewBookingTodayNumber.BackColor = System.Drawing.Color.Transparent;
            NewBookingTodayNumber.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            NewBookingTodayNumber.ForeColor = System.Drawing.Color.White;
            NewBookingTodayNumber.Location = new System.Drawing.Point(86, 22);
            NewBookingTodayNumber.Name = "NewBookingTodayNumber";
            NewBookingTodayNumber.Size = new System.Drawing.Size(26, 27);
            NewBookingTodayNumber.TabIndex = 1;
            NewBookingTodayNumber.Text = "#";
            NewBookingTodayNumber.Click += label1_Click_1;
            // 
            // ArrvingTodayNumber
            // 
            ArrvingTodayNumber.AutoSize = true;
            ArrvingTodayNumber.BackColor = System.Drawing.Color.Transparent;
            ArrvingTodayNumber.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ArrvingTodayNumber.ForeColor = System.Drawing.Color.White;
            ArrvingTodayNumber.Location = new System.Drawing.Point(101, 21);
            ArrvingTodayNumber.Name = "ArrvingTodayNumber";
            ArrvingTodayNumber.Size = new System.Drawing.Size(26, 27);
            ArrvingTodayNumber.TabIndex = 0;
            ArrvingTodayNumber.Text = "#";
            ArrvingTodayNumber.Click += NewBookingNumber_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel2.Controls.Add(ArrivingToday);
            panel2.Controls.Add(ArrvingTodayNumber);
            panel2.Location = new System.Drawing.Point(255, 101);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(224, 100);
            panel2.TabIndex = 3;
            // 
            // ArrivingToday
            // 
            ArrivingToday.AutoSize = true;
            ArrivingToday.BackColor = System.Drawing.Color.Transparent;
            ArrivingToday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ArrivingToday.ForeColor = System.Drawing.Color.White;
            ArrivingToday.Location = new System.Drawing.Point(49, 60);
            ArrivingToday.Name = "ArrivingToday";
            ArrivingToday.Size = new System.Drawing.Size(127, 21);
            ArrivingToday.TabIndex = 3;
            ArrivingToday.Text = "Arriving Today";
            ArrivingToday.Click += label5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel3.Controls.Add(CurrentlyStaying);
            panel3.Controls.Add(CurrentStaying);
            panel3.Controls.Add(CurrentlyStayingNumber);
            panel3.Location = new System.Drawing.Point(494, 101);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(224, 100);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint_1;
            // 
            // CurrentlyStaying
            // 
            CurrentlyStaying.AutoSize = true;
            CurrentlyStaying.BackColor = System.Drawing.Color.Transparent;
            CurrentlyStaying.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            CurrentlyStaying.ForeColor = System.Drawing.Color.White;
            CurrentlyStaying.Location = new System.Drawing.Point(42, 62);
            CurrentlyStaying.Name = "CurrentlyStaying";
            CurrentlyStaying.Size = new System.Drawing.Size(136, 21);
            CurrentlyStaying.TabIndex = 3;
            CurrentlyStaying.Text = "Current Staying";
            // 
            // CurrentStaying
            // 
            CurrentStaying.AutoSize = true;
            CurrentStaying.BackColor = System.Drawing.Color.Transparent;
            CurrentStaying.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            CurrentStaying.ForeColor = System.Drawing.Color.White;
            CurrentStaying.Location = new System.Drawing.Point(101, 21);
            CurrentStaying.Name = "CurrentStaying";
            CurrentStaying.Size = new System.Drawing.Size(26, 27);
            CurrentStaying.TabIndex = 1;
            CurrentStaying.Text = "#";
            CurrentStaying.Click += CurrentStaying_Click;
            // 
            // CurrentlyStayingNumber
            // 
            CurrentlyStayingNumber.AutoSize = true;
            CurrentlyStayingNumber.BackColor = System.Drawing.Color.Transparent;
            CurrentlyStayingNumber.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            CurrentlyStayingNumber.ForeColor = System.Drawing.Color.Magenta;
            CurrentlyStayingNumber.Location = new System.Drawing.Point(66, 21);
            CurrentlyStayingNumber.Name = "CurrentlyStayingNumber";
            CurrentlyStayingNumber.Size = new System.Drawing.Size(18, 27);
            CurrentlyStayingNumber.TabIndex = 1;
            CurrentlyStayingNumber.Text = " ";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel4.Controls.Add(DepartingToday);
            panel4.Controls.Add(DepartingTodayNumber);
            panel4.Location = new System.Drawing.Point(731, 101);
            panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(224, 100);
            panel4.TabIndex = 5;
            // 
            // DepartingToday
            // 
            DepartingToday.AutoSize = true;
            DepartingToday.BackColor = System.Drawing.Color.Transparent;
            DepartingToday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DepartingToday.ForeColor = System.Drawing.Color.White;
            DepartingToday.Location = new System.Drawing.Point(44, 60);
            DepartingToday.Name = "DepartingToday";
            DepartingToday.Size = new System.Drawing.Size(150, 21);
            DepartingToday.TabIndex = 3;
            DepartingToday.Text = "Departing Today";
            // 
            // DepartingTodayNumber
            // 
            DepartingTodayNumber.AutoSize = true;
            DepartingTodayNumber.BackColor = System.Drawing.Color.Transparent;
            DepartingTodayNumber.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            DepartingTodayNumber.ForeColor = System.Drawing.Color.White;
            DepartingTodayNumber.Location = new System.Drawing.Point(100, 21);
            DepartingTodayNumber.Name = "DepartingTodayNumber";
            DepartingTodayNumber.Size = new System.Drawing.Size(26, 27);
            DepartingTodayNumber.TabIndex = 1;
            DepartingTodayNumber.Text = "#";
            DepartingTodayNumber.Click += DepartingTodayNumber_Click;
            // 
            // ArrvingListPanelSD
            // 
            ArrvingListPanelSD.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            ArrvingListPanelSD.Controls.Add(panel5);
            ArrvingListPanelSD.Controls.Add(flowLayoutPanel1);
            ArrvingListPanelSD.Location = new System.Drawing.Point(16, 221);
            ArrvingListPanelSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ArrvingListPanelSD.Name = "ArrvingListPanelSD";
            ArrvingListPanelSD.Size = new System.Drawing.Size(939, 596);
            ArrvingListPanelSD.TabIndex = 6;
            ArrvingListPanelSD.Paint += BookingListPanelSD_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Gainsboro;
            panel5.Controls.Add(TodaysArrivingLabel);
            panel5.Location = new System.Drawing.Point(6, 4);
            panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(930, 75);
            panel5.TabIndex = 1;
            panel5.Paint += panel5_Paint;
            // 
            // TodaysArrivingLabel
            // 
            TodaysArrivingLabel.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            TodaysArrivingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            TodaysArrivingLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            TodaysArrivingLabel.ForeColor = System.Drawing.Color.White;
            TodaysArrivingLabel.Location = new System.Drawing.Point(0, 0);
            TodaysArrivingLabel.Name = "TodaysArrivingLabel";
            TodaysArrivingLabel.Size = new System.Drawing.Size(930, 75);
            TodaysArrivingLabel.TabIndex = 0;
            TodaysArrivingLabel.Text = "Todays Arrival:";
            TodaysArrivingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            TodaysArrivingLabel.Click += TodaysArrivingLabel_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 81);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(929, 498);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(207, 185, 163);
            dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(207, 185, 163);
            dataGridView1.Location = new System.Drawing.Point(3, 4);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 70;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(926, 492);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // HotelInfoPanel
            // 
            HotelInfoPanel.Controls.Add(HotelInfoViewbuttonDB);
            HotelInfoPanel.Controls.Add(HotelNameLabel);
            HotelInfoPanel.Location = new System.Drawing.Point(961, 21);
            HotelInfoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            HotelInfoPanel.Name = "HotelInfoPanel";
            HotelInfoPanel.Size = new System.Drawing.Size(361, 80);
            HotelInfoPanel.TabIndex = 7;
            // 
            // HotelInfoViewbuttonDB
            // 
            HotelInfoViewbuttonDB.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            HotelInfoViewbuttonDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            HotelInfoViewbuttonDB.FlatAppearance.BorderSize = 0;
            HotelInfoViewbuttonDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            HotelInfoViewbuttonDB.ForeColor = System.Drawing.Color.Azure;
            HotelInfoViewbuttonDB.Location = new System.Drawing.Point(281, 25);
            HotelInfoViewbuttonDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            HotelInfoViewbuttonDB.Name = "HotelInfoViewbuttonDB";
            HotelInfoViewbuttonDB.Size = new System.Drawing.Size(70, 35);
            HotelInfoViewbuttonDB.TabIndex = 10;
            HotelInfoViewbuttonDB.UseVisualStyleBackColor = false;
            HotelInfoViewbuttonDB.Click += HotelInfoViewbuttonDB_Click;
            // 
            // HotelNameLabel
            // 
            HotelNameLabel.AutoSize = true;
            HotelNameLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            HotelNameLabel.ForeColor = System.Drawing.Color.White;
            HotelNameLabel.Location = new System.Drawing.Point(18, 23);
            HotelNameLabel.Name = "HotelNameLabel";
            HotelNameLabel.Size = new System.Drawing.Size(248, 37);
            HotelNameLabel.TabIndex = 9;
            HotelNameLabel.Text = "VISTA HERMOSA";
            HotelNameLabel.Click += HotelNameLabel_Click;
            // 
            // MenuRoomButtonSD
            // 
            MenuRoomButtonSD.BackColor = System.Drawing.Color.Black;
            MenuRoomButtonSD.BackgroundImage = (System.Drawing.Image)resources.GetObject("MenuRoomButtonSD.BackgroundImage");
            MenuRoomButtonSD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            MenuRoomButtonSD.FlatAppearance.BorderSize = 0;
            MenuRoomButtonSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MenuRoomButtonSD.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuRoomButtonSD.ForeColor = System.Drawing.Color.White;
            MenuRoomButtonSD.Location = new System.Drawing.Point(237, 35);
            MenuRoomButtonSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuRoomButtonSD.Name = "MenuRoomButtonSD";
            MenuRoomButtonSD.Size = new System.Drawing.Size(102, 34);
            MenuRoomButtonSD.TabIndex = 2;
            MenuRoomButtonSD.UseVisualStyleBackColor = false;
            MenuRoomButtonSD.Click += MenuRoomButtonSD_Click;
            // 
            // MenuBookingButtonSD
            // 
            MenuBookingButtonSD.BackColor = System.Drawing.Color.Black;
            MenuBookingButtonSD.BackgroundImage = (System.Drawing.Image)resources.GetObject("MenuBookingButtonSD.BackgroundImage");
            MenuBookingButtonSD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            MenuBookingButtonSD.FlatAppearance.BorderSize = 0;
            MenuBookingButtonSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MenuBookingButtonSD.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuBookingButtonSD.ForeColor = System.Drawing.Color.White;
            MenuBookingButtonSD.Location = new System.Drawing.Point(129, 33);
            MenuBookingButtonSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuBookingButtonSD.Name = "MenuBookingButtonSD";
            MenuBookingButtonSD.Size = new System.Drawing.Size(100, 36);
            MenuBookingButtonSD.TabIndex = 1;
            MenuBookingButtonSD.UseVisualStyleBackColor = false;
            MenuBookingButtonSD.Click += MenuBookingButtonSD_Click;
            // 
            // MenuDashboardButtonSD
            // 
            MenuDashboardButtonSD.BackColor = System.Drawing.Color.DimGray;
            MenuDashboardButtonSD.BackgroundImage = (System.Drawing.Image)resources.GetObject("MenuDashboardButtonSD.BackgroundImage");
            MenuDashboardButtonSD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            MenuDashboardButtonSD.FlatAppearance.BorderSize = 0;
            MenuDashboardButtonSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MenuDashboardButtonSD.Location = new System.Drawing.Point(19, 34);
            MenuDashboardButtonSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuDashboardButtonSD.Name = "MenuDashboardButtonSD";
            MenuDashboardButtonSD.Size = new System.Drawing.Size(103, 33);
            MenuDashboardButtonSD.TabIndex = 0;
            MenuDashboardButtonSD.UseVisualStyleBackColor = false;
            MenuDashboardButtonSD.Click += MenuDashboardButtonSD_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(1238, 785);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(73, 32);
            button1.TabIndex = 8;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            chart1.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 95F;
            chartArea1.InnerPlotPosition.Width = 89.23778F;
            chartArea1.InnerPlotPosition.X = 5.38110828F;
            chartArea1.InnerPlotPosition.Y = 2.50000048F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 45.5F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new System.Drawing.Point(990, 135);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = FastReport.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieStartAngle=7";
            series1.MarkerSize = 14;
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new System.Drawing.Size(321, 630);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            ClientSize = new System.Drawing.Size(1323, 868);
            Controls.Add(chart1);
            Controls.Add(button1);
            Controls.Add(MenuRoomButtonSD);
            Controls.Add(MenuBookingButtonSD);
            Controls.Add(MenuDashboardButtonSD);
            Controls.Add(HotelInfoPanel);
            Controls.Add(ArrvingListPanelSD);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(SearchBarSD);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximumSize = new System.Drawing.Size(1341, 915);
            MinimumSize = new System.Drawing.Size(1341, 915);
            Name = "StaffDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += StaffDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ArrvingListPanelSD.ResumeLayout(false);
            panel5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            HotelInfoPanel.ResumeLayout(false);
            HotelInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox SearchBarSD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel ArrvingListPanelSD;
        private System.Windows.Forms.Panel HotelInfoPanel;
        private System.Windows.Forms.Label NewBooking;
        private System.Windows.Forms.Label ArrvingTodayNumber;
        private System.Windows.Forms.Label ArrivingToday;
        private System.Windows.Forms.Label NewBookingTodayNumber;
        private System.Windows.Forms.Label CurrentlyStayingNumber;
        private System.Windows.Forms.Label DepartingTodayNumber;
        private System.Windows.Forms.Label CurrentlyStaying;
        private System.Windows.Forms.Label DepartingToday;
        private System.Windows.Forms.Label HotelNameLabel;
        private System.Windows.Forms.Button MenuRoomButtonSD;
        private System.Windows.Forms.Button MenuBookingButtonSD;
        private System.Windows.Forms.Button MenuDashboardButtonSD;
        private System.Windows.Forms.Label TodaysArrivingLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button HotelInfoViewbuttonDB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CurrentStaying;
        private FastReport.DataVisualization.Charting.Chart chart1;
    }
}
