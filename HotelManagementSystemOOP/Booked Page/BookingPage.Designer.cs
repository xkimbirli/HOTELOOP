namespace HotelManagementSystemOOP
{
    partial class BookingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingPage));
            SearchBarBP = new System.Windows.Forms.TextBox();
            DisplayPanelBP = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            DeluxeRoomTabBP = new System.Windows.Forms.Button();
            StandardRoomTabBP = new System.Windows.Forms.Button();
            AllRoomsTabBP = new System.Windows.Forms.Button();
            SuiteRoomBP = new System.Windows.Forms.Button();
            AddBookingbuttonBP = new System.Windows.Forms.Button();
            fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            MenuRoomButtonBP = new System.Windows.Forms.Button();
            MenuBookingButtonBP = new System.Windows.Forms.Button();
            MenuDashboardButtonBP = new System.Windows.Forms.Button();
            MenuRoomInfoButtonBP = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // SearchBarBP
            // 
            SearchBarBP.AcceptsReturn = true;
            SearchBarBP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            SearchBarBP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SearchBarBP.Location = new System.Drawing.Point(571, 28);
            SearchBarBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SearchBarBP.MaximumSize = new System.Drawing.Size(500, 35);
            SearchBarBP.MinimumSize = new System.Drawing.Size(2, 35);
            SearchBarBP.Name = "SearchBarBP";
            SearchBarBP.Size = new System.Drawing.Size(406, 35);
            SearchBarBP.TabIndex = 2;
            SearchBarBP.Text = "search..";
            // 
            // DisplayPanelBP
            // 
            DisplayPanelBP.BackColor = System.Drawing.Color.Gainsboro;
            DisplayPanelBP.Location = new System.Drawing.Point(21, 217);
            DisplayPanelBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DisplayPanelBP.Name = "DisplayPanelBP";
            DisplayPanelBP.Size = new System.Drawing.Size(1276, 588);
            DisplayPanelBP.TabIndex = 3;
            DisplayPanelBP.Paint += DisplayPanelBP_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.Black;
            panel3.Controls.Add(DeluxeRoomTabBP);
            panel3.Controls.Add(StandardRoomTabBP);
            panel3.Controls.Add(AllRoomsTabBP);
            panel3.Controls.Add(SuiteRoomBP);
            panel3.Location = new System.Drawing.Point(18, 159);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1279, 65);
            panel3.TabIndex = 1;
            // 
            // DeluxeRoomTabBP
            // 
            DeluxeRoomTabBP.BackColor = System.Drawing.Color.Black;
            DeluxeRoomTabBP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            DeluxeRoomTabBP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            DeluxeRoomTabBP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            DeluxeRoomTabBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DeluxeRoomTabBP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DeluxeRoomTabBP.ForeColor = System.Drawing.Color.White;
            DeluxeRoomTabBP.Location = new System.Drawing.Point(722, 5);
            DeluxeRoomTabBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DeluxeRoomTabBP.Name = "DeluxeRoomTabBP";
            DeluxeRoomTabBP.Size = new System.Drawing.Size(187, 54);
            DeluxeRoomTabBP.TabIndex = 5;
            DeluxeRoomTabBP.Text = "DELUXE";
            DeluxeRoomTabBP.UseVisualStyleBackColor = false;
            DeluxeRoomTabBP.Click += DeluxeRoomTabRC_Click;
            // 
            // StandardRoomTabBP
            // 
            StandardRoomTabBP.BackColor = System.Drawing.Color.Black;
            StandardRoomTabBP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            StandardRoomTabBP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            StandardRoomTabBP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            StandardRoomTabBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StandardRoomTabBP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            StandardRoomTabBP.ForeColor = System.Drawing.Color.White;
            StandardRoomTabBP.Location = new System.Drawing.Point(379, 7);
            StandardRoomTabBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            StandardRoomTabBP.Name = "StandardRoomTabBP";
            StandardRoomTabBP.Size = new System.Drawing.Size(187, 54);
            StandardRoomTabBP.TabIndex = 4;
            StandardRoomTabBP.Text = "STANDARD";
            StandardRoomTabBP.UseVisualStyleBackColor = false;
            StandardRoomTabBP.Click += StandardRoomTabBP_Click;
            // 
            // AllRoomsTabBP
            // 
            AllRoomsTabBP.BackColor = System.Drawing.Color.Black;
            AllRoomsTabBP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            AllRoomsTabBP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            AllRoomsTabBP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            AllRoomsTabBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AllRoomsTabBP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            AllRoomsTabBP.ForeColor = System.Drawing.Color.White;
            AllRoomsTabBP.Location = new System.Drawing.Point(6, 2);
            AllRoomsTabBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AllRoomsTabBP.Name = "AllRoomsTabBP";
            AllRoomsTabBP.Size = new System.Drawing.Size(208, 59);
            AllRoomsTabBP.TabIndex = 0;
            AllRoomsTabBP.Text = "ALL ROOMS";
            AllRoomsTabBP.UseVisualStyleBackColor = false;
            AllRoomsTabBP.Click += AllRoomsTabBP_Click_1;
            // 
            // SuiteRoomBP
            // 
            SuiteRoomBP.BackColor = System.Drawing.Color.Black;
            SuiteRoomBP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            SuiteRoomBP.FlatAppearance.BorderSize = 0;
            SuiteRoomBP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            SuiteRoomBP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            SuiteRoomBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SuiteRoomBP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SuiteRoomBP.ForeColor = System.Drawing.Color.White;
            SuiteRoomBP.Location = new System.Drawing.Point(1089, 5);
            SuiteRoomBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SuiteRoomBP.Name = "SuiteRoomBP";
            SuiteRoomBP.Size = new System.Drawing.Size(187, 54);
            SuiteRoomBP.TabIndex = 3;
            SuiteRoomBP.Text = "SUITE";
            SuiteRoomBP.UseVisualStyleBackColor = false;
            SuiteRoomBP.Click += SuiteRoomBP_Click;
            // 
            // AddBookingbuttonBP
            // 
            AddBookingbuttonBP.BackColor = System.Drawing.Color.Black;
            AddBookingbuttonBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddBookingbuttonBP.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            AddBookingbuttonBP.ForeColor = System.Drawing.Color.White;
            AddBookingbuttonBP.Location = new System.Drawing.Point(883, 92);
            AddBookingbuttonBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddBookingbuttonBP.Name = "AddBookingbuttonBP";
            AddBookingbuttonBP.Size = new System.Drawing.Size(94, 31);
            AddBookingbuttonBP.TabIndex = 5;
            AddBookingbuttonBP.Text = "ADD";
            AddBookingbuttonBP.UseVisualStyleBackColor = false;
            AddBookingbuttonBP.Click += button2_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MenuRoomButtonBP
            // 
            MenuRoomButtonBP.BackColor = System.Drawing.Color.Black;
            MenuRoomButtonBP.BackgroundImage = (System.Drawing.Image)resources.GetObject("MenuRoomButtonBP.BackgroundImage");
            MenuRoomButtonBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            MenuRoomButtonBP.FlatAppearance.BorderSize = 0;
            MenuRoomButtonBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MenuRoomButtonBP.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuRoomButtonBP.ForeColor = System.Drawing.Color.White;
            MenuRoomButtonBP.Location = new System.Drawing.Point(122, 26);
            MenuRoomButtonBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuRoomButtonBP.Name = "MenuRoomButtonBP";
            MenuRoomButtonBP.Size = new System.Drawing.Size(99, 34);
            MenuRoomButtonBP.TabIndex = 2;
            MenuRoomButtonBP.UseVisualStyleBackColor = false;
            // 
            // MenuBookingButtonBP
            // 
            MenuBookingButtonBP.BackColor = System.Drawing.Color.Black;
            MenuBookingButtonBP.BackgroundImage = (System.Drawing.Image)resources.GetObject("MenuBookingButtonBP.BackgroundImage");
            MenuBookingButtonBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            MenuBookingButtonBP.FlatAppearance.BorderSize = 0;
            MenuBookingButtonBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MenuBookingButtonBP.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuBookingButtonBP.ForeColor = System.Drawing.Color.White;
            MenuBookingButtonBP.Location = new System.Drawing.Point(227, 27);
            MenuBookingButtonBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuBookingButtonBP.Name = "MenuBookingButtonBP";
            MenuBookingButtonBP.Size = new System.Drawing.Size(103, 34);
            MenuBookingButtonBP.TabIndex = 1;
            MenuBookingButtonBP.UseVisualStyleBackColor = false;
            MenuBookingButtonBP.Click += MenuBookingButtonBP_Click;
            // 
            // MenuDashboardButtonBP
            // 
            MenuDashboardButtonBP.BackColor = System.Drawing.Color.Black;
            MenuDashboardButtonBP.BackgroundImage = (System.Drawing.Image)resources.GetObject("MenuDashboardButtonBP.BackgroundImage");
            MenuDashboardButtonBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            MenuDashboardButtonBP.FlatAppearance.BorderSize = 0;
            MenuDashboardButtonBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MenuDashboardButtonBP.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuDashboardButtonBP.ForeColor = System.Drawing.Color.White;
            MenuDashboardButtonBP.Location = new System.Drawing.Point(12, 27);
            MenuDashboardButtonBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuDashboardButtonBP.Name = "MenuDashboardButtonBP";
            MenuDashboardButtonBP.Size = new System.Drawing.Size(104, 33);
            MenuDashboardButtonBP.TabIndex = 0;
            MenuDashboardButtonBP.UseVisualStyleBackColor = false;
            MenuDashboardButtonBP.Click += MenuDashboardButtonBP_Click;
            // 
            // MenuRoomInfoButtonBP
            // 
            MenuRoomInfoButtonBP.BackColor = System.Drawing.Color.Black;
            MenuRoomInfoButtonBP.BackgroundImage = (System.Drawing.Image)resources.GetObject("MenuRoomInfoButtonBP.BackgroundImage");
            MenuRoomInfoButtonBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            MenuRoomInfoButtonBP.FlatAppearance.BorderSize = 0;
            MenuRoomInfoButtonBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MenuRoomInfoButtonBP.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuRoomInfoButtonBP.ForeColor = System.Drawing.Color.White;
            MenuRoomInfoButtonBP.Location = new System.Drawing.Point(336, 27);
            MenuRoomInfoButtonBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuRoomInfoButtonBP.Name = "MenuRoomInfoButtonBP";
            MenuRoomInfoButtonBP.Size = new System.Drawing.Size(104, 33);
            MenuRoomInfoButtonBP.TabIndex = 8;
            MenuRoomInfoButtonBP.UseVisualStyleBackColor = false;
            MenuRoomInfoButtonBP.Click += MenuRoomInfoButtonBP_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(18, 93);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(362, 34);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Availble", "Reserved", "Occupied", "Under Maintenance" });
            comboBox1.Location = new System.Drawing.Point(544, 92);
            comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(316, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Location = new System.Drawing.Point(1022, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(228, 109);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // BookingPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1323, 868);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(MenuRoomInfoButtonBP);
            Controls.Add(MenuDashboardButtonBP);
            Controls.Add(MenuRoomButtonBP);
            Controls.Add(MenuBookingButtonBP);
            Controls.Add(AddBookingbuttonBP);
            Controls.Add(DisplayPanelBP);
            Controls.Add(SearchBarBP);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximumSize = new System.Drawing.Size(1341, 915);
            MinimumSize = new System.Drawing.Size(1341, 915);
            Name = "BookingPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += BookingPage_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox SearchBarBP;
        private System.Windows.Forms.Panel DisplayPanelBP;
        private System.Windows.Forms.Button AddBookingbuttonBP;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button MenuRoomButtonBP;
        private System.Windows.Forms.Button MenuBookingButtonBP;
        private System.Windows.Forms.Button MenuDashboardButtonBP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SuiteRoomBP;
        private System.Windows.Forms.Button AllRoomsTabBP;
        private System.Windows.Forms.Button StandardRoomTabBP;
        private System.Windows.Forms.Button DeluxeRoomTabBP;
        private System.Windows.Forms.Button MenuRoomInfoButtonBP;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}