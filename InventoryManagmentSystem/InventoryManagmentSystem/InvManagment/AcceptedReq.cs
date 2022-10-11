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
    public partial class AcceptedReq : UserControl
    {
        Function fn = new Function();
        string query;
        public AcceptedReq()
        {
            InitializeComponent();
        }

        private void AcceptedReq_Load(object sender, EventArgs e)
        {
            query = "Select Emp_ID,First_name,Last_name,Email,Adress,Department,Asset_name,Asset_model,Amount_asset,Date_of_req from Accepted_req";
            DataSet ds = fn.getData(query);
            AcceptedReqDataGridView.DataSource = ds.Tables[0];
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            query = "Select Emp_ID,First_name,Last_name,Email,Adress,Department,Asset_name,Asset_model,Amount_asset,Date_of_req from Accepted_req";
            DataSet ds = fn.getData(query);
            AcceptedReqDataGridView.DataSource = ds.Tables[0];
        }

        private void EmployeeSearchbtn_Click(object sender, EventArgs e)
        {

        }

        
    }
}
