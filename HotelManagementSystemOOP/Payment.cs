using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.CompilerServices;

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
                              "FOREIGN KEY(BookingID) REFERENCES Booking(BookingID))";
                SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                command.ExecuteNonQuery();
            }
        }
        private void InitializeFormControls()
        {
            // Populate RoomTypeDropdownBF with room types
            PaymentMethodDDP.Items.Add("Cash");
            PaymentMethodDDP.Items.Add("Card");
            PaymentMethodDDP.Items.Add("E-Wallet");

            // Populate SexDropdownBF with sex options
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

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

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

                // Check if the discount coupon exists in Discounts table
                if (!string.IsNullOrWhiteSpace(discountCoupon))
                {
                    string query = "SELECT Percentage FROM Discount WHERE DiscountCoupon = @discountcoupon";
                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@discountcoupon", discountCoupon);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int accumulatedPercentage = Convert.ToInt32(result);
                            MessageBox.Show($"You accumulated {accumulatedPercentage}%.");

                            // Save the payment details including discount coupon
                            using (var saveCmd = new SQLiteCommand(con))
                            {
                                saveCmd.CommandText = "INSERT INTO Payments(BookingID, DiscountCoupon, PaymentMethod, PaymentStatus) " +
                                                      "VALUES (@bookingid, @discountcoupon, @paymentmethod, @paymentstatus)";
                                saveCmd.Parameters.AddWithValue("@bookingid", bookingId);
                                saveCmd.Parameters.AddWithValue("@discountcoupon", discountCoupon);
                                saveCmd.Parameters.AddWithValue("@paymentmethod", paymentMethod);
                                saveCmd.Parameters.AddWithValue("@paymentstatus", paymentStatus);

                                saveCmd.ExecuteNonQuery();
                                MessageBox.Show("Payment saved successfully.");
                            }

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Discount coupon not found in database. Please enter a valid discount coupon.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a discount coupon.");
                }
            }
        }



        private void DiscountCoupon_TextChanged(object sender, EventArgs e)
        {
            /* string couponInput = DiscountCoupon.Text.Trim();

             if (string.IsNullOrWhiteSpace(couponInput))
             {
                 return; // Avoid unnecessary database calls when input is empty
             }

             using (var con = new SQLiteConnection(cs))
             {
                 con.Open();

                 // Query to check if the discount coupon exists in the database
                 string query = "SELECT COUNT(*) FROM Discount WHERE DiscountCoupon = @couponInput";

                 using (var cmd = new SQLiteCommand(query, con))
                 {
                     cmd.Parameters.AddWithValue("@couponInput", couponInput);

                     int count = Convert.ToInt32(cmd.ExecuteScalar());

                     if (count > 0)
                     {
                         // Coupon exists in the database
                         MessageBox.Show("Discount coupon is valid!");
                     }
                     else
                     {
                         // Coupon does not exist in the database
                         MessageBox.Show("Invalid discount coupon.");
                     }
                 }
             }
         }*/
        }
    }
}