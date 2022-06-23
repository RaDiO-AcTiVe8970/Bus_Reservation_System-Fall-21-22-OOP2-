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
    public partial class BusInfo : Form
    {
        public BusInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBus db = new DBus();
            db.bname = txtBname.Text;
            OBus ob = new OBus();
            SqlDataAdapter sql = ob.show(db);
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
