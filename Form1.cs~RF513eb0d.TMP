using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyDe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void projectAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            showFrm(new ProjectAssignment());
        }

        private void timeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFrm(new TimeEntry());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showFrm(new Login());
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFrm(new EmployeeDetails());
           
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFrm(new Department());
        }
    }
}
