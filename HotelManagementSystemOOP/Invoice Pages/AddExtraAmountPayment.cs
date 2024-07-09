using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HotelManagementSystemOOP
{
    public partial class AddExtraAmountPayment : Form
    {
        private int bookingID;
        private string roomType;
        private DateTime checkOutDate;
        private int rateID;
        private StandardRoomBookedListTab standardRoomBookedList;
        private DeluxeRoomBookedListTab deluxeRoomBookedListTab;

        public AddExtraAmountPayment(int bookingID, string roomType, DateTime checkOutDate, int rateID)
        {
            InitializeComponent();

            // Store the passed parameters in private fields
            this.bookingID = bookingID;
            this.roomType = roomType;
            this.checkOutDate = checkOutDate;
            this.rateID = rateID;

            // Display initial values if needed
            // For example:
            //labelBookingID.Text = bookingID.ToString();
            //  labelRoomType.Text = roomType;
            //labelCheckOutDate.Text = checkOutDate.ToString("yyyy-MM-dd");
            // Set DateTimePicker format
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateTime extendedDate = dateTimePicker1.Value;

            try
            {
                using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                {
                    connection.Open();

                    // Update ExtendDate in Booking table based on BookingID and CheckOutDate
                    string updateQuery = @"UPDATE Booking 
                                           SET ExtendDate = @ExtendedDate 
                                           WHERE BookingID = @BookingID 
                                           AND CheckOutDate = @CheckOutDate";

                    using (var command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ExtendedDate", extendedDate.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@BookingID", bookingID); // Ensure bookingID is correctly passed
                        command.Parameters.AddWithValue("@CheckOutDate", checkOutDate.ToString("yyyy-MM-dd")); // Ensure checkOutDate is correctly passed
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Extended date saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddExtraAmountPayment_Load(object sender, EventArgs e)
        {

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SaveEtraAddAmount_Click(object sender, EventArgs e)
        {
            DateTime extendedDate = dateTimePicker1.Value;

            try
            {
                using (var connection = new SQLiteConnection("Data Source=TOTOO.db"))
                {
                    connection.Open();

                    // Update ExtendDate in Booking table
                    string updateQuery = @"UPDATE Booking 
                                           SET ExtendDate = @ExtendedDate 
                                           WHERE BookingID = @BookingID";

                    using (var command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ExtendedDate", extendedDate.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@BookingID", bookingID);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Extended date saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close(); // Close the form after saving
        }
    }
}
   
