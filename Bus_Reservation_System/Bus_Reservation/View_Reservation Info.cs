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
    public partial class View_Reservation_Info : Form
    {
        public View_Reservation_Info()
        {
            InitializeComponent();
        }

   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new User_Login().Show();
        }

        private void btnSHow_Click(object sender, EventArgs e)
        {
            DTicket dt = new DTicket();
            dt.name = textUsername.Text;
            OTicket ob = new OTicket();
            SqlDataAdapter sql = ob.show(dt);
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridResInfo.DataSource = dataTable;
        }
    }
}
