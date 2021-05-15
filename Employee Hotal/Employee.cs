using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Employee_Hotal
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtid.Text, txtName.Text,
txtGender.Text,

        txtphone.Text,
     txtAddress.Text,
    txtposition.Text,
  txtEducation.Text,
    txtdate.Text
);


            try
            {





                //int employeeID = Convert.ToInt32(employeeID.Text);
                int EmployeeID = Convert.ToInt32(txtid.Text);
                string employeeName = txtName.Text;
                string EmployeeGender = txtGender.Text;
                string EmployeePhone = txtphone.Text;
                string EmployeeAddress = txtAddress.Text;
                string EmployeePosition = txtposition.Text;
                string EmployeeEducation = txtEducation.Text;
                string EmployeeDOB = txtdate.Text;




                SqlConnection con = new SqlConnection();



                con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=hotal;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into  employee values ('" + EmployeeID + "','" + employeeName + "','" + EmployeeGender + "','" + EmployeePhone + "','" + EmployeeAddress + "','" + EmployeePosition + "','" + EmployeeEducation + "','" + EmployeeDOB + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
              
                DA.Fill(DS);
               




            }
            catch (Exception)
            {
                MessageBox.Show("Saved!");


            }
           
            txtName.Clear();
            txtAddress.Clear();
            txtphone.Clear();
            txtid.Clear();

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



            }
            con.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=hotal;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"UPDATE [hotal].[dbo].[employee]
   SET [EmployeeID] ='" + txtid.Text + "',[EmployeeName] ='" + txtName.Text + "' ,[EmployeeGender] ='" + txtGender.Text + "',[EmployeePhone] ='" + txtphone.Text + "' ,[EmployeeAddress] ='" + txtAddress.Text + "' ,[EmployeePosition] ='" + txtposition.Text + "' ,[EmployeeEducation] ='" + txtEducation.Text + "' ,[EmployeeDOB] ='" + txtdate.Text + "'  WHERE [EmployeeID] ='" + txtid.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update");
            con.Close();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=hotal;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [hotal].[dbo].[employee]
      WHERE [EmployeeID] ='" + txtid.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete");
            con.Close();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            new Home().Show();
            this.Hide();
                 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

    
    }
}
