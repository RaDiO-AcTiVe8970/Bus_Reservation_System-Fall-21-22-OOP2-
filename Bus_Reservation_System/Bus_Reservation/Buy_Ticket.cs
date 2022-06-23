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
    public partial class Buy_Ticket : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-63QCUO7H;Initial Catalog=BusReservation;Integrated Security=True");
        public Buy_Ticket()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new User_Login().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTicket dt = new DTicket();
            dt.name = textUsername.Text;
            dt.btype = comboBtype.Text;
            dt.email = textEmail.Text;
            dt.departure = comboDept.Text;
            dt.bname = comboBname.Text;
            dt.phone = textPhone.Text;
            dt.seat = textSeat.Text;
            dt.destination = comboBox1.Text;
            OTicket ob = new OTicket();

            connection.Open();
            SqlCommand cmd = new SqlCommand ("select (bname) from bus where departure='" + comboDept.Text + "' and btype='" + comboBtype.Text + "' and route='" + comboBox1.Text + "'",connection);
            SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (textUsername.Text != "" && comboBtype.Text != "" && textEmail.Text != "" && textSeat.Text != "" && comboBname.Text != "" && comboDept.Text != "" && comboBox1.Text != "")
                    {
                        int number = ob.addTicket(dt);
                        if (number > 0)
                        {
                            MessageBox.Show("Bus Added~!");
                            //new User_Login().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error!");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Error~! Wrong Bus or timing.");
                }
                reader.Close();
                reader.Dispose();
            connection.Close();
        }

        private void Buy_Ticket_Load(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                SqlCommand sc = new SqlCommand("select (bname) from Bus", connection);
                SqlDataReader reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("bname", typeof(string));
                dt.Load(reader);
                comboBname.ValueMember = "bname";
                comboBname.DataSource = dt;
                connection.Close();
            }
            catch (Exception)
            {

            }
        }

        private void comboBtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void textSeat_KeyPress(object sender, KeyPressEventArgs e)
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
