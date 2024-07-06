namespace HotelManagementSystemOOP
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            UsernameLogIn = new System.Windows.Forms.Label();
            PasswordLogIn = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(449, 401);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.MaximumSize = new System.Drawing.Size(500, 35);
            textBox1.MinimumSize = new System.Drawing.Size(314, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(380, 35);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox2.Location = new System.Drawing.Point(451, 535);
            textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox2.MaximumSize = new System.Drawing.Size(500, 35);
            textBox2.MinimumSize = new System.Drawing.Size(314, 35);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new System.Drawing.Size(380, 35);
            textBox2.TabIndex = 1;
            textBox2.Tag = "";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // UsernameLogIn
            // 
            UsernameLogIn.AutoSize = true;
            UsernameLogIn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            UsernameLogIn.ForeColor = System.Drawing.Color.White;
            UsernameLogIn.Location = new System.Drawing.Point(451, 374);
            UsernameLogIn.Name = "UsernameLogIn";
            UsernameLogIn.Size = new System.Drawing.Size(96, 19);
            UsernameLogIn.TabIndex = 2;
            UsernameLogIn.Text = "Username:";
            // 
            // PasswordLogIn
            // 
            PasswordLogIn.AutoSize = true;
            PasswordLogIn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PasswordLogIn.ForeColor = System.Drawing.Color.White;
            PasswordLogIn.Location = new System.Drawing.Point(447, 508);
            PasswordLogIn.Name = "PasswordLogIn";
            PasswordLogIn.Size = new System.Drawing.Size(92, 19);
            PasswordLogIn.TabIndex = 3;
            PasswordLogIn.Text = "Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(472, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(338, 272);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(1323, 868);
            Controls.Add(pictureBox1);
            Controls.Add(PasswordLogIn);
            Controls.Add(UsernameLogIn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximumSize = new System.Drawing.Size(1341, 915);
            MinimumSize = new System.Drawing.Size(1341, 915);
            Name = "LogIn";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += LogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label UsernameLogIn;
        private System.Windows.Forms.Label PasswordLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}