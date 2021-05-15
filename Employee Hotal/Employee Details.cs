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
    public partial class Employee_Details : Form
    {
        public Employee_Details()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
                 
        }

        private void button1_Click(object sender, EventArgs e)
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
                txtGender.Text = (dr["EmployeeGender"].ToString());
                txtphone.Text = (dr["EmployeePhone"].ToString());
                txtAddress.Text = (dr["EmployeeAddress"].ToString());
                txtposition.Text = (dr["EmployeePosition"].ToString());
                txtEducation.Text = (dr["EmployeeEducation"].ToString());
                txtdate.Text = (dr["EmployeeDOB"].ToString());
                txtName.Visible = true;
                txtGender.Visible = true;
                txtphone.Visible = true;
                txtAddress.Visible = true;
                txtposition.Visible = true;
                txtEducation.Visible = true;
                txtdate.Visible = true;


            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {

                printDocument1.Print();
            
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("===Employee==",new Font("Century Gothic",25,FontStyle.Bold ),Brushes.Red,new Point(200));

            e.Graphics.DrawString("Employee ID:"+textBox1.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Red, new Point(10,100));
            e.Graphics.DrawString("Employee Gender:" + txtGender.Text , new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Blue, new Point(10, 140));

            e.Graphics.DrawString("Employee Phone:"+txtphone.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Orange, new Point(10, 190));

            e.Graphics.DrawString("Employee Address:" + txtAddress.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Red, new Point(10, 220));
            e.Graphics.DrawString("Employee Position:" + txtposition.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Red, new Point(10, 260));

            e.Graphics.DrawString("Employee Education:" + txtEducation.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Red, new Point(10, 310));


            e.Graphics.DrawString("Employee DOB:" + txtdate.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Red, new Point(10, 360));










        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
