namespace Payroll_Management_system
{
    partial class PayrollMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.secondpanel = new System.Windows.Forms.Panel();
            this.generatepayroll = new System.Windows.Forms.Button();
            this.Attendance = new System.Windows.Forms.Button();
            this.deductionn = new System.Windows.Forms.Button();
            this.Paneldropdown = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.Employeedetails = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.generatePayroll1 = new Payroll_Management_system.GeneratePayroll();
            this.deduction1 = new Payroll_Management_system.Deduction();
            this.attendance1 = new Payroll_Management_system.Attendance();
            this.manageEmployee1 = new Payroll_Management_system.ManageEmployee();
            this.employee_Details1 = new Payroll_Management_system.Employee_Details();
            this.secondpage1 = new Payroll_Management_system.Secondpage();
            this.dashboard1 = new Payroll_Management_system.Dashboard();
            this.login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.secondpanel.SuspendLayout();
            this.Paneldropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.secondpanel);
            this.panel1.Controls.Add(this.Paneldropdown);
            this.panel1.Controls.Add(this.Dashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 509);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // secondpanel
            // 
            this.secondpanel.BackColor = System.Drawing.Color.Transparent;
            this.secondpanel.Controls.Add(this.login);
            this.secondpanel.Controls.Add(this.generatepayroll);
            this.secondpanel.Controls.Add(this.Attendance);
            this.secondpanel.Controls.Add(this.deductionn);
            this.secondpanel.Location = new System.Drawing.Point(1, 308);
            this.secondpanel.Name = "secondpanel";
            this.secondpanel.Size = new System.Drawing.Size(200, 189);
            this.secondpanel.TabIndex = 28;
            // 
            // generatepayroll
            // 
            this.generatepayroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.generatepayroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.generatepayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatepayroll.Font = new System.Drawing.Font("Good Times Rg", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatepayroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.generatepayroll.Image = ((System.Drawing.Image)(resources.GetObject("generatepayroll.Image")));
            this.generatepayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generatepayroll.Location = new System.Drawing.Point(-1, 90);
            this.generatepayroll.Name = "generatepayroll";
            this.generatepayroll.Size = new System.Drawing.Size(203, 45);
            this.generatepayroll.TabIndex = 30;
            this.generatepayroll.Text = "        GENERATE PAYROLL";
            this.generatepayroll.UseVisualStyleBackColor = false;
            this.generatepayroll.Click += new System.EventHandler(this.generatepayroll_Click);
            // 
            // Attendance
            // 
            this.Attendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Attendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attendance.Font = new System.Drawing.Font("Good Times Rg", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.Attendance.Image = ((System.Drawing.Image)(resources.GetObject("Attendance.Image")));
            this.Attendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Attendance.Location = new System.Drawing.Point(-3, 0);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(203, 45);
            this.Attendance.TabIndex = 23;
            this.Attendance.Text = "ATTENDANCE";
            this.Attendance.UseVisualStyleBackColor = false;
            this.Attendance.Click += new System.EventHandler(this.Attendance_Click);
            // 
            // deductionn
            // 
            this.deductionn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.deductionn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.deductionn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deductionn.Font = new System.Drawing.Font("Good Times Rg", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductionn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.deductionn.Image = ((System.Drawing.Image)(resources.GetObject("deductionn.Image")));
            this.deductionn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deductionn.Location = new System.Drawing.Point(-2, 45);
            this.deductionn.Name = "deductionn";
            this.deductionn.Size = new System.Drawing.Size(203, 45);
            this.deductionn.TabIndex = 29;
            this.deductionn.Text = "DEDUCTION";
            this.deductionn.UseVisualStyleBackColor = false;
            this.deductionn.Click += new System.EventHandler(this.deductionn_Click);
            // 
            // Paneldropdown
            // 
            this.Paneldropdown.BackColor = System.Drawing.Color.Transparent;
            this.Paneldropdown.Controls.Add(this.button4);
            this.Paneldropdown.Controls.Add(this.Employeedetails);
            this.Paneldropdown.Controls.Add(this.button3);
            this.Paneldropdown.Controls.Add(this.button1);
            this.Paneldropdown.Location = new System.Drawing.Point(1, 157);
            this.Paneldropdown.Name = "Paneldropdown";
            this.Paneldropdown.Size = new System.Drawing.Size(199, 151);
            this.Paneldropdown.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Good Times Rg", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(-3, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 35);
            this.button4.TabIndex = 25;
            this.button4.Text = " Manage Employee";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Employeedetails
            // 
            this.Employeedetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Employeedetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Employeedetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employeedetails.Font = new System.Drawing.Font("Good Times Rg", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employeedetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.Employeedetails.Image = ((System.Drawing.Image)(resources.GetObject("Employeedetails.Image")));
            this.Employeedetails.Location = new System.Drawing.Point(-3, 80);
            this.Employeedetails.Name = "Employeedetails";
            this.Employeedetails.Size = new System.Drawing.Size(202, 38);
            this.Employeedetails.TabIndex = 24;
            this.Employeedetails.Text = " Employee Details";
            this.Employeedetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Employeedetails.UseVisualStyleBackColor = false;
            this.Employeedetails.Click += new System.EventHandler(this.Employeedetails_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Good Times Rg", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-3, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 38);
            this.button3.TabIndex = 23;
            this.button3.Text = "Add Employee";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Good Times Rg", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 45);
            this.button1.TabIndex = 22;
            this.button1.Text = "         EMPLOYEE";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Good Times Rg", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.Image")));
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(-1, 112);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(203, 45);
            this.Dashboard.TabIndex = 26;
            this.Dashboard.Text = "DASHBOARD";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // generatePayroll1
            // 
            this.generatePayroll1.BackColor = System.Drawing.SystemColors.Control;
            this.generatePayroll1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("generatePayroll1.BackgroundImage")));
            this.generatePayroll1.Location = new System.Drawing.Point(197, 0);
            this.generatePayroll1.Name = "generatePayroll1";
            this.generatePayroll1.Size = new System.Drawing.Size(654, 509);
            this.generatePayroll1.TabIndex = 2;
            // 
            // deduction1
            // 
            this.deduction1.BackColor = System.Drawing.Color.Transparent;
            this.deduction1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deduction1.BackgroundImage")));
            this.deduction1.Font = new System.Drawing.Font("EA Font v1.5 by Ghettoshark", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deduction1.Location = new System.Drawing.Point(197, 0);
            this.deduction1.Name = "deduction1";
            this.deduction1.Size = new System.Drawing.Size(654, 509);
            this.deduction1.TabIndex = 3;
            // 
            // attendance1
            // 
            this.attendance1.AccessibleName = "";
            this.attendance1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("attendance1.BackgroundImage")));
            this.attendance1.Location = new System.Drawing.Point(197, 0);
            this.attendance1.Name = "attendance1";
            this.attendance1.Size = new System.Drawing.Size(654, 509);
            this.attendance1.TabIndex = 4;
            // 
            // manageEmployee1
            // 
            this.manageEmployee1.BackColor = System.Drawing.Color.Transparent;
            this.manageEmployee1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("manageEmployee1.BackgroundImage")));
            this.manageEmployee1.Location = new System.Drawing.Point(197, 0);
            this.manageEmployee1.Name = "manageEmployee1";
            this.manageEmployee1.Size = new System.Drawing.Size(654, 509);
            this.manageEmployee1.TabIndex = 5;
            // 
            // employee_Details1
            // 
            this.employee_Details1.BackColor = System.Drawing.Color.Transparent;
            this.employee_Details1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employee_Details1.BackgroundImage")));
            this.employee_Details1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_Details1.Location = new System.Drawing.Point(197, 0);
            this.employee_Details1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_Details1.Name = "employee_Details1";
            this.employee_Details1.Size = new System.Drawing.Size(654, 509);
            this.employee_Details1.TabIndex = 6;
            // 
            // secondpage1
            // 
            this.secondpage1.BackColor = System.Drawing.Color.Transparent;
            this.secondpage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secondpage1.BackgroundImage")));
            this.secondpage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondpage1.Location = new System.Drawing.Point(197, 0);
            this.secondpage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondpage1.Name = "secondpage1";
            this.secondpage1.Size = new System.Drawing.Size(654, 509);
            this.secondpage1.TabIndex = 7;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(197, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(647, 509);
            this.dashboard1.TabIndex = 8;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Good Times Rg", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.login.Image = ((System.Drawing.Image)(resources.GetObject("login.Image")));
            this.login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login.Location = new System.Drawing.Point(-3, 135);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(203, 45);
            this.login.TabIndex = 31;
            this.login.Text = "LOG OUT";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // PayrollMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 509);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.secondpage1);
            this.Controls.Add(this.employee_Details1);
            this.Controls.Add(this.manageEmployee1);
            this.Controls.Add(this.attendance1);
            this.Controls.Add(this.deduction1);
            this.Controls.Add(this.generatePayroll1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayrollMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayrollMain";
            this.Load += new System.EventHandler(this.PayrollMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.secondpanel.ResumeLayout(false);
            this.Paneldropdown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel secondpanel;
        private System.Windows.Forms.Button Attendance;
        private System.Windows.Forms.Panel Paneldropdown;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Employeedetails;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button generatepayroll;
        private System.Windows.Forms.Button deductionn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GeneratePayroll generatePayroll1;
        private Deduction deduction1;
        private Attendance attendance1;
        private ManageEmployee manageEmployee1;
        private Employee_Details employee_Details1;
        private Secondpage secondpage1;
        private Dashboard dashboard1;
        private System.Windows.Forms.Button login;
    }
}