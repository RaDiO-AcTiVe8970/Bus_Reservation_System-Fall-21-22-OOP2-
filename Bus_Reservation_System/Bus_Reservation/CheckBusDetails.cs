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
    public partial class CheckBusDetails : Form
    {
        List<DAgentRegister> company = new List<DAgentRegister>();
        List<DBus> bus1 = new List<DBus>();
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-63QCUO7H;Initial Catalog=BusReservation;Integrated Security=True");
        public CheckBusDetails()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanel().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CheckBusDetails_Load(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                SqlCommand sc = new SqlCommand("select (cname) from AgentReg", connection);
                SqlDataReader reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("cname", typeof(string));
                dt.Load(reader);
                comboCname.ValueMember = "cname";
                comboCname.DataSource = dt;
                connection.Close(); 
            }
            catch (Exception)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBus db = new DBus();
            db.bname = textBname.Text;
            db.cname = comboCname.Text;
            OBus ob = new OBus();
            SqlDataAdapter sql = ob.showAdmin(db);
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridBus.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OBus ob = new OBus();
            SqlDataAdapter sql = ob.showAll();
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridBus.DataSource = dataTable;
        }

        private void comboCname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
