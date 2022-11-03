using System;
using System.CodeDom;
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
    public partial class TimeEntry : Form
    {
       
        DataTable dt;
        public TimeEntry()
        {
            InitializeComponent();
           

            dt = new DataTable();
            dt.Columns.Add("Project_Name",typeof(string));
            dt.Columns.Add("Date",typeof(string));
            dt.Columns.Add("Time",typeof(string));


            //dataGridView1.Columns["Start Time"].DefaultCellStyle.Format = "HH:mm:ss";

        }

        private void TimeEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDeDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.companyDeDataSet.Projects);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                var row  = dt.NewRow();
                row["Project_Name"] = txtProject.SelectedValue;
                row["Date"] = txtDate.Value.ToShortDateString();
                row["Time"] = txtTime.Value.ToShortTimeString();
                dt.Rows.Add(row);

                dataGridView1.DataSource = dt;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
