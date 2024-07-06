namespace HotelManagementSystemOOP
{
    partial class EmployeeInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInformation));
            textBox1 = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            DashboardButtonEI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(21, 102);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(348, 28);
            textBox1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(20, 146);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(427, 644);
            dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(9, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(334, 37);
            label1.TabIndex = 16;
            label1.Text = "Employee Information";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(343, 10);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(73, 71);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Black;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(755, 25);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(52, 35);
            button1.TabIndex = 18;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DashboardButtonEI
            // 
            DashboardButtonEI.BackColor = System.Drawing.Color.Black;
            DashboardButtonEI.FlatAppearance.BorderSize = 0;
            DashboardButtonEI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DashboardButtonEI.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DashboardButtonEI.ForeColor = System.Drawing.Color.White;
            DashboardButtonEI.Location = new System.Drawing.Point(815, 25);
            DashboardButtonEI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DashboardButtonEI.Name = "DashboardButtonEI";
            DashboardButtonEI.Size = new System.Drawing.Size(112, 35);
            DashboardButtonEI.TabIndex = 12;
            DashboardButtonEI.Text = "DASHBOARD";
            DashboardButtonEI.UseVisualStyleBackColor = false;
            DashboardButtonEI.Click += DashboardButtonEI_Click;
            // 
            // EmployeeInformation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(942, 855);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(DashboardButtonEI);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximumSize = new System.Drawing.Size(948, 861);
            MinimumSize = new System.Drawing.Size(948, 861);
            Name = "EmployeeInformation";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += EmployeeInformation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DashboardButtonEI;
    }
}
