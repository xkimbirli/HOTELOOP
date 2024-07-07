using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class Payment : Form
    {
        string path = "TOTOO.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";

        private BookingForm bookingForm;

        public Payment(BookingForm bookingForm)
        {
            InitializeComponent();
            this.bookingForm = bookingForm;
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
            }

            using (var sqlite = new SQLiteConnection(cs))
            {
                sqlite.Open();
                string sql = "CREATE TABLE IF NOT EXISTS Payments(" +
                              "PaymentID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                              "BookingID INTEGER, " +
                              "DiscountID INTEGER, " +
                              "DiscountCoupon VARCHAR(50), " +
                              "PaymentMethod VARCHAR(20), " +
                              "PaymentStatus VARCHAR(20), " +
                              "FOREIGN KEY(DiscountID) REFERENCES Discount(DiscountID), " +
                              "FOREIGN KEY(BookingID) REFERENCES Booking(BookingID))";
                SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                command.ExecuteNonQuery();
            }
        }

        private void InitializeFormControls()
        {
            // Populate PaymentMethodDDP with payment methods
            PaymentMethodDDP.Items.Add("Cash");
            PaymentMethodDDP.Items.Add("Card");
            PaymentMethodDDP.Items.Add("E-Wallet");

            // Populate PaymetStatusDDP with payment status options
            PaymetStatusDDP.Items.Add("Paid");
            PaymetStatusDDP.Items.Add("Not Paid");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call the method to delete the most recent booking
            bookingForm.DeleteRecentBooking();
            this.Close();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            InitializeFormControls();
            Create_db();
        }

        private void PaymentMethodDDP_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void SavePayment_Click(object sender, EventArgs e)
        {
            string discountCoupon = DiscountCoupon.Text.Trim();
            string paymentMethod = PaymentMethodDDP.Text;
            string paymentStatus = PaymetStatusDDP.Text;

            // Validate required fields
            if (string.IsNullOrWhiteSpace(paymentMethod) || string.IsNullOrWhiteSpace(paymentStatus))
            {
                MessageBox.Show("Payment Method and Payment Status cannot be empty.");
                return;
            }

            int discountPercentage = 0;
            long discountId = 0;
            bool validDiscountCoupon = true;

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

                if (!string.IsNullOrWhiteSpace(discountCoupon))
                {
                    using (var cmd = new SQLiteCommand("SELECT DiscountID, Percentage FROM Discount WHERE DiscountCoupon = @discountCoupon", con))
                    {
                        cmd.Parameters.AddWithValue("@discountCoupon", discountCoupon);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                discountId = reader.GetInt64(0);
                                discountPercentage = reader.GetInt32(1);
                            }
                            else
                            {
                                MessageBox.Show("Discount coupon not found in database. Please enter a valid discount coupon.");
                                validDiscountCoupon = false;
                            }
                        }
                    }
                }

                if (validDiscountCoupon)
                {
                    // Retrieve the most recent BookingID
                    long bookingId;
                    using (var cmd = new SQLiteCommand("SELECT BookingID FROM Booking ORDER BY BookingID DESC LIMIT 1", con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("No booking found.");
                            return;
                        }
                        bookingId = (long)result;
                    }

                    // Save the payment details including discount coupon
                    using (var saveCmd = new SQLiteCommand(con))
                    {
                        saveCmd.CommandText = "INSERT INTO Payments(BookingID, DiscountID, DiscountCoupon, PaymentMethod, PaymentStatus) " +
                                              "VALUES (@bookingid, @discountid, @discountcoupon, @paymentmethod, @paymentstatus)";
                        saveCmd.Parameters.AddWithValue("@bookingid", bookingId);
                        saveCmd.Parameters.AddWithValue("@discountid", discountId);
                        saveCmd.Parameters.AddWithValue("@discountcoupon", discountCoupon);
                        saveCmd.Parameters.AddWithValue("@paymentmethod", paymentMethod);
                        saveCmd.Parameters.AddWithValue("@paymentstatus", paymentStatus);

                        saveCmd.ExecuteNonQuery();
                        MessageBox.Show($"Payment saved successfully. You accumulated {discountPercentage}% discount.");
                    }
                    this.Close();
                }
            }
        }
        private void DiscountCoupon_TextChanged(object sender, EventArgs e)
        {
        }
        }
}
