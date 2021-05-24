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
    public partial class Secondpage : UserControl
    {
        public Secondpage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Connection.connectionString);
        private void Secondpage_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string gender="";
            if(male.Checked)
            {
                gender = "Male";
            }
            else if(female.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Please select your gender.");
            }
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid image.");
                }
                else
                {
                    if (name.Text == "")
                    {
                        MessageBox.Show("Please enter Name.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (fathername.Text == "")
                    {
                        MessageBox.Show("Please enter Father Name.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //else if (phone.Text == "")
                    else if (string.IsNullOrEmpty(phone.Text))
                    {
                        MessageBox.Show("Please enter Phone Number.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (designation.Text == "")
                    {
                        MessageBox.Show("Please enter your Designation.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (department.Text == "")
                    {
                        MessageBox.Show("Please enter Department.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (basicsalary.Text == "")
                    {
                        MessageBox.Show("Please enter Salary.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        string query = "Insert Into Employee (eName,eFname,eGender,eDesignation,ePhone,eDepartment,eImage) Values('" + name.Text + "','" + fathername.Text + "','" + gender + "','" + designation.Text + "','" + Convert.ToUInt64(phone.Text) + "','" + department.Text + "','\\Image\\" + filename + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        System.IO.File.Copy(openFileDialog1.FileName, path + "\\Image\\" + filename);
                        cmd.ExecuteNonQuery();
                        string getEID = "select max(Eid) as Eid from Employee where eName='" + name.Text + "'";
                        SqlDataAdapter adapt = new SqlDataAdapter(getEID, con);
                        DataTable dtEID = new DataTable();
                        adapt.Fill(dtEID);
                        int EmployeeId = 0;
                        EmployeeId = Convert.ToInt32(dtEID.Rows[0]["Eid"]);
                        cmd.CommandText="Insert Into Salary(Eid,sBasicSalary) Values('"+EmployeeId+"','" + basicsalary.Text + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Data has been Successfully Uploaded");
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Already exits");
                con.Close();
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
                openFileDialog1.InitialDirectory = "C://Desktop";
                openFileDialog1.Title = "Select image to be Upload";
                openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            try
            {
                if(openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    if(openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        Image.Image = new Bitmap(openFileDialog1.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void basicsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void designation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
