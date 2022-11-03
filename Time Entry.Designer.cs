namespace Master_Database
{
    partial class Time_Entry
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
            this.lblProjectName1 = new System.Windows.Forms.Label();
            this.cmbProjectName1 = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.mastersDataSet = new Master_Database.MastersDataSet();
            this.mastersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mastersDataSet3 = new Master_Database.MastersDataSet3();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new Master_Database.MastersDataSet3TableAdapters.ProjectTableAdapter();
            this.btnAdd1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectName1
            // 
            this.lblProjectName1.AutoSize = true;
            this.lblProjectName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblProjectName1.Location = new System.Drawing.Point(53, 46);
            this.lblProjectName1.Name = "lblProjectName1";
            this.lblProjectName1.Size = new System.Drawing.Size(167, 29);
            this.lblProjectName1.TabIndex = 2;
            this.lblProjectName1.Text = "Project Name";
            // 
            // cmbProjectName1
            // 
            this.cmbProjectName1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.projectBindingSource, "ProjectName", true));
            this.cmbProjectName1.DataSource = this.projectBindingSource;
            this.cmbProjectName1.DisplayMember = "ProjectName";
            this.cmbProjectName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbProjectName1.FormattingEnabled = true;
            this.cmbProjectName1.Location = new System.Drawing.Point(282, 45);
            this.cmbProjectName1.Name = "cmbProjectName1";
            this.cmbProjectName1.Size = new System.Drawing.Size(317, 30);
            this.cmbProjectName1.TabIndex = 4;
            this.cmbProjectName1.ValueMember = "ProjectName";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDate.Location = new System.Drawing.Point(53, 107);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 29);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTime.Location = new System.Drawing.Point(53, 169);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 29);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(282, 107);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(317, 28);
            this.dateTimePickerDate.TabIndex = 9;
            this.dateTimePickerDate.Value = new System.DateTime(2022, 10, 31, 14, 7, 28, 0);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(373, 170);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.ShowUpDown = true;
            this.dateTimePickerFrom.Size = new System.Drawing.Size(184, 28);
            this.dateTimePickerFrom.TabIndex = 10;
            this.dateTimePickerFrom.Value = new System.DateTime(2022, 10, 31, 14, 7, 28, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(541, 241);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DELETE);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFrom.Location = new System.Drawing.Point(277, 168);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(72, 29);
            this.lblFrom.TabIndex = 12;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTo.Location = new System.Drawing.Point(277, 215);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(42, 29);
            this.lblTo.TabIndex = 14;
            this.lblTo.Text = "To";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTo.Location = new System.Drawing.Point(373, 217);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.ShowUpDown = true;
            this.dateTimePickerTo.Size = new System.Drawing.Size(184, 28);
            this.dateTimePickerTo.TabIndex = 13;
            this.dateTimePickerTo.Value = new System.DateTime(2022, 10, 31, 14, 7, 28, 0);
            // 
            // mastersDataSet
            // 
            this.mastersDataSet.DataSetName = "MastersDataSet";
            this.mastersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mastersDataSetBindingSource
            // 
            this.mastersDataSetBindingSource.DataSource = this.mastersDataSet;
            this.mastersDataSetBindingSource.Position = 0;
            // 
            // mastersDataSet3
            // 
            this.mastersDataSet3.DataSetName = "MastersDataSet3";
            this.mastersDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.mastersDataSet3;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd1
            // 
            this.btnAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAdd1.Location = new System.Drawing.Point(594, 182);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(114, 51);
            this.btnAdd1.TabIndex = 15;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // Time_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 525);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbProjectName1);
            this.Controls.Add(this.lblProjectName1);
            this.Name = "Time_Entry";
            this.Text = "Time_Entry";
            this.Load += new System.EventHandler(this.Time_Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName1;
        private System.Windows.Forms.ComboBox cmbProjectName1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.BindingSource mastersDataSetBindingSource;
        private MastersDataSet mastersDataSet;
        private MastersDataSet3 mastersDataSet3;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private MastersDataSet3TableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.Button btnAdd1;
    }
}