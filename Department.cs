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

namespace CompanyDe
{
    public partial class Department : Form
    {
        SqlConnection con;
        string ConnectionString = "Data Source=RGP\\MSSQLSERVER01;Initial Catalog=CompanyDe;Integrated Security=True";
        DataTable dt;
        SqlDataAdapter adp;

        public Department()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionString);

            

        }

        private void Display()
        {
            try
            {

                dt = new DataTable();
                con.Open();
                string query1 = "SELECT * FROM Department";
                adp = new SqlDataAdapter(query1, con);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddDep_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDepCode!=null && txtDepId!=null && txtDepName != null)
                {
                    con.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand("INSERT INTO Department (DepartmentId,DepartmentCode,DepartmentName) VALUES (@id,@name,@code)", con);
                    cmd.Parameters.Add("@id", txtDepId.Text);
                    cmd.Parameters.Add("@name", txtDepName.Text);
                    cmd.Parameters.Add("@code", txtDepCode.Text);


                    cmd.ExecuteNonQuery();

                    
                    cmd.Dispose();
                    con.Close();
                    Display();
                }
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
                adp = new SqlDataAdapter("SELECT * FROM Department WHERE DepartmentName LIKE '%" + txtSearch.Text + "%'", con);
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
    }
}
