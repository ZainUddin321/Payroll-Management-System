namespace Payroll_Management_system
{
    partial class ManageEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployee));
            this.Detaildisplayer = new System.Windows.Forms.DataGridView();
            this.updatedetail = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Detaildisplayer)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Detaildisplayer
            // 
            this.Detaildisplayer.AllowUserToAddRows = false;
            this.Detaildisplayer.AllowUserToDeleteRows = false;
            this.Detaildisplayer.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.Detaildisplayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detaildisplayer.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Detaildisplayer.Location = new System.Drawing.Point(17, 133);
            this.Detaildisplayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Detaildisplayer.Name = "Detaildisplayer";
            this.Detaildisplayer.ReadOnly = true;
            this.Detaildisplayer.Size = new System.Drawing.Size(624, 288);
            this.Detaildisplayer.TabIndex = 20;
            this.Detaildisplayer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Detaildisplayer_CellContentClick);
            // 
            // updatedetail
            // 
            this.updatedetail.Location = new System.Drawing.Point(35, 437);
            this.updatedetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updatedetail.Name = "updatedetail";
            this.updatedetail.Size = new System.Drawing.Size(233, 55);
            this.updatedetail.TabIndex = 21;
            this.updatedetail.Text = "Update Detail";
            this.updatedetail.UseVisualStyleBackColor = true;
            this.updatedetail.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(304, 437);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(233, 55);
            this.Delete.TabIndex = 22;
            this.Delete.Text = "Delete Detail";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "noun_Refresh_24732.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("EA Font v1.5 by Ghettoshark", 30F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 44);
            this.label1.TabIndex = 25;
            this.label1.Text = "Manage Employee";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 68);
            this.panel2.TabIndex = 36;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ImageIndex = 0;
            this.Close.ImageList = this.imageList2;
            this.Close.Location = new System.Drawing.Point(612, 1);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(35, 37);
            this.Close.TabIndex = 26;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "close.png");
            this.imageList2.Images.SetKeyName(1, "minimize+minus+remove+sign+icon-1320085940403912850.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Search by ID:";
            // 
            // search
            // 
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(509, 93);
            this.search.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(81, 22);
            this.search.TabIndex = 19;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(596, 78);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 50);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Payroll_Management_system.Properties.Resources.gradientBackground1;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.updatedetail);
            this.Controls.Add(this.Detaildisplayer);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageEmployee";
            this.Size = new System.Drawing.Size(654, 509);
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Detaildisplayer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Detaildisplayer;
        private System.Windows.Forms.Button updatedetail;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button2;
    }
}
