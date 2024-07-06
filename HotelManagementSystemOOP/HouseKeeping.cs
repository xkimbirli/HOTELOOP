using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class HouseKeeping : Form
    {
        private LogIn logIn;
        private string connectionString = "Data Source=TOTOO.db;Version=3;";

        public HouseKeeping(LogIn logIn)
        {
            InitializeComponent();
            this.logIn = logIn; // Initialize logIn field
            LoadRoomData();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick; // Ensure the event is wired up
        }

        private void LoadRoomData()
        {
            string query = "SELECT Floor.FloorNumber, Rooms.RoomNumber, Rooms.RoomType, Rooms.RoomID " +
                           "FROM Rooms " +
                           "INNER JOIN Floor ON Rooms.FloorID = Floor.FloorID " +
                           "WHERE Rooms.RoomStatus = 'Unclean'";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading room data: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                dataGridView1.DataSource = dataTable;

                // Add a "Clean" button column dynamically
                if (dataGridView1.Columns["Clean"] == null)
                {
                    DataGridViewButtonColumn cleanButtonColumn = new DataGridViewButtonColumn();
                    cleanButtonColumn.Name = "Clean";
                    cleanButtonColumn.HeaderText = "Clean";
                    cleanButtonColumn.Text = "Clean";
                    cleanButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(cleanButtonColumn);
                }
            }
        }

        private void ExitHouseKeeping_Click(object sender, EventArgs e)
        {
            logIn.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Clean"].Index && e.RowIndex >= 0)
            {
                int roomID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["RoomID"].Value);
                MessageBox.Show("Updating RoomID: " + roomID); // Debugging

                // Update RoomStatus to "Available" in the Rooms table
                string updateQuery = "UPDATE Rooms SET RoomStatus = 'Available' WHERE RoomID = @RoomID";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@RoomID", roomID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room status updated to Available.");
                            // Refresh the DataGridView if needed
                            LoadRoomData();
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating room status: " + ex.Message);
                    }
                }
            }
        }

        private void HouseKeeping_Load(object sender, EventArgs e)
        {
            // Any initialization logic
        }

        private void ExitHouseKeeping_Click_1(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }
    }
}
