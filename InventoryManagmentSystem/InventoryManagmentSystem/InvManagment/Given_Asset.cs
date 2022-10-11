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
    public partial class Given_Asset : UserControl
    {
        string query;
        Function fn = new Function();
        public Given_Asset()
        {
            InitializeComponent();
        }

        private void Given_Asset_Load(object sender, EventArgs e)
        {
            query = "Select Emp_ID ,First_name,Last_name,Phone_num,Department,total_coast,Asset_name,Asset_amount,Asset_given_Date from Given_Asset";
            DataSet ds1 = fn.getData(query);
            GivenAssetDataGridView.DataSource = ds1.Tables[0];
        }
    }
}
