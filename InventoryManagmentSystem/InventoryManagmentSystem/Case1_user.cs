using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class Case1_user : Form
    {

        string txt;
        Function fn = new Function();
        public Case1_user(string txt)
        {
            txt = this.txt;
            InitializeComponent();
        }
        public Case1_user()
        {
            InitializeComponent();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void AcceptedReqBtn_Click(object sender, EventArgs e)
        {
            acceptedReq1.Visible = true;
            acceptedReq1.BringToFront();
        }

        private void Case1_user_Load_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            acceptedReq1.Visible = false;
            withdwal_asset1.Visible = false;
            changePass_For_case1User1.Visible = false;
            assetForCase1_user1.Visible = false;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            UsenameLabel.Text = txt;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            withdwal_asset1.Visible = true;
            withdwal_asset1.BringToFront();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            changePass_For_case1User1.Visible = true;
            changePass_For_case1User1.BringToFront();
        }

        private void Assets_Click(object sender, EventArgs e)
        {
            assetForCase1_user1.Visible = true;
            assetForCase1_user1.BringToFront();
        }
    }
}
