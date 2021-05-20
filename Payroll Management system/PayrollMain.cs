using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Payroll_Management_system
{
    public partial class PayrollMain : Form
    {
        public PayrollMain()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void generatePayroll1_Load(object sender, EventArgs e)
        {

        }

        private void PayrollMain_Load(object sender, EventArgs e)
        {
            manageEmployee1.Hide();
            employee_Details1.Hide();
            secondpage1.Hide();
            attendance1.Hide();
            deduction1.Hide();
            dashboard1.Show();
            Paneldropdown.Height = 45;
            secondpanel.Top = 201;     
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            secondpage1.Hide();
            dashboard1.Hide();
            employee_Details1.Hide();
            attendance1.Hide();
            manageEmployee1.Hide();
            deduction1.Hide();
            generatePayroll1.Hide();
            dashboard1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Paneldropdown.Height == 157)
            {
                button1.Image = Image.FromFile(@"F:\Icons\dropdown1.png");
                Paneldropdown.Height = 45;
                secondpanel.Top = 201;;
            }
            else
            {
                button1.Image = Image.FromFile(@"F:\Icons\Dropup.png");
                Paneldropdown.Height = 157;
                secondpanel.Top = 309;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manageEmployee1.Hide();
            employee_Details1.Hide();
            dashboard1.Hide();
            generatePayroll1.Hide();
            attendance1.Hide();
            deduction1.Hide();
            secondpage1.Show();
        }

        private void Employeedetails_Click(object sender, EventArgs e)
        {
            manageEmployee1.Hide();
            dashboard1.Hide();
            secondpage1.Hide();
            generatePayroll1.Hide();
            attendance1.Hide();
            deduction1.Hide();
            employee_Details1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dashboard1.Hide();
            secondpage1.Hide();
            generatePayroll1.Hide();
            employee_Details1.Hide();
            attendance1.Hide();
            deduction1.Hide();
            manageEmployee1.Show();
        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            dashboard1.Hide();
            secondpage1.Hide();
            generatePayroll1.Hide();
            employee_Details1.Hide();
            manageEmployee1.Hide();
            deduction1.Hide();
            attendance1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard1.Hide();
            secondpage1.Hide();
            generatePayroll1.Hide();
            employee_Details1.Hide();
            manageEmployee1.Hide();
            attendance1.Hide();
            deduction1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
        }

        private void Dashboard_MouseEnter(object sender, EventArgs e)
        {
        }

        private void Dashboard_MouseLeave(object sender, EventArgs e)
        {
        }

        private void Dashboard_MouseHover(object sender, EventArgs e)
        {
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
        }

        private void Employeedetails_MouseHover(object sender, EventArgs e)
        {
        }

        private void Employeedetails_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
        }

        private void Attendance_MouseHover(object sender, EventArgs e)
        {
        }

        private void Attendance_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
        }

        private void deductionn_Click(object sender, EventArgs e)
        {
            dashboard1.Hide();
            secondpage1.Hide();
            generatePayroll1.Hide();
            employee_Details1.Hide();
            manageEmployee1.Hide();
            attendance1.Hide();
            deduction1.Show();
        }

        private void generatepayroll_Click(object sender, EventArgs e)
        {
            secondpage1.Hide();
            dashboard1.Hide();
            employee_Details1.Hide();
            attendance1.Hide();
            manageEmployee1.Hide();
            deduction1.Hide();
            generatePayroll1.Show();
        }

        private void deductionn_MouseHover(object sender, EventArgs e)
        {
        }

        private void deductionn_MouseLeave(object sender, EventArgs e)
        {
        }

        private void generatepayroll_MouseHover(object sender, EventArgs e)
        {
        }

        private void generatepayroll_MouseLeave(object sender, EventArgs e)
        {
        }
        private void login_Click(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            this.Hide();
            loginpage.Show();

        }
    }
}
