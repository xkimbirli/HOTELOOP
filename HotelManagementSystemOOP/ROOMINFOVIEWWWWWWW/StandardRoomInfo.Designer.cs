namespace HotelManagementSystemOOP
{
    partial class StandardRoomInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardRoomInfo));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ExitStandardRoomInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(35, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1244, 379);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ExitStandardRoomInfo
            // 
            ExitStandardRoomInfo.BackColor = System.Drawing.Color.Transparent;
            ExitStandardRoomInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ExitStandardRoomInfo.ForeColor = System.Drawing.Color.White;
            ExitStandardRoomInfo.Location = new System.Drawing.Point(1248, 5);
            ExitStandardRoomInfo.Name = "ExitStandardRoomInfo";
            ExitStandardRoomInfo.Size = new System.Drawing.Size(31, 29);
            ExitStandardRoomInfo.TabIndex = 1;
            ExitStandardRoomInfo.Text = "x";
            ExitStandardRoomInfo.UseVisualStyleBackColor = false;
            // 
            // StandardRoomInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(1291, 441);
            ControlBox = false;
            Controls.Add(ExitStandardRoomInfo);
            Controls.Add(pictureBox1);
            Name = "StandardRoomInfo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "StandardRoomInfo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExitStandardRoomInfo;
    }
}