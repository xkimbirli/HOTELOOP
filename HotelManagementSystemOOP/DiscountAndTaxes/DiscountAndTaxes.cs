using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class DiscountAndTaxes : Form
    {
        private AdminDashboard adminDashboard;
        private string cs = @"URI=file:" + Path.Combine(Application.StartupPath, "TOTOO.db");

        private SQLiteConnection con;

        public DiscountAndTaxes(AdminDashboard adminDashboard)
        {
            InitializeComponent();
            this.adminDashboard = adminDashboard;
            con = new SQLiteConnection(cs); // Initialize the connection
        }

        private void AddDiscount_Click(object sender, EventArgs e)
        {
            AddDiscount addDiscount = new AddDiscount(this);
            addDiscount.Show();
        }

        private void AddTax_Click(object sender, EventArgs e)
        {
            AddTax addTax = new AddTax(this);
            addTax.Show();
        }

        private void DiscountAndTaxes_Load(object sender, EventArgs e)
        {
            //Load_Discounts();
            Load_Tax();
            Create_db();
            LoadRates();

        }
        private void Create_db()
        {
            try
            {
                con.Open();

                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Rate (
                        RateID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StandardRate INTEGER,
                        DeluxeRate INTEGER,
                        SuiteRate INTEGER
                    );";

                SQLiteCommand command = new SQLiteCommand(createTableQuery, con);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating Rate table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void LoadRates()
        {
            try
            {
                con.Open();

                string selectQuery = "SELECT * FROM Rate ORDER BY RateID DESC LIMIT 1";

                using (var command = new SQLiteCommand(selectQuery, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            StandardRate.Text = reader["StandardRate"].ToString();
                            DeluxeRate.Text = reader["DeluxeRate"].ToString();
                            SuiteRate.Text = reader["SuiteRate"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        /* public void Load_Discounts()
         {
             try
             {
                 con.Open();

                 string selectQuery = "SELECT d.DiscountName, d.DiscountCoupon, d.Percentage " +
                                      "FROM Discount d";

                 using (var command = new SQLiteCommand(selectQuery, con))
                 {
                     using (var adapter = new SQLiteDataAdapter(command))
                     {
                         DataTable dataTable = new DataTable();
                         adapter.Fill(dataTable);

                         dataGridViewDiscount.DataSource = dataTable;
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
         }*/

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

                        dataGridViewTax.DataSource = dataTable;
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




        private void SaveRoomRates_Click(object sender, EventArgs e)
        {

            SaveRates();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click event
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Handle panel paint event
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void StandardRate_TextChanged(object sender, EventArgs e)
        { }

        private void DeluxeRate_TextChanged(object sender, EventArgs e)
        { }

        private void SuiteRate_TextChanged(object sender, EventArgs e)
        { }
        private void SaveRates()
        {
            int standardRate, deluxeRate, suiteRate;

            if (!int.TryParse(StandardRate.Text, out standardRate) ||
                !int.TryParse(DeluxeRate.Text, out deluxeRate) ||
                !int.TryParse(SuiteRate.Text, out suiteRate))
            {
                MessageBox.Show("Please enter valid integer values for rates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();

                string updateQuery = @"
                    INSERT INTO Rate (StandardRate, DeluxeRate, SuiteRate)
                    VALUES (@standardRate, @deluxeRate, @suiteRate)
                    ON CONFLICT (RateID) DO UPDATE SET
                        StandardRate = @standardRate,
                        DeluxeRate = @deluxeRate,
                        SuiteRate = @suiteRate;";

                SQLiteCommand command = new SQLiteCommand(updateQuery, con);
                command.Parameters.AddWithValue("@standardRate", standardRate);
                command.Parameters.AddWithValue("@deluxeRate", deluxeRate);
                command.Parameters.AddWithValue("@suiteRate", suiteRate);
                command.ExecuteNonQuery();

                MessageBox.Show("Rates saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving rates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
