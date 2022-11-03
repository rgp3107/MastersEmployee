namespace Master_Database
{
    partial class Designation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtDesignName = new System.Windows.Forms.TextBox();
            this.txtDesignCode = new System.Windows.Forms.TextBox();
            this.txtDesignID = new System.Windows.Forms.TextBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.lblDesignCode = new System.Windows.Forms.Label();
            this.lblDesignID = new System.Windows.Forms.Label();
            this.lblDesignDetails = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.designationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mastersDataSet5 = new Master_Database.MastersDataSet5();
            this.designationTableAdapter = new Master_Database.MastersDataSet5TableAdapters.DesignationTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(770, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 156);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSave.Location = new System.Drawing.Point(39, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 121);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSearch.Location = new System.Drawing.Point(361, 349);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(366, 36);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblSearch.Location = new System.Drawing.Point(30, 349);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(278, 31);
            this.lblSearch.TabIndex = 21;
            this.lblSearch.Text = "Search Record by Name";
            // 
            // txtDesignName
            // 
            this.txtDesignName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDesignName.Location = new System.Drawing.Point(361, 249);
            this.txtDesignName.Name = "txtDesignName";
            this.txtDesignName.Size = new System.Drawing.Size(366, 28);
            this.txtDesignName.TabIndex = 20;
            // 
            // txtDesignCode
            // 
            this.txtDesignCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDesignCode.Location = new System.Drawing.Point(361, 186);
            this.txtDesignCode.Name = "txtDesignCode";
            this.txtDesignCode.Size = new System.Drawing.Size(366, 28);
            this.txtDesignCode.TabIndex = 19;
            // 
            // txtDesignID
            // 
            this.txtDesignID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDesignID.Location = new System.Drawing.Point(361, 121);
            this.txtDesignID.Name = "txtDesignID";
            this.txtDesignID.Size = new System.Drawing.Size(366, 28);
            this.txtDesignID.TabIndex = 18;
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDeptName.Location = new System.Drawing.Point(30, 246);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(220, 29);
            this.lblDeptName.TabIndex = 17;
            this.lblDeptName.Text = "Department Name";
            // 
            // lblDesignCode
            // 
            this.lblDesignCode.AutoSize = true;
            this.lblDesignCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDesignCode.Location = new System.Drawing.Point(30, 183);
            this.lblDesignCode.Name = "lblDesignCode";
            this.lblDesignCode.Size = new System.Drawing.Size(214, 29);
            this.lblDesignCode.TabIndex = 16;
            this.lblDesignCode.Text = "Designation Code";
            // 
            // lblDesignID
            // 
            this.lblDesignID.AutoSize = true;
            this.lblDesignID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDesignID.Location = new System.Drawing.Point(30, 118);
            this.lblDesignID.Name = "lblDesignID";
            this.lblDesignID.Size = new System.Drawing.Size(178, 29);
            this.lblDesignID.TabIndex = 15;
            this.lblDesignID.Text = "Designation ID";
            // 
            // lblDesignDetails
            // 
            this.lblDesignDetails.AutoSize = true;
            this.lblDesignDetails.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDesignDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesignDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDesignDetails.Location = new System.Drawing.Point(30, 66);
            this.lblDesignDetails.Name = "lblDesignDetails";
            this.lblDesignDetails.Size = new System.Drawing.Size(234, 31);
            this.lblDesignDetails.TabIndex = 14;
            this.lblDesignDetails.Text = "Designation Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.designationIDDataGridViewTextBoxColumn,
            this.designationCodeDataGridViewTextBoxColumn,
            this.designationNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.designationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(699, 291);
            this.dataGridView1.TabIndex = 13;
            // 
            // designationIDDataGridViewTextBoxColumn
            // 
            this.designationIDDataGridViewTextBoxColumn.DataPropertyName = "DesignationID";
            this.designationIDDataGridViewTextBoxColumn.HeaderText = "DesignationID";
            this.designationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationIDDataGridViewTextBoxColumn.Name = "designationIDDataGridViewTextBoxColumn";
            this.designationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // designationCodeDataGridViewTextBoxColumn
            // 
            this.designationCodeDataGridViewTextBoxColumn.DataPropertyName = "DesignationCode";
            this.designationCodeDataGridViewTextBoxColumn.HeaderText = "DesignationCode";
            this.designationCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationCodeDataGridViewTextBoxColumn.Name = "designationCodeDataGridViewTextBoxColumn";
            this.designationCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // designationNameDataGridViewTextBoxColumn
            // 
            this.designationNameDataGridViewTextBoxColumn.DataPropertyName = "DesignationName";
            this.designationNameDataGridViewTextBoxColumn.HeaderText = "DesignationName";
            this.designationNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationNameDataGridViewTextBoxColumn.Name = "designationNameDataGridViewTextBoxColumn";
            this.designationNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // designationBindingSource
            // 
            this.designationBindingSource.DataMember = "Designation";
            this.designationBindingSource.DataSource = this.mastersDataSet5;
            // 
            // mastersDataSet5
            // 
            this.mastersDataSet5.DataSetName = "MastersDataSet5";
            this.mastersDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // designationTableAdapter
            // 
            this.designationTableAdapter.ClearBeforeFill = true;
            // 
            // Designation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(998, 797);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtDesignName);
            this.Controls.Add(this.txtDesignCode);
            this.Controls.Add(this.txtDesignID);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.lblDesignCode);
            this.Controls.Add(this.lblDesignID);
            this.Controls.Add(this.lblDesignDetails);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Designation";
            this.Text = "Designation";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtDesignName;
        private System.Windows.Forms.TextBox txtDesignCode;
        private System.Windows.Forms.TextBox txtDesignID;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Label lblDesignCode;
        private System.Windows.Forms.Label lblDesignID;
        private System.Windows.Forms.Label lblDesignDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MastersDataSet5 mastersDataSet5;
        private System.Windows.Forms.BindingSource designationBindingSource;
        private MastersDataSet5TableAdapters.DesignationTableAdapter designationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationNameDataGridViewTextBoxColumn;
    }
}