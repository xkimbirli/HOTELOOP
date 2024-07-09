using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    
    public partial class BpTabStandardRooms : UserControl
    {
        private string cs = @"Data Source=TOTOO.db";
        public BpTabStandardRooms()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BpTabStandardRooms_Load(object sender, EventArgs e)
        {
            LoadRoomData();
        }
        private void LoadRoomData()
        {
            try
            {
                using (var connection = new SQLiteConnection(cs))
                {
                    connection.Open();
                    string selectQuery = "SELECT r.RoomNumber, f.FloorNumber, r.RoomStatus " +
                                        "FROM Rooms r " +
                                        "JOIN Floor f ON f.FloorID = r.FloorID " +
                                        "WHERE r.RoomType = 'Standard';";


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
                                DataPropertyName = "RoomNumber",
                                HeaderText = "Room Number"
                            });
                            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                            {
                                DataPropertyName = "RoomStatus",
                                HeaderText = "Room Status"
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
