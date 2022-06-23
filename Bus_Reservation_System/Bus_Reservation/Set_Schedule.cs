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
    public partial class Set_Schedule : Form
    {
        public Set_Schedule()
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
            DBus db = new DBus();
            db.bname = comboBname.Text;
            db.departure = comboDept.Text;
            db.date = dateTime.Text;

            OBus ob = new OBus();
            int number = ob.addtime(db);

            if(number >0)
            {
                MessageBox.Show("Bus Schedule Added~!");
                this.Hide();
                new Agent_Panel_Login().Show();
            }
            else
            {
                MessageBox.Show("Error~!");
            }    
        }

        private void Set_Schedule_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-63QCUO7H;Initial Catalog=BusReservation;Integrated Security=True");
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
    }
}

