using Quan_Ly_Khach_San_2024.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Khach_San_2024.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace Quan_Ly_Khach_San_2024
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            btnHome.PerformClick();
        }
        #region Ẩn hiện các nút theo loại User đăng nhập
        private void btnHome_Click(object sender, EventArgs e)
        {
            uC_Home1.Visible = true;
            uC_Home1.BringToFront();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            uC_Search1.Visible = true;
            uC_Search1.BringToFront();
            if (DBConnection.type == "Normal")
            {
                uC_Search1.btnAddRS.Visible = false;
            }
            else if (DBConnection.type == "HotelOwner")
            {
                uC_Search1.btnAddRS.Visible = true;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            uC_Statistical1.Visible = true;
            uC_Statistical1.BringToFront();
        }
        #endregion

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Home1.btnFind.Click += btnFind_Click;// sử dụng btnFind của UC_Home trong dashboard. 
            uC_Search1.btnAddRS.Click += btnAddRS_Click;// sử dụng btnAddSearch của UC_Search trong dashboard. 
            if (DBConnection.type == "HotelOwner")
            {
               //button dashboard
               btnHome.Visible = true;
               btnSearch.Visible = true;
               btnProfile.Visible = true;
               btnStatistical.Visible = true;
               btnHelp.Visible = true;
            }
            else if (DBConnection.type == "Normal")
            {
                //button dashboard
                btnHome.Visible = true;
                btnSearch.Visible = true;
                btnProfile.Visible = true;
                btnStatistical.Visible = false;
                btnHelp.Visible = true;
                
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            uC_Search1.Visible = true;
            uC_Search1.BringToFront();
            if (DBConnection.type == "Normal")
            {
                uC_Search1.btnAddRS.Visible = false;
            }
            else if (DBConnection.type == "HotelOwner")
            {
                uC_Search1.btnAddRS.Visible = true;
            }
        }
        private void btnAddRS_Click(object sender, EventArgs e)
        {
            uC_Search1.btnAddRS.Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }
    }
}
