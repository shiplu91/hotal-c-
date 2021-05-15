using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Hotal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "user")
            {

                if (txtpass.Text == "pass")
                {
                    new Home().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please:Enter the correct informtion");
                
                }
            }
            else
            {
                MessageBox.Show("Please:Enter the correct informtion");

            }
        }
    }
}
