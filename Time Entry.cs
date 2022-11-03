using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Master_Database
{
    public partial class Time_Entry : Form
    {

        string str ="Data Source=SMITS-LAPI;Initial Catalog=Masters;Integrated Security=True";
        SqlConnection con;    
        DataTable dt = new DataTable();
        public Time_Entry()
        {
            InitializeComponent();

            con = new SqlConnection(str);
            dt.Columns.Add("Project Name");
            dt.Columns.Add("Date");
            dt.Columns.Add("Time From");
            dt.Columns.Add("Time To");
            dt.Columns.Add("Action");

        }

        private void Time_Entry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mastersDataSet3.Project' table. You can move, or remove it, as needed.
            this.projectTableAdapter.Fill(this.mastersDataSet3.Project);

        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {

            try
            {
                string ProjectName = cmbProjectName1.SelectedValue.ToString();
                string Date = dateTimePickerDate.Value.ToShortDateString();
                string From = dateTimePickerFrom.Value.ToShortTimeString();
                string To = dateTimePickerTo.Value.ToShortTimeString();

                var row = dt.NewRow();
                row[0] = ProjectName;
                row[1] = Date;
                row[2] = From;
                row[3] = To;
                row[4] = "DELETE";
                dt.Rows.Add(row);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Action"].DefaultCellStyle.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        if (dr["Project Name"] == row.Cells[0].Value)
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
