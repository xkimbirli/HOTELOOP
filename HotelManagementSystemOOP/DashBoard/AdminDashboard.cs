using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class AdminDashboard : Form
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";
        private LogIn logIn;
        public AdminDashboard(LogIn logIn)
        {
            InitializeComponent();
            this.logIn = logIn;

           // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void OccupancyRateButtonAD_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Call method to update Room label
            UpdateTotalRoomsLabel();


            // Call method to update TotalEmployees label (excluding admin)
            UpdateTotalEmployeesLabel();

            UpdateTotalFloorsLabel();
           // DisplayLatestHotelLogo();
        }
        /*private void DisplayLatestHotelLogo()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

                // Query to select the latest logo based on the highest ID (assuming descending order)
                string query = "SELECT Logo FROM Hotel ORDER BY HotelID DESC LIMIT 1";//

                using (var cmd = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0 && dt.Rows[0]["Logo"] != DBNull.Value)
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
                        else
                        {
                            // Handle case where there's no logo in the database or it's DBNull.Value
                            pictureBox1.Image = null; // Clear the pictureBox1
                        }
                    }
                }
            }
        }*/

        private void UpdateTotalFloorsLabel()
        {
            using (var con = new SQLiteConnection("URI=file:" + Application.StartupPath + "\\TOTOO.db"))
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM Floor";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    int floorCount = Convert.ToInt32(cmd.ExecuteScalar());
                    label3.Text = $"Total Floor: {floorCount}";
                }
            }
        }
        private void UpdateTotalRoomsLabel()
        {
            using (var con = new SQLiteConnection("URI=file:" + Application.StartupPath + "\\TOTOO.db"))
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM Rooms";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    int roomCount = Convert.ToInt32(cmd.ExecuteScalar());
                    label1.Text = $"Total Rooms: {roomCount}";
                }
            }
        }



        private void UpdateTotalEmployeesLabel()
        {
            // Initialize with 1 employee if the label is not already set
            if (string.IsNullOrEmpty(label2.Text))
            {
                label2.Text = "Total Employees: ";
            }

            // Update the employee count from the database
            using (var con = new SQLiteConnection("URI=file:" + Application.StartupPath + "\\TOTOO.db"))
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM Employee";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    int employeeCount = Convert.ToInt32(cmd.ExecuteScalar());
                    label2.Text = $"Total Employees: {employeeCount}";
                }
            }
        }

        private void RoomInformationButtonAD_Click(object sender, EventArgs e)
        {
            // Create an instance of Discount and Taxes and pass the current form instance
            DiscountAndTaxes discountAndTaxes = new DiscountAndTaxes(this);

            // Show the Room Information
            discountAndTaxes.Show();
            
            this.Close();

        }

        private void GenerealSettingButtonAD_Click(object sender, EventArgs e)
        {
            // Create an instance of General Setting and pass the current form instance
            GeneralSettings generalSettings = new GeneralSettings(this);

            // Show the General setting
            generalSettings.Show();

        }

        private void EmployeeInformationButtonAD_Click(object sender, EventArgs e)
        {
            // Create an instance of Employee Information and pass the current form instance
            EmployeeInformation employeeInformation = new EmployeeInformation(this);

            // Show the Employee Information
            employeeInformation.Show();

        }

        private void LogOutButtonAD_Click(object sender, EventArgs e)
        {

        }

        private void LogOutButtonAD_Click_1(object sender, EventArgs e)
        {
            // Create an instance to logout admin 
            LogIn logIn = new LogIn();
            // show the Log In
            logIn.Show();
            // hide the current page
            this.Hide();
        }

        private void RevenueReportButtonAD_Click(object sender, EventArgs e)
        {
            GenerateReport generateReport = new GenerateReport(this);
            generateReport.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TotalRooms_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}