using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HotelManagementSystemOOP
{
    public partial class RoomInfos : Form
    {
        private BookingPage bookingPage;
        private string cs = @"Data Source=TOTOO.db";

        public RoomInfos(BookingPage bookingPage)
        {
            InitializeComponent();
            this.bookingPage = bookingPage;
        }

        private void RoomInfos_Load(object sender, EventArgs e)
        {
            
        }

       

    private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional handler
        }
    }
}
