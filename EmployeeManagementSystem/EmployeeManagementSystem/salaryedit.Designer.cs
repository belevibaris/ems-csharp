
namespace EmployeeManagementSystem
{
    partial class salaryedit
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.signout = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.Button();
            this.addemployee = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.welcomeUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.emsDatabaseDataSet2 = new EmployeeManagementSystem.emsDatabaseDataSet2();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new EmployeeManagementSystem.emsDatabaseDataSet2TableAdapters.employeesTableAdapter();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeepositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeetelnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeyearofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Indigo;
            this.splitContainer1.Panel1.Controls.Add(this.signout);
            this.splitContainer1.Panel1.Controls.Add(this.salary);
            this.splitContainer1.Panel1.Controls.Add(this.addemployee);
            this.splitContainer1.Panel1.Controls.Add(this.dashboard);
            this.splitContainer1.Panel1.Controls.Add(this.welcomeUser);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1410, 683);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.TabIndex = 0;
            // 
            // signout
            // 
            this.signout.BackColor = System.Drawing.Color.Transparent;
            this.signout.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.pngwing_com__5_;
            this.signout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signout.FlatAppearance.BorderSize = 0;
            this.signout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.signout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signout.Image = global::EmployeeManagementSystem.Properties.Resources.pngwing_com__5_;
            this.signout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signout.Location = new System.Drawing.Point(2, 620);
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(112, 43);
            this.signout.TabIndex = 11;
            this.signout.UseVisualStyleBackColor = false;
            // 
            // salary
            // 
            this.salary.BackColor = System.Drawing.Color.Indigo;
            this.salary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.ForeColor = System.Drawing.Color.FloralWhite;
            this.salary.Location = new System.Drawing.Point(66, 437);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(250, 55);
            this.salary.TabIndex = 10;
            this.salary.Text = "Salary";
            this.salary.UseVisualStyleBackColor = false;
            // 
            // addemployee
            // 
            this.addemployee.BackColor = System.Drawing.Color.Indigo;
            this.addemployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addemployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployee.ForeColor = System.Drawing.Color.FloralWhite;
            this.addemployee.Location = new System.Drawing.Point(66, 349);
            this.addemployee.Name = "addemployee";
            this.addemployee.Size = new System.Drawing.Size(250, 55);
            this.addemployee.TabIndex = 9;
            this.addemployee.Text = "Add Employee";
            this.addemployee.UseVisualStyleBackColor = false;
            this.addemployee.Click += new System.EventHandler(this.addemployee_Click);
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.Indigo;
            this.dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.FloralWhite;
            this.dashboard.Location = new System.Drawing.Point(66, 261);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(250, 55);
            this.dashboard.TabIndex = 8;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = false;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // welcomeUser
            // 
            this.welcomeUser.AutoSize = true;
            this.welcomeUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcomeUser.Location = new System.Drawing.Point(108, 180);
            this.welcomeUser.Name = "welcomeUser";
            this.welcomeUser.Size = new System.Drawing.Size(159, 22);
            this.welcomeUser.TabIndex = 7;
            this.welcomeUser.Text = "Welcome, USER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.hm;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(107, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 154);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeidDataGridViewTextBoxColumn,
            this.employeenameDataGridViewTextBoxColumn,
            this.employeesurnameDataGridViewTextBoxColumn,
            this.employeesalaryDataGridViewTextBoxColumn,
            this.employeepositionDataGridViewTextBoxColumn,
            this.employeegenderDataGridViewTextBoxColumn,
            this.employeeemailDataGridViewTextBoxColumn,
            this.employeetelnoDataGridViewTextBoxColumn,
            this.employeeyearofbirthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(515, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 603);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees";
            // 
            // emsDatabaseDataSet2
            // 
            this.emsDatabaseDataSet2.DataSetName = "emsDatabaseDataSet2";
            this.emsDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.emsDatabaseDataSet2;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeenameDataGridViewTextBoxColumn
            // 
            this.employeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name";
            this.employeenameDataGridViewTextBoxColumn.HeaderText = "employee_name";
            this.employeenameDataGridViewTextBoxColumn.Name = "employeenameDataGridViewTextBoxColumn";
            // 
            // employeesurnameDataGridViewTextBoxColumn
            // 
            this.employeesurnameDataGridViewTextBoxColumn.DataPropertyName = "employee_surname";
            this.employeesurnameDataGridViewTextBoxColumn.HeaderText = "employee_surname";
            this.employeesurnameDataGridViewTextBoxColumn.Name = "employeesurnameDataGridViewTextBoxColumn";
            // 
            // employeesalaryDataGridViewTextBoxColumn
            // 
            this.employeesalaryDataGridViewTextBoxColumn.DataPropertyName = "employee_salary";
            this.employeesalaryDataGridViewTextBoxColumn.HeaderText = "employee_salary";
            this.employeesalaryDataGridViewTextBoxColumn.Name = "employeesalaryDataGridViewTextBoxColumn";
            // 
            // employeepositionDataGridViewTextBoxColumn
            // 
            this.employeepositionDataGridViewTextBoxColumn.DataPropertyName = "employee_position";
            this.employeepositionDataGridViewTextBoxColumn.HeaderText = "employee_position";
            this.employeepositionDataGridViewTextBoxColumn.Name = "employeepositionDataGridViewTextBoxColumn";
            // 
            // employeegenderDataGridViewTextBoxColumn
            // 
            this.employeegenderDataGridViewTextBoxColumn.DataPropertyName = "employee_gender";
            this.employeegenderDataGridViewTextBoxColumn.HeaderText = "employee_gender";
            this.employeegenderDataGridViewTextBoxColumn.Name = "employeegenderDataGridViewTextBoxColumn";
            // 
            // employeeemailDataGridViewTextBoxColumn
            // 
            this.employeeemailDataGridViewTextBoxColumn.DataPropertyName = "employee_email";
            this.employeeemailDataGridViewTextBoxColumn.HeaderText = "employee_email";
            this.employeeemailDataGridViewTextBoxColumn.Name = "employeeemailDataGridViewTextBoxColumn";
            // 
            // employeetelnoDataGridViewTextBoxColumn
            // 
            this.employeetelnoDataGridViewTextBoxColumn.DataPropertyName = "employee_tel_no";
            this.employeetelnoDataGridViewTextBoxColumn.HeaderText = "employee_tel_no";
            this.employeetelnoDataGridViewTextBoxColumn.Name = "employeetelnoDataGridViewTextBoxColumn";
            // 
            // employeeyearofbirthDataGridViewTextBoxColumn
            // 
            this.employeeyearofbirthDataGridViewTextBoxColumn.DataPropertyName = "employee_year_of_birth";
            this.employeeyearofbirthDataGridViewTextBoxColumn.HeaderText = "employee_year_of_birth";
            this.employeeyearofbirthDataGridViewTextBoxColumn.Name = "employeeyearofbirthDataGridViewTextBoxColumn";
            // 
            // salaryedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 683);
            this.Controls.Add(this.splitContainer1);
            this.Name = "salaryedit";
            this.Text = "salaryedit";
            this.Load += new System.EventHandler(this.salaryedit_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button signout;
        private System.Windows.Forms.Button salary;
        private System.Windows.Forms.Button addemployee;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Label welcomeUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private emsDatabaseDataSet2 emsDatabaseDataSet2;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private emsDatabaseDataSet2TableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeepositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeetelnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeyearofbirthDataGridViewTextBoxColumn;
    }
}