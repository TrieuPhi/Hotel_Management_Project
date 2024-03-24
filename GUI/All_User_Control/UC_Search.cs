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

namespace Quan_Ly_Khach_San_2024.All_User_Control
{
    public partial class UC_Search : UserControl
    {
        DBConnection db = new DBConnection();
        public UC_Search()
        {
            InitializeComponent();
            show_dshotel();
        }

        public void show_dshotel()
        {
            string str_sql = "select HotelName, District, City from Hotels";
            DataTable dt = db.HienThi(str_sql);
            foreach (DataRow row in dt.Rows)
            {
                UC_Hotel uC_Hotel = new UC_Hotel();

                uC_Hotel.label1.Text = row[0].ToString();
                uC_Hotel.label2.Text = row[1].ToString() + ", " + row[2].ToString();

                uC_Hotel.Click += (sender, e) =>
                {
                    // Xử lý sự kiện click ở đây, ví dụ mở form chi tiết
                    DetailsHotel detailsHotel = new DetailsHotel(row); // Thay thế FormDetails bằng tên form chi tiết của bạn
                    detailsHotel.ShowDialog(); // Mở form chi tiết dưới dạng dialog
                };

                flPnDSHotel.Controls.Add(uC_Hotel);

                uC_Hotel.Margin = new Padding(10); // Thiết lập khoảng cách 5 pixels

            }
        }
    }
}
