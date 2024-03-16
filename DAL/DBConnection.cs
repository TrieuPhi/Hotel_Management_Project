using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Quan_Ly_Khach_San_2024.DAL
{
    public class DBConnection
    {
        private static string connectionString = Properties.Settings.Default.cnnStr;
        private SqlConnection conn;

        public DBConnection()
        {
            conn = new SqlConnection(connectionString);
        }

        public void ThucThi(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thực thi thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable HienThi(string sql)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }
    }
}
