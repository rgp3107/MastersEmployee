namespace Master_Database
{
    partial class Project_Assignment
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblAssignEmp = new System.Windows.Forms.Label();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mastersDataSet = new Master_Database.MastersDataSet();
            this.cmbAssignEmp = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mastersDataSet1 = new Master_Database.MastersDataSet1();
            this.projectTableAdapter = new Master_Database.MastersDataSetTableAdapters.ProjectTableAdapter();
            this.employeeTableAdapter = new Master_Database.MastersDataSet1TableAdapters.EmployeeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mastersDataSet2 = new Master_Database.MastersDataSet2();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter1 = new Master_Database.MastersDataSet2TableAdapters.EmployeeTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTitle.Location = new System.Drawing.Point(272, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Project Assignment";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblProjectName.Location = new System.Drawing.Point(43, 73);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(167, 29);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Text = "Project Name";
            // 
            // lblAssignEmp
            // 
            this.lblAssignEmp.AutoSize = true;
            this.lblAssignEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAssignEmp.Location = new System.Drawing.Point(43, 137);
            this.lblAssignEmp.Name = "lblAssignEmp";
            this.lblAssignEmp.Size = new System.Drawing.Size(211, 29);
            this.lblAssignEmp.TabIndex = 2;
            this.lblAssignEmp.Text = "Assign Employee";
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.projectBindingSource, "ProjectName", true));
            this.cmbProjectName.DataSource = this.projectBindingSource;
            this.cmbProjectName.DisplayMember = "ProjectName";
            this.cmbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(278, 72);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(228, 30);
            this.cmbProjectName.TabIndex = 3;
            this.cmbProjectName.ValueMember = "ProjectName";
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.mastersDataSet;
            // 
            // mastersDataSet
            // 
            this.mastersDataSet.DataSetName = "MastersDataSet";
            this.mastersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbAssignEmp
            // 
            this.cmbAssignEmp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "FName", true));
            this.cmbAssignEmp.DataSource = this.employeeBindingSource;
            this.cmbAssignEmp.DisplayMember = "FName";
            this.cmbAssignEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbAssignEmp.FormattingEnabled = true;
            this.cmbAssignEmp.Location = new System.Drawing.Point(278, 136);
            this.cmbAssignEmp.Name = "cmbAssignEmp";
            this.cmbAssignEmp.Size = new System.Drawing.Size(228, 30);
            this.cmbAssignEmp.TabIndex = 4;
            this.cmbAssignEmp.ValueMember = "FName";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.mastersDataSet1;
            // 
            // mastersDataSet1
            // 
            this.mastersDataSet1.DataSetName = "MastersDataSet1";
            this.mastersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 334);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DELETE);
   
            // 
            // mastersDataSet2
            // 
            this.mastersDataSet2.DataSetName = "MastersDataSet2";
            this.mastersDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.mastersDataSet2;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(543, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Project_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 591);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbAssignEmp);
            this.Controls.Add(this.cmbProjectName);
            this.Controls.Add(this.lblAssignEmp);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Project_Assignment";
            this.Text = "Project_Assignment";
            this.Load += new System.EventHandler(this.Project_Assignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblAssignEmp;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.ComboBox cmbAssignEmp;
        private MastersDataSet mastersDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private MastersDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private MastersDataSet1 mastersDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MastersDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MastersDataSet2 mastersDataSet2;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private MastersDataSet2TableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private System.Windows.Forms.Button btnAdd;
    }
}