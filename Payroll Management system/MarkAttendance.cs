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
    public partial class MarkAttendance : Form
    {
        public MarkAttendance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\zaing\OneDrive\Documents\PayrollDataBase.mdf;Integrated Security = True; Connect Timeout = 30");
        private void MarkAttendance_Load(object sender, EventArgs e)
        {

        }

        private void adddetails_Click(object sender, EventArgs e)
        {
            string attendance = "Absent";
            if (Employeeid.Text == "")
            {
                MessageBox.Show("Please enter employee id.");
            }
            if((present.Checked==false)&&(absent.Checked==false))
            {
                MessageBox.Show("Mark Absent or present.");
            }
            if (Timemode.Text == "")
            {
                MessageBox.Show("Please enter Timezone.");
            }
            if (name.Text != ""&&Timemode.Text != ""&& (present.Checked == true) || (absent.Checked == true))
            {
                con.Open();
                string firstquery = "Select Name,Date From Attendance where Name='"+name.Text+"' and Date='"+date.Value+"'";
                SqlDataAdapter dadap = new SqlDataAdapter(firstquery, con);
                DataTable dt = new DataTable();
                dadap.Fill(dt);
                con.Close();
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("The Attendance has already been recorded of this date.", "Attendance already marked", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    string arrtime = (Hour.Value + ":" + min1.Value + min2.Value) + " " + Timemode.Text;
                    DateTime time = Convert.ToDateTime(arrtime);
                    DateTime requiredtime = Convert.ToDateTime("9:00 AM");
                    int result = DateTime.Compare(time, requiredtime);
                    if (result < 0 || result == 0)
                    {
                        if (present.Checked)
                        {
                            attendance = "Present";
                        }
                        else if (absent.Checked)
                        {
                            attendance = "Absent";
                            arrtime = null;
                        }
                    }
                    else
                    {

                        arrtime = null;
                        attendance = "Absent";
                    }
                    con.Open();
                    string query = "Insert into Attendance (EmployeeID,Name,AbsentPresent,ArriveTime,Date) Values('" + Employeeid.Text + "','" + name.Text + "','" + attendance + "','" + arrtime + "','" + date.Value + "')";
                    SqlDataAdapter data = new SqlDataAdapter(query, con);
                    data.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Attendance has been recorded successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
            }
        }
        private void Employeeid_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * From EmployeeDetail where EmployeeID='" + Employeeid.Text + "'";
            SqlCommand data = new SqlCommand(query, con);
            SqlDataReader read = data.ExecuteReader();
            while (read.Read())
            {
                name.Text = read.GetValue(0).ToString();
            }
            con.Close();
        }
    }
}
