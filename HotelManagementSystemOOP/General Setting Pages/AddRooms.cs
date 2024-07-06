using System;
using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class AddRooms : Form
    {
        string path = "TOTOO.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";

        private GeneralSettings generalSettings;

        public AddRooms(GeneralSettings generalSettings)
        {
            InitializeComponent();
            this.generalSettings = generalSettings;
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);

                using (var sqlite = new SQLiteConnection(cs))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE IF NOT EXISTS Rooms(" +
                                 "RoomID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                 "FloorID INTEGER, " +
                                 "RoomType VARCHAR(50), " +
                                 "RoomNumber INTEGER, " +
                                 "RoomStatus VARCHAR(20) DEFAULT 'Available', " +
                                 "FOREIGN KEY(FloorID) REFERENCES Floor (FloorID))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();

                    Console.WriteLine("Table Rooms created successfully.");
                }
            }
            else
            {
                using (var sqlite = new SQLiteConnection(cs))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE IF NOT EXISTS Rooms(" +
                                 "RoomID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                 "FloorID INTEGER, " +
                                 "RoomType VARCHAR(50), " +
                                 "RoomNumber INTEGER, " +
                                 "RoomStatus VARCHAR(20) DEFAULT 'Available', " +
                                 "FOREIGN KEY(FloorID) REFERENCES Floor(FloorID))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();

                    Console.WriteLine("Table Rooms ensured to exist.");
                }
                Console.WriteLine("Database already exists.");
            }
        }

        private void InitializeFormControls()
        {
            // Populate AddRoomDropdown with room types
            AddRoomDropdown.Items.Add("Standard");
            AddRoomDropdown.Items.Add("Deluxe");
            AddRoomDropdown.Items.Add("Suite");
        }

        private void AddRooms_Load(object sender, EventArgs e)
        {
            InitializeFormControls();
            Create_db();
        }

        private void ExitAddRooms_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FloorNumberAddRooms_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // Cast sender to TextBox

            // Remove any non-numeric characters using regular expressions
            textBox.Text = Regex.Replace(textBox.Text, "[^0-9]", "");
            textBox.SelectionStart = textBox.Text.Length; // Set the cursor to the end of the text

            // Check if the entered FloorNumber exists in the Floors table
            int floorNumber;
            if (!int.TryParse(textBox.Text, out floorNumber))
            {
                return; // Exit if parsing fails
            }

            if (!IsFloorNumberInDatabase(floorNumber))
            {
                MessageBox.Show($"Floor with number {floorNumber} does not exist in the database.");
                textBox.Text = ""; // Clear the invalid input
            }
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

        private bool IsFloorNumberInDatabase(int floorNumber)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM Floor WHERE FloorNumber = @floornumber";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@floornumber", floorNumber);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Returns true if the floor number exists in the Floors table
                }
            }
        }

        private void SaveAddRooms_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBoxes(this))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert room data into SQLite database
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(con))
                {
                    try
                    {
                        // Check if the entered FloorNumber exists in the Floors table
                        int floorNumber;
                        if (!int.TryParse(FloorNumberAddRooms.Text, out floorNumber))
                        {
                            MessageBox.Show("Please enter a valid floor number.");
                            return;
                        }

                        if (!IsFloorNumberInDatabase(floorNumber))
                        {
                            MessageBox.Show($"Floor with number {floorNumber} does not exist in the database.");
                            return;
                        }

                        // Validate RoomNumber
                        int roomNumber;
                        if (!int.TryParse(RoomNumber.Text, out roomNumber))
                        {
                            MessageBox.Show("Please enter a valid room number.");
                            return;
                        }

                        // Check if the room number already exists for the given room type
                        if (IsRoomNumberForTypeExists(roomNumber, AddRoomDropdown.Text))
                        {
                            MessageBox.Show($"Room number {roomNumber} already exists for room type {AddRoomDropdown.Text}.");
                            return;
                        }

                        // Determine the room status
                        string roomStatus = IsFloorUnderMaintenance(floorNumber) ? "Under Maintenance" : "Available";

                        // Perform the insertion into the Rooms table
                        cmd.CommandText = "INSERT INTO Rooms(FloorID, RoomType, RoomNumber, RoomStatus) " +
                                          "VALUES (@floorid, @roomtype, @roomnumber, @roomstatus)";

                        cmd.Parameters.AddWithValue("@floorid", GetFloorIDByNumber(floorNumber));
                        cmd.Parameters.AddWithValue("@roomtype", AddRoomDropdown.Text);
                        cmd.Parameters.AddWithValue("@roomnumber", roomNumber);
                        cmd.Parameters.AddWithValue("@roomstatus", roomStatus);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
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

        private int GetFloorIDByNumber(int floorNumber)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string sql = "SELECT FloorID FROM Floor WHERE FloorNumber = @floornumber";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@floornumber", floorNumber);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    return -1; // Return -1 if floor number is not found (should not happen due to prior check)
                }
            }
        }

        private bool IsRoomNumberForTypeExists(int roomNumber, string roomType)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM Rooms WHERE RoomNumber = @roomnumber AND RoomType = @roomtype";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@roomnumber", roomNumber);
                    cmd.Parameters.AddWithValue("@roomtype", roomType);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Returns true if the room number exists for the given room type
                }
            }
        }

        private void RoomNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // Cast sender to TextBox

            // Remove any non-numeric characters using regular expressions
            textBox.Text = Regex.Replace(textBox.Text, "[^0-9]", "");
            textBox.SelectionStart = textBox.Text.Length; // Set the cursor to the end of the text
        }

        private void AddRoomDropdown_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        { }

        private bool IsFloorUnderMaintenance(int floorNumber)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string sql = "SELECT HasCheckbox FROM Floor WHERE FloorNumber = @floornumber";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@floornumber", floorNumber);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result) == 0;
                    }
                    return false; // Return false if floor number is not found (should not happen due to prior check)
                }
            }
        }
    }
}