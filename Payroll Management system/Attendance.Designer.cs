namespace Payroll_Management_system
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.adddetails = new System.Windows.Forms.Button();
            this.employeeid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Detaildisplayer = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Detaildisplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("EA Font v1.5 by Ghettoshark", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 44);
            this.label1.TabIndex = 53;
            this.label1.Text = "Attendance  Record";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 72);
            this.panel2.TabIndex = 54;
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ImageIndex = 0;
            this.Close.ImageList = this.imageList1;
            this.Close.Location = new System.Drawing.Point(614, 3);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(34, 33);
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
            this.imageList1.Images.SetKeyName(2, "noun_Refresh_24732.png");
            // 
            // adddetails
            // 
            this.adddetails.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adddetails.Location = new System.Drawing.Point(434, 97);
            this.adddetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adddetails.Name = "adddetails";
            this.adddetails.Size = new System.Drawing.Size(200, 42);
            this.adddetails.TabIndex = 63;
            this.adddetails.Text = "MARK ATTENDANCE";
            this.adddetails.UseVisualStyleBackColor = true;
            this.adddetails.Click += new System.EventHandler(this.adddetails_Click_1);
            // 
            // employeeid
            // 
            this.employeeid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeid.Location = new System.Drawing.Point(159, 108);
            this.employeeid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.employeeid.Name = "employeeid";
            this.employeeid.Size = new System.Drawing.Size(92, 22);
            this.employeeid.TabIndex = 65;
            this.employeeid.TextChanged += new System.EventHandler(this.employeeid_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 64;
            this.label3.Text = "Employee ID:";
            // 
            // Detaildisplayer
            // 
            this.Detaildisplayer.AllowUserToAddRows = false;
            this.Detaildisplayer.AllowUserToDeleteRows = false;
            this.Detaildisplayer.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.Detaildisplayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detaildisplayer.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Detaildisplayer.Location = new System.Drawing.Point(42, 170);
            this.Detaildisplayer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Detaildisplayer.Name = "Detaildisplayer";
            this.Detaildisplayer.ReadOnly = true;
            this.Detaildisplayer.Size = new System.Drawing.Size(444, 287);
            this.Detaildisplayer.TabIndex = 66;
            this.Detaildisplayer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Detaildisplayer_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.imageList2;
            this.button2.Location = new System.Drawing.Point(264, 97);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 40);
            this.button2.TabIndex = 67;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "noun_Refresh_24732.png");
            // 
            // Attendance
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Payroll_Management_system.Properties.Resources.gradientBackground1;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Detaildisplayer);
            this.Controls.Add(this.employeeid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adddetails);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Attendance";
            this.Size = new System.Drawing.Size(654, 509);
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Detaildisplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button adddetails;
        private System.Windows.Forms.TextBox employeeid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Detaildisplayer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList2;
    }
}
