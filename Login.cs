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
    public partial class Login : Form
    {
        SqlConnection con;
        string connectionString = "Data Source=RGP\\MSSQLSERVER01;Initial Catalog=CompanyDe;Integrated Security=True";
        public Login()
        {
            con = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsername!=null && txtPassword != null)
                {
                    con.Open();
                    string query = "SELECT * FROM Employees WHERE UserId=@user AND UserPassword=@pass";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.Add("@user", txtUsername.Text);
                    cmd.Parameters.Add("@pass", txtPassword.Text);

                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    adp.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        MessageBox.Show("You have successfully Login");
                        Form1 form = new Form1();
                        this.Hide();
                        form.Show();

                         

                    }
                    else
                    {
                        MessageBox.Show("Please check username and password");
                    }

                    cmd.Dispose();
                    con.Close();
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }

        }
    }
}
