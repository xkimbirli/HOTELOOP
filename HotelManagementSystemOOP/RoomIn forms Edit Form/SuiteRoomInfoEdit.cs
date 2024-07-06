using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class SuiteRoomInfoEdit : UserControl
    {
        string path = "TOTOO.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";

        public SuiteRoomInfoEdit()
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
                string sql = "CREATE TABLE IF NOT EXISTS SuiteRoom(" +
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

        private void SaveSuiteR_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(SqrMtrsSuiteR.Text) ||
                string.IsNullOrWhiteSpace(BedSuiteR.Text) ||
                string.IsNullOrWhiteSpace(BathroomSuiteR.Text) ||
                string.IsNullOrWhiteSpace(FurnishingSuiteR.Text) ||
                string.IsNullOrWhiteSpace(AmenitiesSuiteR.Text) ||
                string.IsNullOrWhiteSpace(AddPerksSuiteR.Text) ||
                string.IsNullOrWhiteSpace(RateSuiteR.Text))
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
                        cmd.CommandText = "INSERT INTO SuiteRoom(SquareMeter, BedIncluded, BathroomInclution, FurnishingInclution, Ammenities, AdditionalPerks, RatePerHour) " +
                                          "VALUES (@squaremeter, @bedincluded, @bathroominclution, @furnishinginclution, @ammenities, @additionalperks, @rateperhour)";

                        cmd.Parameters.AddWithValue("@squaremeter", SqrMtrsSuiteR.Text);
                        cmd.Parameters.AddWithValue("@bedincluded", BedSuiteR.Text);
                        cmd.Parameters.AddWithValue("@bathroominclution", BathroomSuiteR.Text);
                        cmd.Parameters.AddWithValue("@furnishinginclution", FurnishingSuiteR.Text);
                        cmd.Parameters.AddWithValue("@ammenities", AmenitiesSuiteR.Text);
                        cmd.Parameters.AddWithValue("@additionalperks", AddPerksSuiteR.Text);
                        cmd.Parameters.AddWithValue("@rateperhour", RateSuiteR.Text);

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
        private void SuiteRoomInfoEdit_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AmenitiesSuiteR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
