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
    public partial class Notfication_for_emp : Form
    {
        string Confirmation_pass;
        string query;
        string Asset_name;
        string amount;
        Function fn = new Function();
        string txt;
        
        public Notfication_for_emp()
        {
            InitializeComponent();
        }
        public Notfication_for_emp(string txt)
        {
            this.txt = txt;
            InitializeComponent();
        }
 
        private void Notfication_for_emp_Load(object sender, EventArgs e)
        {
            query = "select Asset_name,Amount_asset ,Confirmation_password  from Accepted_req where user_name='" + txt + "'";
            DataSet ds = fn.getData(query);
            NotficationDataGridView.DataSource = ds.Tables[0];


        }
    }
}
