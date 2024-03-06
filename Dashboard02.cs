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

namespace Quan_Ly_Khach_San_2024
{
    public partial class Dashboard02 : Form
    {
        public Dashboard02()
        {
            InitializeComponent();
            btnHome.PerformClick();
          
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
        /*  private void btnHome_Click(object sender, EventArgs e)
{
uC_Home1.Visible = true;
uC_Home1.BringToFront();

}

private void btnSearch_Click(object sender, EventArgs e)
{
uC_Search1.Visible = true;
uC_Search1.BringToFront();
}*/

    }
}
