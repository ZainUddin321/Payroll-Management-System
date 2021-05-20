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
    public partial class Employee_Details : UserControl
    {
        public Employee_Details()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\zaing\OneDrive\Documents\PayrollDataBase.mdf;Integrated Security = True; Connect Timeout = 30");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Employee_Details_Load(object sender, EventArgs e)
        {
            detaildisplayer();
        }
        public void detaildisplayer()
        {
            con.Open();
            string query = "Select * from EmployeeDetail";
            SqlDataAdapter data = new SqlDataAdapter(query, con);
            DataTable dtable = new DataTable();
            data.Fill(dtable);
            Detaildisplayer.DataSource = dtable;
            con.Close();
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            Detaildisplayer.DataSource = null;
            if (search.Text == "")
            {
                con.Open();
                string query = "Select * from EmployeeDetail";
                SqlDataAdapter data = new SqlDataAdapter(query, con);
                DataTable dtable = new DataTable();
                data.Fill(dtable);
                Detaildisplayer.DataSource = dtable;
                con.Close();
            }
            else
            {
                con.Open();
                string query = "Select * from EmployeeDetail where EmployeeID='" + search.Text + "'";
                SqlDataAdapter data = new SqlDataAdapter(query, con);
                DataTable dtable = new DataTable();
                data.Fill(dtable);
                Detaildisplayer.DataSource = dtable;
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detaildisplayer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            detaildisplayer();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
