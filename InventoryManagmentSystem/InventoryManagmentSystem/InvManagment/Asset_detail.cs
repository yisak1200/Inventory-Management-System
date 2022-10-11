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
    public partial class Asset_detail : UserControl
    {
        string query;
        Function fn = new Function();
        public Asset_detail()
        {
            InitializeComponent();
        }

        private void Asset_detail_Load(object sender, EventArgs e)
        {
            query = "select *from Asset_detail";
            DataSet ds = fn.getData(query);
            AssetDetailDataGridView.DataSource = ds.Tables[0];
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (itemGrouptxt.Text == "")
            {
                MessageBox.Show("item group name is Requiered");
            }
            else
            {
                query = "insert into Asset_detail values ('" + itemGrouptxt.Text + "')";
                fn.setData(query);
                MessageBox.Show("Asset Group Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //refresh
                query = "select *from Asset_detail";
                DataSet ds = fn.getData(query);
                AssetDetailDataGridView.DataSource = ds.Tables[0];
                clear();
            }
        }

        private void AssetDetailDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.AssetDetailDataGridView.Rows[e.RowIndex];
                itemGrouptxt.Text = row.Cells["Asset_group"].Value.ToString();
                itemcodetxt.Text = row.Cells["Asset_code"].Value.ToString();
            }
        }

        private void UpdateAssetDetailBtn_Click(object sender, EventArgs e)
        {
            query = "Update  Asset_detail set Asset_group='" + itemGrouptxt.Text + "' where Asset_code='" + itemcodetxt.Text + "'";
            fn.setData(query);
            MessageBox.Show("Asset Detail updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //refresh
            query = "select *from Asset_detail";
            DataSet ds = fn.getData(query);
            AssetDetailDataGridView.DataSource = ds.Tables[0];
            clear();
        }

        private void ClearFormbtn_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            itemcodetxt.Clear();
            itemGrouptxt.Clear();
        }
    }
}
