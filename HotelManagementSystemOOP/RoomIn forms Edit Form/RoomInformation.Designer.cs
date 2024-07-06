namespace HotelManagementSystemOOP
{
    partial class RoomInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInformation));
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            panel1 = new System.Windows.Forms.Panel();
            DashboardButtonRI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(14, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(272, 37);
            label1.TabIndex = 0;
            label1.Text = "Room Information";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(292, 24);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(79, 62);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(535, 64);
            comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(242, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Gray;
            panel1.Location = new System.Drawing.Point(21, 105);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(883, 682);
            panel1.TabIndex = 3;
            // 
            // DashboardButtonRI
            // 
            DashboardButtonRI.BackColor = System.Drawing.Color.Transparent;
            DashboardButtonRI.FlatAppearance.BorderSize = 0;
            DashboardButtonRI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DashboardButtonRI.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DashboardButtonRI.ForeColor = System.Drawing.Color.Black;
            DashboardButtonRI.Location = new System.Drawing.Point(783, 58);
            DashboardButtonRI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DashboardButtonRI.Name = "DashboardButtonRI";
            DashboardButtonRI.Size = new System.Drawing.Size(121, 39);
            DashboardButtonRI.TabIndex = 12;
            DashboardButtonRI.Text = "DASHBOARD";
            DashboardButtonRI.UseVisualStyleBackColor = false;
            // 
            // RoomInformation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(942, 855);
            ControlBox = false;
            Controls.Add(comboBox1);
            Controls.Add(DashboardButtonRI);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximumSize = new System.Drawing.Size(948, 861);
            MinimumSize = new System.Drawing.Size(948, 861);
            Name = "RoomInformation";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += RoomInformation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DashboardButtonRI;
    }
}
