namespace HotelManagementSystemOOP
{
    partial class RoomInfos
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
            panel1 = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(monthCalendar1);
            panel1.Location = new System.Drawing.Point(824, 35);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(468, 777);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(47, 327);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(393, 358);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new System.Drawing.Point(109, 78);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // RoomInfos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1323, 868);
            Controls.Add(panel1);
            Name = "RoomInfos";
            Text = "RoomInfos";
            Load += RoomInfos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}