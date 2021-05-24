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
using System.Configuration;
namespace Payroll_Management_system
{
    public partial class GeneratePayroll : UserControl
    {
        public GeneratePayroll()
        {
            InitializeComponent();
        }
        public double DeductionA, NETSalary;
        public string DeductionR;
        public int damount;
        private void GeneratePayroll_Load(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }
        SqlConnection con = new SqlConnection(Connection.connectionString);
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double CA, MA, HR, GrossPay, Inc_Tax;
            int PAY = 0;

            PAY = Convert.ToInt32(basicpay.Text);
            if (PAY >= 160000)
            {
                CA = (int)(PAY * 0.40);
                Convence.Text = CA.ToString();

                MA = (int)(PAY * 0.30);
                Medical.Text = MA.ToString();

                HR = (int)(PAY * 0.20);
                Houserent.Text = HR.ToString();
                GrossPay = CA + MA + HR + PAY;
                grosspay.Text = GrossPay.ToString();
                if (GrossPay >= 320000)
                {
                    Inc_Tax = GrossPay * 0.20;
                    incometax.Text = Inc_Tax.ToString();
                    NETSalary = GrossPay - Inc_Tax;
                }
                else if (GrossPay >= 280000 && GrossPay<320000)
                {
                    Inc_Tax = GrossPay * 0.15;
                    incometax.Text = Inc_Tax.ToString();
                    NETSalary = GrossPay - Inc_Tax;
                }
                else if (GrossPay >= 230000 && GrossPay < 280000)
                {
                    Inc_Tax = GrossPay * 0.12;
                    incometax.Text = Inc_Tax.ToString();
                    NETSalary = GrossPay - Inc_Tax;
                }
                else if (GrossPay >= 190000 && GrossPay < 230000)
                {
                    Inc_Tax = GrossPay * 0.10;
                    incometax.Text = Inc_Tax.ToString();
                    NETSalary = GrossPay - Inc_Tax;
                }
            }
            else if (PAY >=80000)
            {
                CA = (int)(PAY * 0.35);
                Convence.Text = CA.ToString();

                MA = (int)(PAY * 0.25);
                Medical.Text = MA.ToString();

                HR = (int)(PAY * 0.15);
                Houserent.Text = HR.ToString();
                GrossPay = CA + MA + HR + PAY;
                grosspay.Text = GrossPay.ToString();
                if (GrossPay >= 140000)
                {
                    Inc_Tax = GrossPay * 0.06;
                    incometax.Text = Inc_Tax.ToString();
                    NETSalary = GrossPay - Inc_Tax;
                }
                else if (GrossPay >= 100000 &&GrossPay<140000)
                {
                    Inc_Tax = GrossPay * 0.05;
                    incometax.Text = Inc_Tax.ToString();
                    NETSalary = GrossPay - Inc_Tax;
                }
            }
            else if (PAY>=40000)
            {
                CA = (int)(PAY * 0.25);
                Convence.Text = CA.ToString();

                MA = (int)(PAY * 0.15);
                Medical.Text = MA.ToString();

                HR = (int)(PAY * 0.05);
                Houserent.Text = HR.ToString();
                GrossPay = CA + MA + HR + PAY;
                grosspay.Text = GrossPay.ToString();
                if (GrossPay >= 70000)
                {
                    Inc_Tax = GrossPay * 0.04;
                    incometax.Text = Inc_Tax.ToString();
                    NETSalary = GrossPay - Inc_Tax;
                }
                else if (GrossPay >= 50000 && GrossPay < 70000)
                {
                    Inc_Tax = GrossPay * 0.03;
                    incometax.Text = Inc_Tax.ToString();
                    NETSalary = GrossPay - Inc_Tax;
                }
            }
            else
            {
                CA = 3000;
                Convence.Text = CA.ToString();

                MA = 2000;
                Medical.Text = MA.ToString();

                HR = 1000;
                Houserent.Text = HR.ToString();
                GrossPay = CA + MA + HR + PAY;
                grosspay.Text = GrossPay.ToString();
                Inc_Tax = GrossPay * 0.02;
                incometax.Text = Inc_Tax.ToString();
                NETSalary = GrossPay - Inc_Tax;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                name.ResetText();
                basicpay.ResetText();
                Convence.ResetText();
                Medical.ResetText();
                Houserent.ResetText();
                incometax.ResetText();
                grosspay.ResetText();
                Total.ResetText();
                DeductionAmount.ResetText();
                DeductionReason.ResetText();
                Total.ResetText();
            }
            catch(Exception)
            {
            }
            damount = 0;
            DeductionA = 0;
            DeductionR = "";
            try
            {
                string query = "Select * From Employee where Eid='" + Employeeid.Text + "'";
                SqlCommand data = new SqlCommand(query, con);
                con.Open();
                SqlDataReader read = data.ExecuteReader();
                while (read.Read())
                {
                    name.Text = read.GetValue(1).ToString();
                }
                con.Close();
                data.CommandText = "Select * From Salary where Eid = '" + Employeeid.Text + "'";
                con.Open();
                //read = data.ExecuteReader();
                //while(read.Read())
                //{
                //    basicpay.Text = read.GetValue(3).ToString();
                //}
                SqlDataAdapter adapt = new SqlDataAdapter(data.CommandText, con);

                DataTable dta = new DataTable();
                adapt.Fill(dta);
                if (dta.Rows.Count > 0)
                {

                    basicpay.Text = dta.Rows[0]["sBasicSalary"].ToString();

                }
                con.Close();
                data.CommandText = "Select * From Deduction where Eid = '" + Employeeid.Text + "'";
                con.Open();
                read = data.ExecuteReader();
                while (read.Read())
                {
                    if (read.GetValue(3) == null)
                    {
                        DeductionA += 0;
                    }
                    else
                    {
                        DeductionA += Convert.ToInt32(read.GetValue(3));
                    }
                    if (read.GetValue(2) != null)
                    {
                        DeductionR += read.GetValue(2).ToString() + ":" + read.GetValue(3).ToString()+ "\n";
                    }
                    else
                    {
                        DeductionR = "";
                    }
                }
                con.Close();
            }
            catch(Exception c)
            { 
                MessageBox.Show(c.Message);
            }
            con.Open();
            string firstquery = "Select aMarkAttendance,aArriveTime From Attendance where Eid='" + Employeeid.Text + "' AND aMarkAttendance='" + "Absent" + "'";
            SqlDataAdapter da = new SqlDataAdapter(firstquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 3 && dt.Rows.Count < 6)
            {
                damount= Convert.ToInt32(basicpay.Text) / 30;
                DeductionA += Convert.ToInt32(basicpay.Text) / 30;
                DeductionR += dt.Rows.Count.ToString() + "Days Absent ";
            }
            else if (dt.Rows.Count >= 6 && dt.Rows.Count < 9)
            {
                damount = (2*Convert.ToInt32(basicpay.Text)) / 30;
                DeductionA += (2 * Convert.ToInt32(basicpay.Text)) / 30;
                DeductionR += dt.Rows.Count.ToString() + "Days Absent ";
            }
            else if (dt.Rows.Count >= 9 && dt.Rows.Count < 12)
            {
                damount = (3 * Convert.ToInt32(basicpay.Text)) / 30;
                DeductionA += (3 * Convert.ToInt32(basicpay.Text)) / 30;
                DeductionR += dt.Rows.Count.ToString() + "Days Absent ";
            }
            else if (dt.Rows.Count > 12)
            {
                damount = Convert.ToInt32(basicpay.Text) / 2;
                DeductionA += Convert.ToInt32(basicpay.Text) / 2;
                DeductionR += dt.Rows.Count.ToString() + "Days Absent.";
            }
            else if (dt.Rows.Count < 3)
            {
                DeductionA += 0;
                //DeductionR += "";
            }
            if (dt.Rows.Count!=0)
            {
                DeductionAmount.Text = DeductionA.ToString();
                DeductionReason.Text = DeductionR.ToString() + damount.ToString() + ".";
            }
            Total.Text = (NETSalary - DeductionA).ToString();
            con.Close();
        }

        private void basicsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void leave_TextChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeductionReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void Convence_TextChanged(object sender, EventArgs e)
        {

        }

        private void adddetails_Click(object sender, EventArgs e)
        {
            //DeductionAmount.Text = DeductionA.ToString();
            //DeductionReason.Text = DeductionR.ToString() +":"+ damount.ToString() +".";
        }

        private void DeductionReason_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
