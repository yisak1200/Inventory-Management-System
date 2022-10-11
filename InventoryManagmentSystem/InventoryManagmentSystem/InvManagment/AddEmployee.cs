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
using System.IO;

namespace InventoryManagmentSystem.InvManagment
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection con = new SqlConnection("DATA SOURCE=MEKONEN;DATABASE=InventoryManagmentSystem;UID=yisak;PWD=y12i007665");
        
        string imageLocation = null;
        Function fn = new Function();
        string query,query1;
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            query = "Select Employee_ID ,First_name,Last_name,Phone_num,Department,Email,Adress from Employee_tbl";
            DataSet ds1 = fn.getData(query);
            EmployeDataGridView.DataSource = ds1.Tables[0];
            wrongLabel.Visible = false;
            DepartmentCombo.Items.Clear();
            query = "select Department_name from Department";
            DataSet ds = fn.getData(query);
            for(int i = 0;i<ds.Tables[0].Rows.Count;i++)
            {
                DepartmentCombo.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
        public void autogen()
        {
            string num = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            int leng = num.Length;
            string otp = string.Empty;
            int otpdigit = 5;
            string finaldigit;
            int getindex;
            for(int i=0;i<otpdigit;i++)
            {
                do
                {
                    getindex = new Random().Next(0, leng);
                    finaldigit = num.ToCharArray()[getindex].ToString();
                } while (otp.IndexOf(finaldigit) != -1);
                otp += finaldigit;
            }
            EmpIdtxt.Text = (otp);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            txtFirstName.Clear();
            txtAddress.Clear();
            txtConfirmPassword.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPassword.Clear();
            txtPhoneNum.Clear();
            txtUsername.Clear();
            EmpIdtxt.Clear();
            DepartmentCombo.Text = null;
            wrongLabel.Visible = false;
        }

        private void EmpRegistrationBtn_Click(object sender, EventArgs e)
        {

            autogen();
            query = "Select count(*)from Employee_tbl where user_name='"+ txtUsername.Text+ "'";
            DataSet ds = fn.getData(query);
            if(ds.Tables[0].Rows[0][0].ToString()=="1")
            {
                wrongLabel.Visible = true;  
            }
            else if(EmpIdtxt.Text==""|| txtAddress.Text=="" ||txtConfirmPassword.Text=="" ||txtEmail.Text=="" ||txtFirstName.Text=="" ||txtLastName.Text=="" ||txtPassword.Text=="" ||txtPhoneNum.Text=="" ||txtUsername.Text=="" || DepartmentCombo.Text==null)
            {
                MessageBox.Show("All inputs Are Required");
            }
            else if(txtPassword.Text!=txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password Should bes the Same");
            }
            else { 
            try {

                    //var image = new ImageConverter().ConvertTo(empPic.Image, typeof(Byte[]));
                    query = "insert into Employee_tbl  values('"+EmpIdtxt.Text+"','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtPhoneNum.Text + "','" + DepartmentCombo.Text + "','" + txtEmail.Text + "','" + txtUsername.Text + "','" + txtAddress.Text + "','" + txtPassword.Text + "')";
                    SqlCommand cmd = new SqlCommand(query,con);
                    //cmd.Parameters.AddWithValue("@image",image);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Employee Registerd Sucessfully");
                    //refresh tbl Automatically
                    query1 = "select * from Employee_tbl";
                    DataSet ds1 = fn.getData(query1);
                    EmployeDataGridView.DataSource = ds1.Tables[0];
                }
                catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
            clear();
        }

        private void EmployeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.EmployeDataGridView.Rows[e.RowIndex];
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
                txtFirstName.Text = row.Cells["First_name"].Value.ToString();
                txtLastName.Text = row.Cells["Last_name"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                EmpIdtxt.Text = row.Cells["Employee_ID"].Value.ToString();
                txtPhoneNum.Text = row.Cells["Phone_num"].Value.ToString();
                txtAddress.Text = row.Cells["Adress"].Value.ToString();
                txtPassword.Text = "Password can't be updated";
                txtConfirmPassword.Text= "Password can't be updated";
                txtUsername.Text = "Username can't be updated";
                DepartmentCombo.Text = row.Cells["Department"].Value.ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try { 
            query = "Update Employee_tbl set First_name='"+ txtFirstName.Text+ "',Last_name='"+txtLastName.Text+"',Email='"+txtEmail.Text+"',Adress='"+txtAddress.Text+"',Phone_num='"+txtPhoneNum.Text+"',Department='"+DepartmentCombo.Text+"' where Employee_ID='"+ EmpIdtxt.Text + "'";
            fn.setData(query);
                MessageBox.Show("Employee updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refresh the table
                query1 = "Select Employee_ID ,First_name,Last_name,Phone_num,Department,Email,Adress from Employee_tbl";
                DataSet ds1 = fn.getData(query1);
                EmployeDataGridView.DataSource = ds1.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            query1 = "select count(*) from Given_Asset where Emp_ID='" + EmpIdtxt.Text + "'";
            DataSet ds = fn.getData(query1);
            if(ds.Tables[0].Rows[0][0].ToString()=="1")
            {
                MessageBox.Show("this user already take asset can not be deleted");
            }
            else
            { 
                query = "Delete from Employee_tbl where Employee_ID='"+EmpIdtxt.Text+"'";
                fn.setData(query);
                MessageBox.Show("Employee Deleted Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refresh the table
                query = "select * from Employee_tbl";
                DataSet ds1 = fn.getData(query);
                EmployeDataGridView.DataSource = ds1.Tables[0];
            }
        }

        private void EmployeeSearchbtn_Click(object sender, EventArgs e)
        {
            query = "select * from Employee_tbl where First_name LIKE'" + EmpSearchtxt.Text + "%'";
            DataSet ds = fn.getData(query);
            EmployeDataGridView.DataSource = ds.Tables[0];
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            query = "select * from Employee_tbl";
            DataSet ds = fn.getData(query);
            EmployeDataGridView.DataSource = ds.Tables[0];
            EmpSearchtxt.Clear();
        }

        private void EmployeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uploadImgbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter= "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif";
            if (ofd.ShowDialog()==DialogResult.OK)
                {
                    imageLocation = ofd.FileName.ToString();
                    empPic.ImageLocation = imageLocation;
                }
            
            
        }

        private void DepartmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
