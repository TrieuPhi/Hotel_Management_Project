using Microsoft.SqlServer.Management.Smo;
using Quan_Ly_Khach_San_2024.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Quan_Ly_Khach_San_2024.DAO
{
    public class UserDao
    {
        private DBConnection dbConnection;

        public UserDao()
        {
            dbConnection = new DBConnection();
        }
    }

}

