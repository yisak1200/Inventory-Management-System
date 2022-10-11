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
    public partial class subAdmin : Form
    {
        string txt;
        
        public subAdmin(string txt)
        {
            this.txt = txt;
            InitializeComponent();
        }
        public subAdmin()
        {

            InitializeComponent();
        }
        private void subAdmin_Load(object sender, EventArgs e)
        {
            panel3.Visible = true;
            depEmpReq1.Visible = false;
            addItem1.Visible = false;
            acceptedReq1.Visible = false;
            changePass_INV1.Visible = false;
            given_Asset1.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Close();
        }

        private void EmployeeReqBtn_Click(object sender, EventArgs e)
        {
            depEmpReq1.Visible = true;
            depEmpReq1.BringToFront();
        }

        private void Assets_Click(object sender, EventArgs e)
        {
            addItem1.Visible = true;
            addItem1.BringToFront();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            UsenameLabel.Text = txt;
        }

        private void AcceptedReqBtn_Click(object sender, EventArgs e)
        {
            acceptedReq1.Visible = true;
            acceptedReq1.BringToFront();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            changePass_INV1.Visible = true;
            changePass_INV1.BringToFront();
        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            Store_Report sr = new Store_Report();
            sr.Show();
            
        }

        private void GivenAssetbtn_Click(object sender, EventArgs e)
        {
            given_Asset1.Visible = true;
            given_Asset1.BringToFront();
        }
    }
}
