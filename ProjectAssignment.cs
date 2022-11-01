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
    public partial class ProjectAssignment : Form
    {
        SqlConnection con;
        string connectionString  = "Data Source=RGP\\MSSQLSERVER01;Initial Catalog=CompanyDe;Integrated Security=True";
       

        DataTable dt;

        public ProjectAssignment()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString); 
 
            dt = new DataTable();
            dt.Columns.Add("Employee_Id", typeof(string));
            dt.Columns.Add("Project_Name", typeof(string));
            dt.Columns.Add("Employee_Code", typeof(string));
            dt.Columns.Add("Employee_FirstName", typeof(string));
            dt.Columns.Add("Delete", typeof(string));

        }

        

        private void ProjectAssignment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDeDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.companyDeDataSet1.Employees);
            // TODO: This line of code loads data into the 'companyDeDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.companyDeDataSet.Projects);

        }

        private void btnAddToProject_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                

                string ProjectName = Proj.SelectedValue.ToString();
                string EmployeeName = Employ.SelectedValue.ToString();
                

                SqlDataReader dataReader;
                SqlCommand cmd;
                


                cmd = new SqlCommand("select employeeid,EmployeeCode,firstname from employees WHERE EmployeeCode = @project ", con);
                cmd.Parameters.Add("@project", EmployeeName);


                //Display();
                 

               


                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    var row = dt.NewRow();
                    row["Employee_Id"] = dataReader.GetValue(0);
                    row["Employee_Code"] = dataReader.GetValue(1);
                    row["Employee_FirstName"] = dataReader.GetValue(2);
                    row["Project_Name"] = ProjectName;
                    row["Delete"] = "Delete";
                    dt.Rows.Add(row);


                }
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Delete"].DefaultCellStyle.ForeColor = Color.Red;


                dataReader.Close();
                cmd.Dispose();





                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Display()
        {
            throw new NotImplementedException();
        }

        private void DeleteFromGrid(object sender, DataGridViewCellEventArgs e)
        {
            //for deleting the value from EmployeeAssign Table
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (e.ColumnIndex == 4)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["Employee_Id"] == row.Cells[0].Value)
                    {
                        dr.Delete();
                        break;
                    }
                }
            }

        }

       
    }
}
