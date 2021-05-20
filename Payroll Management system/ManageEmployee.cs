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
    public partial class ManageEmployee : UserControl
    {
        UpdateEmployee Uemployee = new UpdateEmployee();
        DeleteEmployee Demployee = new DeleteEmployee();
        public ManageEmployee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\zaing\OneDrive\Documents\PayrollDataBase.mdf;Integrated Security = True; Connect Timeout = 30");
        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            detaildisplayer();
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

        private void Update_Click(object sender, EventArgs e)
        {
            Uemployee.Show();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            Demployee.Show();
        }

        private void Detaildisplayer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
