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
using System.IO;

namespace Payroll_Management_system
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Connection.connectionString);
        private void Signup_Click(object sender, EventArgs e)
        {
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        private void Username_TextChanged(object sender, EventArgs e)
        {
            string query= "select eName,eFname,eGender,ePhone,eDepartment,eImage,sBasicSalary,dAmount,dReason from Employee"
                          + " left join Salary on Employee.Eid = Salary.Eid"
                          + " left join Deduction on Employee.Eid = Deduction.Eid"
                          + " where Employee.Eid = '"+id.Text+"'";
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                name.Text = dt.Rows[0]["eName"].ToString();
                fathername.Text = dt.Rows[0]["eFname"].ToString();
                gender.Text = dt.Rows[0]["eGender"].ToString();
                phone.Text = dt.Rows[0]["ePhone"].ToString();
                department.Text = dt.Rows[0]["eDepartment"].ToString();
                basicpay.Text = dt.Rows[0]["sBasicSalary"].ToString();
                deductionamount.Text = dt.Rows[0]["dAmount"].ToString();
                deductionreason.Text = dt.Rows[0]["dReason"].ToString();
                try
                {
                    image.Image = Image.FromFile(@"F:\source\repos\Payroll Management system\Payroll Management system" + dt.Rows[0]["eImage"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            con.Close();
            /*con.Open();
            string query = "Select * From Employee where Eid='" + id.Text + "'";
            SqlCommand data = new SqlCommand(query, con);
            SqlDataReader read = data.ExecuteReader();

            while (read.Read())
            {
                name.Text = read.GetValue(1).ToString();
                fathername.Text = read.GetValue(2).ToString();
                gender.Text = read.GetValue(3).ToString();
                phone.Text = "+92-" + read.GetValue(4).ToString();
                department.Text = read.GetValue(7).ToString();
                try
                {
                    image.Image = Image.FromFile(@"F:\source\repos\Payroll Management system\Payroll Management system" + read.GetValue(7).ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            con.Close();
            con.Open();
            query = "select sBasicSalary from Salary where Eid='" + id.Text + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            basicpay.Text = dt.Rows[0]["sBasicSalary"].ToString();
            query = "select dAmount,dReason from Deduction where Eid='" + id.Text + "'";
            SqlDataAdapter adapt1 = new SqlDataAdapter(query, con);
            DataTable dt1 = new DataTable();
            adapt1.Fill(dt1);
            deductionamount.Text = dt.Rows[0]["dAmount"].ToString();
            deductionreason.Text = dt.Rows[0]["dReason"].ToString();
            con.Close();
            */
        }

        private void Information_Paint(object sender, PaintEventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /*public void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = Information.Size;
            memoryimage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryimage);
            memoryGraphics.CopyFromScreen(Information.Location.X,Information.Location.Y,12,137,s);
        }*/
        private void deduct_Click(object sender, EventArgs e)
        {
            Print(this.Information);
        }
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        public void Print(Panel pnl)
        {
            Information = pnl;
            GetPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage,(pagearea.Width/2-this.Information.Width/2), this.Information.Location.Y);
        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
