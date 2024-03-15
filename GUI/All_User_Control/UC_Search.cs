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
        private Dictionary<string, List<string>> cityDistricts = new Dictionary<string, List<string>>();
        public UC_Search()
        {
            InitializeComponent();
            // Thêm các thành phố và quận vào từ điển
            cityDistricts.Add("Hanoi", new List<string> { "Ba Dinh", "Hoan Kiem", "Cau Giay" });
            cityDistricts.Add("Ho Chi Minh City", new List<string> { "District 1", "District 2", "District 3" });

            // Thêm các thành phố vào ComboBox
            foreach (var city in cityDistricts.Keys)
            {
                cbbCity.Items.Add(city);
            }
            // Tạo một DataTable để lưu trữ dữ liệu của các khách sạn
            DataTable hotelTable = new DataTable();
            hotelTable.Columns.Add("ID", typeof(int));
            hotelTable.Columns.Add("Tên khách sạn", typeof(string));
            hotelTable.Columns.Add("Địa chỉ", typeof(string));
            hotelTable.Columns.Add("Đánh giá ", typeof(string));
            // Thêm dữ liệu mẫu
            hotelTable.Rows.Add(1, "Tên Khách Sạn", "Địa chỉ", "Đánh Giá");
            hotelTable.Rows.Add(1, "Khách sạn A", "123 Đường ABC, Thành phố XYZ","5 sao");
            hotelTable.Rows.Add(2, "Khách sạn B", "456 Đường DEF, Thành phố XYZ","3 sao");
            // Nếu dữ liệu thực tế được lấy từ cơ sở dữ liệu, bạn cần thay thế các dòng trên với dữ liệu thực tế.
            datagridviewSearch.DataSource = hotelTable;
            datagridviewSearch.Columns["ID"].Visible = false; // Ẩn cột ID


        }

        private void cbbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa tất cả các quận hiện tại
            cbbDistrict.Items.Clear();

            // Lấy tên thành phố được chọn
            string selectedCity = cbbCity.SelectedItem.ToString();

            // Lấy danh sách quận của thành phố được chọn từ từ điển và thêm vào ComboBox
            foreach (var district in cityDistricts[selectedCity])
            {
                cbbDistrict.Items.Add(district);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedCity = cbbCity.SelectedItem.ToString();
            string selectedDistrict = cbbDistrict.SelectedItem.ToString();

            MessageBox.Show("Searching in " + selectedDistrict + ", " + selectedCity);
        }

        private void cbbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UC_Search_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            BookRoom br = new BookRoom();
            br.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DetailsHotel ds = new DetailsHotel();
            ds.Show();
        }


        private void datagridviewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
