namespace Quan_Ly_Khach_San_2024
{
    partial class Dashboard01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard01));
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnPayBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.uC_Search1 = new Quan_Ly_Khach_San_2024.All_User_Control.UC_Search();
            this.uC_Home1 = new Quan_Ly_Khach_San_2024.All_User_Control.UC_Home();
            this.pnlDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.BackColor = System.Drawing.Color.White;
            this.pnlDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDashBoard.Controls.Add(this.uC_Home1);
            this.pnlDashBoard.Controls.Add(this.uC_Search1);
            this.pnlDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashBoard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(1554, 836);
            this.pnlDashBoard.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.Gold;
            this.btnSearch.BorderRadius = 12;
            this.btnSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSearch.BorderThickness = 2;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(90)))), ((int)(((byte)(205)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearch.Location = new System.Drawing.Point(15, 243);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 70);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(15, 8);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(77, 71);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btnPayBill
            // 
            this.btnPayBill.BackColor = System.Drawing.Color.Transparent;
            this.btnPayBill.BorderColor = System.Drawing.Color.Gold;
            this.btnPayBill.BorderRadius = 12;
            this.btnPayBill.BorderThickness = 2;
            this.btnPayBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(90)))), ((int)(((byte)(205)))));
            this.btnPayBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPayBill.ForeColor = System.Drawing.Color.White;
            this.btnPayBill.Image = ((System.Drawing.Image)(resources.GetObject("btnPayBill.Image")));
            this.btnPayBill.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPayBill.Location = new System.Drawing.Point(15, 348);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(70, 70);
            this.btnPayBill.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Gold;
            this.btnHome.BorderRadius = 12;
            this.btnHome.BorderThickness = 2;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(90)))), ((int)(((byte)(205)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageSize = new System.Drawing.Size(40, 40);
            this.btnHome.Location = new System.Drawing.Point(15, 131);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(70, 70);
            this.btnHome.TabIndex = 0;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(9, 82);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(86, 20);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "User Name";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(15, 791);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(61, 41);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 7;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(87)))), ((int)(((byte)(123)))));
            this.guna2GradientPanel1.BorderRadius = 18;
            this.guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2GradientPanel1.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2GradientPanel1.Controls.Add(this.lblUserName);
            this.guna2GradientPanel1.Controls.Add(this.btnHome);
            this.guna2GradientPanel1.Controls.Add(this.btnPayBill);
            this.guna2GradientPanel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.btnSearch);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(68)))), ((int)(((byte)(135)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(89)))), ((int)(((byte)(121)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(100, 836);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // uC_Search1
            // 
            this.uC_Search1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uC_Search1.Location = new System.Drawing.Point(98, -1);
            this.uC_Search1.Name = "uC_Search1";
            this.uC_Search1.Size = new System.Drawing.Size(1457, 836);
            this.uC_Search1.TabIndex = 0;
            // 
            // uC_Home1
            // 
            this.uC_Home1.Location = new System.Drawing.Point(98, -1);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(1457, 836);
            this.uC_Home1.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1554, 836);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.pnlDashBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.pnlDashBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDashBoard;
        private All_User_Control.UC_Home uC_Home1;
        private All_User_Control.UC_Search uC_Search1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnPayBill;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.Label lblUserName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}