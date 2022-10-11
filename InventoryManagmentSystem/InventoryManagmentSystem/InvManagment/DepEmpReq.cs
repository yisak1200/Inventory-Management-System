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

namespace InventoryManagmentSystem.InvManagment
{
    public partial class DepEmpReq : UserControl
    {
        string query,query1,query2,query3,query4;
        string Confirmatio_pass;
        Function fn = new Function();
        int Amount;
        int Convert_Amount;
        public DepEmpReq()
        {
            InitializeComponent();
        }

        private void DepEmpReq_Load(object sender, EventArgs e)
        {
            try
            {
                query = "select Employee_ID, user_name ,First_name,Last_name,Phone_num,Email,Adress,Department,Asset_name,Asset_model,Amount_asset,Date_of_req from Employee_tbl, Employee_req Where Employee_req.Emp_ID = Employee_tbl.Employee_ID";
                DataSet ds = fn.getData(query);
                EmpReqDataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpReqDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.EmpReqDataGridView.Rows[e.RowIndex];
                txtFirstName.Text = row.Cells["First_name"].Value.ToString();
                txtLastName.Text = row.Cells["Last_name"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                EmpIdtxt.Text = row.Cells["Employee_ID"].Value.ToString();
                txtPhoneNum.Text = row.Cells["Phone_num"].Value.ToString();
                txtAddress.Text = row.Cells["Adress"].Value.ToString();
                Departmenttxt.Text = row.Cells["Department"].Value.ToString();
                ItemNameTxt.Text = row.Cells["Asset_name"].Value.ToString();
                itemModeltxt.Text = row.Cells["Asset_model"].Value.ToString();
                AmountTxt.Text = row.Cells["Amount_asset"].Value.ToString();
                DateofReqtxt.Text = row.Cells["Date_of_req"].Value.ToString();
                usernametxt.Text = row.Cells["user_name"].Value.ToString();

            }
        }

        private void RejectReqBtn_Click(object sender, EventArgs e)
        {
            query1 = "Delete from Employee_req where Asset_name ='" + ItemNameTxt.Text + "'";
            fn.setData(query1);
            MessageBox.Show("Request Regicted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            //refresh tbl Automatically
            query2 = "select Employee_ID,user_name, First_name, Last_name, Phone_num, Email, Adress, Department, Asset_name, Asset_model, Amount_asset, Date_of_req from Employee_tbl, Employee_req Where Employee_req.Emp_ID = Employee_tbl.Employee_ID";
            DataSet ds1 = fn.getData(query2);
            EmpReqDataGridView.DataSource = ds1.Tables[0];
        }

        private void AcceptReq_Click(object sender, EventArgs e)
        {
            query4 = "Select *from Asset_tbl Where Asset_name LIKE'"+ItemNameTxt.Text+"%'";
            query3 = "Select count(*) from Asset_tbl where Asset_name LIKE'"+ ItemNameTxt.Text+ "%'";
            DataSet ds = fn.getData(query3);
            SqlDataReader dr = fn.getForCombo(query4);
            Convert_Amount = Convert.ToInt32(AmountTxt.Text);
            if(dr.Read())
            {
                Amount = Convert.ToInt32( dr.GetValue(4).ToString());
            }
            if (ds.Tables[0].Rows[0][0].ToString()=="0")
            {
                MessageBox.Show("We don't have this Item in store");
            }
            else if (Convert_Amount>Amount)
            {
                MessageBox.Show("Amount Have to be Less than=>"+Amount);
            }
            else { 
                    autogen();
                    query = "insert into Accepted_req values('"+ EmpIdtxt.Text+ "','"+ txtFirstName.Text+ "','"+txtLastName.Text+"','"+txtPhoneNum.Text+"','"+txtEmail.Text+"','"+txtAddress.Text+"','"+Departmenttxt.Text+"','"+ItemNameTxt.Text+"','"+itemModeltxt.Text+"','"+AmountTxt.Text+"','"+DateofReqtxt.Text+"','"+usernametxt.Text+"','"+Confirmatio_pass+"')";
                    fn.setData(query);
                MessageBox.Show("Employee Request Accepted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                query1 = "Delete from Employee_req where Asset_name ='"+ ItemNameTxt.Text+ "'";
                    fn.setData(query1);
                    clear();
                    //refresh tbl Automatically
                    query2 = "select Employee_ID, First_name, Last_name, Phone_num, Email, Adress, Department, Asset_name, Asset_model, Amount_asset, Date_of_req from Employee_tbl, Employee_req Where Employee_req.Emp_ID = Employee_tbl.Employee_ID";
                    DataSet ds1 = fn.getData(query2);
                    EmpReqDataGridView.DataSource = ds1.Tables[0];

            }
        }
        private void EmpReqDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void autogen()
        {
            string num = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            int leng = num.Length;
            string otp = string.Empty;
            int otpdigit = 6;
            string finaldigit;
            int getindex;
            for (int i = 0; i < otpdigit; i++)
            {
                do
                {
                    getindex = new Random().Next(0, leng);
                    finaldigit = num.ToCharArray()[getindex].ToString();
                } while (otp.IndexOf(finaldigit) != -1);
                otp += finaldigit;
            }
            
            Confirmatio_pass = (otp); 
        }
        public void clear()
        {
            txtFirstName.Clear();
            txtAddress.Clear();
            itemModeltxt.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            ItemNameTxt.Clear();
            txtPhoneNum.Clear();
            Departmenttxt.Clear();
            EmpIdtxt.Clear();
            DateofReqtxt.Clear();
            AmountTxt.Clear();
        }
    }
}
