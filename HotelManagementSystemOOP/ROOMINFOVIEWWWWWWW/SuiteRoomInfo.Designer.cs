namespace HotelManagementSystemOOP
{
    partial class SuiteRoomInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuiteRoomInfo));
            ExitDeluxeRoomInfo = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ExitDeluxeRoomInfo
            // 
            ExitDeluxeRoomInfo.BackColor = System.Drawing.Color.Transparent;
            ExitDeluxeRoomInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ExitDeluxeRoomInfo.ForeColor = System.Drawing.Color.White;
            ExitDeluxeRoomInfo.Location = new System.Drawing.Point(1248, 12);
            ExitDeluxeRoomInfo.Name = "ExitDeluxeRoomInfo";
            ExitDeluxeRoomInfo.Size = new System.Drawing.Size(31, 29);
            ExitDeluxeRoomInfo.TabIndex = 3;
            ExitDeluxeRoomInfo.Text = "x";
            ExitDeluxeRoomInfo.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(37, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1215, 379);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // SuiteRoomInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(1291, 441);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(ExitDeluxeRoomInfo);
            Name = "SuiteRoomInfo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SuiteRoomInfo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button ExitDeluxeRoomInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}