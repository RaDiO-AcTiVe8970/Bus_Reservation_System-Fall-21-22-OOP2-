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
    public partial class CheckAgentDetails : Form
    {
        public CheckAgentDetails()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanel().Show();
        }

        private void CheckAgentDetails_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-63QCUO7H;Initial Catalog=BusReservation;Integrated Security=True");
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
            DAgentRegister dar = new DAgentRegister();
            dar.cname = comboCname.Text;
            OAgentRegister oar = new OAgentRegister();
            SqlDataAdapter sql = oar.show(dar);
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridAgent.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OAgentRegister oar = new OAgentRegister();
            SqlDataAdapter sql = oar.showAll();
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridAgent.DataSource = dataTable;
        }

        private void comboCname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
