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
    public partial class Login : Form
    {

        string str =  "Data Source=SMITS-LAPI;Initial Catalog=Masters;Integrated Security=True";
   
        public Login()
        {
            InitializeComponent();
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter UserName and Password.");
                }
                else
                {
                    SqlConnection con = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand("Select * from Employee where UserId = @user and Password = @pass", con);
                    cmd.Parameters.Add("@user", txtUserName.Text);
                    cmd.Parameters.Add("@pass", txtPassword.Text);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;

                    if(count == 1)
                    {
                        MessageBox.Show("You've successfully logged in. . .");
                        Form1 form = new Form1();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Valid Details!");
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
