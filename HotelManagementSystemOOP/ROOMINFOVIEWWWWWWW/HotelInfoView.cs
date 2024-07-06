using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SQLite;
using System.IO;
using Microsoft.CodeAnalysis;
namespace HotelManagementSystemOOP
{
    public partial class HotelInfoView : Form
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";
        private StaffDashboard staffDashboard;
        public HotelInfoView(StaffDashboard staffDashboard)
        {
            InitializeComponent();
            this.staffDashboard = staffDashboard;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void HotelInfoView_Load(object sender, EventArgs e)
        {
            DisplayLatestHotelLogo();
            DisplayHotelLocation();
            DisplayHotelPhoneNumber();
            DisplayEmail();
            DisplayHotelOverview();
        }
        private void DisplayLatestHotelLogo()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

                // Query to select the latest logo based on the highest ID (assuming descending order)
                string query = "SELECT Logo FROM Hotel ORDER BY HotelID DESC";

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

        private void ExitHotelInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DisplayHotelLocation();
        }
        private void DisplayHotelLocation()
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                {
                    connection.Open();

                    string selectQuery = "SELECT Location FROM Hotel  ORDER BY HotelID"; // Assuming there's only one row in the Hotel table
                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        var location = command.ExecuteScalar()?.ToString();
                        if (!string.IsNullOrEmpty(location))
                        {
                            HotelLocation.Text = location;
                        }
                        else
                        {
                            HotelLocation.Text = "Location Not Found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching Location: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            DisplayHotelPhoneNumber();
        }
        private void DisplayHotelPhoneNumber()
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                {
                    connection.Open();

                    string selectQuery = "SELECT ContactNumber FROM Hotel  ORDER BY HotelID"; // Assuming there's only one row in the Hotel table
                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        var phonenumber = command.ExecuteScalar()?.ToString();
                        if (!string.IsNullOrEmpty(phonenumber))
                        {
                            HotelPhoneNumber.Text = phonenumber;
                        }
                        else
                        {
                            HotelPhoneNumber.Text = "Phone Number Not Found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching ContactNumber: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            DisplayEmail();
        }
        private void DisplayEmail()
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                {
                    connection.Open();

                    string selectQuery = "SELECT EmailAddress FROM Hotel  ORDER BY HotelID"; // Assuming there's only one row in the Hotel table
                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        var email = command.ExecuteScalar()?.ToString();
                        if (!string.IsNullOrEmpty(email))
                        {
                            HotelEmain.Text = email;
                        }
                        else
                        {
                            HotelEmain.Text = "Email Name Not Found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching Email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
            DisplayHotelOverview();
        }
        private void DisplayHotelOverview()
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                {
                    connection.Open();

                    string selectQuery = "SELECT Overview FROM Hotel  ORDER BY HotelID"; // Assuming there's only one row in the Hotel table
                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        var overview = command.ExecuteScalar()?.ToString();
                        if (!string.IsNullOrEmpty(overview))
                        {
                            HotelOverview.Text = overview;
                        }
                        else
                        {
                            HotelOverview.Text = "Overview Name Not Found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching Overview: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
