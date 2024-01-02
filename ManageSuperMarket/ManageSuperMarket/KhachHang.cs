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
    public partial class KhachHang : MetroFramework.Forms.MetroForm
    {
        public KhachHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            GrKhachHang.Hide();
            GrChucNang.Hide();
            DGVKhachHang.Hide();
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
                GrKhachHang.Show();
                GrChucNang.Show();
                TxtTimKiem.Show();
                DGVKhachHang.Show();
            }
        }

        private DataAccess dataAccess = new DataAccess();
        void LoadData()
        {
            DGVKhachHang.DataSource = dataAccess.GetDataTable("select * from khachhang");

            DGVKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            DGVKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            DGVKhachHang.Columns[2].HeaderText = "Địa chỉ";
            DGVKhachHang.Columns[3].HeaderText = "SDT";
            DGVKhachHang.Columns[4].HeaderText = "Điểm";
            DGVKhachHang.Columns[5].HeaderText = "Ngày tạo";
            DGVKhachHang.Columns[6].HeaderText = "Năm gắn bó";
            DGVKhachHang.Columns[7].HeaderText = "Mã mục hàng";
        }

        private void DGVKhachHang_Click(object sender, EventArgs e)
        {
            int id = DGVKhachHang.CurrentRow.Index;
            TxtMaKH.Text = DGVKhachHang.Rows[id].Cells[0].Value.ToString();
            TxtHoTen.Text = DGVKhachHang.Rows[id].Cells[1].Value.ToString();
            TxtDiaChi.Text = DGVKhachHang.Rows[id].Cells[2].Value.ToString();
            TxtSDT.Text = DGVKhachHang.Rows[id].Cells[3].Value.ToString();
            TxtDiem.Text = DGVKhachHang.Rows[id].Cells[4].Value.ToString();
            TxtNgayTao.Text = DGVKhachHang.Rows[id].Cells[5].Value.ToString();
            TxtNamGB.Text = DGVKhachHang.Rows[id].Cells[6].Value.ToString();
            TxtMaHang.Text = DGVKhachHang.Rows[id].Cells[7].Value.ToString();
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "Nhập khách hàng cần tìm kiếm")
            {
                LoadData();
            }
            else
            {
                DGVKhachHang.DataSource = dataAccess.GetDataTable("Select * from khachhang  where TenKH like N'%" + TxtTimKiem.Text + "%'");

                DGVKhachHang.Columns[0].HeaderText = "Mã khách hàng";
                DGVKhachHang.Columns[1].HeaderText = "Tên khách hàng";
                DGVKhachHang.Columns[2].HeaderText = "Địa chỉ";
                DGVKhachHang.Columns[3].HeaderText = "SDT";
                DGVKhachHang.Columns[4].HeaderText = "Điểm";
                DGVKhachHang.Columns[5].HeaderText = "Ngày tạo";
                DGVKhachHang.Columns[6].HeaderText = "Năm gắn bó";
                DGVKhachHang.Columns[7].HeaderText = "Mã mục hàng";
            }
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
                "insert into khachhang values (" + TxtMaKH.Text + "," + " '" + TxtHoTen.Text + "'" + "," + " '" + TxtDiaChi.Text + "'" + ", " + " '" + TxtSDT.Text + "'" + ", " + " '" + TxtDiem.Text + "'" + "," + " '" + DateTimeNow.Value.ToString("yyyy-MM-dd") + "'" + ", " + " '" + TxtNamGB.Text + "'" + ", " + " '" + TxtMaHang.Text + "'" + ")";
                dataAccess.UpdateData(i_insertCommand);
            }
            finally
            {
                MetroMessageBox.Show(this, "Thêm khách hàng mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TxtMaKH.Text = "Mã khách hàng";
                TxtHoTen.Text = "Tên khách hàng";
                TxtDiaChi.Text = "Địa chỉ";
                TxtSDT.Text = "Số điện thoại";
                TxtDiem.Text = "Điểm tích lũy";
                TxtNgayTao.Text = "Ngày tạo";
                TxtNamGB.Text = "Năm gắn bó";
                TxtMaHang.Text = "Mã mục hàng";
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string i_updateCommand =
                "update khachhang set TenKH = '" + TxtHoTen.Text + "',DiaChi = '" + TxtDiaChi.Text + "', SDT = '" + TxtSDT.Text + "', Diem = '" + TxtDiem.Text + "',NgayTao = '" + TxtNgayTao.Text + "', NamGanBo = '" + TxtNamGB.Text + "', MaMucHang = '" + TxtMaHang.Text + "' where MaKH = '" + TxtMaKH.Text + "' ";
                dataAccess.UpdateData(i_updateCommand);
            }

            finally
            {
                MetroMessageBox.Show(this, "Cập nhật thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TxtMaKH.Text = "Mã khách hàng";
                TxtHoTen.Text = "Tên khách hàng";
                TxtDiaChi.Text = "Địa chỉ";
                TxtSDT.Text = "Số điện thoại";
                TxtDiem.Text = "Điểm tích lũy";
                TxtNgayTao.Text = "Ngày tạo";
                TxtNamGB.Text = "Năm gắn bó";
                TxtMaHang.Text = "Mã mục hàng";
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string i_deleteCommand =
                "delete from khachhang where MaKH = '" + TxtMaKH.Text + "' ";
                dataAccess.UpdateData(i_deleteCommand);
            }

            finally
            {
                MetroMessageBox.Show(this, "Xóa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TxtMaKH.Text = "Mã khách hàng";
                TxtHoTen.Text = "Tên khách hàng";
                TxtDiaChi.Text = "Địa chỉ";
                TxtSDT.Text = "Số điện thoại";
                TxtDiem.Text = "Điểm tích lũy";
                TxtNgayTao.Text = "Ngày tạo";
                TxtNamGB.Text = "Năm gắn bó";
                TxtMaHang.Text = "Mã mục hàng";
            }
        }

        private void TxtMaKH_Enter(object sender, EventArgs e)
        {
            if (TxtMaKH.Text == "Mã khách hàng")
            {
                TxtMaKH.Text = "";
                TxtMaKH.ForeColor = Color.Black;
            }
        }

        private void TxtMaKH_Leave(object sender, EventArgs e)
        {
            if (TxtMaKH.Text == "")
            {
                TxtMaKH.Text = "Mã khách hàng";
                TxtMaKH.ForeColor = Color.Gray;
            }
        }

        private void TxtHoTen_Enter(object sender, EventArgs e)
        {
            if (TxtHoTen.Text == "Tên khách hàng")
            {
                TxtHoTen.Text = "";
                TxtHoTen.ForeColor = Color.Black;
            }
        }

        private void TxtHoTen_Leave(object sender, EventArgs e)
        {
            if (TxtHoTen.Text == "")
            {
                TxtHoTen.Text = "Tên khách hàng";
                TxtHoTen.ForeColor = Color.Gray;
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

        private void TxtDiem_Enter(object sender, EventArgs e)
        {
            if (TxtDiem.Text == "Điểm tích lũy")
            {
                TxtDiem.Text = "";
                TxtDiem.ForeColor = Color.Black;
            }
        }

        private void TxtDiem_Leave(object sender, EventArgs e)
        {
            if (TxtDiem.Text == "")
            {
                TxtDiem.Text = "Điểm tích lũy";
                TxtDiem.ForeColor = Color.Gray;
            }
        }

        private void TxtNgayTao_Enter(object sender, EventArgs e)
        {
            if (TxtNgayTao.Text == "Ngày tạo")
            {
                TxtNgayTao.Text = "";
                TxtNgayTao.ForeColor = Color.Black;
            }
        }

        private void TxtNgayTao_Leave(object sender, EventArgs e)
        {
            if (TxtNgayTao.Text == "")
            {
                TxtNgayTao.Text = "Ngày tạo";
                TxtNgayTao.ForeColor = Color.Gray;
            }
        }

        private void TxtNamGB_Enter(object sender, EventArgs e)
        {
            if (TxtNamGB.Text == "Năm gắn bó")
            {
                TxtNamGB.Text = "";
                TxtNamGB.ForeColor = Color.Black;
            }
        }

        private void TxtNamGB_Leave(object sender, EventArgs e)
        {
            if (TxtNamGB.Text == "")
            {
                TxtNamGB.Text = "Năm gắn bó";
                TxtNamGB.ForeColor = Color.Gray;
            }
        }

        private void TxtMaHang_Enter(object sender, EventArgs e)
        {
            if (TxtMaHang.Text == "Mã mục hàng")
            {
                TxtMaHang.Text = "";
                TxtMaHang.ForeColor = Color.Black;
            }
        }

        private void TxtMaHang_Leave(object sender, EventArgs e)
        {
            if (TxtMaHang.Text == "")
            {
                TxtMaHang.Text = "Mã mục hàng";
                TxtMaHang.ForeColor = Color.Gray;
            }
        }

        private void TxtTimKiem_Enter(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "Nhập khách hàng cần tìm kiếm")
            {
                TxtTimKiem.Text = "";
                TxtTimKiem.ForeColor = Color.Black;
            }
        }

        private void TxtTimKiem_Leave(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "")
            {
                TxtTimKiem.Text = "Nhập khách hàng cần tìm kiếm";
                TxtTimKiem.ForeColor = Color.Gray;
            }
        }
    }
}
