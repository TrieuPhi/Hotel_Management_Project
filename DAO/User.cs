using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San_2024.DAO
{
    public class User
    {
        protected int id;
        protected string username;
        protected string password;
        protected string usertype;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string UserType
        {
            get { return usertype; }
            set { usertype = value; }
        }

        // Phương thức khởi tạo mặc định
        public User() { }

        // Phương thức khởi tạo với tham số
        public User(int id, string username, string password, string usertype) 
        { 
            this.id = id;
            this.username = username;   
            this.password = password;
            this.usertype = usertype;
        }
    }
}
