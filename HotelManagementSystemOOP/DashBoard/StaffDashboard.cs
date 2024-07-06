using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity.Core.Metadata.Edm;

namespace HotelManagementSystemOOP
{
    public partial class StaffDashboard : Form
    {
        private LogIn _LogIn;
        private DataTable dataTable;
        
        public StaffDashboard(LogIn logIn)
        {
            InitializeComponent();
            _LogIn = logIn;
            InitializeNavigationControl();
            SearchBarSD.TextChanged += SearchBarSD_TextChanged;
        }
        
        public StaffDashboard(Invoice invoice)
        {
            InitializeComponent();
            invoice = invoice;
            InitializeNavigationControl();
            SearchBarSD.TextChanged += SearchBarSD_TextChanged;
        }
        private BookingList BookingList;

        public StaffDashboard(BookingList bookingList)
        {
            InitializeComponent();
            BookingList = bookingList;
            InitializeNavigationControl();
            SearchBarSD.TextChanged += SearchBarSD_TextChanged;
        }

        public StaffDashboard(BookingPage bookingPage)
        {
            InitializeComponent();
            bookingPage = bookingPage;
            InitializeNavigationControl();
            SearchBarSD.TextChanged += SearchBarSD_TextChanged;
        }

        private void InitializeNavigationControl()
        {
            // Initialization of navigation controls can be added here if needed
        }

        private void StaffDashboard_Load(object sender, EventArgs e)
        {

            DisplayCompanyName();
            LoadData();
            UpdateArrivingCount();
            UpdateCreatedTodayCount();
            UpdateCurrentStayingCount();
            UpdateDepartingTodayCount();
           
        }

        private void LoadData()
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                {
                    connection.Open();
                    string selectQuery = "SELECT b.BookingID, g.Name, b.RoomType, b.RoomNumber, b.CheckInDate, b.CheckOutDate, b.Status, b.CreatedDate " +
                                         "FROM Booking b " +
                                         "JOIN Guest g ON b.GuestID = g.GuestID " +
                                         "WHERE b.Status != 'Arrived'"; // Exclude rows with 'Arrived' status

                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Filter data to show only today's check-ins
                            DateTime today = DateTime.Today;
                            DataTable filteredTable = dataTable.Clone();
                            foreach (DataRow row in dataTable.Rows)
                            {
                                DateTime checkInDate = DateTime.Parse(row["CheckInDate"].ToString());
                                if (checkInDate.Date == today)
                                {
                                    filteredTable.ImportRow(row);
                                }
                            }

                            dataGridView1.AutoGenerateColumns = true;
                            dataGridView1.DataSource = filteredTable;

                            // Optionally, set column headers
                            dataGridView1.Columns["Name"].HeaderText = "Guest Name";
                            dataGridView1.Columns["RoomNumber"].HeaderText = "Room Number";
                            dataGridView1.Columns["RoomType"].HeaderText = "Room Type";
                            dataGridView1.Columns["CheckInDate"].HeaderText = "Check In";
                            dataGridView1.Columns["CheckOutDate"].HeaderText = "Check Out";
                            dataGridView1.Columns["Status"].HeaderText = "Status";
                            dataGridView1.Columns["CreatedDate"].HeaderText = "Booked Date";

                            DataGridViewButtonColumn ArrivedButtonColumn = new DataGridViewButtonColumn();
                            ArrivedButtonColumn.Name = "ArriveButton";
                            ArrivedButtonColumn.HeaderText = "Arrived";
                            ArrivedButtonColumn.Text = "Arrived";
                            ArrivedButtonColumn.UseColumnTextForButtonValue = true;
                            dataGridView1.Columns.Add(ArrivedButtonColumn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SearchBarSD_TextChanged(object sender, EventArgs e)
        {
            FilterData(SearchBarSD.Text.Trim().ToLower());
        }

        private void FilterData(string searchTerm)
        {
            if (dataTable != null)
            {
                DataTable filteredTable = dataTable.Clone();
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["Name"].ToString().ToLower().Contains(searchTerm) ||
                        row["RoomType"].ToString().ToLower().Contains(searchTerm) ||
                        row["RoomNumber"].ToString().ToLower().Contains(searchTerm) ||
                        row["Status"].ToString().ToLower().Contains(searchTerm))
                    {
                        filteredTable.ImportRow(row);
                    }
                }
                dataGridView1.DataSource = filteredTable;
                // If no results found, show an empty DataTable
                if (filteredTable.Rows.Count == 0)
                {
                    dataGridView1.DataSource = null;
                }
            }
        }

        private void UpdateCreatedTodayCount()
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                {
                    connection.Open();

                    string countQuery = "SELECT COUNT(*) FROM Booking WHERE date(CreatedDate) = date('now')";
                    using (var command = new SQLiteCommand(countQuery, connection))
                    {
                        int totalCount = Convert.ToInt32(command.ExecuteScalar());
                        NewBookingTodayNumber.Text = $"{totalCount}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCurrentStayingCount()
        {
            try
            {
                int occupiedRoomCount = CountOccupiedRooms();

                // Update label
                CurrentStaying.Text = occupiedRoomCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CountOccupiedRooms()
        {
            int occupiedCount = 0;

            using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
            {
                connection.Open();

                string countQuery = "SELECT COUNT(*) FROM Rooms WHERE RoomStatus = 'Occupied'";
                using (var command = new SQLiteCommand(countQuery, connection))
                {
                    occupiedCount = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return occupiedCount;
        }

        private int CountTodaysArriving()
        {
            int bookingCount = 0;
            DateTime today = DateTime.Today;

            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime bookingDate = DateTime.Parse(row["BookingDate"].ToString());
                    if (bookingDate.Date == today)
                    {
                        bookingCount++;
                    }
                }
            }
            return bookingCount;
        }

        private void UpdateArrivingCount()
        {
            int todayArrivingCount = 0;
            DateTime today = DateTime.Today;

            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime checkInDate = DateTime.Parse(row["CheckInDate"].ToString());
                    if (checkInDate.Date == today)
                    {
                        todayArrivingCount++;
                    }
                }
            }

            ArrvingTodayNumber.Text = todayArrivingCount.ToString();
        }

        private void UpdateDepartingTodayCount()
        {
            int departingTodayCount = CountDepartingToday();
            DepartingTodayNumber.Text = departingTodayCount.ToString();
        }

        private int CountDepartingToday()
        {
            int departingTodayCount = 0;
            DateTime today = DateTime.Today;

            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime checkOutDate = DateTime.Parse(row["CheckOutDate"].ToString());
                    if (checkOutDate.Date == today)
                    {
                        departingTodayCount++;
                    }
                }
            }

            return departingTodayCount;
        }

        private void UpdateRoomStatus(string roomType, string roomNumber, string status)
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Rooms SET RoomStatus = @status WHERE RoomNumber = @roomNumber AND RoomType = @roomType";
                    using (var command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@roomNumber", roomNumber);
                        command.Parameters.AddWithValue("@roomType", roomType);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating RoomStatus: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookingPage BP = new BookingPage();
            BP.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _LogIn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuRoomButtonSD_Click(object sender, EventArgs e)
        {
            BookingList bookingList = new BookingList(this);
            bookingList.Show();
            this.Close();
        }

        private void MenuBookingButtonSD_Click(object sender, EventArgs e)
        {
            BookingPage bookingPage = new BookingPage(this);
            bookingPage.Show();
            this.Close();
        }

        private void HotelInfoViewbuttonDB_Click(object sender, EventArgs e)
        {
            HotelInfoView hotelInfoView = new HotelInfoView(this);
            hotelInfoView.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a button cell and the column index matches the "Arrived" button column
            if (e.ColumnIndex == dataGridView1.Columns["ArriveButton"].Index && e.RowIndex >= 0)
            {
                // Get the room number from the DataGridView
                string roomNumber = dataGridView1.Rows[e.RowIndex].Cells["RoomNumber"].Value.ToString();
                string roomType = dataGridView1.Rows[e.RowIndex].Cells["RoomType"].Value.ToString();

                // Update the RoomStatus in the Rooms table to "Occupied"
                UpdateRoomStatus(roomType, roomNumber, "Occupied");

                // Update the Booking Status to "Arrived" in the database
                string bookingId = dataGridView1.Rows[e.RowIndex].Cells["BookingID"].Value.ToString(); // Assuming you have a BookingID column
                UpdateBookingStatus(bookingId, "Arrived");

                // Update the "Current Staying" count
                UpdateCurrentStayingCount();

                // Update the "Arriving Today" count
                int arrivingTodayCount = Convert.ToInt32(ArrvingTodayNumber.Text);
                arrivingTodayCount--;
                ArrvingTodayNumber.Text = arrivingTodayCount.ToString();

                // Remove the row from the DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void UpdateBookingStatus(string bookingId, string status)
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Booking SET Status = @status WHERE BookingID = @bookingId";
                    using (var command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@bookingId", bookingId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Booking Status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // Placeholder method, can be left empty
        }

        private void BookingListPanelSD_Paint(object sender, PaintEventArgs e)
        {
            // Placeholder method, can be left empty
        }

        private void MenuDashboardButtonSD_Click(object sender, EventArgs e)
        {
            // Placeholder method, can be left empty
        }

        private void TodaysArrivingLabel_Click(object sender, EventArgs e)
        {

        }

        private void NewBookingNumber_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CurrentStaying_Click(object sender, EventArgs e)
        {

        }

        private void DepartingTodayNumber_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void HotelNameLabel_Click(object sender, EventArgs e)
        {
            DisplayCompanyName();
        }

        private void DisplayCompanyName()
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                {
                    connection.Open();

                    string selectQuery = "SELECT CompanyName FROM Hotel  ORDER BY HotelID"; // Assuming there's only one row in the Hotel table
                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        var companyName = command.ExecuteScalar()?.ToString();
                        if (!string.IsNullOrEmpty(companyName))
                        {
                            HotelNameLabel.Text = companyName;
                        }
                        else
                        {
                            HotelNameLabel.Text = "Company Name Not Found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching Company Name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}