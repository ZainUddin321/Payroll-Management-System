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
    public partial class Attendance : UserControl
    {
        MarkAttendance mattendance = new MarkAttendance();
        public Attendance()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        SqlConnection con = new SqlConnection(@"Data Source=ZAINUDDIN\SQLEXPRESS;Initial Catalog='Payroll Database';Integrated Security=True");
        //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\zaing\OneDrive\Documents\PayrollDataBase.mdf;Integrated Security = True; Connect Timeout = 30");
        private void adddetails_Click(object sender, EventArgs e)
        {
        }

        private void Employeeid_TextChanged(object sender, EventArgs e)
        {
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Attendance_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
        }

        private void adddetails_Click_1(object sender, EventArgs e)
        {
            mattendance.Show();
        }

        private void employeeid_TextChanged_1(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select aDate,aMarkAttendance,aArriveTime from Attendance where Eid='" + employeeid.Text+"'";
            SqlDataAdapter data = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            Detaildisplayer.DataSource = dt;
            con.Close();
        }

        private void Detaildisplayer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void detaildisplayer()
        {
            con.Open();
            string query = "Select aDate,aMarkAttendance,aArriveTime from Attendance where Eid='" + employeeid.Text + "'";
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
    }
}
