namespace CompanyDe
{
    partial class ProjectAssignment
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Proj = new System.Windows.Forms.ComboBox();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDeDataSet = new CompanyDe.CompanyDeDataSet();
            this.Employ = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDeDataSet1 = new CompanyDe.CompanyDeDataSet1();
            this.projectsTableAdapter = new CompanyDe.CompanyDeDataSetTableAdapters.ProjectsTableAdapter();
            this.employeesTableAdapter = new CompanyDe.CompanyDeDataSet1TableAdapters.EmployeesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddToProject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProjectName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Assigned";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(248, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "ProjectAssignment";
            // 
            // Proj
            // 
            this.Proj.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.projectsBindingSource, "ProjectName", true));
            this.Proj.DataSource = this.projectsBindingSource;
            this.Proj.DisplayMember = "ProjectName";
            this.Proj.FormattingEnabled = true;
            this.Proj.Location = new System.Drawing.Point(264, 81);
            this.Proj.Name = "Proj";
            this.Proj.Size = new System.Drawing.Size(172, 21);
            this.Proj.TabIndex = 3;
            this.Proj.ValueMember = "ProjectName";
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.companyDeDataSet;
            // 
            // companyDeDataSet
            // 
            this.companyDeDataSet.DataSetName = "CompanyDeDataSet";
            this.companyDeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Employ
            // 
            this.Employ.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "FirstName", true));
            this.Employ.DataSource = this.employeesBindingSource;
            this.Employ.DisplayMember = "FirstName";
            this.Employ.FormattingEnabled = true;
            this.Employ.Location = new System.Drawing.Point(264, 133);
            this.Employ.Name = "Employ";
            this.Employ.Size = new System.Drawing.Size(172, 21);
            this.Employ.TabIndex = 4;
            this.Employ.ValueMember = "EmployeeCode";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.companyDeDataSet1;
            // 
            // companyDeDataSet1
            // 
            this.companyDeDataSet1.DataSetName = "CompanyDeDataSet1";
            this.companyDeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(116, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 195);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeleteFromGrid);
            // 
            // btnAddToProject
            // 
            this.btnAddToProject.Location = new System.Drawing.Point(308, 174);
            this.btnAddToProject.Name = "btnAddToProject";
            this.btnAddToProject.Size = new System.Drawing.Size(75, 23);
            this.btnAddToProject.TabIndex = 6;
            this.btnAddToProject.Text = "ADD";
            this.btnAddToProject.UseVisualStyleBackColor = true;
            this.btnAddToProject.Click += new System.EventHandler(this.btnAddToProject_Click);
            // 
            // ProjectAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddToProject);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Employ);
            this.Controls.Add(this.Proj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProjectAssignment";
            this.Text = "ProjectAssignment";
            this.Load += new System.EventHandler(this.ProjectAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Proj;
        private System.Windows.Forms.ComboBox Employ;
        private CompanyDeDataSet companyDeDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private CompanyDeDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private CompanyDeDataSet1 companyDeDataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private CompanyDeDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddToProject;
    }
}