namespace Payroll_Management_system
{
    partial class Deduction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deduction));
            this.name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Employeeid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deductionreason = new System.Windows.Forms.ComboBox();
            this.deductionamount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(120, 142);
            this.name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(214, 22);
            this.name.TabIndex = 41;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Name:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Employeeid
            // 
            this.Employeeid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Employeeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employeeid.Location = new System.Drawing.Point(168, 97);
            this.Employeeid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Employeeid.MaxLength = 50;
            this.Employeeid.Name = "Employeeid";
            this.Employeeid.Size = new System.Drawing.Size(150, 22);
            this.Employeeid.TabIndex = 39;
            this.Employeeid.TextChanged += new System.EventHandler(this.Employeeid_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "Employee ID:";
            // 
            // department
            // 
            this.department.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(170, 192);
            this.department.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Size = new System.Drawing.Size(214, 22);
            this.department.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Department:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Deduction Reason:";
            // 
            // deductionreason
            // 
            this.deductionreason.FormattingEnabled = true;
            this.deductionreason.Items.AddRange(new object[] {
            "Poor behavior",
            "Late task submission",
            "Recovery of Advance",
            "Past loan",
            "Compensation for damage of office",
            "Tools used in the employees office work"});
            this.deductionreason.Location = new System.Drawing.Point(218, 244);
            this.deductionreason.Name = "deductionreason";
            this.deductionreason.Size = new System.Drawing.Size(121, 20);
            this.deductionreason.TabIndex = 49;
            // 
            // deductionamount
            // 
            this.deductionamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deductionamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductionamount.Location = new System.Drawing.Point(226, 294);
            this.deductionamount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deductionamount.Name = "deductionamount";
            this.deductionamount.Size = new System.Drawing.Size(214, 22);
            this.deductionamount.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Deduction Amount:";
            // 
            // deduct
            // 
            this.deduct.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.deduct.Location = new System.Drawing.Point(57, 342);
            this.deduct.Name = "deduct";
            this.deduct.Size = new System.Drawing.Size(200, 42);
            this.deduct.TabIndex = 52;
            this.deduct.Text = "Deduct";
            this.deduct.UseVisualStyleBackColor = true;
            this.deduct.Click += new System.EventHandler(this.deduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("EA Font v1.5 by Ghettoshark", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 44);
            this.label1.TabIndex = 53;
            this.label1.Text = "Deduction";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 52);
            this.panel2.TabIndex = 54;
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ImageIndex = 0;
            this.Close.ImageList = this.imageList1;
            this.Close.Location = new System.Drawing.Point(614, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(30, 30);
            this.Close.TabIndex = 54;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close.png");
            this.imageList1.Images.SetKeyName(1, "minimize+minus+remove+sign+icon-1320085940403912850.png");
            // 
            // Deduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Payroll_Management_system.Properties.Resources.gradientBackground1;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deduct);
            this.Controls.Add(this.deductionamount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deductionreason);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Employeeid);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("EA Font v1.5 by Ghettoshark", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Deduction";
            this.Size = new System.Drawing.Size(654, 509);
            this.Load += new System.EventHandler(this.Deduction_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Employeeid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox deductionreason;
        private System.Windows.Forms.TextBox deductionamount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Close;
    }
}
