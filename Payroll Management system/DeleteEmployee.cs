﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Payroll_Management_system
{
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Connection.connectionString);
        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Delete from Employee Where Eid='"+employeeid.Text+"'";
            SqlCommand data = new SqlCommand(query,con);
            data.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been succesfully Deleted","Delete Operation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Hide();
            employeeid.Text = "";
            
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
