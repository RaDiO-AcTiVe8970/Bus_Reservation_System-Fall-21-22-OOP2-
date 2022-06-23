using Contents.Define;
using Contents.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Reservation
{
    public partial class AgentLogin : Form
    {
        public AgentLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAgentRegister dar = new DAgentRegister();
            dar.email = txtEmail.Text;
            dar.pass = txtPass.Text;

            OAgentRegister ar = new OAgentRegister();
            SqlDataAdapter sql = ar.agentLogin(dar);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                new Agent_Panel_Login().Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password~!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserLogin().Show();
        }
    }
}
