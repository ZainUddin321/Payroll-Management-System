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
    public partial class Login : Form
    {
        Sign_Up signup = new Sign_Up();
        PayrollMain pmain = new PayrollMain();
        public Login()
        {
            InitializeComponent();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            signup.Show();
        }
        //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\zaing\OneDrive\Documents\PayrollDataBase.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlConnection con = new SqlConnection(@"Data Source=ZAINUDDIN\SQLEXPRESS;Initial Catalog='Payroll Database';Integrated Security=True");
        private void Login1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query="Select * from Login where Username='"+Username.Text+"' AND Password='"+Password.Text+"'";
            SqlDataAdapter data = new SqlDataAdapter(query, con);
            DataTable dtable = new DataTable();
            data.Fill(dtable);
            if(dtable.Rows.Count==1)
            {
                Hide();
                pmain.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password or Username", "Incorrect Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           /* con.Open();
            string query = "Delete from Attendance";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            con.Close();*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
