using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class AddEmployee : Form
    {
        string path = "TOTOO.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";

        SQLiteConnection con;
        private EmployeeInformation employeeInformation;

        public AddEmployee(EmployeeInformation employeeInformation)
        {
            InitializeComponent();
            this.employeeInformation = employeeInformation;
            PopulatePositionDropdown();
            PopulateSexDropdown(); // Populate Sex dropdown
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
                string sql = "CREATE TABLE IF NOT EXISTS Employee(" +
                             "Name VARCHAR(50), " +
                             "Sex VARCHAR(7), " +
                             "Birthdate VARCHAR(11), " +
                             "Age VARCHAR(3), " +
                             "ContactNumber VARCHAR(11), " +
                             "EmailAddress VARCHAR(50), " +
                             "Address VARCHAR(100), " +
                             "Username VARCHAR(20) UNIQUE, " + // Add UNIQUE constraint
                             "Password VARCHAR(20), " +
                             "Position VARCHAR(20), " +
                             "DateHire VARCHAR(20), " +
                             "ShiftSchedule VARCHAR(20), " +
                             "EmployeeProfile BLOB)";
                SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                command.ExecuteNonQuery();
            }
        }

        private void SaveEditEmployeeInfoButton_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBoxes(this))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the username already exists
            if (UsernameExists(UsernameAE.Text))
            {
                MessageBox.Show("The username already exists. Please choose a different username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

                        cmd.CommandText = "INSERT INTO Employee(Name, Sex, Birthdate, ContactNumber, EmailAddress, Address, Username, Password, Position, DateHire, ShiftSchedule, EmployeeProfile) " +
                                          "VALUES (@name, @sex, @birthdate, @contactnumber, @emailaddress, @address, @username, @password, @position, @datehire, @shiftschedule, @employeeprofile)";

                        cmd.Parameters.AddWithValue("@name", EmployeeNameAE.Text);
                        cmd.Parameters.AddWithValue("@sex", SexDropdownAe.Text);
                        cmd.Parameters.AddWithValue("@birthdate", BirtDateAE.Text);
                       // cmd.Parameters.AddWithValue("@age", AgeAE.Text);
                        cmd.Parameters.AddWithValue("@contactnumber", ContactNumberAE.Text);
                        cmd.Parameters.AddWithValue("@emailaddress", EmailAddAE.Text);
                        cmd.Parameters.AddWithValue("@address", AddressAE.Text);
                        cmd.Parameters.AddWithValue("@username", UsernameAE.Text);
                        cmd.Parameters.AddWithValue("@password", PasswordAE.Text);
                        cmd.Parameters.AddWithValue("@position", PositionDropdownAE.Text);
                        cmd.Parameters.AddWithValue("@datehire", DateHireAE.Text);
                        cmd.Parameters.AddWithValue("@shiftschedule", ShiftSchedAE.Text);

                        if (EmployeePic.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                EmployeePic.Image.Save(ms, EmployeePic.Image.RawFormat);
                                byte[] imgData = ms.ToArray();
                                cmd.Parameters.AddWithValue("@employeeprofile", imgData);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@employeeprofile", DBNull.Value);
                        }

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

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            Create_db();
        }

        private void ExitButtonAE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SexDropdownAe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the selection change event for Sex dropdown
            string selectedSex = SexDropdownAe.SelectedItem.ToString();
            Console.WriteLine("Selected Sex: " + selectedSex);
        }

        private void UploadPhotoButtonAE_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                EmployeePic.Image = new Bitmap(dlg.FileName);
            }
        }

        private void PopulatePositionDropdown()
        {
            PositionDropdownAE.Items.Add("Admin");
            PositionDropdownAE.Items.Add("Receptionist");
            PositionDropdownAE.Items.Add("Housekeeping");
        }

        private void PopulateSexDropdown()
        {
            SexDropdownAe.Items.Add("Male");
            SexDropdownAe.Items.Add("Female");
            SexDropdownAe.SelectedIndexChanged += SexDropdownAe_SelectedIndexChanged; // Register the event handler
        }

        private bool UsernameExists(string username)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand("SELECT COUNT(1) FROM Employee WHERE Username = @username", con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        private void BirtDateAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgeAE_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // Cast sender to TextBox

            // Remove any non-numeric characters using regular expressions
            textBox.Text = Regex.Replace(textBox.Text, "[^0-9]", "");
        }

        private void ContactNumberAE_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // Cast sender to TextBox

            // Remove any non-numeric characters using regular expressions
            textBox.Text = Regex.Replace(textBox.Text, "[^0-9]", "");
        }

        private void EmailAddAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeNameAE_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // Cast sender to TextBox

            // Remove any non-alphabetic characters using regular expressions
            textBox.Text = Regex.Replace(textBox.Text, "[^a-zA-Z]", "");
        }

        private void PositionDropdownAE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}