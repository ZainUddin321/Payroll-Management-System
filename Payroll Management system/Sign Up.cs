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
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\zaing\OneDrive\Documents\PayrollDataBase.mdf;Integrated Security = True; Connect Timeout = 30");
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
                con.Open();
                string query = "Select * From EmployeeDetail where EmployeeID='" + id.Text + "'";
                SqlCommand data = new SqlCommand(query, con);
                SqlDataReader read = data.ExecuteReader();

            while (read.Read())
            {
                name.Text = read.GetValue(0).ToString();
                fathername.Text = read.GetValue(1).ToString();
                gender.Text = read.GetValue(3).ToString();
                phone.Text = "+92-" + read.GetValue(4).ToString();
                department.Text = read.GetValue(5).ToString();
                basicpay.Text = read.GetValue(6).ToString();
                deductionamount.Text = read.GetValue(8).ToString();
                deductionreason.Text = read.GetValue(9).ToString();
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
