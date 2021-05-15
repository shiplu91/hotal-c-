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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Employee().Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Employee_Details().Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Salary().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Employee().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Employee_Details().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Salary().Show();
            this.Hide();
        }
    }
}
