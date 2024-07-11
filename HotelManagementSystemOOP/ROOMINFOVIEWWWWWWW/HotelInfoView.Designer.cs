namespace HotelManagementSystemOOP
{
    partial class HotelInfoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelInfoView));
            ExitHotelInfo = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            HotelLocation = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            HotelPhoneNumber = new System.Windows.Forms.Label();
            HotelEmain = new System.Windows.Forms.Label();
            HotelOverview = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ExitHotelInfo
            // 
            ExitHotelInfo.Location = new System.Drawing.Point(797, 12);
            ExitHotelInfo.Name = "ExitHotelInfo";
            ExitHotelInfo.Size = new System.Drawing.Size(35, 29);
            ExitHotelInfo.TabIndex = 0;
            ExitHotelInfo.Text = "X";
            ExitHotelInfo.UseVisualStyleBackColor = true;
            ExitHotelInfo.Click += ExitHotelInfo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(335, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(200, 149);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(47, 208);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 21);
            label1.TabIndex = 2;
            label1.Text = "LOCATION:";
            // 
            // HotelLocation
            // 
            HotelLocation.AutoSize = true;
            HotelLocation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            HotelLocation.Location = new System.Drawing.Point(170, 209);
            HotelLocation.Name = "HotelLocation";
            HotelLocation.Size = new System.Drawing.Size(36, 20);
            HotelLocation.TabIndex = 3;
            HotelLocation.Text = "text";
            HotelLocation.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(47, 250);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(235, 21);
            label3.TabIndex = 4;
            label3.Text = "CONTANCT INFORMATION";
            // 
            // HotelPhoneNumber
            // 
            HotelPhoneNumber.AutoSize = true;
            HotelPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            HotelPhoneNumber.Location = new System.Drawing.Point(76, 275);
            HotelPhoneNumber.Name = "HotelPhoneNumber";
            HotelPhoneNumber.Size = new System.Drawing.Size(114, 20);
            HotelPhoneNumber.TabIndex = 5;
            HotelPhoneNumber.Text = "PhoneNumber";
            HotelPhoneNumber.Click += label4_Click;
            // 
            // HotelEmain
            // 
            HotelEmain.AutoSize = true;
            HotelEmain.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            HotelEmain.Location = new System.Drawing.Point(76, 304);
            HotelEmain.Name = "HotelEmain";
            HotelEmain.Size = new System.Drawing.Size(46, 20);
            HotelEmain.TabIndex = 6;
            HotelEmain.Text = "Email";
            HotelEmain.Click += label5_Click;
            // 
            // HotelOverview
            // 
            HotelOverview.AutoSize = true;
            HotelOverview.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            HotelOverview.Location = new System.Drawing.Point(56, 370);
            HotelOverview.Name = "HotelOverview";
            HotelOverview.Size = new System.Drawing.Size(36, 20);
            HotelOverview.TabIndex = 7;
            HotelOverview.Text = "text";
            HotelOverview.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(47, 340);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(101, 21);
            label7.TabIndex = 8;
            label7.Text = "OVERVIEW";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(47, 440);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(182, 21);
            label8.TabIndex = 9;
            label8.Text = "ACCOMMODATION";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(69, 476);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(53, 20);
            label9.TabIndex = 10;
            label9.Text = "rooms";
            // 
            // HotelInfoView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(844, 581);
            ControlBox = false;
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(HotelOverview);
            Controls.Add(HotelEmain);
            Controls.Add(HotelPhoneNumber);
            Controls.Add(label3);
            Controls.Add(HotelLocation);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(ExitHotelInfo);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "HotelInfoView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += HotelInfoView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ExitHotelInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HotelLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label HotelPhoneNumber;
        private System.Windows.Forms.Label HotelEmain;
        private System.Windows.Forms.Label HotelOverview;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
