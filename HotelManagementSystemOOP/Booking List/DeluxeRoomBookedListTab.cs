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
    public partial class DeluxeRoomBookedListTab : UserControl
    {
        public DeluxeRoomBookedListTab()
        {
            InitializeComponent();
        }

        private void DeluxeRoomBookedListTab_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                {
                    connection.Open();

                    string selectQuery = @"SELECT g.Name, b.RoomNumber, b.CheckInDate, b.CheckOutDate 
                                   FROM Booking b 
                                   JOIN Guest g ON b.GuestID = g.GuestID
                                   WHERE b.RoomType = 'Deluxe'";

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
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["CheckoutButton"].Index)
            {
                // Prompt user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to check out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Retrieve room information from the DataGridView
                    string roomNumber = dataGridView1.Rows[e.RowIndex].Cells["RoomNumber"].Value.ToString();
                    string roomType = "Deluxe"; // Assuming you have the RoomType available

                    try
                    {
                        using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                        {
                            connection.Open();

                            string updateQuery = @"UPDATE Rooms 
                                          SET RoomStatus = 'Unclean' 
                                          WHERE RoomNumber = @RoomNumber 
                                          AND RoomType = @RoomType";

                            using (var command = new SQLiteCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                                command.Parameters.AddWithValue("@RoomType", roomType);
                                command.ExecuteNonQuery();
                            }
                        }

                        // Remove row from DataGridView
                        dataGridView1.Rows.RemoveAt(e.RowIndex);

                        // Navigate to the Invoice form or another form
                        Invoice invoice = new Invoice(this); // Pass any necessary parameters
                        invoice.Show(); // Show the form

                        // Close the current form (DeluxeRoomBookedListTab UserControl)
                        Form parentForm = this.FindForm();
                        parentForm.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ExtendButton"].Index)
            {
                // Handle extension button action here
            }

        }
    }
}
