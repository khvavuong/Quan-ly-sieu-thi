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
    public partial class HoaDon : MetroFramework.Forms.MetroForm
    {
        public HoaDon()
        {
            InitializeComponent();
            LoadData();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            GrHoaDon.Hide();
            DGVHoaDon.Hide();
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
                GrHoaDon.Show();
                TxtTimKiem.Show();
                DGVHoaDon.Show();
            }
        }
        private DataAccess dataAccess = new DataAccess();
        void LoadData()
        {
            DGVHoaDon.DataSource = dataAccess.GetDataTable("select * from donhang");

            DGVHoaDon.Columns[0].HeaderText = "Mã phiếu xuất";
            DGVHoaDon.Columns[1].HeaderText = "Tên sản phẩm";
            DGVHoaDon.Columns[2].HeaderText = "Ngày xuất hóa đơn";
            DGVHoaDon.Columns[3].HeaderText = "Tổng tiền thanh toán";
            DGVHoaDon.Columns[4].HeaderText = "Nhân viên xuất hóa đơn";
        }
        private void DGVHoaDon_Click(object sender, EventArgs e)
        {
            int id = DGVHoaDon.CurrentRow.Index;
            TxtMaPhieu.Text = DGVHoaDon.Rows[id].Cells[0].Value.ToString();
            TxtTenSP.Text = DGVHoaDon.Rows[id].Cells[1].Value.ToString();
            TxtNgayBan.Text = DGVHoaDon.Rows[id].Cells[2].Value.ToString();
            TxtTong.Text = DGVHoaDon.Rows[id].Cells[3].Value.ToString();
            TxtNhanVien.Text = DGVHoaDon.Rows[id].Cells[4].Value.ToString();
        }
        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "Nhập mã hóa đơn cần tìm kiếm")
            {
                LoadData();
            }
            else
            {
                DGVHoaDon.DataSource = dataAccess.GetDataTable("Select * from donhang  where maphieu like N'%" + TxtTimKiem.Text + "%'");

                DGVHoaDon.Columns[0].HeaderText = "Mã phiếu xuất";
                DGVHoaDon.Columns[1].HeaderText = "Tên sản phẩm";
                DGVHoaDon.Columns[2].HeaderText = "Ngày xuất hóa đơn";
                DGVHoaDon.Columns[3].HeaderText = "Tổng tiền thanh toán";
                DGVHoaDon.Columns[4].HeaderText = "Nhân viên xuất hóa đơn";
            }
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Bạn có chắc chắn muốn thoát quản lý hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                MainAdmin mainAdmin = new MainAdmin();
                mainAdmin.Show();
                this.Hide();
            }
        }
        private void TxtMaPhieu_Leave(object sender, EventArgs e)
        {
            if (TxtMaPhieu.Text == "")
            {
                TxtMaPhieu.Text = "Mã phiếu xuất";
                TxtMaPhieu.ForeColor = Color.Gray;
            }
        }

        private void TxtMaPhieu_Enter(object sender, EventArgs e)
        {
            if (TxtMaPhieu.Text == "Mã phiếu xuất")
            {
                TxtMaPhieu.Text = "";
                TxtMaPhieu.ForeColor = Color.Black;
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

        private void TxtTenSP_Enter(object sender, EventArgs e)
        {
            if (TxtTenSP.Text == "Tên sản phẩm")
            {
                TxtTenSP.Text = "";
                TxtTenSP.ForeColor = Color.Black;
            }
        }

        private void TxtNgayBan_Leave(object sender, EventArgs e)
        {
            if (TxtNgayBan.Text == "")
            {
                TxtNgayBan.Text = "Ngày xuất hóa đơn";
                TxtNgayBan.ForeColor = Color.Gray;
            }
        }
        private void TxtNgayBan_Enter(object sender, EventArgs e)
        {
            if (TxtNgayBan.Text == "Ngày xuất hóa đơn")
            {
                TxtNgayBan.Text = "";
                TxtNgayBan.ForeColor = Color.Black;
            }
        }

        private void TxtTong_Leave(object sender, EventArgs e)
        {
            if (TxtTong.Text == "")
            {
                TxtTong.Text = "Tổng tiền thanh toán";
                TxtTong.ForeColor = Color.Gray;
            }
        }

        private void TxtTong_Enter(object sender, EventArgs e)
        {
            if (TxtTong.Text == "Tổng tiền thanh toán")
            {
                TxtTong.Text = "";
                TxtTong.ForeColor = Color.Black;
            }
        }

        private void TxtNhanVien_Leave(object sender, EventArgs e)
        {
            if (TxtNhanVien.Text == "")
            {
                TxtNhanVien.Text = "Nhân viên xuất hóa đơn";
                TxtNhanVien.ForeColor = Color.Gray;
            }
        }

        private void TxtNhanVien_Enter(object sender, EventArgs e)
        {
            if (TxtNhanVien.Text == "Nhân viên xuất hóa đơn")
            {
                TxtNhanVien.Text = "";
                TxtNhanVien.ForeColor = Color.Black;
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
