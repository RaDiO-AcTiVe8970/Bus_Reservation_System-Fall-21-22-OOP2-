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
    public partial class UserSchedule : Form
    {
        public UserSchedule()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBus db = new DBus();
            db.date = dateTimePicker1.Text;
            db.departure = comboBox1.Text;
            OBus ob = new OBus();
            SqlDataAdapter sql = ob.showSchedule(db);
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridUser.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OBus ob = new OBus();
            SqlDataAdapter sql = ob.showAll();
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridUser.DataSource = dataTable;
        }
    }
}
