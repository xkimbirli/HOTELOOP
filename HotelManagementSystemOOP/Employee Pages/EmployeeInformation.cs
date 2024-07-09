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

    public partial class EmployeeInformation : Form
    {
        private AdminDashboard adminDashboard;
        private string connectionString = "Data Source=TOTOO.db;Version=3;";
        public EmployeeInformation(AdminDashboard adminDashboard)
        {
            InitializeComponent();
            this.adminDashboard = adminDashboard;
            LoadEmployeeData();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick; // Ensure the event is wired up
        }

        private void LoadEmployeeData()
        {
            string query = "SELECT Employee.Name, Employee.Position FROM Employee";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Employee data: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            
            }
        }
        private void EmployeeInformation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of add employeee and pass the current form instance
            AddEmployee addEmployee = new AddEmployee(this);

            // Show the Add employee
            addEmployee.Show();
        }

        private void DashboardButtonEI_Click(object sender, EventArgs e)
        {
            //Create an instance of AdminDashboard
            AdminDashboard adminDashboard = this.adminDashboard;

            // show the Admin Dashboard
            adminDashboard.Show();

            //close the current page
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
