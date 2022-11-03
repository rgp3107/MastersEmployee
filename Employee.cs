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

namespace Master_Database
{
    public partial class Employee : Form
    {
        string str = "Data Source=SMITS-LAPI;Initial Catalog=Masters;Integrated Security=True";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection con;
        SqlCommand cmd;
        public Employee()
        {
            InitializeComponent();
            con = new SqlConnection(str);
            display();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text == "" && txtEmpCode.Text == "" && txtFName.Text == "" && txtMName.Text == "" && txtLName.Text == "" && txtAdd1.Text == "" && txtAdd2.Text == "" && txtCIty.Text == "" && txtPinCode.Text == "" && txtMobile.Text == "" && txtEmail.Text == "" && txtUserId.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please fill the details");
            }
            else
            {
                try
                {
                    string EmpID = txtEmpID.Text;
                    string EmpCode = txtEmpCode.Text;
                    string FName = txtFName.Text;
                    string MName = txtMName.Text;
                    string LName = txtLName.Text;
                    string DOB = dtpDOB.Value.ToString();
                    string DOJ = dtpDOJ.Value.ToString();
                    string Add1 = txtAdd1.Text;
                    string Add2 = txtAdd2.Text;
                    string City = txtCIty.Text;
                    string PinCode = txtPinCode.Text;
                    string Mobile = txtMobile.Text;
                    string Email = txtEmail.Text;
                    string IsMarried;

                    if (rbtnY.Checked)
                    {
                        IsMarried = "Yes";
                    }
                    else
                    {
                        IsMarried = "No";
                    }

                    string IsAdmin;

                    if (rbtnYes.Checked)
                    {
                        IsAdmin = "Yes";

                    }
                    else
                    {
                        IsAdmin = "No";
                    }

                    string UserID = txtUserId.Text;
                    string Password = txtPassword.Text;

                    con.Open();
                    cmd = new SqlCommand("Insert into Employee ( EmployeeID, EmployeeCode, FName, MName, LName, DOB, DOJ, MaritalStatus, Address1, Address2, City, PinCode, Mobile, Email, UserId, Password, IsAdmin) values  (@EmpID, @EmpCode, @FName, @MName, @LName, @DOB, @DOJ, @MaritalStatus, @Add1, @Add2, @City, @Pin, @Mobile, @Email, @UserId, @Password, @IsAdmin)", con);
                    cmd.Parameters.Add("@EmpID", EmpID);
                    cmd.Parameters.Add("@EmpCode", EmpCode);
                    cmd.Parameters.Add("@FName", FName);
                    cmd.Parameters.Add("@MName", MName);
                    cmd.Parameters.Add("@LName", LName);
                    cmd.Parameters.Add("@DOB", DOB);
                    cmd.Parameters.Add("@DOJ", DOJ);
                    cmd.Parameters.Add("@MaritalStatus", IsMarried);
                    cmd.Parameters.Add("@Add1", Add1);
                    cmd.Parameters.Add("@Add2", Add2);
                    cmd.Parameters.Add("@City", City);
                    cmd.Parameters.Add("@Pin", PinCode);
                    cmd.Parameters.Add("@Mobile", Mobile);
                    cmd.Parameters.Add("@Email", Email);
                    cmd.Parameters.Add("@UserId", UserID);
                    cmd.Parameters.Add("@Password", Password);
                    cmd.Parameters.Add("@IsAdmin", IsAdmin);




                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Your Data is been saved into Database.");
                    clear();
                    display();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            
        }
        private void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from Employee", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void clear()
        {
            txtEmpID.Text = "";
            txtEmpCode.Text = "";
            txtFName.Text = "";
            txtMName.Text = "";
            txtLName.Text = "";
            txtAdd1.Text = "";
            txtAdd2.Text = "";
            txtCIty.Text = "";
            txtPinCode.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtUserId.Text = "";
            txtPassword.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                adpt = new SqlDataAdapter("select * from Employee where FName like '%" + txtSearch.Text + "%'", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
