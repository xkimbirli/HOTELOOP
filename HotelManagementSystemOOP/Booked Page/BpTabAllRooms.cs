using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class BpTabAllRooms : UserControl
    {
        private string cs = @"Data Source=TOTOO.db";

        public BpTabAllRooms()
        {
            InitializeComponent();
        }

        private void BpTabAllRooms_Load(object sender, EventArgs e)
        {
            LoadRoomData(); // Load all rooms initially
        }

        public void LoadRoomData()
        {
            try
            {
                using (var connection = new SQLiteConnection(cs))
                {
                    connection.Open();

                    string selectQuery = "SELECT r.RoomNumber, r.RoomType, f.FloorNumber, r.RoomStatus " +
                                         "FROM Rooms r " +
                                         "JOIN Floor f ON f.FloorID = r.FloorID";

                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind data to DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FilterRoomsByStatus(string roomStatus)
        {
            try
            {
                using (var connection = new SQLiteConnection(cs))
                {
                    connection.Open();

                    string selectQuery = "SELECT r.RoomNumber, r.RoomType, f.FloorNumber, r.RoomStatus " +
                                         "FROM Rooms r " +
                                         "JOIN Floor f ON f.FloorID = r.FloorID " +
                                         "WHERE r.RoomStatus = @RoomStatus";

                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@RoomStatus", roomStatus);

                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind data to DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event if needed
        }

        // Inside BpTabAllRooms user control
        public void PerformSearch(string searchText)
        {
            // Your search logic implementation here
            // Example:
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool rowVisible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        rowVisible = true;
                        break;
                    }
                }
                row.Visible = rowVisible;
            }
        }

    }
}
