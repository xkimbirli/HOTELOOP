using System;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class AddDiscount : Form
    {
        private DiscountAndTaxes discountAndTaxes;
        string path = "TOTOO.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";

        public AddDiscount(DiscountAndTaxes discountAndTaxes)
        {
            InitializeComponent();
            this.discountAndTaxes = discountAndTaxes;
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);

                using (var sqlite = new SQLiteConnection(cs))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE IF NOT EXISTS Discount(" +
                                 "DiscountID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                 "DiscountName VARCHAR(30), " +
                                 "DiscountCoupon VARCHAR(30), " +
                                 "Percentage INTEGER)";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();

                    Console.WriteLine("Table Discount created successfully.");
                }
            }
        }

        private void TaxPercentage_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Text = Regex.Replace(textBox.Text, "[^0-9]", "");
        }

        private void AddDiscount_Load(object sender, EventArgs e)
        {
            Create_db();
        }

        private void SaveAddDiscount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DiscountName.Text) ||
                string.IsNullOrWhiteSpace(DiscountDescription.Text) ||
                string.IsNullOrWhiteSpace(DiscountPercentage.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(DiscountPercentage.Text, out _))
            {
                MessageBox.Show("Percentage must be a valid integer.");
                return;
            }

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(con))
                {
                    try
                    {
                        cmd.CommandText = "INSERT INTO Discount(DiscountName, DiscountCoupon, Percentage) " +
                                          "VALUES (@discountName, @discountCoupon, @percentage)";

                        cmd.Parameters.AddWithValue("@discountName", DiscountName.Text);
                        cmd.Parameters.AddWithValue("@discountCoupon", DiscountDescription.Text);
                        cmd.Parameters.AddWithValue("@percentage", DiscountPercentage.Text);

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

        private void ExitAddDiscount_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
