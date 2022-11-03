﻿using System;
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

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFrm(new Designation());
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFrm(new ProjectDetails());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showFrm(new Department());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showFrm(new Designation());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showFrm(new ProjectDetails());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showFrm(new EmployeeDetails());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showFrm(new ProjectAssignment());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showFrm(new TimeEntry());
        }

       
    }
}
