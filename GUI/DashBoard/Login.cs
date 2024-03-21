using Quan_Ly_Khach_San_2024.DAL;
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
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public Login()
        {
            InitializeComponent();
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
            try
            {
                using (conn)
                {
                    SqlCommand cmd = new SqlCommand("sp_Role_Login", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassWord.Text);

                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd[3].ToString() == "Normal")
                        {
                            DBConnection.type = "Normal";
                        }
                        else if (rd[3].ToString() == "HotelOwner")
                        {
                            DBConnection.type = "HotelOwner";
                        }
                        MessageBox.Show("Welcome " + txtUserName.Text);

                        Dashboard d = new Dashboard();
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
