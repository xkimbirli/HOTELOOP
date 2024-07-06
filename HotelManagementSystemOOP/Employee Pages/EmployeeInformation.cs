using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public EmployeeInformation(AdminDashboard adminDashboard)
        {
            InitializeComponent();
            this.adminDashboard = adminDashboard;
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
    }
}
