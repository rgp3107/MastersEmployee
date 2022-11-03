namespace Master_Database
{
    partial class Projects
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectCode = new System.Windows.Forms.TextBox();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblProjectCode = new System.Windows.Forms.Label();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.lblProjectDetails = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.grpProjectDate = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpProjectDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(803, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 102);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSave.Location = new System.Drawing.Point(34, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 66);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSearch.Location = new System.Drawing.Point(379, 354);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(366, 36);
            this.txtSearch.TabIndex = 33;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblSearch.Location = new System.Drawing.Point(48, 354);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(278, 31);
            this.lblSearch.TabIndex = 32;
            this.lblSearch.Text = "Search Record by Name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtProjectName.Location = new System.Drawing.Point(222, 218);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(226, 24);
            this.txtProjectName.TabIndex = 31;
            // 
            // txtProjectCode
            // 
            this.txtProjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtProjectCode.Location = new System.Drawing.Point(222, 155);
            this.txtProjectCode.Name = "txtProjectCode";
            this.txtProjectCode.Size = new System.Drawing.Size(226, 24);
            this.txtProjectCode.TabIndex = 30;
            // 
            // txtProjectID
            // 
            this.txtProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtProjectID.Location = new System.Drawing.Point(222, 90);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(226, 24);
            this.txtProjectID.TabIndex = 29;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblProjectName.Location = new System.Drawing.Point(43, 218);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(145, 26);
            this.lblProjectName.TabIndex = 28;
            this.lblProjectName.Text = "Project Name";
            // 
            // lblProjectCode
            // 
            this.lblProjectCode.AutoSize = true;
            this.lblProjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblProjectCode.Location = new System.Drawing.Point(43, 155);
            this.lblProjectCode.Name = "lblProjectCode";
            this.lblProjectCode.Size = new System.Drawing.Size(138, 26);
            this.lblProjectCode.TabIndex = 27;
            this.lblProjectCode.Text = "Project Code";
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblProjectID.Location = new System.Drawing.Point(43, 90);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(108, 26);
            this.lblProjectID.TabIndex = 26;
            this.lblProjectID.Text = "Project ID";
            // 
            // lblProjectDetails
            // 
            this.lblProjectDetails.AutoSize = true;
            this.lblProjectDetails.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblProjectDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProjectDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblProjectDetails.Location = new System.Drawing.Point(43, 35);
            this.lblProjectDetails.Name = "lblProjectDetails";
            this.lblProjectDetails.Size = new System.Drawing.Size(179, 31);
            this.lblProjectDetails.TabIndex = 25;
            this.lblProjectDetails.Text = "Project Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(699, 291);
            this.dataGridView1.TabIndex = 24;
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtClientName.Location = new System.Drawing.Point(672, 90);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(297, 24);
            this.txtClientName.TabIndex = 38;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblToDate.Location = new System.Drawing.Point(10, 84);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(36, 26);
            this.lblToDate.TabIndex = 37;
            this.lblToDate.Text = "To";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblFromDate.Location = new System.Drawing.Point(10, 23);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(63, 26);
            this.lblFromDate.TabIndex = 36;
            this.lblFromDate.Text = "From";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblClientName.Location = new System.Drawing.Point(513, 88);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(133, 26);
            this.lblClientName.TabIndex = 35;
            this.lblClientName.Text = "Client Name";
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbtnYes.Location = new System.Drawing.Point(219, 285);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(54, 22);
            this.rbtnYes.TabIndex = 41;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbtnNo.Location = new System.Drawing.Point(335, 285);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(49, 22);
            this.rbtnNo.TabIndex = 42;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblIsActive.Location = new System.Drawing.Point(43, 281);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(95, 26);
            this.lblIsActive.TabIndex = 43;
            this.lblIsActive.Text = "Is Active";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(154, 23);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(297, 28);
            this.dtpFrom.TabIndex = 44;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(154, 82);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(297, 28);
            this.dtpTo.TabIndex = 45;
            // 
            // grpProjectDate
            // 
            this.grpProjectDate.Controls.Add(this.dtpFrom);
            this.grpProjectDate.Controls.Add(this.dtpTo);
            this.grpProjectDate.Controls.Add(this.lblFromDate);
            this.grpProjectDate.Controls.Add(this.lblToDate);
            this.grpProjectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.grpProjectDate.Location = new System.Drawing.Point(518, 132);
            this.grpProjectDate.Name = "grpProjectDate";
            this.grpProjectDate.Size = new System.Drawing.Size(466, 112);
            this.grpProjectDate.TabIndex = 46;
            this.grpProjectDate.TabStop = false;
            this.grpProjectDate.Text = "Project Date";
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1046, 784);
            this.Controls.Add(this.grpProjectDate);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.rbtnNo);
            this.Controls.Add(this.rbtnYes);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtProjectCode);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblProjectCode);
            this.Controls.Add(this.lblProjectID);
            this.Controls.Add(this.lblProjectDetails);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Projects";
            this.Text = "Projects";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpProjectDate.ResumeLayout(false);
            this.grpProjectDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectCode;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblProjectCode;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblProjectDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.GroupBox grpProjectDate;
    }
}