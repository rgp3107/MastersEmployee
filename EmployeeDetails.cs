using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyDe
{
    public partial class EmployeeDetails : Form
    {
        SqlConnection con;
        string ConnectionString = "Data Source=RGP\\MSSQLSERVER01;Initial Catalog=CompanyDe;Integrated Security=True";
        DataTable dt;
        SqlDataAdapter adp;
        public EmployeeDetails()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionString);

            Display();
        }

        private void Display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                string query = "SELECT * FROM Employees";
                adp = new SqlDataAdapter(query, con);
                adp.Fill(dt);

                dataGridView1.DataSource = dt;
                con.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                adp = new SqlDataAdapter("SELECT * FROM Employees WHERE FirstName LIKE '%" + txtSearch.Text + "%'", con);
                dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text != null && txtLastName.Text != null && txtEmpId.Text != null && txtMobile.Text != null)
                {
                    string isActive;
                    if (rdrMyes.Checked)
                    {
                        isActive = "True";
                    }
                    else
                    {
                        isActive = "False";
                    }

                    string isAdmin;
                    if (rdrAdmin.Checked)
                    {
                        isAdmin = "True";
                    }
                    else
                    {
                        isAdmin = "False";
                    }
                    con.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand("INSERT INTO Employees (EmployeeId,EmployeeCode,FirstName,LastName,IsMarried,Emp_Address,City,Zipcode,Mobile,Employee_Email,UserId,UserPassword,IsAdmin,DateOfBirth) VALUES (@id,@code,@fname,@lname,@isActive,@add,@city,@zipcode,@mobile,@email,@user,@pass,@isAdmin,@DOB)", con);
                    cmd.Parameters.Add("@id", txtEmpId.Text);

                    //@id,@code,@fname,@lname,@isActive,@add,@city,@zipcode,@mobile,@email,@user,@pass,@isAdmin,@DOB
                    cmd.Parameters.Add("@name", txtEmpCode.Text);
                    cmd.Parameters.Add("@code", txtFirstName.Text);
                    cmd.Parameters.Add("@fname", txtFirstName.Text);
                    cmd.Parameters.Add("@lname", txtLastName.Text);
                    cmd.Parameters.Add("@isActive", isActive);
                    cmd.Parameters.Add("@add", txtEmpAddress.Text);
                    cmd.Parameters.Add("@city", txtCity.Text);
                    cmd.Parameters.Add("@zipcode", txtZipcode.Text);
                    cmd.Parameters.Add("@mobile", txtMobile.Text);
                    cmd.Parameters.Add("@email", txtEmail.Text);
                    cmd.Parameters.Add("@user", txtUserId.Text);
                    cmd.Parameters.Add("@pass", txtUserPassword.Text);
                    cmd.Parameters.Add("@isAdmin", isAdmin);
                    cmd.Parameters.Add("DOB", DOB.Value);



                    cmd.ExecuteNonQuery();


                    cmd.Dispose();
                    con.Close();
                    Display();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rdrMyes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
