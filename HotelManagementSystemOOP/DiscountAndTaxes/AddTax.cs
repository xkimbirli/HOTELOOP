using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class AddTax : Form
    {
        string path = "TOTOO.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";
        private DiscountAndTaxes discountAndTaxes;
        public AddTax(DiscountAndTaxes discountAndTaxes)
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
                    string sql = "CREATE TABLE IF NOT EXISTS Tax(" +
                                 "TaxID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                 "TaxName VARCHAR(30), " +
                                 "TaxDescription VARCHAR(30), " +
                                 "Tax Percentage INTEGER(3))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();

                    Console.WriteLine("Table Discount created successfully.");
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SaveAddFloor_Click(object sender, EventArgs e)
        {

        }

        private void DiscountPercentage_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // Cast sender to TextBox

            // Remove any non-numeric characters using regular expressions
            textBox.Text = Regex.Replace(textBox.Text, "[^0-9]", "");
        }

        private void AddTax_Load(object sender, EventArgs e)
        {
            Create_db();
        }

        private void ExitAddTax_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveAddTax_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TaxName.Text) ||
               string.IsNullOrWhiteSpace(TaxDescription.Text) ||
               string.IsNullOrWhiteSpace(TaxPercentage.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(TaxPercentage.Text, out _))
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
                        cmd.CommandText = "INSERT INTO Tax(TaxName, TaxDescription, TaxPercentage) " +
                                          "VALUES (@taxName, @taxDescription, @taxPercentage)";

                        cmd.Parameters.AddWithValue("@taxName", TaxName.Text);
                        cmd.Parameters.AddWithValue("@taxDescription", TaxDescription.Text);
                        cmd.Parameters.AddWithValue("@taxPercentage", TaxPercentage.Text);

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
    }
}
