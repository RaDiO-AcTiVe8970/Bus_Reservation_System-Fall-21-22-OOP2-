using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Reservation
{
    public partial class User_Login : Form
    {
        public User_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Buy_Ticket().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // this.Hide();
            new Check_Details().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new View_Reservation_Info().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           //this.Hide();
            new UserSchedule().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new View_Bus_Details().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserLogin().Show();
        }

        private void User_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
