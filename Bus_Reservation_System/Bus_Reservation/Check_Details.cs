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
    public partial class Check_Details : Form
    {
        public Check_Details()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User_Login().Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            DUserRegister dur = new DUserRegister();
            dur.username = textName.Text;
            dur.username = textName.Text;
            OUserRegister our = new OUserRegister();
            SqlDataAdapter sql = our.showByUser(dur);
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridUser.DataSource = dataTable;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DUserRegister dur = new DUserRegister();
            dur.name = textNewName.Text;
            dur.username = textName.Text;
            OUserRegister our = new OUserRegister();
            int number = our.upadateName(dur);

            if (number > 0)
            {
                MessageBox.Show("Name Updated~!");
            }
            else
            {
                MessageBox.Show("Failed~!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DUserRegister dur = new DUserRegister();
            dur.username = textName.Text;
            dur.password = textBNewPass.Text;
            OUserRegister our = new OUserRegister();
            int number = our.upadatePassword(dur);

            if (number > 0)
            {
                MessageBox.Show("Password Updated~!");
            }
            else
            {
                MessageBox.Show("Failed~!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DUserRegister dur = new DUserRegister();
            dur.username = textName.Text;
            dur.phone = textPhone.Text;
            OUserRegister our = new OUserRegister();
            int number = our.upadatePhone(dur);

            if (number > 0)
            {
                MessageBox.Show("Phone Updated~!");
            }
            else
            {
                MessageBox.Show("Failed~!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DUserRegister dur = new DUserRegister();
            dur.username = textName.Text;
            dur.email = textEmail.Text;
            OUserRegister our = new OUserRegister();
            int number = our.upadatEmail(dur);

            if (number > 0)
            {
                MessageBox.Show("Email Updated~!");
            }
            else
            {
                MessageBox.Show("Failed~!");
            }
        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
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
