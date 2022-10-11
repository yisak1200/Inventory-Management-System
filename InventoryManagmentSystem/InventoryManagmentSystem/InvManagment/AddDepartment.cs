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
    public partial class AddDepartment : UserControl
    {
        Function fn = new Function();
        string query;
        
        public int index;
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
            query = "select * from Department  ";
            DataSet ds  =fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void AddDepartmentBtn_Click(object sender, EventArgs e)
        {
            if (Departmenttxt.Text == "")
            {
                MessageBox.Show("Department name is Requiered");
            }else
            {
                query = "insert into Department values ('"+Departmenttxt.Text+"')";
                fn.setData(query);
                MessageBox.Show("Department inserted Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guna2DataGridView1.Refresh();
            }
           
        }

        private void ClearFormbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data will be Lost","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                    Departmenttxt.Clear();
                    DepartmentIdtxt.Clear();
                    DepartmentSearchtxt.Clear();
            }
            
        }

        private void DepartmentSearchBtn_Click(object sender, EventArgs e)
        {                
            query = "select * from Department where Department_name='" + DepartmentSearchtxt.Text + "'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            DepartmentSearchtxt.Clear();
            query = "select * from Department ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
        }

        private void UpdateDepartmentBtn_Click(object sender, EventArgs e)
        {
             query = "Update  Department set Department_name= '" + Departmenttxt.Text + "' where Department_id='"+DepartmentIdtxt.Text+"'";
             fn.setData(query);
            MessageBox.Show("User Data Updated sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.guna2DataGridView1.Rows[e.RowIndex];
                Departmenttxt.Text = row.Cells["Department_name"].Value.ToString();
                DepartmentIdtxt.Text = row.Cells["Department_id"].Value.ToString();
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.guna2DataGridView1.Rows[e.RowIndex];
                Departmenttxt.Text = row.Cells["Department_name"].Value.ToString();
                DepartmentIdtxt.Text = row.Cells["Department_id"].Value.ToString();
            }
        }

        private void DeleteDepartmentBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted Permanently ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "Delete from Department where Department_name='" + Departmenttxt.Text + "' and Department_id='" + DepartmentIdtxt.Text + "'";
                fn.setData(query);
                MessageBox.Show("Department Deleted Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DepartmentSearchtxt_TextChanged(object sender, EventArgs e)
        {
            query = "Select *from Department where Department_name LIKE'"+ DepartmentSearchtxt + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }


    }
}