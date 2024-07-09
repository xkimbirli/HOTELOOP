using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystemOOP
{
    public partial class SuiteRoomBookedListTab : UserControl
    {
        private DataTable dataTable; // Declare dataTable at the class level

        public SuiteRoomBookedListTab()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void SuiteRoomBookedListTab_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                {
                    connection.Open();
                    string selectQuery = @"SELECT g.Name, b.RoomNumber, b.CheckInDate, b.CheckOutDate 
                                           FROM Booking b 
                                           JOIN Guest g ON b.GuestID = g.GuestID
                                           JOIN Rooms r ON b.RoomNumber = r.RoomNumber
                                           WHERE b.RoomType = 'Suite' 
                                             AND r.RoomStatus = 'Occupied'
                                             AND b.Status = 'Arrived'";

                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            dataTable = new DataTable(); // Initialize dataTable
                            adapter.Fill(dataTable);

                            // Automatically generate columns
                            dataGridView1.AutoGenerateColumns = true;
                            dataGridView1.DataSource = dataTable;

                            // Optionally, set column headers
                            dataGridView1.Columns["Name"].HeaderText = "Guest Name";
                            dataGridView1.Columns["RoomNumber"].HeaderText = "Room Number";
                            dataGridView1.Columns["CheckInDate"].HeaderText = "Check In";
                            dataGridView1.Columns["CheckOutDate"].HeaderText = "Check Out";

                            // Add Checkout button column
                            DataGridViewButtonColumn checkoutButtonColumn = new DataGridViewButtonColumn();
                            checkoutButtonColumn.Name = "CheckoutButton";
                            checkoutButtonColumn.HeaderText = "Check Out";
                            checkoutButtonColumn.Text = "Check Out";
                            checkoutButtonColumn.UseColumnTextForButtonValue = true;
                            dataGridView1.Columns.Add(checkoutButtonColumn);

                            // Add Extend button column
                            DataGridViewButtonColumn extendButtonColumn = new DataGridViewButtonColumn();
                            extendButtonColumn.Name = "ExtendButton";
                            extendButtonColumn.HeaderText = "Extend";
                            extendButtonColumn.Text = "Extend";
                            extendButtonColumn.UseColumnTextForButtonValue = true;
                            dataGridView1.Columns.Add(extendButtonColumn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "CheckoutButton" ||
                    dataGridView1.Columns[e.ColumnIndex].Name == "ExtendButton")
                {
                    e.CellStyle.BackColor = SystemColors.ControlDarkDark;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns["CheckoutButton"] != null && e.ColumnIndex == dataGridView1.Columns["CheckoutButton"].Index)
            {
                string roomNumber = dataGridView1.Rows[e.RowIndex].Cells["RoomNumber"].Value?.ToString();
                string guestName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                string checkInDate = dataGridView1.Rows[e.RowIndex].Cells["CheckInDate"].Value?.ToString();
                string checkOutDate = dataGridView1.Rows[e.RowIndex].Cells["CheckOutDate"].Value?.ToString();
                string roomType = "Suite";

                try
                {
                    using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                    {
                        connection.Open();
                        // Fetch guest details
                        string guestDetailsQuery = @"SELECT Contact, Email, NumberOfKids, NumberOfAdults 
                                            FROM Guest 
                                             WHERE Name = @GuestName";
                        string guestPhoneNumber = string.Empty;
                        string guestEmail = string.Empty;
                        int guestKidsNum = 0;
                        int guestAdultNum = 0;

                        using (var command = new SQLiteCommand(guestDetailsQuery, connection))
                        {
                            command.Parameters.AddWithValue("@GuestName", guestName);

                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    guestPhoneNumber = reader["Contact"].ToString();
                                    guestEmail = reader["Email"].ToString();
                                    guestKidsNum = Convert.ToInt32(reader["NumberOfKids"]);
                                    guestAdultNum = Convert.ToInt32(reader["NumberOfAdults"]);
                                }
                            }
                        }

                        // Fetch booking ID
                        string bookingIDQuery = @"SELECT BookingID 
                                          FROM Booking 
                                          WHERE RoomNumber = @RoomNumber 
                                          AND RoomType = @RoomType 
                                          AND GuestID = (SELECT GuestID FROM Guest WHERE Name = @GuestName)";

                        int bookingID = 0;
                        using (var command = new SQLiteCommand(bookingIDQuery, connection))
                        {
                            command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                            command.Parameters.AddWithValue("@RoomType", roomType);
                            command.Parameters.AddWithValue("@GuestName", guestName);
                            bookingID = Convert.ToInt32(command.ExecuteScalar());
                        }

                        // Update RoomStatus in Rooms table
                        string updateRoomStatusQuery = @"UPDATE Rooms 
                                                 SET RoomStatus = 'Unclean' 
                                                 WHERE RoomNumber = @RoomNumber 
                                                 AND RoomType = @RoomType";
                        // Update Status in Booking table
                        string updateBookingStatusQuery = @"UPDATE Booking 
                                                            SET Status = 'CheckOut' 
                                                             WHERE RoomNumber = @RoomNumber 
                                                            AND RoomType = @RoomType ";//AND GuestID = (SELECT GuestID FROM Guest WHERE Name = @GuestName
                        using (var command = new SQLiteCommand(updateBookingStatusQuery, connection))
                        {
                            command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                            command.Parameters.AddWithValue("@RoomType", roomType);
                            command.ExecuteNonQuery();
                        }
                        // Pass room and guest information to Invoice form

                        Invoice invoice = new Invoice(guestName, guestPhoneNumber, guestEmail, guestKidsNum, guestAdultNum,

                                                      bookingID, roomType, roomNumber, DateTime.Parse(checkInDate), DateTime.Parse(checkOutDate));

                        invoice.Show(); // Show the form



                        // Close the current form (StandardRoomBookedListTab UserControl)

                        Form parentForm = this.FindForm();

                        parentForm.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.RowIndex >= 0 && dataGridView1.Columns["ExtendButton"] != null && e.ColumnIndex == dataGridView1.Columns["ExtendButton"].Index)
            {
                {// Handle Extend button click

                    string roomNumber = dataGridView1.Rows[e.RowIndex].Cells["RoomNumber"].Value?.ToString();

                    string guestName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value?.ToString();



                    try

                    {

                        using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))

                        {

                            connection.Open();



                            // Fetch additional booking details

                            string bookingDetailsQuery = @"

                                                     SELECT 

                                                      b.BookingID, 

                                                      b.RoomType, 

                                                      b.CheckOutDate, 

                                                      ra.RateID

                                                         FROM 

                                                         Booking b

                                                      JOIN 

                                                       Rate ra ON b.RateID = ra.RateID

                                                      WHERE 

                                                      b.RoomNumber = @RoomNumber";



                            int bookingID = 0;

                            string roomType = "";

                            DateTime checkOutDate = DateTime.MinValue;

                            int rateID = 0;



                            using (var command = new SQLiteCommand(bookingDetailsQuery, connection))

                            {

                                command.Parameters.AddWithValue("@RoomNumber", roomNumber);

                                using (var reader = command.ExecuteReader())

                                {

                                    if (reader.Read())

                                    {

                                        bookingID = Convert.ToInt32(reader["BookingID"]);

                                        roomType = reader["RoomType"].ToString();

                                        checkOutDate = Convert.ToDateTime(reader["CheckOutDate"]);

                                        rateID = Convert.ToInt32(reader["RateID"]);

                                    }

                                }

                            }



                            // Example: Navigate to AddExtraAmountPayment form and pass data

                            AddExtraAmountPayment extraAmountPaymentForm = new AddExtraAmountPayment(bookingID, roomType, checkOutDate, rateID);

                            extraAmountPaymentForm.Show();



                            // Close the current form (StandardRoomBookedListTab UserControl)

                            Form parentForm = this.FindForm();

                            parentForm.Close();

                        }

                    }

                    catch (Exception ex)

                    {

                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }





                }
            }
        }

        public void PerformSearch(string guestName, string roomNumber)
        {
            try
            {
                DataTable filteredTable = dataTable.Copy(); // Create a copy to avoid modifying original data
                filteredTable.DefaultView.RowFilter = $"Name LIKE '%{guestName}%' AND RoomNumber LIKE '%{roomNumber}%'";
                dataGridView1.DataSource = filteredTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchSuite_TextChanged(object sender, EventArgs e)
        {
            FilterData(SearchSuite.Text.Trim().ToLower());
        }

        private void FilterData(string searchTerm)
        {
            try
            {
                if (dataTable != null)
                {
                    DataTable filteredTable = dataTable.Clone(); // Create a clone of the structure without data

                    // Filter rows based on guest name or room number
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["Name"].ToString().ToLower().Contains(searchTerm) ||
                            row["RoomNumber"].ToString().ToLower().Contains(searchTerm))
                        {
                            filteredTable.ImportRow(row); // Import matching rows to the new table
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}