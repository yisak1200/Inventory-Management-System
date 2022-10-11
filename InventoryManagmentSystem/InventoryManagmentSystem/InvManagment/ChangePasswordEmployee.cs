using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem.InvManagment
{
    public partial class ChangePasswordEmployee : UserControl
    {
        Function fn = new Function();
        string query,query1;
        public ChangePasswordEmployee()
        {
            InitializeComponent();
        }

        private void oldpasswordtxt_Leave(object sender, EventArgs e)
        {
            query = "Select *from Employee_tbl where emp_password='"+oldpasswordtxt.Text+"'";
            DataSet ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count>0)
            {
                guna2Panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }

        private void ChangePasswordEmployee_Load(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
        }

        private void ChangePassbtn_Click(object sender, EventArgs e)
        {
           
            
            if(txtPassword.Text!=txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm password Have to be the same");
            }
            else 
            {
                query1 = "update Employee_tbl set emp_password='"+ txtPassword.Text + "' where emp_password='"+ oldpasswordtxt.Text+ "'";
                fn.setData(query1);
                MessageBox.Show("Password changed ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
                
            }
            
        }
    }
}
