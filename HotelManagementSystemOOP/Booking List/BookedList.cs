using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using NavigationView;
using System.Data.SQLite;
using System.IO;

namespace HotelManagementSystemOOP
{
    public partial class BookingList : Form
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        private BookingList bookingList;
        public BookingList()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }

        private StaffDashboard staffDashboard;
        public BookingList(StaffDashboard staffDashboard)
        {
            InitializeComponent();
            this.staffDashboard = staffDashboard;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }
        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {
                new DeluxeRoomBookedListTab(),
                new StandardRoomBookedListTab(),
                new SuiteRoomBookedListTab()
            };

            navigationControl = new NavigationControl(userControls, panel2); // create an instance of NavigationControl class
            navigationControl.Display(0); // display StandardRoomInformation as default
        }
        private BookingPage bookingPage;
        public BookingList(BookingPage bookingPage)
        {
            InitializeComponent();
            this.bookingPage = bookingPage;
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }
        private void InitializeNavigationButtons()

        {

            List<Button> buttons = new List<Button>()

            {
                StandardRoomTabRC,
                DeluxeRoomTabRC,
                SuiteRoomRC
            };
            navigationButtons = new NavigationButtons(buttons);
            // Attach event handlers
            StandardRoomTabRC.Click += StandardRoomTabRC_Click;
            DeluxeRoomTabRC.Click += button3_Click;
            SuiteRoomRC.Click += SuiteRoomRC_Click;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void MenuDashboardButtonRC_Click(object sender, EventArgs e)
        {
            // Create an instance of Booking Page and pass the current form instance
            BookingPage bookingPage = new BookingPage(this);

            // Show the booking Page
            bookingPage.Show();

            // Hide the current form
            this.Hide();
        }

        private void SuiteRoomRC_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
        }

        private void MenuBookingButtonRC_Click(object sender, EventArgs e)
        {

        }

        private StaffDashboard GetStaffDashboard()
        {
            return staffDashboard;
        }

        private void MenuRoomButtonBL_Click(object sender, EventArgs e, StaffDashboard staffDashboard)
        {
            staffDashboard.Show();
            this.Close();
        }

        private void BookingList_Load(object sender, EventArgs e)
        {
            DisplayLatestHotelLogo();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }
        private void DisplayLatestHotelLogo()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

                // Query to select the latest logo based on the highest ID (assuming descending order)
                string query = "SELECT Logo FROM Hotel ORDER BY HotelID DESC";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // Convert byte array to image
                            byte[] imgData = (byte[])dt.Rows[0]["Logo"];
                            Image img;
                            using (MemoryStream ms = new MemoryStream(imgData))
                            {
                                img = Image.FromStream(ms);
                            }

                            // Display image in pictureBox1
                            pictureBox2.Image = img;
                        }
                    }
                }
            }
        }
        private void StandardRoomTabRC_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
        }

        private void MenuDashboardBL_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = new StaffDashboard(this);
            staffDashboard.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}