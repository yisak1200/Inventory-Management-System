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
    public partial class ChangePassword : UserControl
    {
        string query;
        Function fn = new Function();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void oldPasswordtxt_Leave(object sender, EventArgs e)
        {
            query = "Select *from Admin_tbl where Admin_password='" + oldPasswordtxt.Text + "'";
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
                query = "update Admin_tbl set Admin_password='" + txtPassword.Text + "' where Admin_password='" + oldPasswordtxt.Text + "'";
                fn.setData(query);
                MessageBox.Show("Password changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();

            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            wrongLabel.Visible = false;
        }
    }
}
