using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
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
        public Invoice(string guestName, string guestPhoneNumber, string guestEmail, int guestKidsNum, int guestAdultNum,
                   int bookingID, string roomType, string roomNumber, DateTime checkInDate, DateTime checkOutDate)
        {
            InitializeComponent();
            con = new SQLiteConnection(cs); // Initialize the connection

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
            LoadInvoiceData();
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
        public void LoadInvoiceData()
        {
            try
            {
                con.Open();

                string selectQuery = "SELECT CompanyName, Location, ContactNumber, EmailAddress " +
                                     "FROM Hotel";

                using (var command = new SQLiteCommand(selectQuery, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming CompanyName, Location, ContactNumber, and EmailAddress are in the same order as fetched
                            CompanyName.Text = reader["CompanyName"].ToString();
                            Address.Text = reader["Location"].ToString();
                            PhoneNumber.Text = reader["ContactNumber"].ToString();
                            Email.Text = reader["EmailAddress"].ToString();
                        }
                    }
                }
                // Query to fetch payment details including discount from Payments and Discount tables
                string selectPaymentQuery = "SELECT p.PaymentStatus, p.PaymentMethod, d.Percentage " +
                                   "FROM Payments p " +
                                   "LEFT JOIN Discount d ON p.DiscountID = d.DiscountID " +
                                   "WHERE p.BookingID = @BookingID";

                using (var paymentCommand = new SQLiteCommand(selectPaymentQuery, con))
                {
                    paymentCommand.Parameters.AddWithValue("@BookingID", BookingID.Text);

                    using (var paymentReader = paymentCommand.ExecuteReader())
                    {
                        if (paymentReader.Read())
                        {
                            PaymentStatus.Text = paymentReader["PaymentStatus"].ToString();
                            PaymentMet.Text = paymentReader["PaymentMethod"].ToString();

                            // Display the discount percentage in the Discount textbox
                            Discount.Text = paymentReader["Percentage"].ToString();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
