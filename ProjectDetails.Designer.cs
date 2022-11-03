namespace CompanyDe
{
    partial class ProjectDetails
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddDep = new System.Windows.Forms.Button();
            this.txtProjName = new System.Windows.Forms.TextBox();
            this.txtProjCode = new System.Windows.Forms.TextBox();
            this.txtProId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdrYes = new System.Windows.Forms.RadioButton();
            this.rdrNo = new System.Windows.Forms.RadioButton();
            this.txtProClient = new System.Windows.Forms.TextBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(314, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Search Project";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(43, 228);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(237, 20);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 184);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnAddDep
            // 
            this.btnAddDep.Location = new System.Drawing.Point(515, 66);
            this.btnAddDep.Name = "btnAddDep";
            this.btnAddDep.Size = new System.Drawing.Size(75, 35);
            this.btnAddDep.TabIndex = 16;
            this.btnAddDep.Text = "Add";
            this.btnAddDep.UseVisualStyleBackColor = true;
            this.btnAddDep.Click += new System.EventHandler(this.btnAddDep_Click);
            // 
            // txtProjName
            // 
            this.txtProjName.Location = new System.Drawing.Point(192, 81);
            this.txtProjName.Name = "txtProjName";
            this.txtProjName.Size = new System.Drawing.Size(197, 20);
            this.txtProjName.TabIndex = 15;
            // 
            // txtProjCode
            // 
            this.txtProjCode.Location = new System.Drawing.Point(192, 52);
            this.txtProjCode.Name = "txtProjCode";
            this.txtProjCode.Size = new System.Drawing.Size(197, 20);
            this.txtProjCode.TabIndex = 14;
            // 
            // txtProId
            // 
            this.txtProId.Location = new System.Drawing.Point(192, 19);
            this.txtProId.Name = "txtProId";
            this.txtProId.Size = new System.Drawing.Size(197, 20);
            this.txtProId.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(39, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(39, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Project Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Project Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(39, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "ClientName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(259, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(266, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "End Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(39, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "IsActive";
            // 
            // rdrYes
            // 
            this.rdrYes.AutoSize = true;
            this.rdrYes.Location = new System.Drawing.Point(123, 158);
            this.rdrYes.Name = "rdrYes";
            this.rdrYes.Size = new System.Drawing.Size(43, 17);
            this.rdrYes.TabIndex = 24;
            this.rdrYes.TabStop = true;
            this.rdrYes.Text = "Yes";
            this.rdrYes.UseVisualStyleBackColor = true;
            // 
            // rdrNo
            // 
            this.rdrNo.AutoSize = true;
            this.rdrNo.Location = new System.Drawing.Point(192, 158);
            this.rdrNo.Name = "rdrNo";
            this.rdrNo.Size = new System.Drawing.Size(39, 17);
            this.rdrNo.TabIndex = 25;
            this.rdrNo.TabStop = true;
            this.rdrNo.Text = "No";
            this.rdrNo.UseVisualStyleBackColor = true;
            // 
            // txtProClient
            // 
            this.txtProClient.Location = new System.Drawing.Point(192, 119);
            this.txtProClient.Name = "txtProClient";
            this.txtProClient.Size = new System.Drawing.Size(197, 20);
            this.txtProClient.TabIndex = 26;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(374, 158);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(163, 20);
            this.dtStart.TabIndex = 27;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(374, 195);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(163, 20);
            this.dtEnd.TabIndex = 28;
            // 
            // ProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.txtProClient);
            this.Controls.Add(this.rdrNo);
            this.Controls.Add(this.rdrYes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddDep);
            this.Controls.Add(this.txtProjName);
            this.Controls.Add(this.txtProjCode);
            this.Controls.Add(this.txtProId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProjectDetails";
            this.Text = "ClientName";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddDep;
        private System.Windows.Forms.TextBox txtProjName;
        private System.Windows.Forms.TextBox txtProjCode;
        private System.Windows.Forms.TextBox txtProId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdrYes;
        private System.Windows.Forms.RadioButton rdrNo;
        private System.Windows.Forms.TextBox txtProClient;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
    }
}