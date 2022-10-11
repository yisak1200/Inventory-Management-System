namespace InventoryManagmentSystem
{
    partial class EmployeePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Notficationbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.RequestBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ChangeEmpPassword = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.changePasswordEmployee1 = new InventoryManagmentSystem.InvManagment.ChangePasswordEmployee();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Notficationbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Logoutbtn);
            this.panel1.Controls.Add(this.RequestBtn);
            this.panel1.Controls.Add(this.ChangeEmpPassword);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1494, 134);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Notficationbtn
            // 
            this.Notficationbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Notficationbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Notficationbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Notficationbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Notficationbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Notficationbtn.FillColor = System.Drawing.Color.Transparent;
            this.Notficationbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notficationbtn.ForeColor = System.Drawing.Color.White;
            this.Notficationbtn.Image = ((System.Drawing.Image)(resources.GetObject("Notficationbtn.Image")));
            this.Notficationbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Notficationbtn.ImageSize = new System.Drawing.Size(40, 40);
            this.Notficationbtn.Location = new System.Drawing.Point(763, 76);
            this.Notficationbtn.Name = "Notficationbtn";
            this.Notficationbtn.Size = new System.Drawing.Size(282, 45);
            this.Notficationbtn.TabIndex = 29;
            this.Notficationbtn.Text = " Notfication ";
            this.Notficationbtn.Click += new System.EventHandler(this.Notficationbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "employee name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Logoutbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Logoutbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Logoutbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Logoutbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Logoutbtn.FillColor = System.Drawing.Color.Transparent;
            this.Logoutbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.ForeColor = System.Drawing.Color.White;
            this.Logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("Logoutbtn.Image")));
            this.Logoutbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Logoutbtn.ImageSize = new System.Drawing.Size(40, 40);
            this.Logoutbtn.Location = new System.Drawing.Point(396, 76);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(282, 45);
            this.Logoutbtn.TabIndex = 27;
            this.Logoutbtn.Text = "Log Out";
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // RequestBtn
            // 
            this.RequestBtn.BackColor = System.Drawing.Color.Transparent;
            this.RequestBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RequestBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RequestBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RequestBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RequestBtn.FillColor = System.Drawing.Color.Transparent;
            this.RequestBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestBtn.ForeColor = System.Drawing.Color.White;
            this.RequestBtn.Image = ((System.Drawing.Image)(resources.GetObject("RequestBtn.Image")));
            this.RequestBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RequestBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.RequestBtn.Location = new System.Drawing.Point(1202, 82);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(285, 45);
            this.RequestBtn.TabIndex = 26;
            this.RequestBtn.Text = "Request Assetes";
            this.RequestBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // ChangeEmpPassword
            // 
            this.ChangeEmpPassword.BackColor = System.Drawing.Color.Transparent;
            this.ChangeEmpPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChangeEmpPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChangeEmpPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChangeEmpPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChangeEmpPassword.FillColor = System.Drawing.Color.Transparent;
            this.ChangeEmpPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeEmpPassword.ForeColor = System.Drawing.Color.White;
            this.ChangeEmpPassword.Image = ((System.Drawing.Image)(resources.GetObject("ChangeEmpPassword.Image")));
            this.ChangeEmpPassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChangeEmpPassword.ImageSize = new System.Drawing.Size(40, 40);
            this.ChangeEmpPassword.Location = new System.Drawing.Point(-2, 76);
            this.ChangeEmpPassword.Name = "ChangeEmpPassword";
            this.ChangeEmpPassword.Size = new System.Drawing.Size(285, 45);
            this.ChangeEmpPassword.TabIndex = 25;
            this.ChangeEmpPassword.Text = "Change Password";
            this.ChangeEmpPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ChangeEmpPassword.Click += new System.EventHandler(this.ChangeEmpPassword_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(686, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 29);
            this.label8.TabIndex = 24;
            this.label8.Text = "Employee Page";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1427, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 49);
            this.btnExit.TabIndex = 5;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.changePasswordEmployee1);
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1501, 781);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // changePasswordEmployee1
            // 
            this.changePasswordEmployee1.BackColor = System.Drawing.Color.White;
            this.changePasswordEmployee1.Location = new System.Drawing.Point(-2, -2);
            this.changePasswordEmployee1.Name = "changePasswordEmployee1";
            this.changePasswordEmployee1.Size = new System.Drawing.Size(1491, 769);
            this.changePasswordEmployee1.TabIndex = 0;
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1490, 852);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePage";
            this.Load += new System.EventHandler(this.EmployeePage_Load_2);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button RequestBtn;
        private Guna.UI2.WinForms.Guna2Button ChangeEmpPassword;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button Logoutbtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Notficationbtn;
        private InvManagment.ChangePasswordEmployee changePasswordEmployee1;
    }
}