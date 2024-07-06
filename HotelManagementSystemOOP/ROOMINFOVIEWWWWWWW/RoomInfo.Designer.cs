namespace HotelManagementSystemOOP
{
    partial class RoomInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInfo));
            StandardRoom = new System.Windows.Forms.Button();
            DeluxeRoom = new System.Windows.Forms.Button();
            SuiteRoom = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // StandardRoom
            // 
            StandardRoom.BackColor = System.Drawing.Color.Transparent;
            StandardRoom.Location = new System.Drawing.Point(95, 359);
            StandardRoom.Name = "StandardRoom";
            StandardRoom.Size = new System.Drawing.Size(341, 281);
            StandardRoom.TabIndex = 0;
            StandardRoom.UseVisualStyleBackColor = false;
            // 
            // DeluxeRoom
            // 
            DeluxeRoom.BackColor = System.Drawing.Color.Transparent;
            DeluxeRoom.Location = new System.Drawing.Point(485, 359);
            DeluxeRoom.Name = "DeluxeRoom";
            DeluxeRoom.Size = new System.Drawing.Size(341, 281);
            DeluxeRoom.TabIndex = 1;
            DeluxeRoom.UseVisualStyleBackColor = false;
            // 
            // SuiteRoom
            // 
            SuiteRoom.BackColor = System.Drawing.Color.Transparent;
            SuiteRoom.Location = new System.Drawing.Point(874, 359);
            SuiteRoom.Name = "SuiteRoom";
            SuiteRoom.Size = new System.Drawing.Size(344, 281);
            SuiteRoom.TabIndex = 2;
            SuiteRoom.UseVisualStyleBackColor = false;
            // 
            // RoomInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1323, 868);
            Controls.Add(SuiteRoom);
            Controls.Add(DeluxeRoom);
            Controls.Add(StandardRoom);
            Name = "RoomInfo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "RoomInfo";
            Load += RoomInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button StandardRoom;
        private System.Windows.Forms.Button DeluxeRoom;
        private System.Windows.Forms.Button SuiteRoom;
    }
}