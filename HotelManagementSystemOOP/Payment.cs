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
        private decimal originalRoomRate;

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
                              "PaymentMethod VARCHAR(20), " +
                              "PaymentStatus VARCHAR(20), " +
                              //"FOREIGN KEY(DiscountID) REFERENCES Discount(DiscountID), " +
                              "FOREIGN KEY(BookingID) REFERENCES Booking(BookingID))";
                SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                command.ExecuteNonQuery();
            }
        }

        private void InitializeFormControls()
        {
            DisplayBookingDetails();
            // Populate PaymentMethodDDP with payment methods
            PaymentMethodDDP.Items.Add("Cash");
            PaymentMethodDDP.Items.Add("Card");
            PaymentMethodDDP.Items.Add("E-Wallet");

            // Populate PaymetStatusDDP with payment status options
            // PaymetStatusDDP.Items.Add("Paid");
            //  PaymetStatusDDP.Items.Add("Not Paid");
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
            DisplayBookingDetails();
            CalculateAndDisplayStayDuration();
        }

        private void PaymentMethodDDP_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void SavePayment_Click(object sender, EventArgs e)
        {
            string paymentMethod = PaymentMethodDDP.Text;
            //string paymentStatus = PaymetStatusDDP.Text;

            // Validate required fields
            if (string.IsNullOrWhiteSpace(paymentMethod))
            {
                MessageBox.Show("Payment Method cannot be empty.");
                return;
            }

            // Retrieve the most recent BookingID (assuming this is the Booking to which the payment relates)
            long bookingID = GetMostRecentBookingID();
            if (bookingID == -1)
            {
                MessageBox.Show("No valid booking found to link the payment.");
                return;
            }

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(con))
                {
                    SQLiteTransaction transaction = con.BeginTransaction();

                    try
                    {
                        // Insert payment data
                        cmd.CommandText = "INSERT INTO Payments (BookingID, PaymentMethod, PaymentStatus) VALUES (@bookingID, @paymentMethod, @paymentStatus)";
                        cmd.Parameters.AddWithValue("@bookingID", bookingID);
                        cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                        //  cmd.Parameters.AddWithValue("@paymentStatus", paymentStatus);
                        cmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Payment saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            this.Close();
        }

        private long GetMostRecentBookingID()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand("SELECT BookingID FROM Booking ORDER BY BookingID DESC LIMIT 1", con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return (long)result;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        /* private void SavePayment_Click(object sender, EventArgs e)
         {
             //string discountCoupon = DiscountCoupon.Text.Trim();
             string paymentMethod = PaymentMethodDDP.Text;
             string paymentStatus = PaymetStatusDDP.Text;

             // Validate required fields
             if (string.IsNullOrWhiteSpace(paymentMethod) || string.IsNullOrWhiteSpace(paymentStatus))
             {
                 MessageBox.Show("Payment Method and Payment Status cannot be empty.");
                 return;
             }
        */
        //  int discountPercentage = 0;
        /* long discountId = 0;
         bool validDiscountCoupon = true;

         using (var con = new SQLiteConnection(cs))
         {
             con.Open();

             if (!string.IsNullOrWhiteSpace(discountCoupon))
             {
                 // Check if the discount coupon exists in the Discount table
                 using (var cmdCheckDiscount = new SQLiteCommand("SELECT DiscountID, Percentage FROM Discount WHERE DiscountCoupon = @discountCoupon", con))
                 {
                     cmdCheckDiscount.Parameters.AddWithValue("@discountCoupon", discountCoupon);
                     using (SQLiteDataReader reader = cmdCheckDiscount.ExecuteReader())
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
                 using (var cmdRetrieveBookingId = new SQLiteCommand("SELECT BookingID FROM Booking ORDER BY BookingID DESC LIMIT 1", con))
                 {
                     object result = cmdRetrieveBookingId.ExecuteScalar();
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
                     saveCmd.CommandText = "INSERT INTO Payments(BookingID, DiscountID, PaymentMethod, PaymentStatus) " +
                                           "VALUES (@bookingid, @discountid, @paymentmethod, @paymentstatus)";
                     saveCmd.Parameters.AddWithValue("@bookingid", bookingId);
                     saveCmd.Parameters.AddWithValue("@discountid", discountId);
                     saveCmd.Parameters.AddWithValue("@paymentmethod", paymentMethod);
                     saveCmd.Parameters.AddWithValue("@paymentstatus", paymentStatus);

                     saveCmd.ExecuteNonQuery();
                     MessageBox.Show($"Payment saved successfully. You accumulated {discountPercentage}% discount.");

                     // Calculate and display the discount percentage
                    // CalculateAndDisplayDiscountPercentage();
                 }

             }
         }
     }

     /*private void CalculateAndDisplayDiscountPercentage()
     {
         // Retrieve the original room rate
         decimal.TryParse(RoomRate.Text, out originalRoomRate);

         // Retrieve the total room rate after discounts and taxes (already displayed in TotalRoomRate.Text)

         decimal totalRoomRate;
         decimal.TryParse(TotalRoomRate.Text, out totalRoomRate);

         // Calculate the discount percentage
         decimal discountPercentage = ((originalRoomRate - totalRoomRate) / originalRoomRate) * 100;

         // Display the discount percentage
         TotalRoomRate.Text = $"Discount Percentage: {discountPercentage.ToString("0.##")}%";
     }
     */


        private void DisplayBookingDetails()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

                // Retrieve the most recent BookingID
                long bookingId;
                using (var cmdRetrieveBookingId = new SQLiteCommand("SELECT BookingID FROM Booking ORDER BY BookingID DESC LIMIT 1", con))
                {
                    object result = cmdRetrieveBookingId.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("No booking found.");
                        return;
                    }
                    bookingId = (long)result;
                }

                // Retrieve CheckInDate, CheckOutDate, CheckInTime, CheckOutTime, RoomNumber, RoomType, NumberOfGuest, and RoomRate
                string checkInDateStr, checkOutDateStr, checkInTimeStr, checkOutTimeStr, roomType;
                int roomNumber, numOfGuest;
                decimal roomRate = 0;
                using (var cmdRetrieveDetails = new SQLiteCommand("SELECT CheckInDate, CheckOutDate, CheckInTime, CheckOutTime, RoomNumber, RoomType, NumberOfGuest, Rate.StandardRate, Rate.DeluxeRate, Rate.SuiteRate " +
                                                                  "FROM Booking B " +
                                                                  "JOIN Guest G ON B.GuestID = G.GuestID " +
                                                                  "JOIN Rate ON B.RateID = Rate.RateID " +
                                                                  "WHERE B.BookingID = @bookingId", con))
                {
                    cmdRetrieveDetails.Parameters.AddWithValue("@bookingId", bookingId);
                    using (SQLiteDataReader reader = cmdRetrieveDetails.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            checkInDateStr = reader.GetString(0);
                            checkOutDateStr = reader.GetString(1);
                            checkInTimeStr = reader.GetString(2);
                            checkOutTimeStr = reader.GetString(3);
                            roomNumber = reader.GetInt32(4);
                            roomType = reader.GetString(5);
                            numOfGuest = reader.GetInt32(6); // Retrieve NumberOfGuest

                            // Determine the appropriate room rate based on RoomType
                            if (roomType == "Standard")
                            {
                                roomRate = reader.GetDecimal(7); // Retrieve StandardRate
                            }
                            else if (roomType == "Deluxe")
                            {
                                roomRate = reader.GetDecimal(8); // Retrieve DeluxeRate
                            }
                            else if (roomType == "Suite")
                            {
                                roomRate = reader.GetDecimal(9); // Retrieve SuiteRate
                            }

                            // Retrieve TotalTaxPercentage from the Tax table
                            decimal totalTaxPercentage = 0;
                            using (var cmdRetrieveTaxPercentage = new SQLiteCommand("SELECT SUM(TaxPercentage) FROM Tax", con))
                            {
                                object taxResult = cmdRetrieveTaxPercentage.ExecuteScalar();
                                if (taxResult != null && taxResult != DBNull.Value)
                                {
                                    totalTaxPercentage = Convert.ToDecimal(taxResult);
                                }
                            }

                            // Calculate TotalRoomRate based on duration and room rate including taxes
                            DateTime checkInDateTime = DateTime.ParseExact(checkInDateStr + " " + checkInTimeStr, "yyyy-MM-dd hh:mm tt", null);
                            DateTime checkOutDateTime = DateTime.ParseExact(checkOutDateStr + " " + checkOutTimeStr, "yyyy-MM-dd hh:mm tt", null);
                            TimeSpan duration = checkOutDateTime - checkInDateTime;

                            // Calculate total hours (considering partial days as full days)
                            double totalHours = Math.Ceiling(duration.TotalHours);

                            // Calculate total room rate including taxes
                            decimal totalRoomRate = (decimal)totalHours * roomRate + ((totalTaxPercentage / 100) * roomRate);

                            // Display retrieved values in textboxes
                            CheckInDate.Text = checkInDateStr;
                            CheckOutDate.Text = checkOutDateStr;
                            CheckInTime.Text = checkInTimeStr;
                            CheckOutTime.Text = checkOutTimeStr;
                            RoomNumber.Text = roomNumber.ToString();
                            RoomType.Text = roomType;
                            NumOfGuest.Text = numOfGuest.ToString();
                            RoomRate.Text = roomRate.ToString(); // Display RoomRate
                            TotalRoomRate.Text = totalRoomRate.ToString(); // Display TotalRoomRate

                            // Store the original room rate
                            originalRoomRate = roomRate;
                        }
                        else
                        {
                            MessageBox.Show("Booking details not found.");
                        }
                    }
                }
            }
        }

        private void DiscountCoupon_TextChanged(object sender, EventArgs e)
        {
        }

        private void CheckInDate_Click(object sender, EventArgs e)
        {

        }
        private void StayDuration_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, EventArgs e)
        {

        }

        private void CalculateAndDisplayStayDuration()
        {
            string stayDurationStr = CalculateStayDuration();
            StayDuration.Text = stayDurationStr;
        }
        private string CalculateStayDuration()
        {
            string stayDurationStr = "";

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

                // Retrieve the most recent BookingID
                long bookingId;
                using (var cmdRetrieveBookingId = new SQLiteCommand("SELECT BookingID FROM Booking ORDER BY BookingID DESC LIMIT 1", con))
                {
                    object result = cmdRetrieveBookingId.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("No booking found.");
                        return stayDurationStr;
                    }
                    bookingId = (long)result;
                }

                // Retrieve CheckInDate, CheckOutDate, CheckInTime, and CheckOutTime for the most recent booking
                string checkInDateStr, checkOutDateStr, checkInTimeStr, checkOutTimeStr;
                using (var cmdRetrieveDates = new SQLiteCommand("SELECT CheckInDate, CheckOutDate, CheckInTime, CheckOutTime FROM Booking WHERE BookingID = @bookingId", con))
                {
                    cmdRetrieveDates.Parameters.AddWithValue("@bookingId", bookingId);
                    using (SQLiteDataReader reader = cmdRetrieveDates.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            checkInDateStr = reader.GetString(0);
                            checkOutDateStr = reader.GetString(1);
                            checkInTimeStr = reader.GetString(2);
                            checkOutTimeStr = reader.GetString(3);

                            // Parse dates and times
                            DateTime checkInDateTime, checkOutDateTime;
                            if (DateTime.TryParseExact(checkInDateStr + " " + checkInTimeStr, "yyyy-MM-dd hh:mm tt", null, System.Globalization.DateTimeStyles.None, out checkInDateTime) &&
                                DateTime.TryParseExact(checkOutDateStr + " " + checkOutTimeStr, "yyyy-MM-dd hh:mm tt", null, System.Globalization.DateTimeStyles.None, out checkOutDateTime))
                            {
                                // Calculate duration
                                TimeSpan duration = checkOutDateTime - checkInDateTime;

                                // Format the duration
                                int days = duration.Days;
                                int hours = duration.Hours;

                                stayDurationStr = $"{days} days and {hours} hours";
                            }
                            else
                            {
                                MessageBox.Show("Error parsing dates or times.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Booking details not found.");
                        }
                    }
                }
            }

            return stayDurationStr;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // string discountCoupon = DiscountCoupon.Text.Trim();
            string paymentMethod = PaymentMethodDDP.Text;
            // string paymentStatus = PaymetStatusDDP.Text;
            if (string.IsNullOrWhiteSpace(paymentMethod))
            {
                MessageBox.Show("Payment Method cannot be empty.");
                return;
            }

            int discountPercentage = 0;
            long discountId = 0;
            bool validDiscountCoupon = true;
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}