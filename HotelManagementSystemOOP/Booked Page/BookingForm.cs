using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System;

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq;
using System.Drawing;

namespace HotelManagementSystemOOP
{
    public partial class BookingForm : Form
    {
        string path = "TOTOO.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";

        SQLiteConnection con;
        private BookingPage bookingPage;

        public BookingForm(BookingPage bookingPage)
        {
            InitializeComponent();
            this.bookingPage = bookingPage;
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection("Data Source=" + path))
                {
                    try
                    {
                        sqlite.Open();

                        string sqlGuest = "CREATE TABLE IF NOT EXISTS Guest (" +
                                          "GuestID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                          "Name VARCHAR(30), " +
                                          "Sex VARCHAR(20), " +
                                          "Contact VARCHAR(20), " +
                                          "Nationality VARCHAR(20), " +
                                          "NumberOfGuest INTEGER, " +
                                          "NumberOfKids INTEGER, " +
                                          "NumberOfAdults INTEGER, " +
                                          "Email VARCHAR(50))";
                        using (SQLiteCommand commandGuest = new SQLiteCommand(sqlGuest, sqlite))
                        {
                            commandGuest.ExecuteNonQuery();
                        }

                        string sqlBooking = "CREATE TABLE IF NOT EXISTS Booking (" +
                                            "BookingID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                            "GuestID INTEGER, " +
                                            "RoomType VARCHAR(20), " +
                                            "RoomNumber INTEGER, " +
                                            "CheckInDate VARCHAR(20), " +
                                            "CheckOutDate VARCHAR(20), " +
                                            "Status VARCHAR(20), " +
                                            "FOREIGN KEY(GuestID) REFERENCES Guest(GuestID))";
                        using (SQLiteCommand commandBooking = new SQLiteCommand(sqlBooking, sqlite))
                        {
                            commandBooking.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error creating database: " + ex.Message);
                    }
                }
            }
            else
            {
                Console.WriteLine("Database already exists.");
            }
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            InitializeFormControls();
            Create_db();
            dateTimeCheckIn.MinDate = DateTime.Now;
            dateTimeCheckOut.MinDate = DateTime.Now;
        }

        private void InitializeFormControls()
        {
            RoomTypeDropdownBF.Items.Add("Standard");
            RoomTypeDropdownBF.Items.Add("Deluxe");
            RoomTypeDropdownBF.Items.Add("Suite");

            SexDropdownBF.Items.Add("Male");
            SexDropdownBF.Items.Add("Female");
        }

        private bool IsRoomAvailable(int roomNumber, string roomType)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM Rooms WHERE RoomNumber = @roomnumber AND RoomType = @roomtype AND RoomStatus = 'Available'";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@roomnumber", roomNumber);
                    cmd.Parameters.AddWithValue("@roomtype", roomType);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Returns true if the room exists and is available
                }
            }
        }

        private void BookButtonBF_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBoxes(this))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate room availability
            int roomNumber;
            if (!int.TryParse(RoomNumberTextBoxBF.Text, out roomNumber))
            {
                MessageBox.Show("Please enter a valid room number.");
                return;
            }

            if (!IsRoomAvailable(roomNumber, RoomTypeDropdownBF.Text))
            {
                MessageBox.Show($"Room number {roomNumber} of type {RoomTypeDropdownBF.Text} is not available or does not exist.");
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
                        // Insert guest data
                        cmd.CommandText = "INSERT INTO Guest(Name, Sex, Contact, Nationality, NumberOfGuest, NumberOfKids, NumberOfAdults, Email) " +
                                          "VALUES (@name, @sex, @contact, @nationality, @numberofguest, @numberofkids, @numberofadults, @email)";
                        cmd.Parameters.AddWithValue("@name", GuestNameBF.Text);
                        cmd.Parameters.AddWithValue("@sex", SexDropdownBF.Text);
                        cmd.Parameters.AddWithValue("@contact", ContactBF.Text);
                        cmd.Parameters.AddWithValue("@nationality", NationalitBF.Text);
                        cmd.Parameters.AddWithValue("@numberofguest", NumOfGuestTextBoxBF.Text);
                        cmd.Parameters.AddWithValue("@numberofkids", NumOfKidsTextBoxBF.Text);
                        cmd.Parameters.AddWithValue("@numberofadults", NumOfAdultsTexBoxBF.Text);
                        cmd.Parameters.AddWithValue("@email", EmailBF.Text);
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "SELECT last_insert_rowid()";
                        long guestId = (long)cmd.ExecuteScalar();

                        // Always set status as Reserved
                        string status = "Reserved";

                        // Insert booking data
                        cmd.CommandText = "INSERT INTO Booking(GuestID, RoomType, RoomNumber, CheckInDate, CheckOutDate, Status, CreatedDate) " +
                                          "VALUES (@guestId, @roomtype, @roomnumber, @checkindate, @checkoutdate, @status, datetime('now', 'localtime'))";
                        cmd.Parameters.AddWithValue("@guestId", guestId);

                        cmd.Parameters.AddWithValue("@roomtype", RoomTypeDropdownBF.Text);
                        cmd.Parameters.AddWithValue("@roomnumber", roomNumber);
                        cmd.Parameters.AddWithValue("@checkindate", dateTimeCheckIn.Text);
                        cmd.Parameters.AddWithValue("@checkoutdate", dateTimeCheckOut.Text);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();

                        // Update room status to 'Reserved'
                        cmd.CommandText = "UPDATE Rooms SET RoomStatus = @status WHERE RoomNumber = @roomnumber AND RoomType = @roomtype";
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@roomnumber", roomNumber);
                        cmd.Parameters.AddWithValue("@roomtype", RoomTypeDropdownBF.Text);
                        cmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Data saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            var parentForm = this.ParentForm;
            var bpTabAllRooms = parentForm?.Controls.OfType<BpTabAllRooms>().FirstOrDefault();
            bpTabAllRooms?.LoadRoomData();

            Payment payment = new Payment(this);
            payment.Show();
            this.Close();
        }

        private bool ValidateTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false;
                    }
                }
                else if (control.HasChildren)
                {
                    if (!ValidateTextBoxes(control))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) { }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Text = Regex.Replace(textBox.Text, "[^a-zA-Z]", "");
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Text = Regex.Replace(textBox.Text, "[^0-9]", "");
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void RoomTypeDropdownBF_SelectedIndexChanged(object sender, EventArgs e) { }

        private void NumOfGuestTextBoxBF_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Text = Regex.Replace(textBox.Text, "[^0-9]", ""); // Ensure only numeric digits
            textBox.SelectionStart = textBox.Text.Length;

            // Validate sum of Adults and Kids against TotalGuest
            ValidateGuestCount();
        }

        private void ValidateGuestCount()
        {
            int totalGuests;
            if (int.TryParse(NumOfGuestTextBoxBF.Text, out totalGuests))
            {
                int adults, kids;
                if (int.TryParse(NumOfAdultsTexBoxBF.Text, out adults) && int.TryParse(NumOfKidsTextBoxBF.Text, out kids))
                {
                    if (adults + kids > totalGuests)
                    {
                        // Display error or handle validation
                        // Example: change background color to indicate error
                        NumOfAdultsTexBoxBF.BackColor = Color.Red;
                        NumOfKidsTextBoxBF.BackColor = Color.Red;
                    }
                    else
                    {
                        // Reset background color if valid
                        NumOfAdultsTexBoxBF.BackColor = SystemColors.Window;
                        NumOfKidsTextBoxBF.BackColor = SystemColors.Window;
                    }
                }
            }
        }


        private void dateTimeCheckIn_ValueChanged(object sender, EventArgs e)
        {
        }
        private void dateTimeCheckOut_ValueChanged(object sender, EventArgs e)
        {
        }
        private void NationalitDropdownBF_TextChanged(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }

        public void DeleteRecentBooking()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(con))
                {
                    SQLiteTransaction transaction = con.BeginTransaction();

                    try
                    {
                        // Retrieve the GuestID of the most recent booking
                        cmd.CommandText = "SELECT GuestID FROM Booking ORDER BY BookingID DESC LIMIT 1";
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            long guestId = (long)result;

                            // Delete the most recent booking
                            cmd.CommandText = "DELETE FROM Booking WHERE GuestID = @guestId";
                            cmd.Parameters.AddWithValue("@guestId", guestId);
                            cmd.ExecuteNonQuery();

                            // Delete the corresponding guest record
                            cmd.CommandText = "DELETE FROM Guest WHERE GuestID = @guestId";
                            cmd.Parameters.AddWithValue("@guestId", guestId);
                            cmd.ExecuteNonQuery();

                            transaction.Commit();

                            MessageBox.Show("Recent booking and guest record deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No bookings found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void NumOfAdultsTexBoxBF_TextChanged(object sender, EventArgs e)
        {
            ValidateGuestCount();
        }

        private void NumOfKidsTextBoxBF_TextChanged(object sender, EventArgs e)
        {
            ValidateGuestCount();
        }
    }
    }

