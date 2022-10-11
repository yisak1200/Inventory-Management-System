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
    public partial class ChangePass_INV : UserControl
    {
        string query;
        Function fn = new Function();
        public ChangePass_INV()
        {
            InitializeComponent();
        }

        private void ChangePass_INV_Load(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
        }

        private void oldpasswordtxt_Leave(object sender, EventArgs e)
        {
            query = "Select *from Department_head_tbl where Password='" + oldpasswordtxt.Text + "'";
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
                MessageBox.Show("Password and Confirm password Have to be the same");
            }
            else
            {
                query = "update Department_head_tbl set Password='" + txtPassword.Text + "' where Password='" + oldpasswordtxt.Text + "'";
                fn.setData(query);
                MessageBox.Show("Password changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();

            }
        }
    }
}
