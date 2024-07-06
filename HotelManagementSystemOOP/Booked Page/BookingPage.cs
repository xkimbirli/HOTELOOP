using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Windows.Forms;
using NavigationView;
using System.Drawing;

namespace HotelManagementSystemOOP
{
    public partial class BookingPage : Form
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\TOTOO.db";

        NavigationControl navigationControl;
        NavigationButtons navigationButtons;
        private StaffDashboard staffDashboard;
        private BookingList bookingList;

        public BookingPage()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }

        // Constructor for initializing with StaffDashboard
        public BookingPage(StaffDashboard staffDashboard)
        {
            InitializeComponent();
            this.staffDashboard = staffDashboard;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            InitializeNavigationControl();
            InitializeNavigationButtons();
        }

        // Constructor for initializing with BookingList
        public BookingPage(BookingList bookingList)
        {
            InitializeComponent();
            this.bookingList = bookingList;
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }
        
        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {
                new BpTabStandardRooms(),
                new BpTabAllRooms(),
                new BpTabDeluxeRooms(),
                new BpTabSuiteRooms()
            };

            navigationControl = new NavigationControl(userControls, DisplayPanelBP);
            navigationControl.Display(0); // Display BpTabStandardRooms as default
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            {
                StandardRoomTabBP,
                AllRoomsTabBP,
                DeluxeRoomTabBP,
                SuiteRoomBP
            };

            navigationButtons = new NavigationButtons(buttons);

            // Attach event handlers
            StandardRoomTabBP.Click += StandardRoomTabBP_Click;
            AllRoomsTabBP.Click += AllRoomsTabBP_Click;
            DeluxeRoomTabBP.Click += DeluxeRoomTabRC_Click;
            SuiteRoomBP.Click += SuiteRoomBP_Click;

            navigationButtons.Highlight(StandardRoomTabBP);
        }

        private void StandardRoomTabBP_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("StandardRoomTabBP_Click invoked");
                navigationControl.Display(0); // Display BpTabStandardRooms
                navigationButtons.Highlight(StandardRoomTabBP);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in StandardRoomTabBP_Click: " + ex.Message);
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void AllRoomsTabBP_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("AllRoomsTabBP_Click invoked");
                navigationControl.Display(1); // Display BpTabAllRooms
                navigationButtons.Highlight(AllRoomsTabBP);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in AllRoomsTabBP_Click: " + ex.Message);
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DeluxeRoomTabRC_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("DeluxeRoomTabRC_Click invoked");
                navigationControl.Display(2); // Display BpTabDeluxeRooms
                navigationButtons.Highlight(DeluxeRoomTabBP);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DeluxeRoomTabRC_Click: " + ex.Message);
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void SuiteRoomBP_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("SuiteRoomBP_Click invoked");
                navigationControl.Display(3); // Display BpTabSuiteRooms
                navigationButtons.Highlight(SuiteRoomBP);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in SuiteRoomBP_Click: " + ex.Message);
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BookingForm bookingform = new BookingForm(this);
                bookingform.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in button2_Click: " + ex.Message);
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            // Calendar date changed event logic (if any)
        }

        private void MenuBookingButtonBP_Click(object sender, EventArgs e)
        {
            try
            {
                BookingList bookingList = new BookingList(this);
                bookingList.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in MenuBookingButtonBP_Click: " + ex.Message);
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void MenuDashboardButtonBP_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = new StaffDashboard(this);
            staffDashboard.Show();
            this.Hide();
        }

        private void BookingPage_Load(object sender, EventArgs e)
        {
            DisplayLatestHotelLogo();
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
        private void DisplayPanelBP_Paint(object sender, PaintEventArgs e)
        {
            // Paint event logic for DisplayPanelBP (if any)
        }

        private void AllRoomsTabBP_Click_1(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("AllRoomsTabBP_Click_1 invoked");
                navigationControl.Display(1); // Display BpTabAllRooms
                navigationButtons.Highlight(AllRoomsTabBP);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in AllRoomsTabBP_Click_1: " + ex.Message);
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MenuRoomInfoButtonBP_Click(object sender, EventArgs e)
        {
            RoomInfos roomInfos = new RoomInfos(this);
            roomInfos.Show();
            this.Close();
        }
    }
}
