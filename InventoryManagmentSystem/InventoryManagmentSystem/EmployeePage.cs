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
    public partial class EmployeePage : Form
    {
        string txt;
       
        string query;
        Function fn = new Function();
        public EmployeePage(string txt)
        {
            this.txt = txt;
            InitializeComponent();
        }
        public EmployeePage()
        {
            
            InitializeComponent();
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

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            Employee_Request er = new Employee_Request(txt);
            er.Show();
                        
        }

        private void ChangeEmpPassword_Click(object sender, EventArgs e)
        {
           
            changePasswordEmployee1.Visible = true;
            changePasswordEmployee1.BringToFront();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            label1.Text = txt;
        }

        

        private void Notficationbtn_Click(object sender, EventArgs e)
        {
            Notfication_for_emp nfe = new Notfication_for_emp(txt);
            nfe.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeePage_Load_2(object sender, EventArgs e)
        {
            panel2.Visible = true;
            changePasswordEmployee1.Visible = false;
        }
    }
}
