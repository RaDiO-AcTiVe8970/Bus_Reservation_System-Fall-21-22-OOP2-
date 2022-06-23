using Contents.Define;
using Contents.Operation;
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
    public partial class SeeAgentDetails : Form
    {
        public SeeAgentDetails()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Agent_Panel_Login().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgentGeneralInfo ag = new AgentGeneralInfo();
            ag.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BusInfo bi = new BusInfo();
            bi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SeeAgentDetails_Load(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DAgentRegister dar = new DAgentRegister();
            dar.email = txtEmail.Text;

            OAgentRegister oar = new OAgentRegister();
            int number = oar.deleteagent(dar);

            if (number > 0)
            {
                MessageBox.Show("Account Deleted~!");
                this.Hide();
                new AgentLogin().Show();
            }
            else
            {
                MessageBox.Show("Deletion Failed~!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
        }
    }
}
