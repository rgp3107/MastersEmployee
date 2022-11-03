using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grpMasters.BringToFront();
            
        }

        
        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*  Department department = new Department();
              department.MdiParent = this;
              department.Show();*/

            mdi(new Department());

        }

        private void projectAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project_Assignment project = new Project_Assignment();
            project.MdiParent = this;
            project.Show();
        }

        private void timeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Time_Entry time = new Time_Entry();
            time.MdiParent = this;
            time.Show();
        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Designation design = new Designation();
            design.MdiParent = this;
            design.Show();
        }

        private void mdi(Form frm)
        {
           
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projects project = new Projects();
            project.MdiParent = this;
            project.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.MdiParent = this;
            emp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mdi(new Department());
            //HideButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Designation design = new Designation();
            design.MdiParent = this;
            design.Show();
            //HideButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Projects project = new Projects();
            project.MdiParent = this;
            project.Show();
            grpDetails.SendToBack();
            grpMasters.SendToBack();
           // HideButton();
            //project.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.MdiParent = this;
            emp.Show();
           // HideButton();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Project_Assignment project = new Project_Assignment();
            project.MdiParent = this;
            project.Show();
            //HideButton();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Time_Entry time = new Time_Entry();
            time.MdiParent = this;
            time.Show();
            
           // HideButton();
        }

        private void HideButton()
        {
            grpMasters.Hide();
            grpDetails.Hide();
        }
    }
}
