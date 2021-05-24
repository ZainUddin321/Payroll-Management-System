namespace Payroll_Management_system
{
    partial class UpdateEmployee
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
            this.employeeid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Options = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeid
            // 
            this.employeeid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeid.Location = new System.Drawing.Point(167, 36);
            this.employeeid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeeid.Name = "employeeid";
            this.employeeid.Size = new System.Drawing.Size(70, 22);
            this.employeeid.TabIndex = 21;
            this.employeeid.TextChanged += new System.EventHandler(this.employeeid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Employee ID:";
            // 
            // Options
            // 
            this.Options.FormattingEnabled = true;
            this.Options.Items.AddRange(new object[] {
            "Name",
            "Salary",
            "Phone#",
            "Designation",
            "Department"});
            this.Options.Location = new System.Drawing.Point(132, 89);
            this.Options.MaxDropDownItems = 15;
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(121, 21);
            this.Options.TabIndex = 22;
            this.Options.Text = "Choose";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Update:";
            // 
            // Update
            // 
            this.Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Update.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(53, 163);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(200, 45);
            this.Update.TabIndex = 24;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // value
            // 
            this.value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.Location = new System.Drawing.Point(132, 124);
            this.value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(121, 22);
            this.value.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Value:";
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 229);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.value);
            this.Controls.Add(this.employeeid);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateEmployee";
            this.Load += new System.EventHandler(this.UpdateEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox employeeid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Options;
        private System.Windows.Forms.Label label1;
        private new System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label4;
    }
}