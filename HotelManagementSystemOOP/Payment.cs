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
                             "DiscountCoupon VARCHAR(50), " +
                             "PaymentMethod VARCHAR(20), " +
                             "PaymentStatus VARCHAR(20))";
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
            // Debug message to confirm button click event
            Console.WriteLine("Save button clicked.");

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(con))
                {
                    try
                    {
                        // Debug message to confirm database connection
                        Console.WriteLine("Database connected.");

                        cmd.CommandText = "INSERT INTO Payments(DiscountCoupon, PaymentMethod, PaymentStatus) " +
                                          "VALUES (@discountcoupon, @paymentmethod, @paymentstatus)";

                        cmd.Parameters.AddWithValue("@discountcoupon", DiscountCoupon.Text);
                        cmd.Parameters.AddWithValue("@paymentmethod", PaymentMethodDDP.Text);
                        cmd.Parameters.AddWithValue("@paymentstatus", PaymetStatusDDP.Text);

                        cmd.ExecuteNonQuery();

                        // Debug message to confirm successful execution
                        Console.WriteLine("Data saved successfully.");
                        MessageBox.Show("Data saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        // Debug message to confirm exception
                        Console.WriteLine("Error: " + ex.Message);
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            this.Close();
        }

        private void DiscountCoupon_TextChanged(object sender, EventArgs e)
        {
            string couponInput = DiscountCoupon.Text.Trim();

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
        }
    }
    
}
