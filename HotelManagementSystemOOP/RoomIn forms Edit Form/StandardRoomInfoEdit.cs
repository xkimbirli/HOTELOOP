using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class StandardRoomInfoEdit : UserControl
    {
        string path = "TOTOO.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";
        public StandardRoomInfoEdit()
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
                string sql = "CREATE TABLE IF NOT EXISTS StandardRoom(" +
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void StandardRoomInfoEdit_Load(object sender, EventArgs e)
        {

        }

        private void SaveStandardR_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(SqrMtsStandardR.Text) ||
                string.IsNullOrWhiteSpace(BedStandardR.Text) ||
                string.IsNullOrWhiteSpace(BathStandardR.Text) ||
                string.IsNullOrWhiteSpace(FurnishingStandardR.Text) ||
                string.IsNullOrWhiteSpace(AmanitiesStandardR.Text) ||
                string.IsNullOrWhiteSpace(AddPerksStandardR.Text) ||
                string.IsNullOrWhiteSpace(RateStandardR.Text))
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
                        cmd.CommandText = "INSERT INTO StandardRoom(SquareMeter, BedIncluded, BathroomInclution, FurnishingInclution, Ammenities, AdditionalPerks, RatePerHour) " +
                                          "VALUES (@squaremeter, @bedincluded, @bathroominclution, @furnishinginclution, @ammenities, @additionalperks, @rateperhour)";

                        cmd.Parameters.AddWithValue("@squaremeter", SqrMtsStandardR.Text);
                        cmd.Parameters.AddWithValue("@bedincluded", BedStandardR.Text);
                        cmd.Parameters.AddWithValue("@bathroominclution", BathStandardR.Text);
                        cmd.Parameters.AddWithValue("@furnishinginclution", FurnishingStandardR.Text);
                        cmd.Parameters.AddWithValue("@ammenities", AmanitiesStandardR.Text);
                        cmd.Parameters.AddWithValue("@additionalperks", AddPerksStandardR.Text);
                        cmd.Parameters.AddWithValue("@rateperhour", RateStandardR.Text);

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
