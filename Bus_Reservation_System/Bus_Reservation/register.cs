using Contents.Define;
using Contents.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Reservation
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) txtPass.UseSystemPasswordChar = false;
            else txtPass.UseSystemPasswordChar = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) txtCPass.UseSystemPasswordChar = false;
            else txtCPass.UseSystemPasswordChar = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserLogin().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && comboGender.Text != "" && comboCity.Text != "" && txtPass.Text != "" && txtCPass.Text != "" && txtAddress.Text != "" && txtPAddress.Text != "" && txtPhone.Text != "")
            {
                string pt = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(txtEmail.Text, pt))
                {
                    if (txtCPass.Text == txtPass.Text)
                    {
                        DUserRegister ds = new DUserRegister();
                        ds.name = txtName.Text;
                        ds.username = txtUname.Text;
                        ds.gender = comboGender.Text;
                        ds.city = comboCity.Text;
                        ds.phone = txtPhone.Text;
                        ds.address = txtAddress.Text;
                        ds.paddress = txtPAddress.Text;
                        ds.email = txtEmail.Text;
                        ds.password = txtPass.Text;

                        OUserRegister or = new OUserRegister();
                        int number = or.userregister(ds);
                        if (number > 0)
                        {
                            MessageBox.Show("Sign Up Done!!");
                            new UserLogin().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Doesn't Match!");
                    }
                }
                else
                {
                    MessageBox.Show("Please provide valid Email!");
                }

            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
