namespace Payroll_Management_system
{
    partial class MarkAttendance
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
            this.min2 = new System.Windows.Forms.NumericUpDown();
            this.min1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.NumericUpDown();
            this.adddetails = new System.Windows.Forms.Button();
            this.absent = new System.Windows.Forms.RadioButton();
            this.present = new System.Windows.Forms.RadioButton();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lavel13 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Employeeid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Timemode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.min2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hour)).BeginInit();
            this.SuspendLayout();
            // 
            // min2
            // 
            this.min2.Location = new System.Drawing.Point(237, 249);
            this.min2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(32, 20);
            this.min2.TabIndex = 66;
            // 
            // min1
            // 
            this.min1.Location = new System.Drawing.Point(199, 249);
            this.min1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(32, 20);
            this.min1.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = ":";
            // 
            // Hour
            // 
            this.Hour.Location = new System.Drawing.Point(146, 249);
            this.Hour.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Hour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(32, 20);
            this.Hour.TabIndex = 63;
            this.Hour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // adddetails
            // 
            this.adddetails.Location = new System.Drawing.Point(30, 309);
            this.adddetails.Name = "adddetails";
            this.adddetails.Size = new System.Drawing.Size(200, 45);
            this.adddetails.TabIndex = 62;
            this.adddetails.Text = "Add Details";
            this.adddetails.UseVisualStyleBackColor = true;
            this.adddetails.Click += new System.EventHandler(this.adddetails_Click);
            // 
            // absent
            // 
            this.absent.AutoSize = true;
            this.absent.BackColor = System.Drawing.Color.Transparent;
            this.absent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absent.Location = new System.Drawing.Point(133, 202);
            this.absent.Name = "absent";
            this.absent.Size = new System.Drawing.Size(85, 25);
            this.absent.TabIndex = 61;
            this.absent.TabStop = true;
            this.absent.Text = "Absent";
            this.absent.UseVisualStyleBackColor = false;
            // 
            // present
            // 
            this.present.AutoSize = true;
            this.present.BackColor = System.Drawing.Color.Transparent;
            this.present.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.present.Location = new System.Drawing.Point(30, 202);
            this.present.Name = "present";
            this.present.Size = new System.Drawing.Size(85, 25);
            this.present.TabIndex = 60;
            this.present.TabStop = true;
            this.present.Text = "Present";
            this.present.UseVisualStyleBackColor = false;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(94, 157);
            this.date.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 58;
            this.label4.Text = "Arriving Time:";
            // 
            // lavel13
            // 
            this.lavel13.AutoSize = true;
            this.lavel13.BackColor = System.Drawing.Color.Transparent;
            this.lavel13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lavel13.Location = new System.Drawing.Point(25, 157);
            this.lavel13.Name = "lavel13";
            this.lavel13.Size = new System.Drawing.Size(54, 21);
            this.lavel13.TabIndex = 57;
            this.lavel13.Text = "Date:";
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(94, 105);
            this.name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(214, 22);
            this.name.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "Name:";
            // 
            // Employeeid
            // 
            this.Employeeid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Employeeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employeeid.Location = new System.Drawing.Point(142, 56);
            this.Employeeid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Employeeid.MaxLength = 50;
            this.Employeeid.Name = "Employeeid";
            this.Employeeid.Size = new System.Drawing.Size(150, 22);
            this.Employeeid.TabIndex = 54;
            this.Employeeid.TextChanged += new System.EventHandler(this.Employeeid_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "Employee ID:";
            // 
            // Timemode
            // 
            this.Timemode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Timemode.FormattingEnabled = true;
            this.Timemode.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.Timemode.Location = new System.Drawing.Point(275, 248);
            this.Timemode.Name = "Timemode";
            this.Timemode.Size = new System.Drawing.Size(52, 21);
            this.Timemode.TabIndex = 67;
            // 
            // MarkAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 381);
            this.Controls.Add(this.Timemode);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.adddetails);
            this.Controls.Add(this.absent);
            this.Controls.Add(this.present);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lavel13);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Employeeid);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MarkAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarkAttendance";
            this.Load += new System.EventHandler(this.MarkAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.min2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown min2;
        private System.Windows.Forms.NumericUpDown min1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Hour;
        private System.Windows.Forms.Button adddetails;
        private System.Windows.Forms.RadioButton absent;
        private System.Windows.Forms.RadioButton present;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lavel13;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Employeeid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Timemode;
    }
}