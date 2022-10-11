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
    public partial class AddUser : UserControl
    {
        string query;
        Function fn = new Function();
        public AddUser()
        {
            InitializeComponent();
        }

        private void Registrationbtn_Click(object sender, EventArgs e)
        {
            query = "select count (*) from Case1_user where user_name='" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query);


            if (ds.Tables[0].Rows[0][0].ToString() == "1")
            {

                wrongLabel.Visible = true;

            }

            else if (txtConfirmPassword.Text == "" || txtEmail.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtPassword.Text == "" || txtPhoneNum.Text == "" || txtUsername.Text == "" || AdminImg.Image == null)
            {
                MessageBox.Show("All inputs are Requiered");
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm password have to be the same");
            }
            else { 
            query = "insert into Case1_user values('"+txtFirstName.Text+"','"+txtLastName.Text+"','"+txtPhoneNum.Text+"','"+txtEmail.Text+"','"+txtUsername.Text+"','"+txtAddress.Text+"','"+txtPassword.Text+"')";
            fn.setData(query);
            MessageBox.Show("User Registerd Successfully");
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            wrongLabel.Visible = false;
        }
    }
}
