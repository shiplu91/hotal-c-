using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Employee_Hotal
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
                 
        }
        int Dailybase, total;
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text == "")
            {

                MessageBox.Show("Select");

            }
            else if (wrokedTB.Text == "" || Convert.ToInt32(wrokedTB.Text) > 30)
            {


                MessageBox.Show("Please:Enter the number");


            }
            else
            {
                if (txtPosition.Text == "Maneger")
                {
                    Dailybase = 400;
                }
                else if (txtPosition.Text == "Sub Maneger")
                {
                    Dailybase = 300;
                }
                else if (txtPosition.Text == "IT")
                {

                    Dailybase = 500;


                }
                else if (txtPosition.Text == "Supperferger")
                {

                    Dailybase = 280;

                }
                else if (txtPosition.Text == "Officers")
                {

                    Dailybase = 120;
                }
                else if (txtPosition.Text == "Security")
                {

                    Dailybase = 100;

                }
                else if (txtPosition.Text == "Accounting")
                {
                    Dailybase = 120;

                }
                else
                {
                    Dailybase = 150;


                }
                total = Dailybase * Convert.ToInt32(wrokedTB.Text);
                txtrich.Text = "Employee ID:" + textBox1.Text + "\n" + "Employee Name:" + txtName.Text + "\n" + "Employee Position:" + txtPosition.Text + "\n" + "Employee Wroked:" + wrokedTB.Text + "\n" + "Daily:" + Dailybase + "\n" + "Total Amount:" + total;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("dd");

            }
            else
            {

                string Sourch = "Data Source=LAPTOP-O86D32ES;Initial Catalog=hotal;Integrated Security=True";
                SqlConnection con = new SqlConnection(Sourch);
                con.Open();
                MessageBox.Show("search");
                string sqlSelectQuery = "select * from employee where  EmployeeID=" + int.Parse(textBox1.Text);
                SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {




                    txtName.Text = (dr["employeeName"].ToString());

                    txtPosition.Text = (dr["EmployeePosition"].ToString());




                }
                con.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {

                printDocument1.Print();

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("===Employee==", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(200));

            e.Graphics.DrawString("Employee ID:" + textBox1.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 100));
            e.Graphics.DrawString("Employee Name:" + txtName.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 180));     
            e.Graphics.DrawString("Employee ID:" + textBox1.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 100));

          
         

            //e.Graphics.DrawString("Employee Address:" , new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Red, new Point(10, 220));
            e.Graphics.DrawString("Employee Position:"+txtPosition.Text , new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 260));

            e.Graphics.DrawString("Employee Wroked:" + wrokedTB.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 310));


            e.Graphics.DrawString("Dailypay :"+Dailybase, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 370));

            e.Graphics.DrawString("Total Salary:" + total, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 400));


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void wrokedTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
