using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            con = new SQLiteConnection(cs); // Initialize the connection
        }

        // Constructor for Suite Room
        public Invoice(SuiteRoomBookedListTab suiteRoombookedListTab)
        {
            InitializeComponent();
            this.suiteRoombookedListTab = suiteRoombookedListTab;
            con = new SQLiteConnection(cs); // Initialize the connection
        }

        // Constructor for Deluxe Room
        public Invoice(DeluxeRoomBookedListTab deluxeRoomBookedListTab)
        {
            InitializeComponent();
            this.deluxeRoomBookedListTab = deluxeRoomBookedListTab;
            con = new SQLiteConnection(cs); // Initialize the connection
        }
        private void InitializeConnection()
        {
            con = new SQLiteConnection(cs);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Phonelabel_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            Load_Tax();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void AddExtraPayment_Click(object sender, EventArgs e)
        {
            AddExtraAmountPayment addExtraAmountPayment = new AddExtraAmountPayment(this);
            addExtraAmountPayment.Show();

        }
        public void Load_Tax()
        {
            try
            {
                con.Open();

                string selectQuery = "SELECT t.TaxName, t.TaxDescription, t.TaxPercentage " +
                                     "FROM Tax t";

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

        private void ExitButtonCheckOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadInvoiceData(int bookingID)
        {
            try
            {
                con.Open();

                // Query to fetch Hotel information
                string hotelQuery = "SELECT CompanyName, Location, ContactNumber, EmailAddress " +
                                    "FROM Hotel " +
                                    "WHERE HotelID = (SELECT HotelID FROM Booking WHERE BookingID = @BookingID)";

                using (var hotelCommand = new SQLiteCommand(hotelQuery, con))
                {
                    hotelCommand.Parameters.AddWithValue("@BookingID", bookingID);
                    using (var hotelReader = hotelCommand.ExecuteReader())
                    {
                        if (hotelReader.Read())
                        {
                            CompanyName.Text = hotelReader["CompanyName"].ToString();
                            Address.Text = hotelReader["Location"].ToString();
                            PhoneNumber.Text = hotelReader["ContactNumber"].ToString();
                            Email.Text = hotelReader["EmailAddress"].ToString();
                        }
                    }
                }


                // Query to fetch Booking information
                string guestQuery = "SELECT Name, Contact, Email, NumberOfAdults, NumberOfKids " +
                    "FROM Guest " +
                    "WHERE GuestID = (SELECT GuestID FROM Booking WHERE BookingID = @BookingID)";

                using (var guestCommand = new SQLiteCommand(guestQuery, con))
                {
                    guestCommand.Parameters.AddWithValue("@BookingID", bookingID);
                    using (var guestReader = guestCommand.ExecuteReader())
                    {
                        if (guestReader.Read())
                        {
                            GuestName.Text = guestReader["Name"].ToString();
                            GuestPhoneNumber.Text = guestReader["Contact"].ToString();
                            GuestEmail.Text = guestReader["Email"].ToString();
                            GuestAdultNum.Text = guestReader["NumberOfAdults"].ToString();
                            GuestKidsNum.Text = guestReader["NumberOfKids"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No guest information found for the provided BookingID.");
                        }
                    }
                }
                // Query to fetch Payment information
                /*string paymentQuery = "SELECT PaymentStatus, PaymentMethod FROM Payments WHERE BookingID = @BookingID";
                using (var paymentCommand = new SQLiteCommand(paymentQuery, con))
                {
                    paymentCommand.Parameters.AddWithValue("@BookingID", bookingID);
                    using (var paymentReader = paymentCommand.ExecuteReader())
                    {
                        if (paymentReader.Read())
                        {
                            PaymentStatus.Text = paymentReader["PaymentStatus"].ToString();
                            PaymentMehod.Text = paymentReader["PaymentMethod"].ToString();
                        }
                    }
                }

                // Query to fetch Discount information
                string discountQuery = "SELECT d.Percentage " +
                                       "FROM Discount d " +
                                       "JOIN Booking b ON d.DiscountID = b.DiscountID " +
                                       "WHERE b.BookingID = @BookingID";

                using (var discountCommand = new SQLiteCommand(discountQuery, con))
                {
                    discountCommand.Parameters.AddWithValue("@BookingID", bookingID);
                    using (var discountReader = discountCommand.ExecuteReader())
                    {
                        if (discountReader.Read())
                        {
                            Discount.Text = discountReader["Percentage"].ToString();
                        }
                    }
                }*/
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

        private void GuestAdultNum_Click(object sender, EventArgs e)
        {

        }

        private void GuestEmail_Click(object sender, EventArgs e)
        {

        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            StaffDashboard staffdashboard = new StaffDashboard(this);
            staffdashboard.Show();
            this.Close();
        }
    }
}
