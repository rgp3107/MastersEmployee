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
    public partial class ProjectDetails : Form
    {
        SqlConnection con;
        string ConnectionString = "Data Source=RGP\\MSSQLSERVER01;Initial Catalog=CompanyDe;Integrated Security=True";
        DataTable dt;
        SqlDataAdapter adp;
        public ProjectDetails()
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
                string query1 = "SELECT * FROM Projects";
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                adp = new SqlDataAdapter("SELECT * FROM Projects WHERE ProjectName LIKE '%" + txtSearch.Text + "%'", con);
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

        private void btnAddDep_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProId.Text != null && txtProClient.Text != null && txtProjCode.Text != null && txtProjName.Text != null)
                {
                    string isActive;
                    if (rdrYes.Checked)
                    {
                        isActive = "True";
                    }
                    else
                    {
                        isActive = "False";
                    }
                    con.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand("INSERT INTO Projects (ProjectId,ProjectCode,ProjectName,ProjectStartDate,ProjectEndDate,IsActive) VALUES (@id,@name,@code,@start,@end,@isActive)", con);
                    cmd.Parameters.Add("@id", txtProId.Text);
                    cmd.Parameters.Add("@name", txtProjName.Text);
                    cmd.Parameters.Add("@code", txtProjCode.Text);
                    cmd.Parameters.Add("@start", dtStart.Value);
                    cmd.Parameters.Add("@end", dtEnd.Value); 
                    cmd.Parameters.Add("@isActive", isActive);


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
    }
}
