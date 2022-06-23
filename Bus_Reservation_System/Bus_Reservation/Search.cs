using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Reservation
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanel().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchAgent sa = new SearchAgent();
            sa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SearchUser su = new SearchUser();
            su.ShowDialog();
        }
    }
}
