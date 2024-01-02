using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSuperMarket
{
    public partial class NhanVien : MetroFramework.Forms.MetroForm
    {
        public NhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            GrNhanVien.Hide();
            GrChucNang.Hide();
            DGVNhanVien.Hide();
            DGVTaiKhoan.Hide();
            TxtTimKiem.Hide();
            PtbLoading.Show();
        }

        int x = 0;
        private void TimeWaiting_Tick(object sender, EventArgs e)
        {
            x++;
            if (x == 5)
            {
                TimeWaiting.Stop();
                PtbLoading.Hide();
                GrNhanVien.Show();
                GrChucNang.Show();
                TxtTimKiem.Show();
                DGVNhanVien.Show();
                DGVTaiKhoan.Show();
            }
        }
        
        private DataAccess dataAccess = new DataAccess();
        void LoadData()
        {
            DGVNhanVien.DataSource = dataAccess.GetDataTable("Select maNV,tenNV,NgaySinh,GioiTinh,SDT,DiaChi,TenDN,MaCV,TrangThaiTaiKhoan from nhanvien");

            DGVNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            DGVNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            DGVNhanVien.Columns[2].HeaderText = "Ngày sinh";
            DGVNhanVien.Columns[3].HeaderText = "Giới tính";
            DGVNhanVien.Columns[4].HeaderText = "SĐT";
            DGVNhanVien.Columns[5].HeaderText = "Địa chỉ";
            DGVNhanVien.Columns[6].HeaderText = "Tên đăng nhập";
            DGVNhanVien.Columns[7].HeaderText = "Mã chức vụ";
            DGVNhanVien.Columns[8].HeaderText = "Trạng thái";

            DGVTaiKhoan.DataSource = dataAccess.GetDataTable("Select username,password,fullname, datecreate, isAdmin from taikhoan");
            DGVTaiKhoan.Columns[0].HeaderText = "Tên đăng nhập";
            DGVTaiKhoan.Columns[1].HeaderText = "Mật khẩu";
            DGVTaiKhoan.Columns[2].HeaderText = "Họ và tên";
            DGVTaiKhoan.Columns[3].HeaderText = "Ngày tạo";
            DGVTaiKhoan.Columns[4].HeaderText = "Mã chức vụ";
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "Nhập nhân viên cần tìm kiếm")
            {
                LoadData();
            }
            else
            {
                DGVNhanVien.DataSource = dataAccess.GetDataTable("Select maNV,tenNV,NgaySinh,GioiTinh,SDT,DiaChi,TenDN,MaCV,TrangThaiTaiKhoan from nhanvien  where tenNV like N'%" + TxtTimKiem.Text + "%'");

                DGVNhanVien.Columns[0].HeaderText = "Mã nhân viên";
                DGVNhanVien.Columns[1].HeaderText = "Tên nhân viên";
                DGVNhanVien.Columns[2].HeaderText = "Ngày sinh";
                DGVNhanVien.Columns[3].HeaderText = "Giới tính";
                DGVNhanVien.Columns[4].HeaderText = "SĐT";
                DGVNhanVien.Columns[5].HeaderText = "Địa chỉ";
                DGVNhanVien.Columns[6].HeaderText = "Tên đăng nhập";
                DGVNhanVien.Columns[7].HeaderText = "Mã chức vụ";
                DGVNhanVien.Columns[8].HeaderText = "Trạng thái";

                DGVTaiKhoan.DataSource = dataAccess.GetDataTable("Select username,password,fullname, datecreate, isAdmin from taikhoan  where fullname like N'%" + TxtTimKiem.Text + "%'");
                DGVTaiKhoan.Columns[0].HeaderText = "Tên đăng nhập";
                DGVTaiKhoan.Columns[1].HeaderText = "Mật khẩu";
                DGVTaiKhoan.Columns[2].HeaderText = "Họ và tên";
                DGVTaiKhoan.Columns[3].HeaderText = "Ngày tạo";
                DGVTaiKhoan.Columns[4].HeaderText = "Mã chức vụ";
            }
        }

        private void DGVNhanVien_Click(object sender, EventArgs e)
        {
            int id = DGVNhanVien.CurrentRow.Index;
            TxtMaNhanVien.Text = DGVNhanVien.Rows[id].Cells[0].Value.ToString();
            TxtHoTen.Text = DGVNhanVien.Rows[id].Cells[1].Value.ToString();
            TxtNgaySinh.Text = DGVNhanVien.Rows[id].Cells[2].Value.ToString();
            TxtGioiTinh.Text = DGVNhanVien.Rows[id].Cells[3].Value.ToString();
            TxtSDT.Text = DGVNhanVien.Rows[id].Cells[4].Value.ToString();
            TxtDiaChi.Text = DGVNhanVien.Rows[id].Cells[5].Value.ToString();
            TxtTenDN.Text = DGVNhanVien.Rows[id].Cells[6].Value.ToString();
            TxtMaCV.Text = DGVNhanVien.Rows[id].Cells[7].Value.ToString();
            TxtTrangThai.Text = DGVNhanVien.Rows[id].Cells[8].Value.ToString();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Bạn có chắc chắn muốn thoát bán hàng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                MainAdmin mainAdmin = new MainAdmin();
                mainAdmin.Show();
                this.Hide();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string i_insertCommand = 
                "insert into nhanvien values (" + TxtMaNhanVien.Text + "," + " '" + TxtHoTen.Text + "'" + "," + " '" + TxtMaCV.Text + "'" + ", " + " '" + TxtTenDN.Text + "'" + ", " + " '" + TxtNgaySinh.Text + "'" + "," + " '" + TxtGioiTinh.Text + "'" + ", " + " '" + TxtSDT.Text + "'" + ", " + " '" + TxtDiaChi.Text + "'" + ", " + " '" + DateTimeNow.Value.ToString("yyyy-MM-dd") + "'" + "," + " '" + null + "'" + "," + " '" + TxtTrangThai.Text + "'" + ")";
                dataAccess.UpdateData(i_insertCommand);
            }
            finally
            {
                MetroMessageBox.Show(this, "Thêm nhân viên mới thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TxtMaNhanVien.Text = "Mã nhân viên";
                TxtHoTen.Text = "Họ và tên";
                TxtNgaySinh.Text = "Ngày sinh";
                TxtGioiTinh.Text = "Giới tính";
                TxtSDT.Text = "Số điện thoại";
                TxtDiaChi.Text = "Địa chỉ";
                TxtTenDN.Text = "Tên đăng nhập";
                TxtMaCV.Text = "Mã chức vụ";
                TxtTrangThai.Text = "Trạng thái";
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string i_updateCommand =
                "update nhanvien set TenNV = '" + TxtHoTen.Text + "',MaCV = '" + TxtMaCV.Text + "', TenDN = '" + TxtTenDN.Text + "', NgaySinh = '" + TxtNgaySinh.Text + "',GioiTinh = '" + TxtGioiTinh.Text + "', SDT = '" + TxtSDT.Text + "', DiaChi = '" + TxtDiaChi.Text + "', NgayVaoLam = '" + DateTimeNow.Value.ToString("yyyy-MM-dd") + "',NgayNghiViec = '" + null + "',TrangThaiTaiKhoan = '" + TxtTrangThai.Text + "' where MaNV = '" + TxtMaNhanVien.Text + "' ";
                dataAccess.UpdateData(i_updateCommand);
            }
            
            finally
            {
                MetroMessageBox.Show(this, "Cập nhật thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TxtMaNhanVien.Text = "Mã nhân viên";
                TxtHoTen.Text = "Họ và tên";
                TxtNgaySinh.Text = "Ngày sinh";
                TxtGioiTinh.Text = "Giới tính";
                TxtSDT.Text = "Số điện thoại";
                TxtDiaChi.Text = "Địa chỉ";
                TxtTenDN.Text = "Tên đăng nhập";
                TxtMaCV.Text = "Mã chức vụ";
                TxtTrangThai.Text = "Trạng thái";
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string i_deleteCommand =
                "delete from nhanvien where MaNV = '" + TxtMaNhanVien.Text + "' ";
                dataAccess.UpdateData(i_deleteCommand);
            }

            finally
            {
                MetroMessageBox.Show(this, "Xóa thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TxtMaNhanVien.Text = "Mã nhân viên";
                TxtHoTen.Text = "Họ và tên";
                TxtNgaySinh.Text = "Ngày sinh";
                TxtGioiTinh.Text = "Giới tính";
                TxtSDT.Text = "Số điện thoại";
                TxtDiaChi.Text = "Địa chỉ";
                TxtTenDN.Text = "Tên đăng nhập";
                TxtMaCV.Text = "Mã chức vụ";
                TxtTrangThai.Text = "Trạng thái";
            }
        }

        private void TxtMaNhanVien_Enter(object sender, EventArgs e)
        {
            if (TxtMaNhanVien.Text == "Mã nhân viên")
            {
                TxtMaNhanVien.Text = "";
                TxtMaNhanVien.ForeColor = Color.Black;
            }
        }

        private void TxtMaNhanVien_Leave(object sender, EventArgs e)
        {
            if (TxtMaNhanVien.Text == "")
            {
                TxtMaNhanVien.Text = "Mã nhân viên";
                TxtMaNhanVien.ForeColor = Color.Gray;
            }
        }

        private void TxtHoTen_Enter(object sender, EventArgs e)
        {
            if(TxtHoTen.Text == "Họ và tên")
            {
                TxtHoTen.Text = "";
                TxtHoTen.ForeColor = Color.Black;
            }
        }

        private void TxtHoTen_Leave(object sender, EventArgs e)
        {
            if (TxtHoTen.Text == "")
            {
                TxtHoTen.Text = "Họ và tên";
                TxtHoTen.ForeColor = Color.Gray;
            }
        }

        private void TxtNgaySinh_Enter(object sender, EventArgs e)
        {
            if (TxtNgaySinh.Text == "Ngày sinh")
            {
                TxtNgaySinh.Text = "";
                TxtNgaySinh.ForeColor = Color.Black;
            }
        }

        private void TxtNgaySinh_Leave(object sender, EventArgs e)
        {
            if (TxtNgaySinh.Text == "")
            {
                TxtNgaySinh.Text = "Ngày sinh";
                TxtNgaySinh.ForeColor = Color.Gray;
            }
        }

        private void TxtGioiTinh_Enter(object sender, EventArgs e)
        {
            if (TxtGioiTinh.Text == "Giới tính")
            {
                TxtGioiTinh.Text = "";
                TxtGioiTinh.ForeColor = Color.Black;
            }
        }

        private void TxtGioiTinh_Leave(object sender, EventArgs e)
        {
            if (TxtGioiTinh.Text == "")
            {
                TxtGioiTinh.Text = "Giới tính";
                TxtGioiTinh.ForeColor = Color.Gray;
            }
        }

        private void TxtSDT_Enter(object sender, EventArgs e)
        {
            if (TxtSDT.Text == "Số điện thoại")
            {
                TxtSDT.Text = "";
                TxtSDT.ForeColor = Color.Black;
            }
        }

        private void TxtSDT_Leave(object sender, EventArgs e)
        {
            if (TxtSDT.Text == "")
            {
                TxtSDT.Text = "Số điện thoại";
                TxtSDT.ForeColor = Color.Gray;
            }
        }

        private void TxtDiaChi_Enter(object sender, EventArgs e)
        {
            if (TxtDiaChi.Text == "Địa chỉ")
            {
                TxtDiaChi.Text = "";
                TxtDiaChi.ForeColor = Color.Black;
            }
        }

        private void TxtDiaChi_Leave(object sender, EventArgs e)
        {
            if (TxtDiaChi.Text == "")
            {
                TxtDiaChi.Text = "Địa chỉ";
                TxtDiaChi.ForeColor = Color.Gray;
            }
        }

        private void TxtTenDN_Enter(object sender, EventArgs e)
        {
            if (TxtTenDN.Text == "Tên đăng nhập")
            {
                TxtTenDN.Text = "";
                TxtTenDN.ForeColor = Color.Black;
            }
        }

        private void TxtTenDN_Leave(object sender, EventArgs e)
        {
            if (TxtTenDN.Text == "")
            {
                TxtTenDN.Text = "Tên đăng nhập";
                TxtTenDN.ForeColor = Color.Gray;
            }
        }

        private void TxtMaCV_Enter(object sender, EventArgs e)
        {
            if (TxtMaCV.Text == "Mã chức vụ")
            {
                TxtMaCV.Text = "";
                TxtMaCV.ForeColor = Color.Black;
            }
        }

        private void TxtMaCV_Leave(object sender, EventArgs e)
        {
            if (TxtMaCV.Text == "")
            {
                TxtMaCV.Text = "Mã chức vụ";
                TxtMaCV.ForeColor = Color.Gray;
            }
        }

        private void TxtTrangThai_Enter(object sender, EventArgs e)
        {
            if (TxtTrangThai.Text == "Trạng thái")
            {
                TxtTrangThai.Text = "";
                TxtTrangThai.ForeColor = Color.Black;
            }
        }

        private void TxtTrangThai_Leave(object sender, EventArgs e)
        {
            if (TxtTrangThai.Text == "")
            {
                TxtTrangThai.Text = "Trạng thái";
                TxtTrangThai.ForeColor = Color.Gray;
            }
        }

        private void TxtTimKiem_Enter(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "Nhập nhân viên cần tìm kiếm")
            {
                TxtTimKiem.Text = "";
                TxtTimKiem.ForeColor = Color.Black;
            }
        }

        private void TxtTimKiem_Leave(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "")
            {
                TxtTimKiem.Text = "Nhập nhân viên cần tìm kiếm";
                TxtTimKiem.ForeColor = Color.Gray;
            }
        }
    }
}
