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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Master_Database
{
    public partial class Project_Assignment : Form
    {
        string str = "Data Source=SMITS-LAPI;Initial Catalog=Masters;Integrated Security=True";
        SqlConnection con;
        DataTable dt = new DataTable();

        public Project_Assignment()
        {
            InitializeComponent();

            con = new SqlConnection(str);
            dt.Columns.Add("Employee Id");
            dt.Columns.Add("Employee Code");
            dt.Columns.Add("Employee Name");
            dt.Columns.Add("Project Name");
            dt.Columns.Add("Action");
            
        }

        private void Project_Assignment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mastersDataSet2.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.mastersDataSet2.Employee);
            // TODO: This line of code loads data into the 'mastersDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.mastersDataSet1.Employee);
            // TODO: This line of code loads data into the 'mastersDataSet.Project' table. You can move, or remove it, as needed.
            this.projectTableAdapter.Fill(this.mastersDataSet.Project);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string ProjectName = cmbProjectName.SelectedValue.ToString();
                string AssignEmp = cmbAssignEmp.SelectedValue.ToString();

                string query = "SELECT EmployeeID, EmployeeCode, FName FROM Employee WHERE FName = @emp";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@emp", AssignEmp);
                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read()){
                    var row = dt.NewRow();
                    row[0] = dr.GetValue(0);
                    row[1] = dr.GetValue(1);
                    row[2] = dr.GetValue(2);
                    row[3] = ProjectName;
                    row[4] = "DELETE";
                    dt.Rows.Add(row);
                }
       
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["Action"].DefaultCellStyle.ForeColor = Color.Red;
                cmd.Dispose();
                con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DELETE(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (e.ColumnIndex == 4)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["Employee Id"] == row.Cells[0].Value)
                        {
                            dr.Delete();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

      
    }
}
