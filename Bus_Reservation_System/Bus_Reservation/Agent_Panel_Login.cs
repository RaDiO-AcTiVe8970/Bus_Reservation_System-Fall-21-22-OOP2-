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
    public partial class Agent_Panel_Login : Form
    {
        public Agent_Panel_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Add_Bus().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Set_Schedule().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AgentLogin().Show();
        }

        private void Agent_Panel_Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SeeAgentDetails().Show();
        }
    }
}
