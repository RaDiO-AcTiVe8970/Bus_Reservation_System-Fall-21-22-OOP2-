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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if(checkBox1.Checked) textBox2.UseSystemPasswordChar = false;
           else textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "admin")
                {
                    this.Hide();
                    new AdminPanel().Show();
                }
                else
                {
                    MessageBox.Show("Invalid Password~!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Login~!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserLogin().Show();
        }
    }
}
