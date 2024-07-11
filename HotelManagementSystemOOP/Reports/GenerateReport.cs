using System;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelManagementSystemOOP
{
    public partial class GenerateReport : Form
    {
        private AdminDashboard admindashboard;
        private string connectionString = "Data Source=TOTOO.db;Version=3;";

        public GenerateReport(AdminDashboard admindashboard)
        {
            InitializeComponent();
            this.admindashboard = admindashboard;

        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {
            // Adding columns to the DataGridView for Guest data
            dataGridView1.Columns.Add("GuestName", "Guest Name");
            dataGridView1.Columns.Add("Gender", "Gender");
            dataGridView1.Columns.Add("Nationality", "Nationality");
            dataGridView1.Columns.Add("GuestNumber", "Guest Number");

            // Setting column widths
            dataGridView1.Columns["GuestName"].Width = 150;
            dataGridView1.Columns["Gender"].Width = 100;
            dataGridView1.Columns["Nationality"].Width = 150;
            dataGridView1.Columns["GuestNumber"].Width = 120;

            // Adding columns to the DataGridView for Room data
            dataGridView2.Columns.Add("RoomType", "Room Type");
            dataGridView2.Columns.Add("NumberOfUnits", "Number of Units");
            dataGridView2.Columns.Add("RentedUnits", "Rented Units");
            dataGridView2.Columns.Add("OccupancyRate", "Occupancy Rate");
            dataGridView2.Columns.Add("NetIncome", "Net Income");

            // Setting column widths
            dataGridView2.Columns["RoomType"].Width = 150;
            dataGridView2.Columns["NumberOfUnits"].Width = 120;
            dataGridView2.Columns["RentedUnits"].Width = 120;
            dataGridView2.Columns["OccupancyRate"].Width = 120;
            dataGridView2.Columns["NetIncome"].Width = 150;

            // Load data from the database
            LoadGuestData();
            LoadRoomData();
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);

            dateTimePicker2.Value = DateTime.Now;

            UpdateGuestCountLabels(dateTimePicker1.Value, dateTimePicker2.Value);

        }

        private void LoadGuestData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Name, Sex, Nationality, Contact FROM Guest";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["Name"], reader["Sex"], reader["Nationality"], reader["Contact"]);
                        }
                    }
                }
            }
        }

        private void LoadRoomData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Query to get room counts by type
                string queryStandard = "SELECT COUNT(*) AS TotalStandard FROM Rooms WHERE RoomType = 'Standard'";
                string queryDeluxe = "SELECT COUNT(*) AS TotalDeluxe FROM Rooms WHERE RoomType = 'Deluxe'";
                string querySuite = "SELECT COUNT(*) AS TotalSuite FROM Rooms WHERE RoomType = 'Suite'";

                int totalStandard = 0, totalDeluxe = 0, totalSuite = 0;

                using (SQLiteCommand cmdStandard = new SQLiteCommand(queryStandard, conn))
                {
                    totalStandard = Convert.ToInt32(cmdStandard.ExecuteScalar());
                }

                using (SQLiteCommand cmdDeluxe = new SQLiteCommand(queryDeluxe, conn))
                {
                    totalDeluxe = Convert.ToInt32(cmdDeluxe.ExecuteScalar());
                }

                using (SQLiteCommand cmdSuite = new SQLiteCommand(querySuite, conn))
                {
                    totalSuite = Convert.ToInt32(cmdSuite.ExecuteScalar());
                }

                // Query to get number of rented units (bookings) and rate by type
                string queryRentedStandard = "SELECT COUNT(*) AS RentedStandard, RateID FROM Booking WHERE RoomType = 'Standard' GROUP BY RateID";
                string queryRentedDeluxe = "SELECT COUNT(*) AS RentedDeluxe, RateID FROM Booking WHERE RoomType = 'Deluxe' GROUP BY RateID";
                string queryRentedSuite = "SELECT COUNT(*) AS RentedSuite, RateID FROM Booking WHERE RoomType = 'Suite' GROUP BY RateID";

                int rentedStandard = 0, rentedDeluxe = 0, rentedSuite = 0;
                int rateStandard = 0, rateDeluxe = 0, rateSuite = 0;

                using (SQLiteCommand cmdRentedStandard = new SQLiteCommand(queryRentedStandard, conn))
                {
                    using (SQLiteDataReader reader = cmdRentedStandard.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rentedStandard += Convert.ToInt32(reader["RentedStandard"]);
                            rateStandard = Convert.ToInt32(reader["RateID"]);
                        }
                    }
                }

                using (SQLiteCommand cmdRentedDeluxe = new SQLiteCommand(queryRentedDeluxe, conn))
                {
                    using (SQLiteDataReader reader = cmdRentedDeluxe.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rentedDeluxe += Convert.ToInt32(reader["RentedDeluxe"]);
                            rateDeluxe = Convert.ToInt32(reader["RateID"]);
                        }
                    }
                }

                using (SQLiteCommand cmdRentedSuite = new SQLiteCommand(queryRentedSuite, conn))
                {
                    using (SQLiteDataReader reader = cmdRentedSuite.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rentedSuite += Convert.ToInt32(reader["RentedSuite"]);
                            rateSuite = Convert.ToInt32(reader["RateID"]);
                        }
                    }
                }

                // Fetch rates from Rate table
                string queryRates = "SELECT StandardRate, DeluxeRate, SuiteRate FROM Rate";
                int standardRate = 0, deluxeRate = 0, suiteRate = 0;

                using (SQLiteCommand cmdRates = new SQLiteCommand(queryRates, conn))
                {
                    using (SQLiteDataReader reader = cmdRates.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            standardRate = Convert.ToInt32(reader["StandardRate"]);
                            deluxeRate = Convert.ToInt32(reader["DeluxeRate"]);
                            suiteRate = Convert.ToInt32(reader["SuiteRate"]);
                        }
                    }
                }

                // Calculate Net Income and populate dataGridView2
                double netIncomeStandard = rentedStandard * standardRate;
                double netIncomeDeluxe = rentedDeluxe * deluxeRate;
                double netIncomeSuite = rentedSuite * suiteRate;

                double totalRevenue = netIncomeStandard + netIncomeDeluxe + netIncomeSuite;

                // Update TotalRevenue label
                TotalRevenue.Text = $"${totalRevenue.ToString("0.##")}";
                // Calculate occupancy rate
                double occupancyRateStandard = totalStandard == 0 ? 0 : (double)rentedStandard / totalStandard * 100;
                double occupancyRateDeluxe = totalDeluxe == 0 ? 0 : (double)rentedDeluxe / totalDeluxe * 100;
                double occupancyRateSuite = totalSuite == 0 ? 0 : (double)rentedSuite / totalSuite * 100;

                // Add rows to dataGridView2 with room counts, rented units, occupancy rate, and net income
                dataGridView2.Rows.Add("Standard", totalStandard, rentedStandard, occupancyRateStandard.ToString("0.##") + "%", netIncomeStandard);
                dataGridView2.Rows.Add("Deluxe", totalDeluxe, rentedDeluxe, occupancyRateDeluxe.ToString("0.##") + "%", netIncomeDeluxe);
                dataGridView2.Rows.Add("Suite", totalSuite, rentedSuite, occupancyRateSuite.ToString("0.##") + "%", netIncomeSuite);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell click events in dataGridView1
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell click events in dataGridView2
        }

        private void FemaleGuestTotal_Click(object sender, EventArgs e)
        {
            UpdateGuestCountLabels(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void MaleGuestTotal_Click(object sender, EventArgs e)
        {
            UpdateGuestCountLabels(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private int GetGuestCountByGender(string gender, DateTime dateFrom, DateTime dateTo)
        {
            int count = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT COUNT(*) AS Count FROM Guest " +
                               $"WHERE Sex = '{gender}' AND GuestID IN " +
                               $"(SELECT GuestID FROM Booking WHERE CreatedDate BETWEEN @DateFrom AND @DateTo)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
                    cmd.Parameters.AddWithValue("@DateTo", dateTo);

                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return count;

        }
        private void UpdateGuestCountLabels(DateTime dateFrom, DateTime dateTo)
        {
            int femaleCount = GetGuestCountByGender("Female", dateFrom, dateTo);
            int maleCount = GetGuestCountByGender("Male", dateFrom, dateTo);
            int adultsCount = GetAdultsCount(dateFrom, dateTo);
            int kidsCount = GetKidsCount(dateFrom, dateTo);
            int guestsCount = GetGuestsCount(dateFrom, dateTo);

            FemaleGuestTotal.Text = $"{femaleCount}";
            MaleGuestTotal.Text = $"{maleCount}";
            AdultsTotal.Text = $"{adultsCount}";
            KidsTotal.Text = $"{kidsCount}";
            GuestTotal.Text = $"{guestsCount}";

        }

        private int GetAdultsCount(DateTime dateFrom, DateTime dateTo)
        {
            int count = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SUM(NumberOfAdults) AS TotalAdults FROM Guest " +
                               "WHERE GuestID IN (SELECT GuestID FROM Booking WHERE CreatedDate BETWEEN @DateFrom AND @DateTo)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
                    cmd.Parameters.AddWithValue("@DateTo", dateTo);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        count = Convert.ToInt32(result);
                    }
                }
            }
            return count;
        }

        private int GetKidsCount(DateTime dateFrom, DateTime dateTo)
        {
            int count = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SUM(NumberOfKids) AS TotalKids FROM Guest " +
                               "WHERE GuestID IN (SELECT GuestID FROM Booking WHERE CreatedDate BETWEEN @DateFrom AND @DateTo)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
                    cmd.Parameters.AddWithValue("@DateTo", dateTo);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        count = Convert.ToInt32(result);
                    }
                }
            }
            return count;
        }

        private int GetGuestsCount(DateTime dateFrom, DateTime dateTo)
        {
            int count = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SUM(NumberOfGuest) AS TotalGuests FROM Guest " +
                               "WHERE GuestID IN (SELECT GuestID FROM Booking WHERE CreatedDate BETWEEN @DateFrom AND @DateTo)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
                    cmd.Parameters.AddWithValue("@DateTo", dateTo);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        count = Convert.ToInt32(result);
                    }
                }
            }
            return count;
        }

        private void TotalOccupancyRate_Click(object sender, EventArgs e)
        {
            UpdateOccupancyRateLabel();

        }
        private void UpdateOccupancyRateLabel()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Query to calculate total rented units
                string queryTotalRentedUnits = "SELECT COUNT(*) AS TotalRentedUnits FROM Booking";

                int totalRentedUnits = 0;

                using (SQLiteCommand cmdTotalRentedUnits = new SQLiteCommand(queryTotalRentedUnits, conn))
                {
                    totalRentedUnits = Convert.ToInt32(cmdTotalRentedUnits.ExecuteScalar());
                }

                // Query to calculate total rooms
                string queryTotalRooms = "SELECT COUNT(*) AS TotalRooms FROM Rooms";

                int totalRooms = 0;

                using (SQLiteCommand cmdTotalRooms = new SQLiteCommand(queryTotalRooms, conn))
                {
                    totalRooms = Convert.ToInt32(cmdTotalRooms.ExecuteScalar());
                }

                // Calculate occupancy rate
                double occupancyRate = totalRooms == 0 ? 0 : (double)totalRentedUnits / totalRooms * 100;

                // Display total occupancy rate in label
                TotalOccupancyRate.Text = $"{occupancyRate.ToString("0.##")}%";
            }
        }
        private void TotalRevenue_Click(object sender, EventArgs e)
        {

        }
        private void AdultsTotal_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateTimePicker1.Value.Date;
            DateTime dateTo = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1); // Adjust to end of the selected day

            // Update Guest data grid view
            LoadGuestData(dateFrom, dateTo);

            // Update Room data grid view
            LoadRoomData(dateFrom, dateTo);

            // Update guest count labels
            UpdateGuestCountLabels(dateFrom, dateTo);
        }

        private void LoadGuestData(DateTime dateFrom, DateTime dateTo)
        {
            dataGridView1.Rows.Clear(); // Clear existing rows

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT Guest.Name, Guest.Sex, Guest.Nationality, Guest.Contact
                         FROM Guest
                         INNER JOIN Booking ON Guest.GuestID = Booking.GuestID
                         WHERE Booking.CreatedDate BETWEEN @DateFrom AND @DateTo";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
                    cmd.Parameters.AddWithValue("@DateTo", dateTo);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["Name"], reader["Sex"], reader["Nationality"], reader["Contact"]);
                        }
                    }
                }
            }
        }

        private void LoadRoomData(DateTime dateFrom, DateTime dateTo)
        {
            dataGridView2.Rows.Clear(); // Clear existing rows

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Query to get room counts by type
                string queryStandard = "SELECT COUNT(*) AS TotalStandard FROM Rooms WHERE RoomType = 'Standard'";
                string queryDeluxe = "SELECT COUNT(*) AS TotalDeluxe FROM Rooms WHERE RoomType = 'Deluxe'";
                string querySuite = "SELECT COUNT(*) AS TotalSuite FROM Rooms WHERE RoomType = 'Suite'";

                int totalStandard = 0, totalDeluxe = 0, totalSuite = 0;

                using (SQLiteCommand cmdStandard = new SQLiteCommand(queryStandard, conn))
                {
                    totalStandard = Convert.ToInt32(cmdStandard.ExecuteScalar());
                }

                using (SQLiteCommand cmdDeluxe = new SQLiteCommand(queryDeluxe, conn))
                {
                    totalDeluxe = Convert.ToInt32(cmdDeluxe.ExecuteScalar());
                }

                using (SQLiteCommand cmdSuite = new SQLiteCommand(querySuite, conn))
                {
                    totalSuite = Convert.ToInt32(cmdSuite.ExecuteScalar());
                }

                // Query to get number of rented units (bookings) and rate by type within date range
                string queryRentedStandard = $"SELECT COUNT(*) AS RentedStandard " +
                                             $"FROM Booking " +
                                             $"WHERE RoomType = 'Standard' AND " +
                                             $"      CreatedDate BETWEEN @DateFrom AND @DateTo";

                string queryRentedDeluxe = $"SELECT COUNT(*) AS RentedDeluxe " +
                                           $"FROM Booking " +
                                           $"WHERE RoomType = 'Deluxe' AND " +
                                           $"      CreatedDate BETWEEN @DateFrom AND @DateTo";

                string queryRentedSuite = $"SELECT COUNT(*) AS RentedSuite " +
                                          $"FROM Booking " +
                                          $"WHERE RoomType = 'Suite' AND " +
                                          $"      CreatedDate BETWEEN @DateFrom AND @DateTo";

                int rentedStandard = 0, rentedDeluxe = 0, rentedSuite = 0;

                using (SQLiteCommand cmdRentedStandard = new SQLiteCommand(queryRentedStandard, conn))
                {
                    cmdRentedStandard.Parameters.AddWithValue("@DateFrom", dateFrom);
                    cmdRentedStandard.Parameters.AddWithValue("@DateTo", dateTo);

                    rentedStandard = Convert.ToInt32(cmdRentedStandard.ExecuteScalar());
                }

                using (SQLiteCommand cmdRentedDeluxe = new SQLiteCommand(queryRentedDeluxe, conn))
                {
                    cmdRentedDeluxe.Parameters.AddWithValue("@DateFrom", dateFrom);
                    cmdRentedDeluxe.Parameters.AddWithValue("@DateTo", dateTo);

                    rentedDeluxe = Convert.ToInt32(cmdRentedDeluxe.ExecuteScalar());
                }

                using (SQLiteCommand cmdRentedSuite = new SQLiteCommand(queryRentedSuite, conn))
                {
                    cmdRentedSuite.Parameters.AddWithValue("@DateFrom", dateFrom);
                    cmdRentedSuite.Parameters.AddWithValue("@DateTo", dateTo);

                    rentedSuite = Convert.ToInt32(cmdRentedSuite.ExecuteScalar());
                }

                // Fetch rates from Rate table
                string queryRates = "SELECT StandardRate, DeluxeRate, SuiteRate FROM Rate";
                int standardRate = 0, deluxeRate = 0, suiteRate = 0;

                using (SQLiteCommand cmdRates = new SQLiteCommand(queryRates, conn))
                {
                    using (SQLiteDataReader reader = cmdRates.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            standardRate = Convert.ToInt32(reader["StandardRate"]);
                            deluxeRate = Convert.ToInt32(reader["DeluxeRate"]);
                            suiteRate = Convert.ToInt32(reader["SuiteRate"]);
                        }
                    }
                }

                // Calculate Net Income and populate dataGridView2
                double netIncomeStandard = rentedStandard * standardRate;
                double netIncomeDeluxe = rentedDeluxe * deluxeRate;
                double netIncomeSuite = rentedSuite * suiteRate;

                double totalRevenue = netIncomeStandard + netIncomeDeluxe + netIncomeSuite;

                // Update TotalRevenue label
                TotalRevenue.Text = $"${totalRevenue.ToString("0.##")}";

                // Calculate occupancy rate
                double occupancyRateStandard = totalStandard == 0 ? 0 : (double)rentedStandard / totalStandard * 100;
                double occupancyRateDeluxe = totalDeluxe == 0 ? 0 : (double)rentedDeluxe / totalDeluxe * 100;
                double occupancyRateSuite = totalSuite == 0 ? 0 : (double)rentedSuite / totalSuite * 100;

                // Add rows to dataGridView2 with room counts, rented units, occupancy rate, and net income
                dataGridView2.Rows.Add("Standard", totalStandard, rentedStandard, occupancyRateStandard.ToString("0.##") + "%", netIncomeStandard);
                dataGridView2.Rows.Add("Deluxe", totalDeluxe, rentedDeluxe, occupancyRateDeluxe.ToString("0.##") + "%", netIncomeDeluxe);
                dataGridView2.Rows.Add("Suite", totalSuite, rentedSuite, occupancyRateSuite.ToString("0.##") + "%", netIncomeSuite);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
