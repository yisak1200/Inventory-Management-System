using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class Form1 : Form
    {
        Function fn = new Function();
        string txt;
        string query,query1,query2, query3;
        public Form1()
        {
            
            InitializeComponent();
        }

       

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

      

        

        private void Form1_Load(object sender, EventArgs e)
        {
            wrongLabel.Visible = false;
          
            
        }

       



        private void guna2Button2_Click_1(object sender, EventArgs e)
        {




        }

        private void ShowpassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowpassCheckBox.Checked == true)
            {
                Passwordtxt.PasswordChar = '\0';
                ShowpassCheckBox.Text = "Hide Password";
            }
            else
            {
                Passwordtxt.PasswordChar = '*';
                ShowpassCheckBox.Text = "Show Password";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            query = "select count (*) from Admin_tbl where user_name='" + Usernametxt.Text + "' and Admin_password='" + Passwordtxt.Text + "'";
            query1 = "select count (*) from Employee_tbl where user_name='" + Usernametxt.Text + "' and emp_password='" + Passwordtxt.Text + "'";
            query2 = "select count (*) from Department_head_tbl where user_name='" + Usernametxt.Text + "' and Password='" + Passwordtxt.Text + "'";
            query3 = "select count (*) from Case1_user where user_name = '"+Usernametxt.Text+ "' and User_password='" + Passwordtxt.Text+"'";
            DataSet ds = fn.getData(query);
            DataSet ds1 = fn.getData(query1);
            DataSet ds2 = fn.getData(query2);
            DataSet ds3 = fn.getData(query3);
            wrongLabel.Visible = false;
            if (ds2.Tables[0].Rows[0][0].ToString() == "1")
            {
                txt = Usernametxt.Text;
                wrongLabel.Visible = false;
                subAdmin sap = new subAdmin(txt);
                sap.Show();
                this.Hide();
            }
           
            else if (ds.Tables[0].Rows[0][0].ToString()=="1")
            {
                 txt = Usernametxt.Text;
                AdminPage ap = new AdminPage(txt);
                ap.Show();
                Usernametxt.Clear();
                Passwordtxt.Clear();
                ShowpassCheckBox.Checked = false;
            }
            
            else if (ds1.Tables[0].Rows[0][0].ToString()=="1")
            {
                txt = Usernametxt.Text;
                EmployeePage emp = new EmployeePage(txt);
                emp.Show();
                Usernametxt.Clear();
                Passwordtxt.Clear();
                ShowpassCheckBox.Checked = false;
            }
            else if (ds3.Tables[0].Rows[0][0].ToString()=="1")
            {
                txt = Usernametxt.Text;
                Case1_user c1u = new Case1_user(txt);
                c1u.Show();
                Usernametxt.Clear();
                Passwordtxt.Clear();
                ShowpassCheckBox.Checked = false;
            }
            else
            {
                wrongLabel.Visible = true;
            }
        }
    }
}
