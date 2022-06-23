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
    public partial class AgentGeneralInfo : Form
    {
        public AgentGeneralInfo()
        {
            InitializeComponent();
        }

        private void AgentGeneralInfo_Load(object sender, EventArgs e)
        {
            btnName.Visible = false;
            btnPass.Visible = false;
            textNewname.Visible = false;
            textPass.Visible = false;
            lblName.Visible = false;
            lblPass.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            textNewname.Visible = true;
            btnName.Visible = true;
            lblPass.Visible = false;
            textPass.Visible = false;
            btnPass.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblName.Visible = false;
            textNewname.Visible = false;
            btnName.Visible = false;
            lblPass.Visible = true;
            textPass.Visible = true;
            btnPass.Visible = true;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            DAgentRegister dar = new DAgentRegister();
            dar.email = textEmail.Text;
            dar.cname = textNewname.Text;
            DBus db = new DBus();
            db.cname = textCurrCname.Text;
            db.newCname = textNewname.Text;
            OAgentRegister oar = new OAgentRegister();
            int number = oar.updateName(dar);
            OBus ob = new OBus();
            int number2 = ob.updateName(db);
            if(number> 0)
            {
                if(number2>0)
                {
                    MessageBox.Show("Update Succesful~!");
                }
            }
            else
            {
                MessageBox.Show("Update Failed~!");
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            DAgentRegister dar = new DAgentRegister();
            dar.email = textEmail.Text;
            dar.pass = textPass.Text;
            OAgentRegister oar = new OAgentRegister();
            int number = oar.updatePass(dar);
            if(number>0)
            {
                MessageBox.Show("Update Succesful~!");
            }
            else
            {
                MessageBox.Show("Update Failed~!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAgentRegister dar = new DAgentRegister();
            dar.email = textEmail.Text;
            OAgentRegister oar = new OAgentRegister();
            SqlDataAdapter sql = oar.showViaEmail(dar);
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridAgentView.DataSource = dataTable;
        }
    }
}
