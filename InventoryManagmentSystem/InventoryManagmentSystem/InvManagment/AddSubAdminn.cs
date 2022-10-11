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
    public partial class AddSubAdminn : UserControl
    {
        string query;
        string imageLocation;
        Function fn = new Function();
        public AddSubAdminn()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            query="select count (*) from Admin_tbl where user_name='" + txtUsername.Text + "'" ;
            DataSet ds = fn.getData(query);
            

            if (ds.Tables[0].Rows[0][0].ToString() == "1")
            {
                
                wrongLabel.Visible = true;
               
            }
            
           else if(txtConfirmPassword.Text=="" || txtEmail.Text=="" || txtFirstName.Text=="" ||txtLastName.Text=="" ||txtPassword.Text=="" ||txtPhoneNum.Text=="" ||txtUsername.Text==""|| AdminImg.Image == null)
            {
                MessageBox.Show("All inputs are Requiered");
            }else if (txtPassword.Text!=txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm password have to be the same");
            }
            
            else
            {
                try
                {

                  
                    query = "insert into Admin_tbl  values('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtPhoneNum.Text + "', '" +txtUsername.Text+"','"+txtPassword.Text+"','"+txtAddress.Text+"','"+txtEmail.Text+"')";
                    fn.setData(query);
                    MessageBox.Show("Admin Registred Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            txtAddress.Clear();
            txtConfirmPassword.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPassword.Clear();
            txtPhoneNum.Clear();
            txtUsername.Clear();
        }

        private void AddSubAdminn_Load(object sender, EventArgs e)
        {
            wrongLabel.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtConfirmPassword.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPassword.Clear();
            txtPhoneNum.Clear();
            txtUsername.Clear();
            
        }

        private void uploadImagebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files(*.png)|*.png|jpg|All files(*.*)|*.*|";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageLocation = ofd.FileName.ToString();
                AdminImg.ImageLocation = imageLocation;
            }




        }
    }
}
