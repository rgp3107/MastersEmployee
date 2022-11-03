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
    public partial class Designation : Form
    {
        string str = "Data Source=SMITS-LAPI;Initial Catalog=Masters;Integrated Security=True";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection con;
        SqlCommand cmd;

        public Designation()
        {
            InitializeComponent();
            con = new SqlConnection(str);
            display();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string DesignID = txtDesignID.Text;
                string DesignCode = txtDesignCode.Text;
                string DesignName = txtDesignName.Text;


                con.Open();
                cmd = new SqlCommand("Insert into Designation ( DesignationID, DesignationCode, DesignationName) values  (@DesignID, @DesignCode, @DesignName)", con);
                cmd.Parameters.Add("@DesignID", DesignID);
                cmd.Parameters.Add("@DesignCode", DesignCode);
                cmd.Parameters.Add("@DesignName", DesignName);
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
                adpt = new SqlDataAdapter("select * from Designation", con);
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
            txtDesignID.Text = "";
            txtDesignCode.Text = "";
            txtDesignName.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                adpt = new SqlDataAdapter("select * from Designation where DesignationName like '%" + txtSearch.Text + "%'", con);
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

