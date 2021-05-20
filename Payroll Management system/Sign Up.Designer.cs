namespace Payroll_Management_system
{
    partial class Sign_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_Up));
            this.Employeeid = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.id = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fathername = new System.Windows.Forms.TextBox();
            this.Information = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.deductionreason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.deductionamount = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.basicpay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.TextBox();
            this.dashtext = new System.Windows.Forms.Label();
            this.deduct = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // Employeeid
            // 
            this.Employeeid.AutoSize = true;
            this.Employeeid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employeeid.Location = new System.Drawing.Point(189, 96);
            this.Employeeid.Name = "Employeeid";
            this.Employeeid.Size = new System.Drawing.Size(31, 21);
            this.Employeeid.TabIndex = 6;
            this.Employeeid.Text = "ID:";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Login1.png");
            this.imageList2.Images.SetKeyName(1, "Loginx.jpg");
            this.imageList2.Images.SetKeyName(2, "enter.png");
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.id.Location = new System.Drawing.Point(226, 96);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(111, 20);
            this.id.TabIndex = 10;
            this.id.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close.png");
            this.imageList1.Images.SetKeyName(1, "minimize+minus+remove+sign+icon-1320085940403912850.png");
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.ImageIndex = 1;
            this.Minimize.ImageList = this.imageList1;
            this.Minimize.Location = new System.Drawing.Point(469, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(31, 33);
            this.Minimize.TabIndex = 14;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.button2_Click);
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ImageIndex = 0;
            this.Close.ImageList = this.imageList1;
            this.Close.Location = new System.Drawing.Point(503, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(30, 33);
            this.Close.TabIndex = 13;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fathername:";
            // 
            // fathername
            // 
            this.fathername.BackColor = System.Drawing.SystemColors.Control;
            this.fathername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fathername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fathername.Location = new System.Drawing.Point(145, 73);
            this.fathername.Name = "fathername";
            this.fathername.Size = new System.Drawing.Size(157, 20);
            this.fathername.TabIndex = 12;
            // 
            // Information
            // 
            this.Information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Information.Controls.Add(this.name);
            this.Information.Controls.Add(this.label9);
            this.Information.Controls.Add(this.deductionreason);
            this.Information.Controls.Add(this.label8);
            this.Information.Controls.Add(this.deductionamount);
            this.Information.Controls.Add(this.image);
            this.Information.Controls.Add(this.label7);
            this.Information.Controls.Add(this.basicpay);
            this.Information.Controls.Add(this.label6);
            this.Information.Controls.Add(this.department);
            this.Information.Controls.Add(this.label5);
            this.Information.Controls.Add(this.phone);
            this.Information.Controls.Add(this.label2);
            this.Information.Controls.Add(this.gender);
            this.Information.Controls.Add(this.label1);
            this.Information.Controls.Add(this.fathername);
            this.Information.Location = new System.Drawing.Point(12, 137);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(511, 271);
            this.Information.TabIndex = 16;
            this.Information.Paint += new System.Windows.Forms.PaintEventHandler(this.Information_Paint);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Azonix", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.name.Location = new System.Drawing.Point(117, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 40);
            this.name.TabIndex = 26;
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Deduction Reason:";
            // 
            // deductionreason
            // 
            this.deductionreason.BackColor = System.Drawing.SystemColors.Control;
            this.deductionreason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deductionreason.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductionreason.Location = new System.Drawing.Point(185, 234);
            this.deductionreason.Multiline = true;
            this.deductionreason.Name = "deductionreason";
            this.deductionreason.Size = new System.Drawing.Size(321, 20);
            this.deductionreason.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Deduction Amount:";
            // 
            // deductionamount
            // 
            this.deductionamount.BackColor = System.Drawing.SystemColors.Control;
            this.deductionamount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deductionamount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductionamount.Location = new System.Drawing.Point(191, 205);
            this.deductionamount.Name = "deductionamount";
            this.deductionamount.Size = new System.Drawing.Size(111, 20);
            this.deductionamount.TabIndex = 23;
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(365, 80);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(105, 130);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 21;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Basic Pay:";
            // 
            // basicpay
            // 
            this.basicpay.BackColor = System.Drawing.SystemColors.Control;
            this.basicpay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.basicpay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicpay.Location = new System.Drawing.Point(119, 178);
            this.basicpay.Name = "basicpay";
            this.basicpay.Size = new System.Drawing.Size(148, 20);
            this.basicpay.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Department:";
            // 
            // department
            // 
            this.department.BackColor = System.Drawing.SystemColors.Control;
            this.department.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.department.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(141, 152);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(218, 20);
            this.department.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone:";
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.SystemColors.Control;
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(99, 128);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(172, 20);
            this.phone.TabIndex = 16;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gender:";
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.SystemColors.Control;
            this.gender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(109, 98);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(98, 20);
            this.gender.TabIndex = 14;
            // 
            // dashtext
            // 
            this.dashtext.AutoSize = true;
            this.dashtext.Font = new System.Drawing.Font("Azonix", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.dashtext.Location = new System.Drawing.Point(89, 38);
            this.dashtext.Name = "dashtext";
            this.dashtext.Size = new System.Drawing.Size(381, 40);
            this.dashtext.TabIndex = 23;
            this.dashtext.Text = "EMPLOYEE PAGE";
            // 
            // deduct
            // 
            this.deduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deduct.Location = new System.Drawing.Point(206, 418);
            this.deduct.Name = "deduct";
            this.deduct.Size = new System.Drawing.Size(128, 25);
            this.deduct.TabIndex = 53;
            this.deduct.Text = "Print";
            this.deduct.UseVisualStyleBackColor = true;
            this.deduct.Click += new System.EventHandler(this.deduct_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 459);
            this.Controls.Add(this.deduct);
            this.Controls.Add(this.dashtext);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Employeeid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sign_Up_Load);
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Employeeid;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Minimize;
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fathername;
        private System.Windows.Forms.Panel Information;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox deductionreason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox deductionamount;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox basicpay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label dashtext;
        private System.Windows.Forms.Button deduct;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}