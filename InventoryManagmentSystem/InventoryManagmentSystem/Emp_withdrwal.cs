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
    public partial class Emp_withdrwal : Form
    {
        string txt;
        string query,query1,query2,query3;
        string Date;
        float Amount_of_asset,Coast,Total_Coast;

        Function fn = new Function();
        float Convert_Amount;
        float coast_of_given_item,updated_coast;
        public Emp_withdrwal(string txt)
        {
            this.txt = txt;
            InitializeComponent();
        }
        public Emp_withdrwal()
        {
            InitializeComponent();
        }

        private void EmployeAcceptedInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { 
                DataGridViewRow row = this.EmployeAcceptedInfo.Rows[e.RowIndex];
                ItemNameTxt.Text = row.Cells["Asset_name"].Value.ToString();
                AmountTxt.Text = row.Cells["Amount_asset"].Value.ToString();
                itemModeltxt.Text = row.Cells["Asset_model"].Value.ToString();
                DateofReqtxt.Text = row.Cells["Date_of_req"].Value.ToString();
            }
        }

        private void giveAssetBtn_Click(object sender, EventArgs e)
        {
            Date = DateTime.Now.ToString("ddd, dd MMM yyy");
            
            query2 = "select *from Asset_tbl where Asset_name LIKE'" + ItemNameTxt.Text + "'";
            SqlDataReader dr = fn.getForCombo(query2);
            if (dr.Read())
            {
                Amount_of_asset = Convert.ToInt32(dr.GetInt32(4).ToString());
                Convert_Amount = Convert.ToInt32(AmountTxt.Text);
                Coast = Convert.ToInt32(dr.GetValue(7).ToString());
                Total_Coast = Convert.ToInt32(dr.GetValue(8).ToString());
                
            }
            
            coast_of_given_item = Convert_Amount * Coast;
            updated_coast = Total_Coast - coast_of_given_item;
                
            try { 
                query = "insert into Given_Asset values('"+EmpIdtxt.Text+"','"+txtFirstName.Text+"','"+txtLastName.Text+"','"+txtPhoneNum.Text+"','"+txtEmail.Text+"','"+Departmenttxt.Text+"','"+ coast_of_given_item + "','"+ItemNameTxt.Text+"','"+itemModeltxt.Text+"','"+AmountTxt.Text+"','"+Date+"')";
            fn.setData(query);
                MessageBox.Show("Given Asset Registered Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            float updated_Amount = Amount_of_asset - Convert_Amount;
            query1 = "Update Asset_tbl set Amount_of_item='"+updated_Amount+"'," +"Total_Coast='"+updated_coast+"' where Asset_name LIKE'"+ItemNameTxt.Text+"%'";
            fn.setData(query1);
            query3 = "Delete from Accepted_req where Asset_name='"+ItemNameTxt.Text+"'and" +
                " Emp_ID='"+EmpIdtxt.Text+"'";
            fn.setData(query3);
            //refresh datagridview
            query = "Select Asset_name,Asset_model,Amount_asset,Date_of_req from Accepted_req where Emp_ID='" + txt + "'";
            DataSet ds = fn.getData(query);
            EmployeAcceptedInfo.DataSource = ds.Tables[0];
            
        }

        private void Emp_withdrwal_Load(object sender, EventArgs e)
        {
            query="Select Asset_name,Asset_model,Amount_asset,Date_of_req from Accepted_req where Emp_ID='"+txt+"'";
            DataSet ds = fn.getData(query);
            EmployeAcceptedInfo.DataSource = ds.Tables[0];
            query1 = "select *from Employee_tbl where Employee_ID='"+txt+"'";
            query2 = "select Emp_Image from Employee_tbl where Employee_ID='" + txt + "'";
            //string img = 
            SqlDataReader dr = fn.getForCombo(query1);
            
            if (dr.Read())
            {
               
                EmpIdtxt.Text = dr[0].ToString();
                txtFirstName.Text = dr[1].ToString();
                txtLastName.Text = dr[2].ToString();
                txtPhoneNum.Text = dr[3].ToString();
                txtEmail.Text = dr[5].ToString();
                //txtAddress.Text = dr[7].ToString();
                Departmenttxt.Text = dr[4].ToString();
                //MemoryStream ms = new MemoryStream(dr.GetSqlBytes(9).Buffer);
                //empPic.Image = Image.FromStream(ms);
                
                
                    
               

            }
            
        }
       
    }
}
