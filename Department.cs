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
    public partial class Department : Form
    {
        string str = "Data Source=SMITS-LAPI;Initial Catalog=Masters;Integrated Security=True";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection con;
        SqlCommand cmd;

        public Department()
        {
            InitializeComponent();
            con = new SqlConnection(str);
            display();
            
        }

        private void Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mastersDataSet4.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.mastersDataSet4.Department);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string DeptID = txtDeptID.Text;
                string DeptCode = txtDeptCode.Text;
                string DeptName = txtDeptName.Text;

                
                con.Open();
                cmd = new SqlCommand("Insert into Department ( DepartmentID, DepartmentCode, DepartmentName) values  (@DeptID, @DeptCode, @DeptName)", con);
                cmd.Parameters.Add("@DeptID", DeptID);
                cmd.Parameters.Add("@DeptCode", DeptCode);
                cmd.Parameters.Add("@DeptName", DeptName);
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
                adpt = new SqlDataAdapter("select * from Department", con);
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
            txtDeptID.Text = "";
            txtDeptCode.Text = "";
            txtDeptName.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                adpt = new SqlDataAdapter("select * from Department where DepartmentName like '%" + txtSa.Text + "%'", con);
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
