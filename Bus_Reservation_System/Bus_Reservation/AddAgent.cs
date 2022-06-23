using Contents.Define;
using Contents.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Reservation
{
    public partial class AddAgent : Form
    {
        public AddAgent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanel().Show();
        }

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            if (txtCname.Text != "" && txtEmail.Text != "" && txtPass.Text != "" && txtCPass.Text != "")
            {
                string pt = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(txtEmail.Text, pt))
                {
                    if (txtCPass.Text == txtPass.Text)
                    {
                        DAgentRegister dar = new DAgentRegister();
                        dar.cname = txtCname.Text;
                        dar.email = txtEmail.Text;
                        dar.pass = txtPass.Text;

                        OAgentRegister oar = new OAgentRegister();
                        int number = oar.agentregister(dar);
                        if (number > 0)
                        {
                            MessageBox.Show("Agent Added!!");
                            new AdminPanel().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Doesn't Match!");
                    }
                }
                else
                {
                    MessageBox.Show("Please provide valid Email!");
                }
            }
        }
    }
}
