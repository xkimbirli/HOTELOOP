namespace HotelManagementSystemOOP
{
    partial class AddRooms
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
            AddRoomDropdown = new System.Windows.Forms.ComboBox();
            RoomNumber = new System.Windows.Forms.TextBox();
            FloorNumberAddRooms = new System.Windows.Forms.TextBox();
            SaveAddRooms = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            Rooms = new System.Windows.Forms.Label();
            ExitAddRooms = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            panel1.Controls.Add(AddRoomDropdown);
            panel1.Controls.Add(RoomNumber);
            panel1.Controls.Add(FloorNumberAddRooms);
            panel1.Controls.Add(SaveAddRooms);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(27, 83);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(531, 296);
            panel1.TabIndex = 2;
            // 
            // AddRoomDropdown
            // 
            AddRoomDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AddRoomDropdown.FormattingEnabled = true;
            AddRoomDropdown.Location = new System.Drawing.Point(171, 104);
            AddRoomDropdown.Name = "AddRoomDropdown";
            AddRoomDropdown.Size = new System.Drawing.Size(329, 28);
            AddRoomDropdown.TabIndex = 7;
            AddRoomDropdown.SelectedIndexChanged += AddRoomDropdown_SelectedIndexChanged;
            // 
            // RoomNumber
            // 
            RoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            RoomNumber.Location = new System.Drawing.Point(171, 169);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new System.Drawing.Size(328, 27);
            RoomNumber.TabIndex = 6;
            RoomNumber.TextChanged += RoomNumber_TextChanged;
            // 
            // FloorNumberAddRooms
            // 
            FloorNumberAddRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FloorNumberAddRooms.Location = new System.Drawing.Point(172, 41);
            FloorNumberAddRooms.Name = "FloorNumberAddRooms";
            FloorNumberAddRooms.Size = new System.Drawing.Size(328, 27);
            FloorNumberAddRooms.TabIndex = 5;
            FloorNumberAddRooms.TextChanged += FloorNumberAddRooms_TextChanged;
            // 
            // SaveAddRooms
            // 
            SaveAddRooms.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SaveAddRooms.Location = new System.Drawing.Point(406, 238);
            SaveAddRooms.Name = "SaveAddRooms";
            SaveAddRooms.Size = new System.Drawing.Size(94, 29);
            SaveAddRooms.TabIndex = 3;
            SaveAddRooms.Text = "SAVE";
            SaveAddRooms.UseVisualStyleBackColor = true;
            SaveAddRooms.Click += SaveAddRooms_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.Window;
            label4.Location = new System.Drawing.Point(12, 176);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(107, 20);
            label4.TabIndex = 2;
            label4.Text = "Room Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 20);
            label3.TabIndex = 1;
            label3.Text = "Room Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.Location = new System.Drawing.Point(18, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 20);
            label2.TabIndex = 0;
            label2.Text = "Floor Number";
            label2.Click += label2_Click;
            // 
            // Rooms
            // 
            Rooms.AutoSize = true;
            Rooms.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Rooms.Location = new System.Drawing.Point(12, 30);
            Rooms.Name = "Rooms";
            Rooms.Size = new System.Drawing.Size(105, 34);
            Rooms.TabIndex = 3;
            Rooms.Text = "Rooms";
            // 
            // ExitAddRooms
            // 
            ExitAddRooms.Location = new System.Drawing.Point(525, 12);
            ExitAddRooms.Name = "ExitAddRooms";
            ExitAddRooms.Size = new System.Drawing.Size(33, 29);
            ExitAddRooms.TabIndex = 4;
            ExitAddRooms.Text = "x";
            ExitAddRooms.UseVisualStyleBackColor = true;
            ExitAddRooms.Click += ExitAddRooms_Click;
            // 
            // AddRooms
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(207, 185, 163);
            ClientSize = new System.Drawing.Size(570, 438);
            ControlBox = false;
            Controls.Add(ExitAddRooms);
            Controls.Add(Rooms);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximumSize = new System.Drawing.Size(588, 456);
            MinimumSize = new System.Drawing.Size(588, 456);
            Name = "AddRooms";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += AddRooms_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RoomNumber;
        private System.Windows.Forms.TextBox FloorNumberAddRooms;
        private System.Windows.Forms.Button SaveAddRooms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Rooms;
        private System.Windows.Forms.Button ExitAddRooms;
        private System.Windows.Forms.ComboBox AddRoomDropdown;
    }
}