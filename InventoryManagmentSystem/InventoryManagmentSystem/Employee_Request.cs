using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class Employee_Request : Form
    {
        Function fn = new Function();
        string query, query1;
        string date;
        string emp_id;
        string txt;
        public Employee_Request()
        {
            InitializeComponent();
        }
        public Employee_Request(string txt)
        {
            this.txt = txt;
            InitializeComponent();
        }

        private void RequestItemBtn_Click(object sender, EventArgs e)
        {
            date = DateTime.Now.ToString("ddd, dd MMM yyy");
            query1 = "Select count(*) from Asset_tbl where Asset_name LIKE'"+ItemNameTxt.Text+"%'";
            DataSet ds = fn.getData(query1);
            if(ds.Tables[0].Rows[0][0].ToString()=="0")
            {
                MessageBox.Show("There is no such item in store");
            }
            
           else if (EmpIDtxt.Text == "" || ItemNameTxt.Text == "" || itemModeltxt.Text == "" || AmountTxt.Text == "")
            {
                MessageBox.Show("All inputs are Requiered");
            }
            else
            {
                query = "insert  into Employee_req values('" + ItemNameTxt.Text + "','" + itemModeltxt.Text + "','" + AmountTxt.Text + "','" + date + "','" + EmpIDtxt.Text + "')";
                fn.setData(query);
                MessageBox.Show("Employee Request Registered Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearFormBtn_Click(object sender, EventArgs e)
        {
            AmountTxt.Clear();
            itemModeltxt.Clear();
            ItemNameTxt.Clear();
            
        }

        private void Employee_Request_Load(object sender, EventArgs e)
        {
            query = "Select *from Employee_tbl where user_name='" + txt + "'";
            SqlDataReader dr = fn.getForCombo(query);
            if (dr.Read())
            {
                emp_id = dr.GetValue(0).ToString();
                EmpIDtxt.Text = emp_id;
            }

            
        }
    }
}
