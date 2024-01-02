using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace ManageSuperMarket
{
    public partial class MainAdmin : MetroFramework.Forms.MetroForm
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        int x = 0;

        private void TimeWaiting_Tick(object sender, EventArgs e)
        {
            x++;
            if (x == 5)
            {
                TimeWaiting.Stop();
                PtbLoading.Hide();
                TabControl.Show();
            }
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {
            TabControl.Hide();
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            IntroForm introForm = new IntroForm();
            introForm.Show();
            this.Hide();
        }

        private void BtnBanHang_Click(object sender, EventArgs e)
        {
            BanHang banHang = new BanHang();
            MetroMessageBox.Show(this, "Truy cập bán hàng siêu thị\n Nhân viên: "+ LblAdmin.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            banHang.LblAdmin.Text = LblAdmin.Text;
            banHang.Show();
            this.Hide();
        }

        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            MetroMessageBox.Show(this, "Truy cập quản lý nhân viên siêu thị\n Nhân viên: " + LblAdmin.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nhanVien.LblAdmin.Text = LblAdmin.Text;
            nhanVien.Show();
            this.Hide();
        }

        private void BtnKho_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            MetroMessageBox.Show(this, "Truy cập kho sản phẩm siêu thị\n Nhân viên: " + LblAdmin.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sanPham.LblAdmin.Text = LblAdmin.Text;
            sanPham.Show();
            this.Hide();
        }

        private void BtnHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            MetroMessageBox.Show(this, "Truy cập quản lý hóa đơn siêu thị\n Nhân viên: " + LblAdmin.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hoaDon.LblAdmin.Text = LblAdmin.Text;
            hoaDon.Show();
            this.Hide();
        }

        private void BtnBaoCao_Click(object sender, EventArgs e)
        {
            BaoCao baoCao = new BaoCao();
            MetroMessageBox.Show(this, "Truy cập quản lý báo cáo siêu thị\n Nhân viên: " + LblAdmin.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baoCao.LblAdmin.Text = LblAdmin.Text;
            baoCao.Show();
            this.Hide();
        }

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            MetroMessageBox.Show(this, "Truy cập quản lý hóa đơn siêu thị\n Nhân viên: " + LblAdmin.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            khachHang.LblAdmin.Text = LblAdmin.Text;
            khachHang.Show();
            this.Hide();
        }

        private void BtnNCC_Click(object sender, EventArgs e)
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            MetroMessageBox.Show(this, "Truy cập quản lý nhà cung cấp siêu thị\n Nhân viên: " + LblAdmin.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nhaCungCap.LblAdmin.Text = LblAdmin.Text;
            nhaCungCap.Show();
            this.Hide();
        }
    }
}
