using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San_2024
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                lblError.Visible = false;
                Dashboard01 dashboard = new Dashboard01();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                lblError.Visible = true;
                txtPassword.Clear();
            }
        }
    }
}
