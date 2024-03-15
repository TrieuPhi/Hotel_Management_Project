using Quan_Ly_Khach_San_2024.DAO;
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

namespace Quan_Ly_Khach_San_2024
{
    public partial class Login : Form
    {
        private UserDao userDao;
        public Login()
        {
            InitializeComponent();
            userDao = new UserDao();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*if (txtUserName.Text == "admin" && txtPassWord.Text == "admin")
            {
                lblError.Visible = false;
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                lblError.Visible = true;
                txtPassWord.Clear();
            }*/
        }
    }
}
