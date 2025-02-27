using System;
using System.Windows.Forms;
using QLKD_Project.BLL;

namespace QLKD_Project.GUI
{
    public partial class MainForm: Form
    {
        private HoaDonBLL bll = new HoaDonBLL();
        public MainForm()
        {
            InitializeComponent();
            LoadHoaDon();
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng chọn đúng hàng (không phải tiêu đề)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];

                // Gán dữ liệu từ dòng được chọn vào các TextBox
                txtMahd.Text = row.Cells["Mahd"].Value.ToString();
                txtMakhach.Text = row.Cells["Makhach"].Value.ToString();
                txtMahang.Text = row.Cells["Mahang"].Value.ToString();
                txtNgaymua.Text = row.Cells["Ngaymua"].Value.ToString();
                txtSoluong.Text = row.Cells["Soluong"].Value.ToString();
            }

        }
        private void LoadHoaDon()
        {
            dgvHoaDon.DataSource = bll.GetHoaDonList();
        }

        private void fillHoaDont6()
        {
            dgvHoaDon.DataSource = bll.fillHoaDon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string makhach = txtMakhach.Text;
                string mahang = txtMahang.Text;
                string soluong = txtSoluong.Text;
                string ngaymua = txtNgaymua.Text;


                if (!DateTime.TryParse(txtNgaymua.Text, out DateTime parsedNgayMua))
                {
                    MessageBox.Show("Ngày mua không hợp lệ! Vui lòng nhập theo định dạng yyyy-MM-dd.");
                    return;
                }
                string message = $"Mã khách: {makhach}\nMã hàng: {mahang}\nNgày mua: {ngaymua}\nSố lượng: {soluong}";
                MessageBox.Show(message, "Thông tin nhập vào");
                bll.ThemHoaDon(makhach, mahang, parsedNgayMua.ToString("yyyy-MM-dd"), soluong);
                MessageBox.Show("Thêm hóa đơn thành công!");
                LoadHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txtMahd.Text;
                string ngaymua = txtNgaymua.Text;
                string soluong = txtSoluong.Text;

                bll.SuaHoaDon(mahd, ngaymua, soluong);
                //bll.SuaHoaDon(mahd, soluong);

                MessageBox.Show("Sửa hóa đơn thành công!");
                LoadHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txtMahd.Text;
                bll.XoaHoaDon(mahd);
                MessageBox.Show("Xóa hóa đơn thành công!");
                LoadHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void brnLoad_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void btnfill_Click(object sender, EventArgs e)
        {
            fillHoaDont6();
        }
    }
}
