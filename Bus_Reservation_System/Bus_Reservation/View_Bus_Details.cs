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
    public partial class View_Bus_Details : Form
    {
        public View_Bus_Details()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User_Login().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBus db = new DBus();
            db.bname = textBname.Text;
            OBus ob = new OBus();
            SqlDataAdapter sql = ob.showUser(db);
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
    }
}
