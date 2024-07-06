using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class LogIn : Form
    {
        // Dictionary to store admin credentials
        private Dictionary<string, string> adminCredentials;

        // Database connection string
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";

        // Custom RoundedButton
        private RoundedButton logInButton;

        public LogIn()
        {
            InitializeComponent();
            InitializeCustomComponents();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;



            // Initialize admin credentials (hardcoded for demo purposes)
            adminCredentials = new Dictionary<string, string>
            {
                { "adminUser", "adminPass" }
            };
        }

        private void InitializeCustomComponents()
        {
            // Create the custom rounded button
            logInButton = new RoundedButton
            {
                Text = "Log In",
                Size = new Size(100, 30),
                Location = new Point(520, 500), // Set the desired location
                BackColor = Color.LightGray,
                CornerRadius = 15
            };

            // Add the Click event handler
            logInButton.Click += LogInButton_Click;

            // Add the rounded button to the form's controls
            Controls.Add(logInButton);
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

                // Check if it's an admin login using hardcoded credentials
                if (adminCredentials.ContainsKey(username) && adminCredentials[username] == password)
                {
                    AdminDashboard adminDashboard = new AdminDashboard(this);
                    adminDashboard.Show();
                    Hide();
                }
                else
                {
                    // Check if it's a receptionist login using the database
                    using (var cmd = new SQLiteCommand("SELECT COUNT(1) FROM Employee WHERE Username = @username AND Password = @password AND Position = 'Receptionist'", con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            StaffDashboard staffDashboard = new StaffDashboard(this);
                            staffDashboard.Show();
                            Hide();
                            return; // Exit the method after successful login
                        }
                    }

                    // Check if it's a housekeeping staff login using the database
                    using (var housekeepingCmd = new SQLiteCommand("SELECT COUNT(1) FROM Employee WHERE Username = @username AND Password = @password AND Position = 'Housekeeping'", con))
                    {
                        housekeepingCmd.Parameters.AddWithValue("@username", username);
                        housekeepingCmd.Parameters.AddWithValue("@password", password);
                        int housekeepingCount = Convert.ToInt32(housekeepingCmd.ExecuteScalar());

                        if (housekeepingCount > 0)
                        {
                            HouseKeeping houseKeeping = new HouseKeeping(this);
                            houseKeeping.Show();
                            Hide();
                            return; // Exit the method after successful login
                        }
                    }

                    // Check if it's an admin login using the database (additional check)
                    using (var adminCmd = new SQLiteCommand("SELECT COUNT(1) FROM Employee WHERE Username = @username AND Password = @password AND Position = 'Admin'", con))
                    {
                        adminCmd.Parameters.AddWithValue("@username", username);
                        adminCmd.Parameters.AddWithValue("@password", password);
                        int adminCount = Convert.ToInt32(adminCmd.ExecuteScalar());

                        if (adminCount > 0)
                        {
                            AdminDashboard adminDashboard = new AdminDashboard(this);
                            adminDashboard.Show();
                            Hide();
                            return; // Exit the method after successful login
                        }
                    }

                    // If none of the above conditions are met, show an error message
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        // Other event handlers and methods as per your implementation
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HotelSystem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void LogIn_Load(object sender, EventArgs e)
        {
           DisplayLatestHotelLogo();
        }
        
        private void DisplayLatestHotelLogo()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

                // Query to select the latest logo based on the highest ID (assuming descending order)
                string query = "SELECT Logo FROM Hotel ORDER BY HotelID DESC ";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // Convert byte array to image
                            byte[] imgData = (byte[])dt.Rows[0]["Logo"];
                            Image img;
                            using (MemoryStream ms = new MemoryStream(imgData))
                            {
                                img = Image.FromStream(ms);
                            }

                            // Display image in pictureBox1
                            pictureBox1.Image = img;
                        }
                    }
                }
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}