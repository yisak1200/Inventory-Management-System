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
    public partial class AssetForCase1_user : UserControl
    {
        string query;
        Function fn = new Function();
        public AssetForCase1_user()
        {
            InitializeComponent();
        }

        private void AssetForCase1_user_Load(object sender, EventArgs e)
        {
            query = "select *from Asset_tbl";
            DataSet ds = fn.getData(query);
            AssetDataGridView.DataSource = ds.Tables[0];
        }

        private void AssetDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 & e.Value != null)
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
