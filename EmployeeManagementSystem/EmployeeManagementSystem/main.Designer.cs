
namespace EmployeeManagementSystem
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.salary = new System.Windows.Forms.Button();
            this.addemployee = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.welcomeUser = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.developer = new System.Windows.Forms.Label();
            this.signout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.developer);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1410, 683);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.TabIndex = 0;
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
            this.salary.TabIndex = 4;
            this.salary.Text = "Salary";
            this.salary.UseVisualStyleBackColor = false;
            this.salary.Click += new System.EventHandler(this.salary_Click);
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
            this.addemployee.TabIndex = 3;
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
            this.dashboard.TabIndex = 2;
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
            this.welcomeUser.TabIndex = 1;
            this.welcomeUser.Text = "Welcome, USER";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(18, 418);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(996, 228);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee Management System - How It Works";
            // 
            // developer
            // 
            this.developer.AutoSize = true;
            this.developer.Location = new System.Drawing.Point(907, 661);
            this.developer.Name = "developer";
            this.developer.Size = new System.Drawing.Size(107, 13);
            this.developer.TabIndex = 3;
            this.developer.Text = "Made By Barış Belevi";
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
            this.signout.TabIndex = 5;
            this.signout.UseVisualStyleBackColor = false;
            this.signout.Click += new System.EventHandler(this.signout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.hm;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(107, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EmployeeManagementSystem.Properties.Resources.Ekran_görüntüsü_2024_08_26_025342;
            this.pictureBox4.Location = new System.Drawing.Point(645, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(369, 391);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EmployeeManagementSystem.Properties.Resources.Employee_Management_Meaning_Importance_Tips_Tools___More;
            this.pictureBox2.Location = new System.Drawing.Point(18, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(621, 348);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 683);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "main";
            this.Text = "EMS - Dashboard";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label welcomeUser;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signout;
        private System.Windows.Forms.Button salary;
        private System.Windows.Forms.Button addemployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label developer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

