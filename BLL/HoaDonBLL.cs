using System;
using System.Data;
using QLKD_Project.DAL;

namespace QLKD_Project.BLL
{
    public class HoaDonBLL
    {
        private HoaDonDAL dal = new HoaDonDAL();

        // Lấy danh sách hóa đơn
        public DataTable GetHoaDonList()

        {
            return HoaDonDAL.GetAllHoaDon(); // Nếu GetAllHoaDon là static
        }
        public DataTable fillHoaDon()
        {
            return HoaDonDAL.fillHoaDonMonth6();
        }

        // Thêm hóa đơn với kiểm tra lỗi
        public void ThemHoaDon(string maKhach, string maHang, string ngayMua, string soLuong)
        //public void ThemHoaDon(string maKhach, string maHang, string ngayMua, string soLuong)

        {
            if (string.IsNullOrWhiteSpace(maKhach) || string.IsNullOrWhiteSpace(maHang))
                throw new Exception("Mã khách và mã hàng không được để trống!");

            if (string.IsNullOrWhiteSpace(ngayMua) || string.IsNullOrWhiteSpace(soLuong))
                throw new Exception("Ngày mua và số lượng không được để trống!");

            if (!DateTime.TryParse(ngayMua, out DateTime parsedNgayMua))
                throw new Exception("Ngày mua không hợp lệ!");

            if (!int.TryParse(soLuong, out int parsedSoLuong) || parsedSoLuong <= 0)
                throw new Exception("Số lượng phải là số nguyên dương!");
            string message = $"Mã khách: {maKhach}\nMã hàng: {maHang}\nNgày mua: {ngayMua}\nSố lượng: {parsedSoLuong.ToString()}";
            HoaDonDAL.InsertHoaDon(maKhach, maHang, ngayMua, parsedSoLuong.ToString());
        }

        // Sửa hóa đơn
        public void SuaHoaDon(string mahd, string ngayMua, string soLuong)

        {
            if (string.IsNullOrWhiteSpace(mahd))
                throw new Exception("Mã hóa đơn không được để trống!");

            if (!DateTime.TryParse(ngayMua, out DateTime parsedNgayMua))
                throw new Exception("Ngày mua không hợp lệ!");

            if (!int.TryParse(soLuong, out int parsedSoLuong) || parsedSoLuong <= 0)
                throw new Exception("Số lượng phải là số nguyên dương!");

            HoaDonDAL.UpdateHoaDon(mahd, ngayMua, parsedSoLuong.ToString());

        }

        // Xóa hóa đơn
        public void XoaHoaDon(string mahd)
        {
            if (string.IsNullOrWhiteSpace(mahd))
                throw new Exception("Mã hóa đơn không được để trống!");

            HoaDonDAL.DeleteHoaDon(mahd);
        }

    }
}
