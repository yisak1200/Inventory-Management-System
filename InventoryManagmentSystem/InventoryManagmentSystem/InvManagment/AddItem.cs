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
    public partial class AddItem : UserControl
    {
        Function fn = new Function();
        string query, query1;
        //string Asset_Code;
        string date;
        int total_coast = 0;
        int Amount_of_item;
        int Coast_of_single_item;
        public AddItem()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddItem_Load(object sender, EventArgs e)
        {

            query = "select *from Asset_tbl";
            DataSet ds = fn.getData(query);
            AssetDataGridView.DataSource = ds.Tables[0];

            ItemGroupCombo.Items.Clear();
            query = "select Asset_group from Asset_detail";
            DataSet ds1 = fn.getData(query);
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                ItemGroupCombo.Items.Add(ds1.Tables[0].Rows[i][0].ToString());
            }
            AssetcodeCombo.Items.Clear();
            query1 = "select Asset_code from Asset_detail";
            DataSet ds2 = fn.getData(query1);
            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                AssetcodeCombo.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
            }
        }

        public void clear()
        {
            ItemNameTxt.Clear();
            ItemPinTxt.Clear();
            SeroalNumTxt.Clear();
            AmountTxt.Clear();
            CoastItemTxt.Clear();
            AssetcodeCombo.Text = null;
            ItemGroupCombo.Text = null;
            Receipt_numtxt.Clear();



        }

        private void ClearFormBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void AddItembtn_Click(object sender, EventArgs e)
        {

            date = DateTime.Now.ToString("ddd, dd MMM yyy");
            if (ItemNameTxt.Text == "" || ItemPinTxt.Text == "" || SeroalNumTxt.Text == "" || AmountTxt.Text == "" || CoastItemTxt.Text == "" || AssetcodeCombo.Text == "" || ItemGroupCombo.Text == "" || Measurmenttxt.Text == "")
            {
                MessageBox.Show("all Inputs Are Requiered");
            }

            else
            {

                try
                {
                    query = "insert into Asset_tbl values('" + AssetcodeCombo.Text + "','" + ItemGroupCombo.Text + "','" + ItemNameTxt.Text + "','" + SeroalNumTxt.Text + "','" + AmountTxt.Text + "','" + date + "','" + Measurmenttxt.Text + "','" + CoastItemTxt.Text + "','" + total_coast + "','" + ItemPinTxt.Text + "','" + Receipt_numtxt.Text + "')";
                    fn.setData(query);
                    MessageBox.Show("Item Insereted Suessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Amount_of_item = Convert.ToInt32(AmountTxt.Text);
                Coast_of_single_item = Convert.ToInt32(CoastItemTxt.Text);
                total_coast = Coast_of_single_item * Amount_of_item;
                query = "update Asset_tbl set Total_Coast='" + total_coast + "' where Asset_name='" + ItemNameTxt.Text + "'";
                fn.setData(query);
                //to refresh the page while inserting
                query = "select * from Asset_tbl ";
                DataSet ds = fn.getData(query);
                AssetDataGridView.DataSource = ds.Tables[0];
                clear();
            }

        }

        private void ClearFormbtn_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void AssetDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.AssetDataGridView.Rows[e.RowIndex];
                ItemNameTxt.Text = row.Cells["Asset_name"].Value.ToString();
                ItemPinTxt.Text = row.Cells["Asset_pin_num"].Value.ToString();
                SeroalNumTxt.Text = row.Cells["Serial_number"].Value.ToString();
                AmountTxt.Text = row.Cells["Amount_of_item"].Value.ToString();
                CoastItemTxt.Text = row.Cells["Coast_of_single_Asset"].Value.ToString();
                AssetcodeCombo.Text = row.Cells["Asset_code"].Value.ToString();
                Measurmenttxt.Text = row.Cells["Measurment_of_item"].Value.ToString();
                ItemGroupCombo.Text = row.Cells["item_group"].Value.ToString();
                Receipt_numtxt.Text = row.Cells["Receipt_num"].Value.ToString();
            }
        }

        private void AssetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void UpdateItemBtn_Click(object sender, EventArgs e)
        {
            query = "update Asset_tbl set Asset_name='"+ItemNameTxt.Text+"',Serial_number='"+ SeroalNumTxt .Text+ "',Amount_of_item='"+AmountTxt.Text+"',Coast_of_single_Asset='"+CoastItemTxt.Text+"',Asset_code='"+AssetcodeCombo.Text+ "',Measurment_of_item='"+Measurmenttxt.Text+ "',item_group='"+ItemGroupCombo.Text+ "',Receipt_num='"+Receipt_numtxt.Text+"' where Asset_pin_num='" + ItemPinTxt.Text + "'";
            fn.setData(query);
            MessageBox.Show("Item Updated Suessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //refresh the page while updating
            query = "select * from Asset_tbl ";
            DataSet ds = fn.getData(query);
            AssetDataGridView.DataSource = ds.Tables[0];
           // AssetDataGridView.Refresh();
            clear();
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted Permanently ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "Delete from Asset_tbl where Asset_pin_num='" + ItemPinTxt.Text + "'";
                fn.setData(query);
                MessageBox.Show("Item deleted Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //refresh the page while deleting
                query = "select * from Asset_tbl ";
                DataSet ds = fn.getData(query);
                AssetDataGridView.DataSource = ds.Tables[0];
                clear();
            }
        }

        private void DepartmentSearchBtn_Click(object sender, EventArgs e)
        {
            query = "select *from Asset_tbl where Asset_name LIKE'" + itemSearchtxt.Text + "%'";
            DataSet ds = fn.getData(query);
            AssetDataGridView.DataSource = ds.Tables[0];
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            query = "select *from Asset_tbl";
            DataSet ds = fn.getData(query);
            AssetDataGridView.DataSource = ds.Tables[0];

        }

        private void AssetDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex==4 & e.Value!=null)
            {
                int Amount = Convert.ToInt32(e.Value);
                if (Amount < 100)
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (Amount >= 1000)
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        
        }


    }
}

