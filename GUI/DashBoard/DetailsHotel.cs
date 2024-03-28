using Quan_Ly_Khach_San_2024.DAL;
using Quan_Ly_Khach_San_2024.GUI.All_User_Control;
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
    public partial class DetailsHotel : Form
    {
        DBConnection db = new DBConnection();
        public DetailsHotel()
        {
            InitializeComponent();
            show_dsroom();
        }
        public DetailsHotel(DataRow row)
        {
            InitializeComponent();
            show_dsroom();
            txtNameHotel.Text = row[0].ToString();
            txtAddress.Text = row[1].ToString() + ", " + row[2].ToString();
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            BookRoom br = new BookRoom();
            br.Show();
        }

        public void show_dsroom()
        {
            string str_sql = "select RoomNumber, Type, Price from Rooms";
            DataTable dt = db.HienThi(str_sql);
            foreach (DataRow row in dt.Rows)
            {
                UC_Room uC_Room = new UC_Room();


                uC_Room.label1.Text = row[0].ToString();
                uC_Room.label2.Text = row[1].ToString();
                uC_Room.lblPrice.Text = row[2].ToString();

                flPnDSRoom.Controls.Add(uC_Room);

                uC_Room.Margin = new Padding(10); // Thiết lập khoảng cách 5 pixels

            }
        }
    }
}
