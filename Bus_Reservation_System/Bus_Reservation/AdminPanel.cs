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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminLogin().Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Search().Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminCheckSchedule().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserDetails().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CheckBusDetails().Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddAgent().Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CheckAgentDetails().Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
