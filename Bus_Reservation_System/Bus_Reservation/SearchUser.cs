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
    public partial class SearchUser : Form
    {
        public SearchUser()
        {
            InitializeComponent();
        }

        private void SearchUser_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-63QCUO7H;Initial Catalog=BusReservation;Integrated Security=True");
            try
            {
                connection.Open();
                SqlCommand sc = new SqlCommand("select (username) from UserRegLat", connection);
                SqlDataReader reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("username", typeof(string));
                dt.Load(reader);
                comboUser.ValueMember = "username";
                comboUser.DataSource = dt;
                connection.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DUserRegister dar = new DUserRegister();
            dar.username = comboUser.Text;
            OUserRegister oar = new OUserRegister();
            SqlDataAdapter sql = oar.show(dar);
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridUser.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DUserRegister dur = new DUserRegister();
            dur.username = comboUser.Text;

            OUserRegister oup = new OUserRegister();
            int number = oup.delete(dur);

            if (number > 0)
            {
                MessageBox.Show("Deleted~!");
            }
            else
            {
                MessageBox.Show("Failed to Delete~!");
            }
        }
    }
}
