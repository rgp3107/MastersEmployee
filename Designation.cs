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
    public partial class Designation : Form
    {
        SqlConnection con;
        string ConnectionString = "Data Source=RGP\\MSSQLSERVER01;Initial Catalog=CompanyDe;Integrated Security=True";
        DataTable dt;
        SqlDataAdapter adp;

        public Designation()
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
                string query1 = "SELECT * FROM Designation";
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
                if (txtDesId.Text != null && txtDesignCode.Text != null && txtDesName.Text != null)
                {
                    con.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand("INSERT INTO Designation (DesignationId,DesignationCode,DesignationName) VALUES (@id,@name,@code)", con);
                    cmd.Parameters.Add("@id", txtDesId.Text);
                    cmd.Parameters.Add("@name", txtDesName.Text);
                    cmd.Parameters.Add("@code", txtDesignCode.Text);


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
                adp = new SqlDataAdapter("SELECT * FROM Designation WHERE DesignationName LIKE '%" + txtSearch.Text + "%'", con);
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
