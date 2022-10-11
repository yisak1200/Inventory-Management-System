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
    public partial class ChangePass_For_case1User : UserControl
    {
        string query;
        Function fn = new Function();
        public ChangePass_For_case1User()
        {
            InitializeComponent();
        }

        private void oldpasswordtxt_Leave(object sender, EventArgs e)
        {
            query = "Select *from Case1_user where User_password='" + oldpasswordtxt.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                guna2Panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }

        private void ChangePassbtn_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                wrongLabel.Visible = true;
            }
            else
            {
                query = "update Case1_user set User_password='" + txtPassword.Text + "' where User_password='" + oldpasswordtxt.Text + "'";
                fn.setData(query);
                MessageBox.Show("Password changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();

            }
        }

        private void ChangePass_For_case1User_Load(object sender, EventArgs e)
        {
            wrongLabel.Visible = false;
            guna2Panel1.Visible = false;
        }
    }
}
