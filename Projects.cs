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
    public partial class Projects : Form
    {
        string str = "Data Source=SMITS-LAPI;Initial Catalog=Masters;Integrated Security=True";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection con;
        SqlCommand cmd;
        public Projects()
        {
            InitializeComponent();
            con = new SqlConnection(str);
            display();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ProjectID = txtProjectID.Text;
                string ProjectCode = txtProjectCode.Text;
                string ProjectName = txtProjectName.Text;
                string ClientName = txtClientName.Text;
                string FromDate = dtpFrom.Value.ToString();
                string ToDate = dtpTo.Value.ToString();
                string IsActive;
                
                if (rbtnYes.Checked)
                {
                    IsActive = "Yes";
                }
                else
                {
                    IsActive = "No";
                }

                con.Open();
                cmd = new SqlCommand("Insert into Project ( ProjectID, ProjectCode, ProjectName, ClientName, ProjectStartDate, ProjectEndDate, IsActive) values  (@ProjectID, @ProjectCode, @ProjectName, @ClientName, @From, @To, @IsACtive)", con);
                cmd.Parameters.Add("@ProjectID", ProjectID);
                cmd.Parameters.Add("@ProjectCode", ProjectCode);
                cmd.Parameters.Add("@ProjectName", ProjectName);
                cmd.Parameters.Add("@ClientName", ClientName);
                cmd.Parameters.Add("@From", FromDate);
                cmd.Parameters.Add("@To", ToDate);
                cmd.Parameters.Add("@IsActive", IsActive);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your Data is been saved into Database.");
                clear();
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Valid ID Key. Duplication of ID key is not allowed.");
            }
        }
        private void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from Project", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            txtProjectID.Text = "";
            txtProjectCode.Text = "";
            txtProjectName.Text = "";
            txtClientName.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                adpt = new SqlDataAdapter("select * from Project where ProjectName like '%" + txtSearch.Text + "%'", con);
                dt = new DataTable();
                adpt.Fill(dt);
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
