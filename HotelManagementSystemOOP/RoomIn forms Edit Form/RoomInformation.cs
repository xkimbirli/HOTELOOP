using NavigationView;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class RoomInformation : Form
    {
        NavigationControl navigationControl;
        private AdminDashboard adminDashboard;

        public RoomInformation()
        {
            InitializeComponent();
            InitializeNavigationControl();
            PopulateComboBox();
        }

        public RoomInformation(AdminDashboard adminDashboard)
        {
            InitializeComponent();
            this.adminDashboard = adminDashboard;
            InitializeNavigationControl();
            PopulateComboBox();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {
                new DeluxeRoomInfoEdit(),
                new StandardRoomInfoEdit(),
                new SuiteRoomInfoEdit()
            };

            navigationControl = new NavigationControl(userControls, panel1); // create an instance of NavigationControl class
            navigationControl.Display(0); // display StandardRoomInformation as default
        }

        private void PopulateComboBox()
        {
            comboBox1.Items.Add("Deluxe Room");
            comboBox1.Items.Add("Standard Room");
            comboBox1.Items.Add("Suite Room");
            comboBox1.SelectedIndex = 0; // Set default selection
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            navigationControl.Display(selectedIndex);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Event handler for label1 click, if needed
        }

        private void RoomInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
