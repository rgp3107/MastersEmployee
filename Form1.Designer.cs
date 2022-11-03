namespace Master_Database
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
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectAssignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grpMasters = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpMasters.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentToolStripMenuItem,
            this.designationToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // designationToolStripMenuItem
            // 
            this.designationToolStripMenuItem.Name = "designationToolStripMenuItem";
            this.designationToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.designationToolStripMenuItem.Text = "Designation";
            this.designationToolStripMenuItem.Click += new System.EventHandler(this.designationToolStripMenuItem_Click);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectAssignmentToolStripMenuItem,
            this.timeEntryToolStripMenuItem});
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // projectAssignmentToolStripMenuItem
            // 
            this.projectAssignmentToolStripMenuItem.Name = "projectAssignmentToolStripMenuItem";
            this.projectAssignmentToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.projectAssignmentToolStripMenuItem.Text = "Project Assignment";
            this.projectAssignmentToolStripMenuItem.Click += new System.EventHandler(this.projectAssignmentToolStripMenuItem_Click);
            // 
            // timeEntryToolStripMenuItem
            // 
            this.timeEntryToolStripMenuItem.Name = "timeEntryToolStripMenuItem";
            this.timeEntryToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.timeEntryToolStripMenuItem.Text = "Time Entry";
            this.timeEntryToolStripMenuItem.Click += new System.EventHandler(this.timeEntryToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1538, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // grpMasters
            // 
            this.grpMasters.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpMasters.Controls.Add(this.button4);
            this.grpMasters.Controls.Add(this.button3);
            this.grpMasters.Controls.Add(this.button2);
            this.grpMasters.Controls.Add(this.button1);
            this.grpMasters.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpMasters.Location = new System.Drawing.Point(308, 104);
            this.grpMasters.Name = "grpMasters";
            this.grpMasters.Size = new System.Drawing.Size(664, 141);
            this.grpMasters.TabIndex = 2;
            this.grpMasters.TabStop = false;
            this.grpMasters.Text = "Masters";
            this.grpMasters.UseCompatibleTextRendering = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkKhaki;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button4.Location = new System.Drawing.Point(513, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 74);
            this.button4.TabIndex = 6;
            this.button4.Text = "Employee";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkKhaki;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button3.Location = new System.Drawing.Point(352, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 74);
            this.button3.TabIndex = 5;
            this.button3.Text = "Projects";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(188, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 74);
            this.button2.TabIndex = 4;
            this.button2.Text = "Designation";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(26, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "Department";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpDetails.Controls.Add(this.button6);
            this.grpDetails.Controls.Add(this.button5);
            this.grpDetails.ForeColor = System.Drawing.Color.Indigo;
            this.grpDetails.Location = new System.Drawing.Point(714, 293);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(258, 140);
            this.grpDetails.TabIndex = 3;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.BurlyWood;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button6.Location = new System.Drawing.Point(6, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(246, 39);
            this.button6.TabIndex = 8;
            this.button6.Text = "Time Entry";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.BurlyWood;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button5.Location = new System.Drawing.Point(6, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(246, 39);
            this.button5.TabIndex = 7;
            this.button5.Text = "Project Assignment";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1538, 1055);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpMasters);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Form1";
            this.Text = ".";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpMasters.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectAssignmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeEntryToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox grpMasters;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

