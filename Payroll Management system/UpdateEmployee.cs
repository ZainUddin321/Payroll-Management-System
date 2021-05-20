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
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\zaing\OneDrive\Documents\PayrollDataBase.mdf;Integrated Security = True; Connect Timeout = 30");
        private void Update_Click(object sender, EventArgs e)
        {
            if (Options.SelectedItem.ToString() == "Name")
            {
                con.Open();
                string query = "Update EmployeeDetail SET Name='"+value.Text+"' where EmployeeID='" + employeeid.Text + "'";
                SqlCommand data = new SqlCommand(query, con);
                data.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been succesfully Updated", "Operation Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                employeeid.Text = "";
                Options.Text = "";
                value.Text = "";
            }
            else if (Options.SelectedItem.ToString() == "Fathername")
            {
                con.Open();
                string query = "Update EmployeeDetail SET Fathername='" + value.Text + "' where EmployeeID='" + employeeid.Text + "'";
                SqlCommand data = new SqlCommand(query, con);
                data.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been succesfully Updated", "Operation Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                employeeid.Text = "";
                Options.Text = "";
                value.Text = "";
            }
            else if (Options.SelectedItem.ToString() == "EmployeeID")
            {
                con.Open();
                string query = "Update EmployeeDetail SET EmployeeID='" + value.Text + "' where EmployeeID='" + employeeid.Text + "'";
                SqlCommand data = new SqlCommand(query, con);
                data.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been succesfully Updated", "Operation Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                employeeid.Text = "";
                Options.Text = "";
                value.Text = "";
            }
            else if (Options.SelectedItem.ToString() == "Gender")
            {
                con.Open();
                string query = "Update EmployeeDetail SET Gender='" + value.Text + "' where EmployeeID='" + employeeid.Text + "'";
                SqlCommand data = new SqlCommand(query, con);
                data.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been succesfully Updated", "Operation Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                employeeid.Text = "";
                Options.Text = "";
                value.Text = "";
            }
            else if (Options.SelectedItem.ToString() == "Phone")
            {
                con.Open();
                string query = "Update EmployeeDetail SET Phone='" + value.Text + "' where EmployeeID='" + employeeid.Text + "'";
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
                string query = "Update EmployeeDetail SET Department='" + value.Text + "' where EmployeeID='" + employeeid.Text + "'";
                SqlCommand data = new SqlCommand(query, con);
                data.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been succesfully Updated", "Operation Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                employeeid.Text = "";
                Options.Text = "";
                value.Text = "";
            }
            else if (Options.SelectedItem.ToString() == "Basicsalary")
            {
                con.Open();
                string query = "Update EmployeeDetail SET Basicsalary='" + value.Text + "' where EmployeeID='" + employeeid.Text + "'";
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
                MessageBox.Show("Invalid Field chosen","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
