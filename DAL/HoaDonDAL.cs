using System;
using System.Data;
using System.Data.SqlClient;

namespace QLKD_Project.DAL
{
    public class HoaDonDAL
    {
        // Lấy danh sách hóa đơn
        public static DataTable GetAllHoaDon()
        {
            string query = "SELECT * FROM Hoadon";
            return DBConnection.ExecuteQuery(query);
        }

        public static DataTable fillHoaDonMonth6()
        {
            string query = $"SELECT* FROM Hoadon WHERE MONTH(Ngaymua) = " + 6;
            //SELECT* FROM Hoadon WHERE MONTH(Ngaymua) = 6
            return DBConnection.ExecuteQuery(query);
        }

        // Thêm hóa đơn mới
        public static bool InsertHoaDon( string makhach, string mahang, string ngaymua, string soluong)

        {
            //Kiểm tra Mahang có tồn tại trong bảng Hanghoa không
            string checkQuery = $"SELECT COUNT(*) FROM Hanghoa WHERE Mahang = '{mahang}'";
            DataTable result = DBConnection.ExecuteQuery(checkQuery);

            if (result.Rows[0][0].ToString() == "0")
            {
                throw new Exception("Mahang không tồn tại trong bảng Hanghoa!");
            }

            //Nếu Mahang hợp lệ, thực hiện INSERT
            string mahd = Guid.NewGuid().ToString();
            string query = $"INSERT INTO Hoadon (Mahd, Makhach, Mahang,ngaymua, Soluong) VALUES('{mahd}', '{makhach}','{mahang}', '{ngaymua}' ,'{soluong}')";
    return DBConnection.ExecuteNonQuery(query) > 0;
        }


        // Sửa hóa đơn
        public static bool UpdateHoaDon(string mahd, string ngaymua, string soluong)
        {
            string query = $"UPDATE Hoadon SET Ngaymua = '{ngaymua}', Soluong = '{soluong}' WHERE Mahd = '{mahd}'";
            return DBConnection.ExecuteNonQuery(query) > 0;
        }


        // Xóa hóa đơn
        public static bool DeleteHoaDon(string mahd)
        {
            string query = $"DELETE FROM Hoadon WHERE Mahd = '{mahd}'";
            return DBConnection.ExecuteNonQuery(query) > 0;
        }
       
    }
}
