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
    public partial class SanPham : MetroFramework.Forms.MetroForm
    {
        public SanPham()
        {
            InitializeComponent();
            LoadData();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            GrSanPham.Hide();
            GrChucNang.Hide();
            DGVSanPham.Hide();
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
                GrSanPham.Show();
                GrChucNang.Show();
                TxtTimKiem.Show();
                DGVSanPham.Show();
            }
        }

        private DataAccess dataAccess = new DataAccess();
        void LoadData()
        {
            DGVSanPham.DataSource = dataAccess.GetDataTable("select * from sanpham");

            DGVSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            DGVSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            DGVSanPham.Columns[2].HeaderText = "Mã nhà cung cấp";
            DGVSanPham.Columns[3].HeaderText = "Giá nhập";
            DGVSanPham.Columns[4].HeaderText = "Giá bán";
            DGVSanPham.Columns[5].HeaderText = "Số lượng";
            DGVSanPham.Columns[6].HeaderText = "Hạn sử dụng";
            DGVSanPham.Columns[7].HeaderText = "Nơi sản xuất";
            DGVSanPham.Columns[8].HeaderText = "Đơn vị tính";
            DGVSanPham.Columns[9].HeaderText = "Người nhập hàng";
        }

        private void DGVSanPham_Click(object sender, EventArgs e)
        {
            int id = DGVSanPham.CurrentRow.Index;
            TxtMaSP.Text = DGVSanPham.Rows[id].Cells[0].Value.ToString();
            TxtTenSP.Text = DGVSanPham.Rows[id].Cells[1].Value.ToString();
            TxtNCC.Text = DGVSanPham.Rows[id].Cells[2].Value.ToString();
            TxtGiaNhap.Text = DGVSanPham.Rows[id].Cells[3].Value.ToString();
            TxtGiaBan.Text = DGVSanPham.Rows[id].Cells[4].Value.ToString();
            TxtSoLuong.Text = DGVSanPham.Rows[id].Cells[5].Value.ToString();
            TxtHSD.Text = DGVSanPham.Rows[id].Cells[6].Value.ToString();
            TxtNoiSX.Text = DGVSanPham.Rows[id].Cells[7].Value.ToString();
            TxtDonViTinh.Text = DGVSanPham.Rows[id].Cells[8].Value.ToString();
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(TxtTimKiem.Text == "Nhập sản phẩm cần tìm kiếm")
            {
                LoadData();
            }
            else
            {
                DGVSanPham.DataSource = dataAccess.GetDataTable("Select * from sanpham  where tensp like N'%" + TxtTimKiem.Text + "%'");

                DGVSanPham.Columns[0].HeaderText = "Mã sản phẩm";
                DGVSanPham.Columns[1].HeaderText = "Tên sản phẩm";
                DGVSanPham.Columns[2].HeaderText = "Mã nhà cung cấp";
                DGVSanPham.Columns[3].HeaderText = "Giá nhập";
                DGVSanPham.Columns[4].HeaderText = "Giá bán";
                DGVSanPham.Columns[5].HeaderText = "Số lượng";
                DGVSanPham.Columns[6].HeaderText = "Hạn sử dụng";
                DGVSanPham.Columns[7].HeaderText = "Nơi sản xuất";
                DGVSanPham.Columns[8].HeaderText = "Đơn vị tính";
                DGVSanPham.Columns[9].HeaderText = "Người nhập hàng";
            }
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Bạn có chắc chắn muốn thoát kho hàng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
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
                "insert into sanpham values (N'" + TxtTenSP.Text + "'," + " '" + TxtNCC.Text + "'" + ", " + " '" + TxtGiaNhap.Text + "'" + ", " + " '" + TxtGiaBan.Text + "'" + "," + " '" + TxtSoLuong.Text + "'" + ", " + " '" + TxtHSD.Text + "'" + ", " + " N'" + TxtNoiSX.Text + "'" + "," + " N'" + TxtDonViTinh.Text + "'" + "," + " N'" + LblAdmin.Text + "'" + ")";
                dataAccess.UpdateData(i_insertCommand);
            }
            finally
            {
                MetroMessageBox.Show(this, "Thêm sản phẩm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TxtMaSP.Text = "Mã sản phẩm";
                TxtTenSP.Text = "Tên sản phẩm";
                TxtNCC.Text = "Mã nhà cung cấp";
                TxtGiaNhap.Text = "Giá nhập";
                TxtGiaBan.Text = "Giá bán";
                TxtDonViTinh.Text = "Đơn vị tính";
                TxtHSD.Text = "Hạn sử dụng";
                TxtNoiSX.Text = "Nơi sản xuất";
            }
        }
        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string i_updateCommand =
                "update sanpham set tensp = '" + TxtTenSP.Text + "',mancc = '" + TxtNCC.Text + "', gianhap = '" + TxtGiaNhap.Text + "', giaban = '" + TxtGiaBan.Text + "',solg = '" + TxtSoLuong.Text + "', hsd = '" + TxtHSD.Text + "', noisx = '" + TxtNoiSX.Text + "', donvitinh = '" + TxtDonViTinh.Text + "', nguoinhap = '" + LblAdmin.Text + "' where masp = '" + TxtMaSP.Text + "' ";
                dataAccess.UpdateData(i_updateCommand);
            }

            finally
            {
                MetroMessageBox.Show(this, "Cập nhật thông tin sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TxtMaSP.Text = "Mã sản phẩm";
                TxtTenSP.Text = "Tên sản phẩm";
                TxtNCC.Text = "Mã nhà cung cấp";
                TxtGiaNhap.Text = "Giá nhập";
                TxtGiaBan.Text = "Giá bán";
                TxtDonViTinh.Text = "Đơn vị tính";
                TxtHSD.Text = "Hạn sử dụng";
                TxtNoiSX.Text = "Nơi sản xuất";
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string i_deleteCommand =
                "delete from sanpham where masp = '" + TxtMaSP.Text + "' ";
                dataAccess.UpdateData(i_deleteCommand);
            }

            finally
            {
                MetroMessageBox.Show(this, "Xóa thông tin sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TxtMaSP.Text = "Mã sản phẩm";
                TxtTenSP.Text = "Tên sản phẩm";
                TxtNCC.Text = "Mã nhà cung cấp";
                TxtGiaNhap.Text = "Giá nhập";
                TxtGiaBan.Text = "Giá bán";
                TxtDonViTinh.Text = "Đơn vị tính";
                TxtHSD.Text = "Hạn sử dụng";
                TxtNoiSX.Text = "Nơi sản xuất";
            }
        }
        private void TxtMaSP_Enter(object sender, EventArgs e)
        {
            if (TxtMaSP.Text == "Mã sản phẩm")
            {
                TxtMaSP.Text = "";
                TxtMaSP.ForeColor = Color.Black;
            }
        }

        private void TxtMaSP_Leave(object sender, EventArgs e)
        {
            if (TxtMaSP.Text == "")
            {
                TxtMaSP.Text = "Mã sản phẩm";
                TxtMaSP.ForeColor = Color.Gray;
            }
        }

        private void TxtTenSP_Enter(object sender, EventArgs e)
        {
            if (TxtTenSP.Text == "Tên sản phẩm")
            {
                TxtTenSP.Text = "";
                TxtTenSP.ForeColor = Color.Black;
            }
        }

        private void TxtTenSP_Leave(object sender, EventArgs e)
        {
            if (TxtTenSP.Text == "")
            {
                TxtTenSP.Text = "Tên sản phẩm";
                TxtTenSP.ForeColor = Color.Gray;
            }
        }

        private void TxtNCC_Enter(object sender, EventArgs e)
        {
            if (TxtNCC.Text == "Mã nhà cung cấp")
            {
                TxtNCC.Text = "";
                TxtNCC.ForeColor = Color.Black;
            }
        }

        private void TxtNCC_Leave(object sender, EventArgs e)
        {
            if (TxtNCC.Text == "")
            {
                TxtNCC.Text = "Mã nhà cung cấp";
                TxtNCC.ForeColor = Color.Gray;
            }
        }
        private void TxtGiaNhap_Enter(object sender, EventArgs e)
        {
            if (TxtGiaNhap.Text == "Giá nhập")
            {
                TxtGiaNhap.Text = "";
                TxtGiaNhap.ForeColor = Color.Black;
            }
        }

        private void TxtGiaNhap_Leave(object sender, EventArgs e)
        {
            if (TxtGiaNhap.Text == "")
            {
                TxtGiaNhap.Text = "Giá nhập";
                TxtGiaNhap.ForeColor = Color.Gray;
            }
        }

        private void TxtGiaBan_Enter(object sender, EventArgs e)
        {
            if (TxtGiaBan.Text == "Giá bán")
            {
                TxtGiaBan.Text = "";
                TxtGiaBan.ForeColor = Color.Black;
            }
        }

        private void TxtGiaBan_Leave(object sender, EventArgs e)
        {
            if (TxtGiaBan.Text == "")
            {
                TxtGiaBan.Text = "Giá bán";
                TxtGiaBan.ForeColor = Color.Gray;
            }
        }

        private void TxtSoLuong_Enter(object sender, EventArgs e)
        {
            if (TxtSoLuong.Text == "Số lượng tồn")
            {
                TxtSoLuong.Text = "";
                TxtSoLuong.ForeColor = Color.Black;
            }
        }

        private void TxtSoLuong_Leave(object sender, EventArgs e)
        {
            if (TxtSoLuong.Text == "")
            {
                TxtSoLuong.Text = "Số lượng tồn";
                TxtSoLuong.ForeColor = Color.Gray;
            }
        }
        private void TxtHSD_Enter(object sender, EventArgs e)
        {
            if (TxtHSD.Text == "Hạn sử dụng")
            {
                TxtHSD.Text = "";
                TxtHSD.ForeColor = Color.Black;
            }
        }

        private void TxtHSD_Leave(object sender, EventArgs e)
        {
            if (TxtHSD.Text == "")
            {
                TxtHSD.Text = "Hạn sử dụng";
                TxtHSD.ForeColor = Color.Gray;
            }
        }

        private void TxtNoiSX_Enter(object sender, EventArgs e)
        {
            if (TxtNoiSX.Text == "Nơi sản xuất")
            {
                TxtNoiSX.Text = "";
                TxtNoiSX.ForeColor = Color.Black;
            }
        }

        private void TxtNoiSX_Leave(object sender, EventArgs e)
        {
            if(TxtNoiSX.Text == "")
            {
                TxtNoiSX.Text = "Nơi sản xuất";
                TxtNoiSX.ForeColor= Color.Gray;
            }
        }

        private void TxtDonViTinh_Enter(object sender, EventArgs e)
        {
            if (TxtDonViTinh.Text == "Đơn vị tính")
            {
                TxtDonViTinh.Text = "";
                TxtDonViTinh.ForeColor = Color.Black;
            }
        }

        private void TxtDonViTinh_Leave(object sender, EventArgs e)
        {
            if (TxtDonViTinh.Text == "")
            {
                TxtDonViTinh.Text = "Đơn vị tính";
                TxtDonViTinh.ForeColor = Color.Gray;
            }
        }

        private void TxtTimKiem_Enter(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "Nhập sản phẩm cần tìm kiếm")
            {
                TxtTimKiem.Text = "";
                TxtTimKiem.ForeColor = Color.Black;
            }
        }

        private void TxtTimKiem_Leave(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "")
            {
                TxtTimKiem.Text = "Nhập sản phẩm cần tìm kiếm";
                TxtTimKiem.ForeColor = Color.Gray;
            }
        }
    }
}
