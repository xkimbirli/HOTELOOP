using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class Invoice : Form
    {
        private string cs = @"URI=file:" + Path.Combine(Application.StartupPath, "TOTOO.db");
        private SQLiteConnection con;
        private StandardRoomBookedListTab standardRoomBookedListTab;
        private SuiteRoomBookedListTab suiteRoombookedListTab;
        private DeluxeRoomBookedListTab deluxeRoomBookedListTab;

        // Constructor for Standard Room
        public Invoice(StandardRoomBookedListTab standardRoomBookedListTab)
        {
            InitializeComponent();
            this.standardRoomBookedListTab = standardRoomBookedListTab;
            con = new SQLiteConnection(cs);
        }

        // Constructor for Suite Room
        public Invoice(SuiteRoomBookedListTab suiteRoombookedListTab)
        {
            InitializeComponent();
            this.suiteRoombookedListTab = suiteRoombookedListTab;
            con = new SQLiteConnection(cs);
        }

        // Constructor for Deluxe Room
        public Invoice(DeluxeRoomBookedListTab deluxeRoomBookedListTab)
        {
            InitializeComponent();
            this.deluxeRoomBookedListTab = deluxeRoomBookedListTab;
            con = new SQLiteConnection(cs);
        }

        public Invoice(string guestName, string guestPhoneNumber, string guestEmail, int guestKidsNum, int guestAdultNum,
                   int bookingID, string roomType, string roomNumber, DateTime checkInDate, DateTime checkOutDate)
        {
            InitializeComponent();
            con = new SQLiteConnection(cs);

            // Set the text boxes with the passed data
            GuestName.Text = guestName;
            GuestPhoneNumber.Text = guestPhoneNumber;
            GuestEmail.Text = guestEmail;
            GuestKidsNum.Text = guestKidsNum.ToString();
            GuestAdultNum.Text = guestAdultNum.ToString();
            BookingID.Text = bookingID.ToString();
            RoomType.Text = roomType;
            RoomNumber.Text = roomNumber;
            label13.Text = checkInDate.ToString("yyyy-MM-dd");
            CheckOutDate.Text = checkOutDate.ToString("yyyy-MM-dd");
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            LoadInvoiceData();
            Load_Tax();
            DisplayBookingDetails();
            CalculateAndDisplayStayDuration();
        }

        public void Load_Tax()
        {
            try
            {
                con.Open();

                string selectQuery = "SELECT t.TaxName, t.TaxDescription, t.TaxPercentage FROM Tax t";

                using (var command = new SQLiteCommand(selectQuery, con))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public void LoadInvoiceData()
        {
            try
            {
                con.Open();

                string selectQuery = "SELECT CompanyName, Location, ContactNumber, EmailAddress FROM Hotel";

                using (var command = new SQLiteCommand(selectQuery, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CompanyName.Text = reader["CompanyName"].ToString();
                            Address.Text = reader["Location"].ToString();
                            PhoneNumber.Text = reader["ContactNumber"].ToString();
                            Email.Text = reader["EmailAddress"].ToString();
                        }
                    }
                }

                // Query to fetch payment details
                string selectPaymentQuery = "SELECT PaymentStatus, PaymentMethod FROM Payments WHERE BookingID = @BookingID";

                using (var paymentCommand = new SQLiteCommand(selectPaymentQuery, con))
                {
                    paymentCommand.Parameters.AddWithValue("@BookingID", int.Parse(BookingID.Text));

                    using (var paymentReader = paymentCommand.ExecuteReader())
                    {
                        if (paymentReader.Read())
                        {
                            PaymentStatus.Text = paymentReader["PaymentStatus"].ToString();
                            PaymentMehod.Text = paymentReader["PaymentMethod"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No payment details found for the provided BookingID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        /*   private void AddExtraPayment_Click(object sender, EventArgs e)
       {
           AddExtraAmountPayment addExtraAmountPayment = new AddExtraAmountPayment(this);
           addExtraAmountPayment.Show();
       }
        */
        private void ExitButtonCheckOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            StaffDashboard staffdashboard = new StaffDashboard(this);
            staffdashboard.Show();
            this.Close();
        }
        private void GuestAdultNum_Click(object sender, EventArgs e)
        {

        }

        private void GuestEmail_Click(object sender, EventArgs e)
        { }
        private void panel1_Paint(object sender, EventArgs e)
        { }
        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        { }
        private void label21_Click(object sender, EventArgs e)
        { }
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


                            TotalAmount.Text = totalRoomRate.ToString(); // Display TotalRoomRate

                            // Store the original room rate

                        }
                        else
                        {
                            MessageBox.Show("Booking details not found.");
                        }
                    }
                }
            }
        }
        private void CalculateAndDisplayStayDuration()
        {
            string stayDurationStr = CalculateStayDuration();
            CalculateAndDisplayExtraAmount();
            //TotalAmount.Text = stayDurationStr;
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
        private void CalculateAndDisplayExtraAmount()
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

                // Retrieve CheckOutDate, ExtendDate, RoomType, and RoomRate
                string checkOutDateStr, extendDateStr, roomType;
                decimal roomRate = 0;
                using (var cmdRetrieveDetails = new SQLiteCommand("SELECT CheckOutDate, ExtendDate, RoomType, Rate.StandardRate, Rate.DeluxeRate, Rate.SuiteRate " +
                                                                  "FROM Booking B " +
                                                                  "JOIN Rate ON B.RateID = Rate.RateID " +
                                                                  "WHERE B.BookingID = @bookingId", con))
                {
                    cmdRetrieveDetails.Parameters.AddWithValue("@bookingId", bookingId);
                    using (SQLiteDataReader reader = cmdRetrieveDetails.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            checkOutDateStr = reader.GetString(0);
                            extendDateStr = reader.IsDBNull(1) ? null : reader.GetString(1); // Handle nullable ExtendDate
                            roomType = reader.GetString(2);

                            // Determine the appropriate room rate based on RoomType
                            if (roomType == "Standard")
                            {
                                roomRate = reader.GetDecimal(3); // Retrieve StandardRate
                            }
                            else if (roomType == "Deluxe")
                            {
                                roomRate = reader.GetDecimal(4); // Retrieve DeluxeRate
                            }
                            else if (roomType == "Suite")
                            {
                                roomRate = reader.GetDecimal(5); // Retrieve SuiteRate
                            }

                            // Calculate extra stay duration in hours if ExtendDate is present
                            if (!string.IsNullOrEmpty(extendDateStr))
                            {
                                DateTime checkOutDateTime = DateTime.ParseExact(checkOutDateStr, "yyyy-MM-dd", null);
                                DateTime extendDateTime;
                                if (DateTime.TryParseExact(extendDateStr, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out extendDateTime))
                                {
                                    TimeSpan extendedDuration = extendDateTime - checkOutDateTime;
                                    double extendedHours = Math.Ceiling(extendedDuration.TotalHours);

                                    // Calculate extra amount
                                    decimal extraAmount = (decimal)extendedHours * roomRate;

                                    // Display extra amount in ExtraAmount TextBox
                                    ExtraAmount.Text = extraAmount.ToString();

                                    // Add extra amount to TotalAmount
                                    decimal totalAmount = decimal.Parse(TotalAmount.Text) + extraAmount;

                                    // Display total amount in TotalAmount TextBox or Label
                                    TotalAmount.Text = totalAmount.ToString(); // Assuming TotalAmount is a TextBox or Label
                                }
                                else
                                {
                                    MessageBox.Show("Error parsing extended date.");
                                }
                            }
                            else
                            {
                                // No ExtendDate found, do not add extra amount, just keep TotalAmount as is
                                // This case should ideally be handled before reaching this point
                            }
                        }
                        else
                        {
                            MessageBox.Show("Booking details not found.");
                        }
                    }
                }
            }
        }
        private void panel2_Paint(object sender, EventArgs e)
        { }

        private void PaymentStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
