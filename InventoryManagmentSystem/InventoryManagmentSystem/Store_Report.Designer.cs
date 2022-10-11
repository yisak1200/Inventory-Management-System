namespace InventoryManagmentSystem
{
    partial class Store_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LoadReportbtn = new Guna.UI2.WinForms.Guna2Button();
            this.ItemGroupCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectallAssetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 288);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1448, 454);
            this.reportViewer1.TabIndex = 0;
            // 
            // LoadReportbtn
            // 
            this.LoadReportbtn.BorderRadius = 18;
            this.LoadReportbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoadReportbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoadReportbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoadReportbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoadReportbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.LoadReportbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadReportbtn.ForeColor = System.Drawing.Color.White;
            this.LoadReportbtn.Location = new System.Drawing.Point(482, 206);
            this.LoadReportbtn.Name = "LoadReportbtn";
            this.LoadReportbtn.Size = new System.Drawing.Size(241, 40);
            this.LoadReportbtn.TabIndex = 69;
            this.LoadReportbtn.Text = "Select Based on item";
            this.LoadReportbtn.Click += new System.EventHandler(this.LoadReportbtn_Click);
            // 
            // ItemGroupCombo
            // 
            this.ItemGroupCombo.BackColor = System.Drawing.Color.Transparent;
            this.ItemGroupCombo.BorderColor = System.Drawing.Color.Black;
            this.ItemGroupCombo.BorderRadius = 10;
            this.ItemGroupCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ItemGroupCombo.DropDownHeight = 2000;
            this.ItemGroupCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemGroupCombo.DropDownWidth = 281;
            this.ItemGroupCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemGroupCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemGroupCombo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemGroupCombo.ForeColor = System.Drawing.Color.Black;
            this.ItemGroupCombo.IntegralHeight = false;
            this.ItemGroupCombo.ItemHeight = 25;
            this.ItemGroupCombo.Location = new System.Drawing.Point(35, 215);
            this.ItemGroupCombo.Name = "ItemGroupCombo";
            this.ItemGroupCombo.Size = new System.Drawing.Size(385, 31);
            this.ItemGroupCombo.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 26);
            this.label6.TabIndex = 91;
            this.label6.Text = "Item Group";
            // 
            // SelectallAssetBtn
            // 
            this.SelectallAssetBtn.BorderRadius = 18;
            this.SelectallAssetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectallAssetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectallAssetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectallAssetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectallAssetBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.SelectallAssetBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectallAssetBtn.ForeColor = System.Drawing.Color.White;
            this.SelectallAssetBtn.Location = new System.Drawing.Point(788, 206);
            this.SelectallAssetBtn.Name = "SelectallAssetBtn";
            this.SelectallAssetBtn.Size = new System.Drawing.Size(215, 40);
            this.SelectallAssetBtn.TabIndex = 93;
            this.SelectallAssetBtn.Text = "Select All Asset";
            this.SelectallAssetBtn.Click += new System.EventHandler(this.SelectallAssetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(454, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 37);
            this.label1.TabIndex = 94;
            this.label1.Text = "Inventory Managment System Store Report";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Store_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 805);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectallAssetBtn);
            this.Controls.Add(this.ItemGroupCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoadReportbtn);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "Store_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store_Report";
            this.Load += new System.EventHandler(this.Store_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button LoadReportbtn;
        private Guna.UI2.WinForms.Guna2ComboBox ItemGroupCombo;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button SelectallAssetBtn;
        private System.Windows.Forms.Label label1;
    }
}