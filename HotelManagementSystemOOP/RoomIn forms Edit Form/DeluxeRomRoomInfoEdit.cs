using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HotelManagementSystemOOP
{
    public partial class DeluxeRoomInfoEdit : UserControl
    {
        string path = "TOTOO.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";
        public DeluxeRoomInfoEdit()
        {
            InitializeComponent();
            Create_db(); // Create database and table if they do not exist
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
                string sql = "CREATE TABLE IF NOT EXISTS DeluxeRoom(" +
                             "SquareMeter TEXT, " +
                             "BedIncluded TEXT, " +
                             "BathroomInclution TEXT, " +
                             "FurnishingInclution TEXT, " +
                             "Ammenities TEXT, " +
                             "AdditionalPerks TEXT, " +
                             "RatePerHour TEXT)";
                SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                command.ExecuteNonQuery();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DeluxeRoomInfoEdit_Load(object sender, EventArgs e)
        {


        }

        private void SaveDeluxeR_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(SqrMtrDeluxeR.Text) ||
                string.IsNullOrWhiteSpace(BedDeluxeR.Text) ||
                string.IsNullOrWhiteSpace(BathDeluxeR.Text) ||
                string.IsNullOrWhiteSpace(FurnishingDeluxeR.Text) ||
                string.IsNullOrWhiteSpace(Amenities.Text) ||
                string.IsNullOrWhiteSpace(AddPerks.Text) ||
                string.IsNullOrWhiteSpace(RateDeluxeR.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(con))
                {
                    try
                    {
                        cmd.CommandText = "INSERT INTO DeluxeRoom(SquareMeter, BedIncluded, BathroomInclution, FurnishingInclution, Ammenities, AdditionalPerks, RatePerHour) " +
                                          "VALUES (@squaremeter, @bedincluded, @bathroominclution, @furnishinginclution, @ammenities, @additionalperks, @rateperhour)";

                        cmd.Parameters.AddWithValue("@squaremeter", SqrMtrDeluxeR.Text);
                        cmd.Parameters.AddWithValue("@bedincluded", BedDeluxeR.Text);
                        cmd.Parameters.AddWithValue("@bathroominclution", BathDeluxeR.Text);
                        cmd.Parameters.AddWithValue("@furnishinginclution", FurnishingDeluxeR.Text);
                        cmd.Parameters.AddWithValue("@ammenities", Amenities.Text);
                        cmd.Parameters.AddWithValue("@additionalperks", AddPerks.Text);
                        cmd.Parameters.AddWithValue("@rateperhour", RateDeluxeR.Text);

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
