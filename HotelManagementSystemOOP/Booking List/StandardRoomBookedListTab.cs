using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class StandardRoomBookedListTab : UserControl
    {
        public StandardRoomBookedListTab()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void StandardRoomBookedListTab_Load(object sender, EventArgs e)
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
                                           WHERE b.RoomType = 'Standard' AND r.RoomStatus = 'Occupied'";

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
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["CheckoutButton"].Index)
            {
                // Retrieve room information from the DataGridView
                string roomNumber = dataGridView1.Rows[e.RowIndex].Cells["RoomNumber"].Value.ToString();
                string guestName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string checkInDate = dataGridView1.Rows[e.RowIndex].Cells["CheckInDate"].Value.ToString();
                string checkOutDate = dataGridView1.Rows[e.RowIndex].Cells["CheckOutDate"].Value.ToString();
                string roomType = "Standard"; // Set correct room type

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

                    // Pass room and guest information to Invoice form
                    Invoice invoice = new Invoice(this);
                    invoice.Show(); // Show the form

                    // Close the current form (StandardRoomBookedListTab UserControl)
                    Form parentForm = this.FindForm();
                    parentForm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ExtendButton"].Index)
            {
                // Handle extension button action here
            }
        }


    }
}
