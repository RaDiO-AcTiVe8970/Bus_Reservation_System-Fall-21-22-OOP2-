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
    public partial class Add_Bus : Form
    {
        public Add_Bus()
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
            if (txtBname.Text != "" && comboBusType.Text != "" && comboRoute.Text != "" && txtTotalBus.Text != "" && txtPrice.Text !="")
            {
                 DBus bus = new DBus();
                bus.bname = txtBname.Text;
                bus.btype = comboBusType.Text;
                bus.route = comboRoute.Text;
                bus.totalbus = txtTotalBus.Text;
                bus.price = txtPrice.Text;
                bus.cname = txtCname.Text;

                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-63QCUO7H;Initial Catalog=BusReservation;Integrated Security=True");
                connection.Open();
                SqlCommand check = new SqlCommand("select (cname) from AgentReg where cname='"+ txtCname.Text +"'", connection);
                SqlDataReader reader = check.ExecuteReader();
                if (reader.HasRows)
                {
                    OBus ob = new OBus();
                    int number = ob.addbus(bus);
                    if (number > 0)
                    {
                        MessageBox.Show("Bus Added~!");
                        new Agent_Panel_Login().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Correct company name~!");
                }
                reader.Close();
                reader.Dispose();
                connection.Close();
            }
        }

        private void txtTotalBus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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
