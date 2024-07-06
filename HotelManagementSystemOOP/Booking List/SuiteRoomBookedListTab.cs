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

namespace HotelManagementSystemOOP
{
    public partial class SuiteRoomBookedListTab : UserControl
    {
        public SuiteRoomBookedListTab()
        {
            InitializeComponent();
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
                                   WHERE b.RoomType = 'Suite' AND r.RoomStatus = 'Occupied'
                                             AND b.Status = 'Arrived'";


                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Automatically generate columns
                            dataGridView1.AutoGenerateColumns = true;
                            dataGridView1.DataSource = dataTable;

                            // Optionally, set column headers
                            dataGridView1.Columns["Name"].HeaderText = "Guest Name";
                            dataGridView1.Columns["RoomNumber"].HeaderText = "Room Number";
                            dataGridView1.Columns["CheckInDate"].HeaderText = "Check In";
                            dataGridView1.Columns["CheckOutDate"].HeaderText = "Check Out";

                            // Add CheckOut button column
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.Columns["CheckoutButton"] != null && e.ColumnIndex == dataGridView1.Columns["CheckoutButton"].Index)
            {
                // Retrieve room information from the DataGridView
                string roomNumber = dataGridView1.Rows[e.RowIndex].Cells["RoomNumber"].Value?.ToString();
                string guestName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                string checkInDate = dataGridView1.Rows[e.RowIndex].Cells["CheckInDate"].Value?.ToString();
                string checkOutDate = dataGridView1.Rows[e.RowIndex].Cells["CheckOutDate"].Value?.ToString();
                string roomType = "Suite"; // Set correct room type

                try
                {
                    using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                    {
                        connection.Open();

                        // Update RoomStatus in Rooms table
                        string updateRoomStatusQuery = @"UPDATE Rooms 
                                                         SET RoomStatus = 'Unclean' 
                                                         WHERE RoomNumber = @RoomNumber 
                                                         AND RoomType = @RoomType";

                        using (var command = new SQLiteCommand(updateRoomStatusQuery, connection))
                        {
                            command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                            command.Parameters.AddWithValue("@RoomType", roomType);
                            command.ExecuteNonQuery();
                        }

                        // Update Status in Booking table
                        string updateBookingStatusQuery = @"UPDATE Booking 
                                                            SET Status = 'CheckOut' 
                                                            WHERE RoomNumber = @RoomNumber 
                                                            AND RoomType = @RoomType 
                                                            ";

                        using (var command = new SQLiteCommand(updateBookingStatusQuery, connection))
                        {
                            command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                            command.Parameters.AddWithValue("@RoomType", roomType);
                            command.Parameters.AddWithValue("@GuestName", guestName);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Pass room and guest information to Invoice form
                    Invoice invoice = new Invoice(this);
                    invoice.Show(); // Show the form

                    // Close the current form (SuiteRoomBookedListTab UserControl)
                    Form parentForm = this.FindForm();
                    parentForm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.RowIndex >= 0 && dataGridView1.Columns["ExtendButton"] != null && e.ColumnIndex == dataGridView1.Columns["ExtendButton"].Index)
            {
                // Handle extension button action here
            }
        }


    }
}