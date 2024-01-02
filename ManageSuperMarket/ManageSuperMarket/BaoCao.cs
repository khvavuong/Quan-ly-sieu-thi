using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSuperMarket
{
    public partial class BaoCao : MetroFramework.Forms.MetroForm
    {
        public static string strConnection = @"Data Source=DESKTOP-KN8R2E4;Initial Catalog=QLST;Integrated Security=True";
        public static SqlConnection objConnection;
        public BaoCao()
        {
            InitializeComponent();
            objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            string i_commandDoanhThu = "select sum(thanhtien) from donhang";
            SqlCommand sqlCommandDT = new SqlCommand(i_commandDoanhThu, objConnection);
            int doanhThu = (int)sqlCommandDT.ExecuteScalar();
            BtnDoanhThu.Text = doanhThu.ToString();

            string i_commandNhanVien = "select count(MaNV) from nhanvien";
            SqlCommand sqlCommandNV = new SqlCommand(i_commandNhanVien, objConnection);
            int nhanVien = (int)sqlCommandNV.ExecuteScalar();
            BtnNhanVien.Text = nhanVien.ToString();

            string i_commandKhachHang = "select count(MaKH) from khachhang";
            SqlCommand sqlCommandKH = new SqlCommand(i_commandKhachHang, objConnection);
            int khachHang = (int)sqlCommandNV.ExecuteScalar();
            BtnKhachHang.Text = khachHang.ToString();

            string i_commandKho = "select count(masp) from sanpham";
            SqlCommand sqlCommandKho = new SqlCommand(i_commandKho, objConnection);
            int kho = (int)sqlCommandKho.ExecuteScalar();
            BtnKho.Text = kho.ToString();

            string i_commandHoaDon = "select count(maphieu) from donhang";
            SqlCommand sqlCommandHD = new SqlCommand(i_commandHoaDon, objConnection);
            int hoaDon = (int)sqlCommandHD.ExecuteScalar();
            BtnHoaDon.Text = hoaDon.ToString();

            string i_commandUser = "select count(username) from taikhoan";
            SqlCommand sqlCommandUser = new SqlCommand(i_commandUser, objConnection);
            int user = (int)sqlCommandUser.ExecuteScalar();
            BtnNguoiDung.Text = user.ToString();

            objConnection.Close();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            GrBaoCao.Hide();
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
                GrBaoCao.Show();
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Bạn có chắc chắn muốn thoát quản lý báo cáo?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                MainAdmin mainAdmin = new MainAdmin();
                mainAdmin.Show();
                this.Hide();
            }
        }
    }
}
