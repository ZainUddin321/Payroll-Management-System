using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Payroll_Management_system
{
    public partial class Deduction : UserControl
    {
        public Deduction()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ZAINUDDIN\SQLEXPRESS;Initial Catalog='Payroll Database';Integrated Security=True");
        //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\zaing\OneDrive\Documents\PayrollDataBase.mdf;Integrated Security = True; Connect Timeout = 30");
        private void Deduction_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Employeeid_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * From Employee where Eid='" + Employeeid.Text + "'";
            SqlCommand data = new SqlCommand(query, con);
            SqlDataReader read = data.ExecuteReader();
            while (read.Read())
            {
                name.Text = read.GetValue(1).ToString();
                department.Text = read.GetValue(7).ToString();
            }
            con.Close();
        }

        private void deduct_Click(object sender, EventArgs e)
        {
            if (Employeeid.Text == "")
            {
                MessageBox.Show("Please enter Employee Id", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(department.Text))
            {
                MessageBox.Show("There is no Employee of the given id.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (deductionamount.Text == "")
            {
                MessageBox.Show("Please enter deduction amount", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (deductionreason.Text == "")
            {
                MessageBox.Show("Please enter deduction reason", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string query = "insert into Deduction(Eid, dReason, dAmount) values('" + Employeeid.Text + "','" + deductionreason.Text + "','" + deductionamount.Text + "')";
                SqlDataAdapter data = new SqlDataAdapter(query, con);
                data.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deduction has been Succesfully recorded", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
        }
    }
}
