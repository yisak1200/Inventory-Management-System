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
    public partial class AddDepartmentHead : UserControl
    {
        Function fn = new Function();
        string query,query1;
        public AddDepartmentHead()
        {
            InitializeComponent();
        }

        private void AddDepartmentHead_Load(object sender, EventArgs e)
        {
            wrongLabel.Visible = false;
            DepartmentCombo.Items.Clear();
            query = "select Department_name from Department";
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DepartmentCombo.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            query1 = "select First_name,Last_name,Phone_num,Department,Email,Adress from Department_head_tbl";
            DataSet ds1 = fn.getData(query1);
            DepartmentHeadDataGridView.DataSource = ds1.Tables[0];
        }

        private void EmpRegistrationBtn_Click(object sender, EventArgs e)
        {
            query = "Select count(*)from Department_head_tbl Where user_name='"+ txtUsername.Text + "'";
            DataSet ds = fn.getData(query);
            if(ds.Tables[0].Rows[0][0].ToString()=="1")
            {
                wrongLabel.Visible = true;
            }
            else if(txtAddress.Text == "" || txtConfirmPassword.Text == "" || txtEmail.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtPassword.Text == "" || txtPhoneNum.Text == "" || txtUsername.Text == "" || DepartmentCombo.Text == null)
            {
                MessageBox.Show("All inputs are Requiered");
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password Should bes the Same");
            }
            else { 
            query = "insert into Department_head_tbl values('"+txtFirstName.Text+"','"+txtLastName.Text+"','"+txtPhoneNum.Text+"','"+DepartmentCombo.Text+"','"+txtEmail.Text+"','"+txtUsername.Text+"','"+txtAddress.Text+"','"+txtPassword.Text+"')";
            fn.setData(query);
                MessageBox.Show("Inventory management System Head Registered ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
        }

    }

        private void DepartmentSearchBtn_Click(object sender, EventArgs e)
        {

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
            DepartmentCombo.Text = null;
            wrongLabel.Visible = false;
        }
}
}