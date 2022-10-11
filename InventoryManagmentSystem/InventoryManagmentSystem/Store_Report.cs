using Microsoft.Reporting.WinForms;
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
    public partial class Store_Report : Form
    {
        string query;
        Function fn = new Function();
        public Store_Report()
        {
            InitializeComponent();
        }

        private void Store_Report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            ItemGroupCombo.Items.Clear();
            query = "select Asset_group from Asset_detail";
            DataSet ds1 = fn.getData(query);
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                ItemGroupCombo.Items.Add(ds1.Tables[0].Rows[i][0].ToString());
            }
            
        }

        private void LoadReportbtn_Click(object sender, EventArgs e)
        {
            query = "Select *from Asset_tbl where item_group='"+ ItemGroupCombo.Text+ "' ";
            DataSet ds =fn.getData(query);
            ReportDataSource rds = new ReportDataSource("DataSet1",ds.Tables[0]);
            reportViewer1.LocalReport.ReportPath= @"C:\Users\user\Desktop\InventoryManagmentSystem\InventoryManagmentSystem\StoreReport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void SelectallAssetBtn_Click(object sender, EventArgs e)
        {
            query = "Select *from Asset_tbl ";
            DataSet ds = fn.getData(query);
            ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\user\Desktop\InventoryManagmentSystem\InventoryManagmentSystem\StoreReport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
