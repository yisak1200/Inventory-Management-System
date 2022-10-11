using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace InventoryManagmentSystem.InvManagment
{
    public partial class AdminIDtxt : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2T978A1\\SQLEXPRESS;Initial Catalog=InventoryManagmentSystem;Integrated Security=True;Pooling=False");
      
        Function fn = new Function();
        string query;
        //string imageUrl;
        
        //OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public AdminIDtxt()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            wrongUsernamelabel.Visible = false;
        }
        public void clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNum.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            wrongUsernamelabel.Visible = false;
            pictureBox1.Show();
        }

        private void ClearFormBtn_Click(object sender, EventArgs e)
        {
            clear();
        }
        public Image convertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
                 
        }
      

       

        private void UploadImagebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }



        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count (*) from Admin_tbl where User_name='" + txtUsername.Text + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            cmd.ExecuteNonQuery();
            con.Close();

            if (dtbl.Rows[0][0].ToString() == "1")
            {
                wrongUsernamelabel.Visible = true;
            }
               else if (txtEmail.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtPassword.Text == "" || txtPhoneNum.Text == "" || txtUsername.Text == "")
                {
                MessageBox.Show("All Inputs Are required");
                }
                else if(txtPassword.Text!=txtConfirmPassword.Text)
                {
                MessageBox.Show("Password have to be the same with confirm password");
                }
                else { 
                
                
                
                    query = "insert into Admin_tbl (Admin_ID,First_name,Last_name,Phone_num,User_name,Password)values('"+AdminIdText.Text+"','"+txtFirstName.Text+"','"+txtLastName.Text+"','"+txtPhoneNum.Text+ "','" + txtUsername.Text + "','" + txtPassword.Text + "')";
                  
                    fn.setData(query,"Admin Added Sucessfully");
                }

            }
           
        }
    }

        
    
           
        
    

