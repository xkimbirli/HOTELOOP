using NavigationView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class GeneralSettings : Form
    {
        NavigationControl navigationControl;
        string path = "TOTOO.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";

        SQLiteConnection con;
        private AdminDashboard adminDashboard;

        public GeneralSettings()
        {
            InitializeComponent();
            InitializeNavigationControl();
            AddRoomRoomTypeDD_SelectedIndexChanged();

        }

        public GeneralSettings(AdminDashboard adminDashboard)
        {
            InitializeComponent();
            this.adminDashboard = adminDashboard;
            InitializeNavigationControl();
            AddRoomRoomTypeDD_SelectedIndexChanged();

        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {
                new StandardAddRoomDD(),
                new DeluxeAddRoomDD(),
                new SuiteAddRoomDD()
            };

            navigationControl = new NavigationControl(userControls, panel3);
            navigationControl.Display(0); // Display BpTabStandardRooms as default
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
                string sqlCreateTable = "CREATE TABLE IF NOT EXISTS Hotel(" +
                                        "HotelID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                        "CompanyName VARCHAR(50), " +
                                        "Location VARCHAR(50), " +
                                        "ContactNumber VARCHAR(11), " +
                                        "EmailAddress VARCHAR(50), " +
                                        "Overview VARCHAR(1000), " +
                                        "Logo BLOB)";

                SQLiteCommand command = new SQLiteCommand(sqlCreateTable, sqlite);
                command.ExecuteNonQuery();

                // Check if the Hotel table already has data
                string sqlCheckData = "SELECT COUNT(*) FROM Hotel";
                SQLiteCommand checkCommand = new SQLiteCommand(sqlCheckData, sqlite);
                long count = (long)checkCommand.ExecuteScalar();

                // If no data exists, insert default values
                if (count == 0)
                {
                    string sqlInsert = "INSERT INTO Hotel(CompanyName, Location, ContactNumber, EmailAddress, Overview) " +
                                       "VALUES (@companyname, @location, @contactnumber, @emailaddress, @overview)";
                    SQLiteCommand insertCommand = new SQLiteCommand(sqlInsert, sqlite);
                    insertCommand.Parameters.AddWithValue("@companyname", "VISTA HERMOSA HOTEL");
                    insertCommand.Parameters.AddWithValue("@location", "Quezon City");
                    insertCommand.Parameters.AddWithValue("@contactnumber", "09111111111");
                    insertCommand.Parameters.AddWithValue("@emailaddress", "Vistahermosahotel@gmail.com");
                    insertCommand.Parameters.AddWithValue("@overview", "Hotel Vista Hermosa offers a tranquil and comfortable stay in a scenic setting. Located Quezon City, this hotel provides a peaceful retreat for travelers seeking relaxation. With a focus on comfort and hospitality, Hotel Vista Hermosa promises a serene experience amidst its serene surroundings.");

                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        private void LoadHotelData()
        {
            try
            {
                using (var connection = new SQLiteConnection(cs))
                {
                    connection.Open();
                    string selectQuery = "SELECT CompanyName, Location, ContactNumber, EmailAddress, Overview, Logo FROM Hotel LIMIT 1 ";//
                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Company_Name.Text = reader["CompanyName"].ToString();
                                Location.Text = reader["Location"].ToString();
                                ContactNumber.Text = reader["ContactNumber"].ToString();
                                EmailAddress.Text = reader["EmailAddress"].ToString();
                                Overview.Text = reader["Overview"].ToString();

                                // Load and display logo in PictureBox
                                if (reader["Logo"] != DBNull.Value)
                                {
                                    byte[] logoData = (byte[])reader["Logo"];
                                    pictureBox2.Image = Image.FromStream(new MemoryStream(logoData));
                                }
                                //else
                               // {
                                    // Handle case where there's no logo in the database
                                //    pictureBox2.Image = null;
                                //}
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeneralSettings_Load(object sender, EventArgs e)
        {
            Create_db();
            LoadHotelData();
            LoadRoomData();
        }

        private void LoadRoomData()
        {
            try
            {
                using (var connection = new SQLiteConnection(cs))
                {
                    connection.Open();
                    string selectQuery = "SELECT f.FloorNumber, f.FloorName, f.HasCheckbox " +
                                        "FROM Floor f";

                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Automatically generate columns
                            dataGridView1.AutoGenerateColumns = false;
                            dataGridView1.DataSource = dataTable;

                            // Clear existing columns
                            dataGridView1.Columns.Clear();

                            // Add columns to the DataGridView
                            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                            {
                                DataPropertyName = "FloorNumber",
                                HeaderText = "Floor Number"
                            });
                            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                            {
                                DataPropertyName = "FloorName",
                                HeaderText = "Floor Name"
                            });
                            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                            {
                                DataPropertyName = "HasCheckbox",
                                HeaderText = "Floor Status"
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveButtonGS_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(con))
                {
                    try
                    {
                        cmd.CommandText = "UPDATE Hotel SET CompanyName = @companyname, Location = @location, " +
                                          "ContactNumber = @contactnumber, EmailAddress = @emailaddress, " +
                                          "Overview = @overview, Logo = @logo WHERE ROWID = 1";

                        cmd.Parameters.AddWithValue("@companyname", Company_Name.Text);
                        cmd.Parameters.AddWithValue("@location", Location.Text);
                        cmd.Parameters.AddWithValue("@contactnumber", ContactNumber.Text);
                        cmd.Parameters.AddWithValue("@emailaddress", EmailAddress.Text);
                        cmd.Parameters.AddWithValue("@overview", Overview.Text);

                        if (pictureBox2.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                                byte[] imgData = ms.ToArray();
                                cmd.Parameters.AddWithValue("@logo", imgData);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@logo", DBNull.Value);
                        }

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(dlg.FileName);
            }
        }

        private void DashboardButtonGS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddFloors_Click(object sender, EventArgs e)
        {
            // Placeholder method for adding floors
        }

        private void AddRooms_Click(object sender, EventArgs e)
        {
            //Create an instance for add room   
            AddRooms addRooms = new AddRooms(this);

            //show the add room page
            addRooms.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Placeholder method for PictureBox click
        }

        private void AddFloors_Click_1(object sender, EventArgs e)
        {
            AddFloor addFloor = new AddFloor(this);
            addFloor.Show();// Placeholder method for adding floors
        }

        private void AddRoomRoomTypeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = AddRoomRoomTypeDD.SelectedIndex;
            navigationControl.Display(selectedIndex);
        }

        private void Accomodation_TextChanged(object sender, EventArgs e)
        {
            // Placeholder method for text changed event
        }

        private void ContactNumber_TextChanged(object sender, EventArgs e)
        {
            // Placeholder method for text changed event
        }

        private void Location_TextChanged(object sender, EventArgs e)
        {
            // Placeholder method for text changed event
        }

        private void EmailAddress_TextChanged(object sender, EventArgs e)
        {
            // Placeholder method for text changed event
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Placeholder method for DataGridView cell content click
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Placeholder method for DataGridView cell content click
        }
        private void label6_Click(object sender, EventArgs e)
        {
            // Placeholder method for DataGridView cell content click
        }
        private void dataGridView1_CellContentClick_1(object sender, EventArgs e)
        {
            // Placeholder method for DataGridView cell content click
        }
        private void panel3_Paint(object sender, EventArgs e)
        {
            // Placeholder method for DataGridView cell content click
        }
        private void SaveButtonGS_Click_1(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(con))
                {
                    try
                    {
                        cmd.CommandText = "UPDATE Hotel SET CompanyName = @companyname, Location = @location, " +
                                          "ContactNumber = @contactnumber, EmailAddress = @emailaddress, " +
                                          "Overview = @overview, Logo = @logo WHERE ROWID = 1";//

                        cmd.Parameters.AddWithValue("@companyname", Company_Name.Text);
                        cmd.Parameters.AddWithValue("@location", Location.Text);
                        cmd.Parameters.AddWithValue("@contactnumber", ContactNumber.Text);
                        cmd.Parameters.AddWithValue("@emailaddress", EmailAddress.Text);
                        cmd.Parameters.AddWithValue("@overview", Overview.Text);

                        if (pictureBox2.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                                byte[] imgData = ms.ToArray();
                                cmd.Parameters.AddWithValue("@logo", imgData);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@logo", DBNull.Value);
                        }

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void AddRoomRoomTypeDD_SelectedIndexChanged()
        {
            AddRoomRoomTypeDD.Items.Add("Standard Room");
            AddRoomRoomTypeDD.Items.Add("Deluxe Room");
            AddRoomRoomTypeDD.Items.Add("Suite Room");
            AddRoomRoomTypeDD.SelectedIndex = 0; // Set default selection
        }



    }
}
