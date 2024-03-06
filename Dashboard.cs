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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            /*  uC_AddRoom1.Visible = false;
              uC_Register1.Visible = false;
              uC_CheckOut1.Visible = false;
              uC_CustomerDetails1.Visible = false;
              uC_Employee1.Visible = false;
              btnHome.PerformClick();  */
            uC_Home1.Visible = false;
            uC_Search1.Visible = false;    
            btnHome.PerformClick();
        }

   /*     private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }*/

        /*private void btnCustomerRegister_Click(object sender, EventArgs e)
        {
            *//*pnlMoving.Left = btnCustomerRegister.Left + 10;
            uC_Register1.Visible = true;
            uC_Register1.BringToFront();*//*
        }*/

        private void btncheckout_Click(object sender, EventArgs e)
        {
           /* pnlMoving.Left = btncheckout.Left + 10;
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();*/
        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            /*pnlMoving.Left = btnCustomerDetail.Left + 10;
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();*/
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
           /* pnlMoving.Left = btnEmployee.Left + 10;
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();*/
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            uC_Home1.Visible = true;
            uC_Home1.BringToFront();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            uC_Search1.Visible = true;
            uC_Search1.BringToFront();
        }

        private void uC_Home1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
