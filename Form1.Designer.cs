namespace CompanyDe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectAssignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentToolStripMenuItem,
            this.designationToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.departmentToolStripMenuItem.Text = "Department";
            // 
            // designationToolStripMenuItem
            // 
            this.designationToolStripMenuItem.Name = "designationToolStripMenuItem";
            this.designationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.designationToolStripMenuItem.Text = "Designation";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectAssignmentToolStripMenuItem,
            this.timeEntryToolStripMenuItem});
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // projectAssignmentToolStripMenuItem
            // 
            this.projectAssignmentToolStripMenuItem.Name = "projectAssignmentToolStripMenuItem";
            this.projectAssignmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.projectAssignmentToolStripMenuItem.Text = "Project Assignment";
            this.projectAssignmentToolStripMenuItem.Click += new System.EventHandler(this.projectAssignmentToolStripMenuItem_Click);
            // 
            // timeEntryToolStripMenuItem
            // 
            this.timeEntryToolStripMenuItem.Name = "timeEntryToolStripMenuItem";
            this.timeEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timeEntryToolStripMenuItem.Text = "Time Entry";
            this.timeEntryToolStripMenuItem.Click += new System.EventHandler(this.timeEntryToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectAssignmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeEntryToolStripMenuItem;
    }
}

