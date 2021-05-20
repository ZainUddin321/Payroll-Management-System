namespace Payroll_Management_system
{
    partial class GeneratePayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePayroll));
            this.name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.basicpay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Convence = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Medical = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Houserent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generate = new System.Windows.Forms.Button();
            this.adddetails = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Total = new System.Windows.Forms.Label();
            this.DeductionReason = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DeductionAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.incometax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grosspay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Employeeid = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(97, 139);
            this.name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(214, 22);
            this.name.TabIndex = 21;
            this.name.TextChanged += new System.EventHandler(this.basicsalary_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Name:";
            // 
            // basicpay
            // 
            this.basicpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.basicpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicpay.Location = new System.Drawing.Point(442, 94);
            this.basicpay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.basicpay.MaxLength = 7;
            this.basicpay.Name = "basicpay";
            this.basicpay.ReadOnly = true;
            this.basicpay.Size = new System.Drawing.Size(150, 22);
            this.basicpay.TabIndex = 23;
            this.basicpay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Basic Pay:";
            // 
            // Convence
            // 
            this.Convence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Convence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convence.Location = new System.Drawing.Point(136, 44);
            this.Convence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Convence.MaxLength = 7;
            this.Convence.Name = "Convence";
            this.Convence.ReadOnly = true;
            this.Convence.Size = new System.Drawing.Size(150, 22);
            this.Convence.TabIndex = 25;
            this.Convence.TextChanged += new System.EventHandler(this.Convence_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 24;
            // 
            // Medical
            // 
            this.Medical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Medical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medical.Location = new System.Drawing.Point(136, 87);
            this.Medical.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Medical.MaxLength = 7;
            this.Medical.Name = "Medical";
            this.Medical.ReadOnly = true;
            this.Medical.Size = new System.Drawing.Size(150, 22);
            this.Medical.TabIndex = 27;
            this.Medical.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Medical:";
            // 
            // Houserent
            // 
            this.Houserent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Houserent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Houserent.Location = new System.Drawing.Point(136, 127);
            this.Houserent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Houserent.MaxLength = 7;
            this.Houserent.Name = "Houserent";
            this.Houserent.ReadOnly = true;
            this.Houserent.Size = new System.Drawing.Size(150, 22);
            this.Houserent.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "House Rent:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Employee ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Convence:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.generate);
            this.panel1.Controls.Add(this.adddetails);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.DeductionReason);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.DeductionAmount);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.incometax);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.grosspay);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Houserent);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Medical);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Convence);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(10, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 304);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.Location = new System.Drawing.Point(71, 239);
            this.generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(139, 40);
            this.generate.TabIndex = 65;
            this.generate.Text = "GENERATE";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // adddetails
            // 
            this.adddetails.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adddetails.Location = new System.Drawing.Point(348, 79);
            this.adddetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adddetails.Name = "adddetails";
            this.adddetails.Size = new System.Drawing.Size(234, 40);
            this.adddetails.TabIndex = 64;
            this.adddetails.Text = "CALCULATE DEDUCTION";
            this.adddetails.UseVisualStyleBackColor = true;
            this.adddetails.Click += new System.EventHandler(this.adddetails_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Total);
            this.panel3.Location = new System.Drawing.Point(307, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 31);
            this.panel3.TabIndex = 50;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(3, 1);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(58, 29);
            this.Total.TabIndex = 47;
            this.Total.Text = "0.00";
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // DeductionReason
            // 
            this.DeductionReason.Location = new System.Drawing.Point(480, 168);
            this.DeductionReason.Name = "DeductionReason";
            this.DeductionReason.Size = new System.Drawing.Size(150, 60);
            this.DeductionReason.TabIndex = 49;
            this.DeductionReason.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(316, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 21);
            this.label14.TabIndex = 48;
            this.label14.Text = "Deduction Reason:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(216, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 21);
            this.label12.TabIndex = 46;
            this.label12.Text = "Net Salary:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(316, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 21);
            this.label13.TabIndex = 42;
            this.label13.Text = "Income Tax:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // DeductionAmount
            // 
            this.DeductionAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeductionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeductionAmount.Location = new System.Drawing.Point(435, 127);
            this.DeductionAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeductionAmount.MaxLength = 7;
            this.DeductionAmount.Name = "DeductionAmount";
            this.DeductionAmount.ReadOnly = true;
            this.DeductionAmount.Size = new System.Drawing.Size(150, 22);
            this.DeductionAmount.TabIndex = 39;
            this.DeductionAmount.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(316, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 21);
            this.label15.TabIndex = 38;
            this.label15.Text = "Deduction:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // incometax
            // 
            this.incometax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incometax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incometax.Location = new System.Drawing.Point(435, 44);
            this.incometax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.incometax.MaxLength = 7;
            this.incometax.Name = "incometax";
            this.incometax.ReadOnly = true;
            this.incometax.Size = new System.Drawing.Size(150, 22);
            this.incometax.TabIndex = 37;
            this.incometax.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(418, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 19);
            this.label11.TabIndex = 36;
            this.label11.Text = "Taxes";
            // 
            // grosspay
            // 
            this.grosspay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grosspay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grosspay.Location = new System.Drawing.Point(136, 166);
            this.grosspay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grosspay.MaxLength = 9;
            this.grosspay.Name = "grosspay";
            this.grosspay.ReadOnly = true;
            this.grosspay.Size = new System.Drawing.Size(150, 22);
            this.grosspay.TabIndex = 35;
            this.grosspay.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "Gross Pay:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(111, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "Allowances";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Employeeid
            // 
            this.Employeeid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Employeeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employeeid.Location = new System.Drawing.Point(146, 94);
            this.Employeeid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Employeeid.MaxLength = 50;
            this.Employeeid.Name = "Employeeid";
            this.Employeeid.Size = new System.Drawing.Size(150, 22);
            this.Employeeid.TabIndex = 31;
            this.Employeeid.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("EA Font v1.5 by Ghettoshark", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.label16.Location = new System.Drawing.Point(3, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(375, 44);
            this.label16.TabIndex = 34;
            this.label16.Text = "Generate Payroll";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.label16);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 56);
            this.panel2.TabIndex = 35;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ImageIndex = 0;
            this.Close.ImageList = this.imageList1;
            this.Close.Location = new System.Drawing.Point(614, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(30, 33);
            this.Close.TabIndex = 35;
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
            // GeneratePayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Payroll_Management_system.Properties.Resources.gradientBackground1;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Employeeid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.basicpay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label8);
            this.Name = "GeneratePayroll";
            this.Size = new System.Drawing.Size(654, 509);
            this.Load += new System.EventHandler(this.GeneratePayroll_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox basicpay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Convence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Medical;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Houserent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox grosspay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DeductionAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox incometax;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Employeeid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox DeductionReason;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button adddetails;
        private System.Windows.Forms.Button generate;
    }
}
