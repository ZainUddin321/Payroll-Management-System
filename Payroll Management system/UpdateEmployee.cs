using System;
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
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Connection.connectionString);
        private void Update_Click(object sender, EventArgs e)
        {
            if (Options.SelectedItem.ToString() == "Name")
            {
                con.Open();
                string query = "Update Employee SET eName='"+value.Text+"' where Eid='" + employeeid.Text + "'";
                SqlCommand data = new SqlCommand(query, con);
                data.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been succesfully Updated", "Operation Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                employeeid.Text = "";
                Options.Text = "";
                value.Text = "";
            }
            else if (Options.SelectedItem.ToString() == "Salary")
            {
                con.Open();
                string query = "Update Salary SET sBasicSalary='" + value.Text + "' where Eid='" + employeeid.Text + "'";
                SqlCommand data = new SqlCommand(query, con);
                data.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been succesfully Updated", "Operation Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                employeeid.Text = "";
                Options.Text = "";
                value.Text = "";
            }
            else if (Options.SelectedItem.ToString() == "Phone#")
            {
                con.Open();
                string query = "Update Employee SET ePhone='" + value.Text + "' where Eid='" + employeeid.Text + "'";
                SqlCommand data = new SqlCommand(query, con);
                data.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been succesfully Updated", "Operation Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                employeeid.Text = "";
                Options.Text = "";
                value.Text = "";
            }
            else if (Options.SelectedItem.ToString() == "Designation")
            {
                con.Open();
                string query = "Update Employee SET eDesignation='" + value.Text + "' where Eid='" + employeeid.Text + "'";
                SqlCommand data = new SqlCommand(query, con);
                data.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been succesfully Updated", "Operation Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                employeeid.Text = "";
                Options.Text = "";
                value.Text = "";
            }
            else if (Options.SelectedItem.ToString() == "Department")
            {
                con.Open();
                string query = "Update Employee SET eDepartment='" + value.Text + "' where Eid='" + employeeid.Text + "'";
                SqlCommand data = new SqlCommand(query, con);
                data.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been succesfully Updated", "Operation Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                employeeid.Text = "";
                Options.Text = "";
                value.Text = "";
            }
            else
            {
                MessageBox.Show("Please select any field.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void employeeid_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
