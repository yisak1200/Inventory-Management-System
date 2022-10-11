using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class AdminPage : Form
    {
        string txt;
        string query;
        Function fn = new Function();
        public AdminPage(string txt)
        {
            this.txt = txt;
            InitializeComponent();
        }
        public AdminPage()
        {
            
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            UsenameLabel.Text = txt;
            query = "select *from Admin_tbl where user_name='" + txt + "'";
            
        }
        

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Close();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUser1_Load(object sender, EventArgs e)
        {
            
            
           
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            changePassword1.Visible = true;
            changePassword1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            addItem1.Visible = true;
            addItem1.BringToFront();
        }

        private void addItem1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addDepartment1.Visible = true;
            addDepartment1.BringToFront();
        }

        private void addDepartment1_Load(object sender, EventArgs e)
        {
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            panel3.Visible = true;
            changePassword1.Visible = false;
            addUser1.Visible = false;
            addItem1.Visible = false;
            addDepartment1.Visible = false;
            addSubAdminn1.Visible = false;
            addEmployee1.Visible = false;
            addEmployee1.Visible = false;
            addDepartmentHead1.Visible = false;
            asset_detail1.Visible = false;
            UsenameLabel.Text = txt;
            query = "Select * from Admin_tbl where user_name='" + txt + "'";
            SqlDataReader dr = fn.getForCombo(query);
            dr.Read();
            if (dr.HasRows)
            {
                byte[] im = (byte[])(dr[6]);
                if (im == null)
                {
                    AdminImg.Image = null;
                }
                else
                {
                    MemoryStream mst = new MemoryStream(im);
                    AdminImg.Image = Image.FromStream(mst);
                }
            }
        }

        private void AddSubAdminbtn_Click(object sender, EventArgs e)
        {
            addSubAdminn1.Visible = true;
            addSubAdminn1.BringToFront();
        }

        private void AddEmpbtn_Click(object sender, EventArgs e)
        {
            addEmployee1.Visible = true;
            addEmployee1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AcceptedReqbtn_Click(object sender, EventArgs e)
        {

        }

        private void AddDepHeadbtn_Click(object sender, EventArgs e)
        {
            addDepartmentHead1.Visible = true;
            addDepartmentHead1.BringToFront();
        }

        private void Asset_detaill_Click(object sender, EventArgs e)
        {
            asset_detail1.Visible = true;
            asset_detail1.BringToFront();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            addUser1.Visible = true;
            addUser1.BringToFront();
        }
    }
}
