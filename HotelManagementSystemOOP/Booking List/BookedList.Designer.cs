using System;

namespace HotelManagementSystemOOP
{
    partial class BookingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingList));
            MenuBookPageBL = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            DeluxeRoomTabRC = new System.Windows.Forms.Button();
            SuiteRoomRC = new System.Windows.Forms.Button();
            StandardRoomTabRC = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            MenuDashboardBL = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // MenuBookPageBL
            // 
            MenuBookPageBL.BackColor = System.Drawing.Color.Black;
            MenuBookPageBL.BackgroundImage = (System.Drawing.Image)resources.GetObject("MenuBookPageBL.BackgroundImage");
            MenuBookPageBL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            MenuBookPageBL.FlatAppearance.BorderSize = 0;
            MenuBookPageBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MenuBookPageBL.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuBookPageBL.ForeColor = System.Drawing.Color.White;
            MenuBookPageBL.Location = new System.Drawing.Point(132, 28);
            MenuBookPageBL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuBookPageBL.Name = "MenuBookPageBL";
            MenuBookPageBL.Size = new System.Drawing.Size(99, 35);
            MenuBookPageBL.TabIndex = 0;
            MenuBookPageBL.UseVisualStyleBackColor = false;
            MenuBookPageBL.Click += MenuDashboardButtonRC_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            panel2.Location = new System.Drawing.Point(23, 150);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1275, 683);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            panel3.Controls.Add(DeluxeRoomTabRC);
            panel3.Controls.Add(SuiteRoomRC);
            panel3.Controls.Add(StandardRoomTabRC);
            panel3.Location = new System.Drawing.Point(21, 91);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(316, 58);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // DeluxeRoomTabRC
            // 
            DeluxeRoomTabRC.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            DeluxeRoomTabRC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            DeluxeRoomTabRC.FlatAppearance.BorderSize = 0;
            DeluxeRoomTabRC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            DeluxeRoomTabRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DeluxeRoomTabRC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DeluxeRoomTabRC.ForeColor = System.Drawing.Color.White;
            DeluxeRoomTabRC.Location = new System.Drawing.Point(99, 30);
            DeluxeRoomTabRC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DeluxeRoomTabRC.Name = "DeluxeRoomTabRC";
            DeluxeRoomTabRC.Size = new System.Drawing.Size(102, 28);
            DeluxeRoomTabRC.TabIndex = 2;
            DeluxeRoomTabRC.Text = "DELUXE";
            DeluxeRoomTabRC.UseVisualStyleBackColor = false;
            DeluxeRoomTabRC.Click += button3_Click;
            // 
            // SuiteRoomRC
            // 
            SuiteRoomRC.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            SuiteRoomRC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            SuiteRoomRC.FlatAppearance.BorderSize = 0;
            SuiteRoomRC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            SuiteRoomRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SuiteRoomRC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SuiteRoomRC.ForeColor = System.Drawing.Color.White;
            SuiteRoomRC.Location = new System.Drawing.Point(200, 30);
            SuiteRoomRC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SuiteRoomRC.Name = "SuiteRoomRC";
            SuiteRoomRC.Size = new System.Drawing.Size(102, 28);
            SuiteRoomRC.TabIndex = 3;
            SuiteRoomRC.Text = "SUITE";
            SuiteRoomRC.UseVisualStyleBackColor = false;
            SuiteRoomRC.Click += SuiteRoomRC_Click;
            // 
            // StandardRoomTabRC
            // 
            StandardRoomTabRC.BackColor = System.Drawing.Color.FromArgb(61, 41, 31);
            StandardRoomTabRC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            StandardRoomTabRC.FlatAppearance.BorderSize = 0;
            StandardRoomTabRC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            StandardRoomTabRC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            StandardRoomTabRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StandardRoomTabRC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            StandardRoomTabRC.ForeColor = System.Drawing.Color.White;
            StandardRoomTabRC.Location = new System.Drawing.Point(2, 30);
            StandardRoomTabRC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            StandardRoomTabRC.Name = "StandardRoomTabRC";
            StandardRoomTabRC.Size = new System.Drawing.Size(102, 28);
            StandardRoomTabRC.TabIndex = 1;
            StandardRoomTabRC.Text = "STANDARD";
            StandardRoomTabRC.UseVisualStyleBackColor = false;
            StandardRoomTabRC.Click += StandardRoomTabRC_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Location = new System.Drawing.Point(1089, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(202, 120);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // MenuDashboardBL
            // 
            MenuDashboardBL.BackColor = System.Drawing.Color.Black;
            MenuDashboardBL.BackgroundImage = (System.Drawing.Image)resources.GetObject("MenuDashboardBL.BackgroundImage");
            MenuDashboardBL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            MenuDashboardBL.FlatAppearance.BorderSize = 0;
            MenuDashboardBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MenuDashboardBL.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuDashboardBL.ForeColor = System.Drawing.Color.White;
            MenuDashboardBL.Location = new System.Drawing.Point(25, 28);
            MenuDashboardBL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuDashboardBL.Name = "MenuDashboardBL";
            MenuDashboardBL.Size = new System.Drawing.Size(99, 35);
            MenuDashboardBL.TabIndex = 18;
            MenuDashboardBL.UseVisualStyleBackColor = false;
            MenuDashboardBL.Click += MenuDashboardBL_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Black;
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(237, 28);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(99, 35);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = false;
            // 
            // BookingList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(148, 118, 95);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1323, 868);
            Controls.Add(button1);
            Controls.Add(MenuDashboardBL);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(MenuBookPageBL);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximumSize = new System.Drawing.Size(1341, 915);
            MinimumSize = new System.Drawing.Size(1341, 915);
            Name = "BookingList";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += BookingList_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private void MenuRoomButtonBL_Click(
            object sender, EventArgs e) => throw new NotImplementedException();

        #endregion
        private System.Windows.Forms.Button MenuRoomButtonBL;
        private System.Windows.Forms.Button MenuBookingButtonBL;
        private System.Windows.Forms.Button MenuBookPageBL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SuiteRoomRC;
        private System.Windows.Forms.Button StandardRoomTabRC;
        private System.Windows.Forms.Button DeluxeRoomTabRC;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button MenuDashboardBL;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
