namespace HotelManagementSystemOOP
{
    partial class AddFloor
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
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            FloorNumber = new System.Windows.Forms.TextBox();
            FloorName = new System.Windows.Forms.TextBox();
            FloorStatus = new System.Windows.Forms.RadioButton();
            SaveAddFloor = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ExitAddFloors = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(12, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 34);
            label1.TabIndex = 0;
            label1.Text = "FLOOR";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            panel1.Controls.Add(FloorNumber);
            panel1.Controls.Add(FloorName);
            panel1.Controls.Add(FloorStatus);
            panel1.Controls.Add(SaveAddFloor);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(12, 81);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(546, 296);
            panel1.TabIndex = 1;
            // 
            // FloorNumber
            // 
            FloorNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FloorNumber.Location = new System.Drawing.Point(189, 102);
            FloorNumber.Name = "FloorNumber";
            FloorNumber.Size = new System.Drawing.Size(328, 27);
            FloorNumber.TabIndex = 6;
            FloorNumber.TextChanged += FloorNumber_TextChanged;
            // 
            // FloorName
            // 
            FloorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FloorName.Location = new System.Drawing.Point(189, 41);
            FloorName.Name = "FloorName";
            FloorName.Size = new System.Drawing.Size(328, 27);
            FloorName.TabIndex = 5;
            FloorName.TextChanged += FloorName_TextChanged;
            // 
            // FloorStatus
            // 
            FloorStatus.AutoSize = true;
            FloorStatus.Location = new System.Drawing.Point(189, 169);
            FloorStatus.Name = "FloorStatus";
            FloorStatus.Size = new System.Drawing.Size(71, 24);
            FloorStatus.TabIndex = 4;
            FloorStatus.TabStop = true;
            FloorStatus.Text = "Active";
            FloorStatus.UseVisualStyleBackColor = true;
            FloorStatus.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // SaveAddFloor
            // 
            SaveAddFloor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SaveAddFloor.Location = new System.Drawing.Point(423, 249);
            SaveAddFloor.Name = "SaveAddFloor";
            SaveAddFloor.Size = new System.Drawing.Size(94, 29);
            SaveAddFloor.TabIndex = 3;
            SaveAddFloor.Text = "SAVE";
            SaveAddFloor.UseVisualStyleBackColor = true;
            SaveAddFloor.Click += SaveAddFloor_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.Window;
            label4.Location = new System.Drawing.Point(21, 169);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 20);
            label4.TabIndex = 2;
            label4.Text = "STATUS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(117, 20);
            label3.TabIndex = 1;
            label3.Text = "FLOOR NUMBER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.Location = new System.Drawing.Point(18, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 20);
            label2.TabIndex = 0;
            label2.Text = "FLOOR NAME";
            // 
            // ExitAddFloors
            // 
            ExitAddFloors.Location = new System.Drawing.Point(525, 12);
            ExitAddFloors.Name = "ExitAddFloors";
            ExitAddFloors.Size = new System.Drawing.Size(33, 29);
            ExitAddFloors.TabIndex = 5;
            ExitAddFloors.Text = "x";
            ExitAddFloors.UseVisualStyleBackColor = true;
            ExitAddFloors.Click += ExitAddFloors_Click;
            // 
            // AddFloor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            ClientSize = new System.Drawing.Size(570, 438);
            ControlBox = false;
            Controls.Add(ExitAddFloors);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximumSize = new System.Drawing.Size(588, 456);
            MinimumSize = new System.Drawing.Size(588, 456);
            Name = "AddFloor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += AddFloor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FloorNumber;
        private System.Windows.Forms.TextBox FloorName;
        private System.Windows.Forms.RadioButton FloorStatus;
        private System.Windows.Forms.Button SaveAddFloor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitAddFloors;
    }
}