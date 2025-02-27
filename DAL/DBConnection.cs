using System;
using System.Data;
using MySql.Data.MySqlClient; // Dùng thư viện MySQL

namespace QLKD_Project.DAL
{
    public class DBConnection
    {
        private static string connectionString = "Server=localhost;Database=QLKD;User Id=root;Password=S300pmu1;";

        // Mở kết nối MySQL
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Thực thi SELECT -> trả về DataTable
        public static DataTable ExecuteQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                return dt;
            }
        }

        // Thực thi INSERT, UPDATE, DELETE -> trả về số dòng ảnh hưởng
        public static int ExecuteNonQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
            }
        }
    }
}
