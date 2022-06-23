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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new AdminLogin().Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new AgentLogin().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) txtPass.UseSystemPasswordChar = false;
            else txtPass.UseSystemPasswordChar = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new register().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DUserRegister dr = new DUserRegister();
            dr.email = txtEmail.Text;
            dr.password = txtPass.Text;

            OUserRegister ur = new OUserRegister();
            SqlDataAdapter sql = ur.userLogin(dr);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                new User_Login().Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password~!");
            }
        }
    }
}
