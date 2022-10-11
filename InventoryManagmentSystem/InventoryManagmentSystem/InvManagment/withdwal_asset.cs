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
    public partial class withdwal_asset : UserControl
    {
        Function fn = new Function();
        string query;
        string txt;
        public withdwal_asset()
        {
            InitializeComponent();
        }

        private void withdwal_asset_Load(object sender, EventArgs e)
        {
            wrongLabel.Visible = false;
        }

        private void ConfirmAsset_Click(object sender, EventArgs e)
        {
            query = "select count (*) from Accepted_req where Confirmation_password='" + AssetConfPasstxt.Text + "' and Emp_ID='" + EmpIdtxt.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows[0][0].ToString() == "1")
            {
                txt = EmpIdtxt.Text;
                Emp_withdrwal ew = new Emp_withdrwal(txt);
                ew.Show();

            }
            else wrongLabel.Visible = true;
        }
    }
}
