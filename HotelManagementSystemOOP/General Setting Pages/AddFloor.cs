using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System;

using System;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class AddFloor : Form
    {
        string path = "TOTOO.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";

        private GeneralSettings generalSettings;
        public AddFloor(GeneralSettings generalSettings)
        {
            InitializeComponent();
            this.generalSettings = generalSettings;
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
            }

            using (var sqlite = new SQLiteConnection(cs))
            {
                try
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE IF NOT EXISTS Floor(" +
                                 "FloorID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                 "FloorName VARCHAR(50), " +
                                 "FloorNumber INTEGER"+
                                 "HasCheckbox INTEGER)";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating database table: " + ex.Message);
                    Console.WriteLine("Error creating database table: " + ex.Message);
                }
            }
        }

        private void AddFloor_Load(object sender, EventArgs e)
        {
            Create_db();
        }

        private void ExitAddFloors_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveAddFloor_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBoxes(this))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(con))
                {
                    try
                    {
                        cmd.CommandText = "SELECT COUNT(*) FROM Floor WHERE FloorNumber = @floornumber";
                        cmd.Parameters.AddWithValue("@floornumber", FloorNumber.Text);
                        long count = (long)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Floor number already exists. Please enter a different floor number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        cmd.CommandText = "INSERT INTO Floor(FloorName, FloorNumber, HasCheckbox) " +
                                          "VALUES (@floorname, @floornumber, @hascheckbox)";
                        cmd.Parameters.AddWithValue("@floorname", FloorName.Text);
                        cmd.Parameters.AddWithValue("@hascheckbox", FloorStatus.Checked ? 1 : 0);

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

        private void FloorName_TextChanged(object sender, EventArgs e)
        {
            // Handle text change event if needed
        }

        private void FloorNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            textBox.Text = Regex.Replace(textBox.Text, "[^0-9]", "");

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!int.TryParse(textBox.Text, out int floorNumber))
                {
                    textBox.Text = "";
                    MessageBox.Show("Please enter a valid number.");
                }
                else if (floorNumber < 1 || floorNumber > 30)
                {
                    MessageBox.Show("Floor number must be between 1 and 30.");
                    textBox.Text = "";
                }
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Handle text change event if needed
        }

    }
}
