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
using MetroFramework;

namespace ManageSuperMarket
{
    public partial class BanHang : MetroFramework.Forms.MetroForm
    {
        public BanHang()
        {
            InitializeComponent();
            LoadData();

            DGVThanhToan.ColumnCount = 6;
            DGVThanhToan.Columns[0].Name = "Mã sản phẩm";
            DGVThanhToan.Columns[1].Name = "Tên sản phẩm";
            DGVThanhToan.Columns[2].Name = "Đơn vị tính";
            DGVThanhToan.Columns[3].Name = "Giá bán";
            DGVThanhToan.Columns[4].Name = "Số lượng";
            DGVThanhToan.Columns[5].Name = "Thành tiền";
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            GrBanHang.Hide();
            GrChucNang.Hide();
            TxtTimKiem.Hide();
            DGVSanPham.Hide();
            DGVThanhToan.Hide();
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
                GrBanHang.Show();
                GrChucNang.Show();
                TxtTimKiem.Show();
                DGVSanPham.Show();
                DGVThanhToan.Show();
            }
        }

        DataAccess dataAccess = new DataAccess();
        public int a = 0;
        public int y = 0;

        void LoadData()
        {
            DGVSanPham.DataSource = dataAccess.GetDataTable("Select masp,tensp,donvitinh,solg,giaban from sanpham");

            DGVSanPham.Columns[0].HeaderText = "Mã sản phẩm"; 
            DGVSanPham.Columns[0].Width = 120;
            DGVSanPham.Columns[1].HeaderText = "Tên sản phẩm"; 
            DGVSanPham.Columns[1].Width = 120;
            DGVSanPham.Columns[2].HeaderText = "Đơn vị tính"; 
            DGVSanPham.Columns[4].Width = 120;
            DGVSanPham.Columns[3].HeaderText = "Số lượng";
            DGVSanPham.Columns[3].Width = 120;
            DGVSanPham.Columns[4].HeaderText = "Giá bán"; 
            DGVSanPham.Columns[2].Width = 120;
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "Nhập sản phẩm cần tìm kiếm")
            {
                LoadData();
            }
            else
            {
                DGVSanPham.DataSource = dataAccess.GetDataTable("Select masp,tensp,donvitinh,solg,giaban from sanpham where tensp like N'%" + TxtTimKiem.Text + "%' ");

                DGVSanPham.Columns[0].HeaderText = "Mã sản phẩm"; DGVSanPham.Columns[0].Width = 120;
                DGVSanPham.Columns[1].HeaderText = "Tên sản phẩm"; DGVSanPham.Columns[1].Width = 120;
                DGVSanPham.Columns[2].HeaderText = "Đơn vị tính"; DGVSanPham.Columns[4].Width = 120;
                DGVSanPham.Columns[3].HeaderText = "Số lượng"; DGVSanPham.Columns[3].Width = 120;
                DGVSanPham.Columns[4].HeaderText = "Giá bán"; DGVSanPham.Columns[2].Width = 120;
            }
        }

        private void DGVSanPham_Click(object sender, EventArgs e)
        {
            int id = DGVSanPham.CurrentRow.Index;
            TxtMaSanPham.Text = DGVSanPham.Rows[id].Cells[0].Value.ToString();
            TxtTenSanPham.Text = DGVSanPham.Rows[id].Cells[1].Value.ToString();
            TxtDonViTinh.Text = DGVSanPham.Rows[id].Cells[2].Value.ToString();
            TxtTon.Text = DGVSanPham.Rows[id].Cells[3].Value.ToString();
            TxtGiaNhap.Text = DGVSanPham.Rows[id].Cells[4].Value.ToString();
            TxtNhap.Text = "1";
            TxtChietKhau.Text = "10";

            LblTien.Text = Convert.ToString(Convert.ToInt32(TxtNhap.Text) * Convert.ToInt32(TxtGiaNhap.Text));
        }

        private void DGVThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                BtnThem.Enabled = false;
                TxtNhap.Enabled = false;
                BtnThoat.Enabled = true;
                int curow = DGVThanhToan.CurrentRow.Index;

                TxtMaSanPham.Text = DGVThanhToan.Rows[curow].Cells[0].Value.ToString();
                TxtTenSanPham.Text = DGVThanhToan.Rows[curow].Cells[1].Value.ToString();
                TxtDonViTinh.Text = DGVThanhToan.Rows[curow].Cells[2].Value.ToString();
                TxtGiaNhap.Text = DGVThanhToan.Rows[curow].Cells[3].Value.ToString();
                TxtNhap.Text = DGVThanhToan.Rows[curow].Cells[4].Value.ToString();
                y = int.Parse(TxtNhap.Text);

                string soLuong = "Select solg from sanpham where masp ='" + TxtMaSanPham.Text + "'";
                SqlDataReader sqlReader = dataAccess.ShowText(soLuong);
                while (sqlReader.Read())
                {
                    a = int.Parse(sqlReader[0].ToString());

                }

            }
            catch
            {
                MetroMessageBox.Show(this, "Danh sách lựa chọn trống! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if(TxtMaSanPham.Text == "" || TxtTenSanPham.Text == "" || TxtDonViTinh.Text == "" || TxtGiaNhap.Text == "" || TxtTon.Text == "" || TxtChietKhau.Text == "")
            {
                MetroMessageBox.Show(this, "Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int giaBan = Convert.ToInt32(TxtGiaNhap.Text);
                int soLuongBan = Convert.ToInt32(TxtNhap.Text);
                int soLuongTon = Convert.ToInt32(TxtTon.Text);
                

                if(TxtChietKhau.Text == "")
                {
                    MetroMessageBox.Show(this, "Bạn chưa nhập chiết khấu sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(TxtNhap.Text == "")
                {
                    MetroMessageBox.Show(this, "Bạn chưa nhập số lượng bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (soLuongBan > soLuongTon)
                {
                    MetroMessageBox.Show(this, "Số lượng hàng tồn trong kho không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    int tong = soLuongBan * giaBan;
                    int tongTienSP = tong - tong * Convert.ToInt32(TxtChietKhau.Text) / 100;

                    DGVThanhToan.Rows.Add(TxtMaSanPham.Text, TxtTenSanPham.Text, TxtDonViTinh.Text, TxtGiaNhap.Text, TxtNhap.Text, tongTienSP.ToString());
                    int soLuongCon = soLuongTon - soLuongBan;


                    int n = DGVThanhToan.RowCount;

                    /* DGVThanhToan.Rows[n].Cells[0].Value = TxtMaSanPham.Text;
                    DGVThanhToan.Rows[n].Cells[1].Value = TxtTenSanPham.Text;
                    DGVThanhToan.Rows[n].Cells[2].Value = TxtDonViTinh.Text;
                    DGVThanhToan.Rows[n].Cells[3].Value = TxtGiaNhap.Text;
                    DGVThanhToan.Rows[n].Cells[4].Value = TxtNhap.Text;
                    DGVThanhToan.Rows[n].Cells[5].Value = tongTien.ToString(); */

                    // Update data khi thanh toán button (sửa lại) đổ từ data grid view về database 
                    int maSP = Convert.ToInt32(DGVThanhToan.Rows[n-1].Cells[0].Value.ToString());

                    string updateData = "update sanpham set solg ='" + soLuongCon + "'   where masp ='" + maSP + "' ";
                    dataAccess.UpdateData(updateData);
                    LoadData();


                   /* TxtDonViTinh.Text = "";
                    TxtGiaNhap.Text = "";
                    TxtMaSanPham.Text = "";
                    TxtTenSanPham.Text = "";
                    TxtTon.Text = "";
                    TxtNhap.Text = "1"; */

                 //   LoadData();

                    double thanhTien = 0;

                    for (int i = 0; i < n; i++)
                    {
                        thanhTien += Convert.ToDouble(DGVThanhToan.Rows[i].Cells[5].Value.ToString());
                    }
                    LblTien.Text = thanhTien.ToString();
                }
            }
        }

        private void BtnNhapLai_Click(object sender, EventArgs e)
        {
            TxtDonViTinh.Text = "";
            TxtGiaNhap.Text = "";
            TxtMaSanPham.Text = "";
            TxtTenSanPham.Text = "";
            TxtTon.Text = "";

            TxtNhap.Text = "1";
            BtnThoat.Enabled = false;
            TxtNhap.Enabled = true;
            BtnThem.Enabled = true;
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if(DGVThanhToan.RowCount == 0)
                {
                    MetroMessageBox.Show(this, "Danh sách trống \n Không thể thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DateTime dateTime = System.DateTime.Now;
                    string timeNow = dateTime.ToString();
                    string randomNameFile = timeNow.Replace(" ", "_").Replace("/", "-").Replace(":", "-");

                    double thanhTien = 0;
                    string s = "";
                    int rowCount = DGVThanhToan.Rows.Count;

                    for (int i = 0; i < rowCount - 1; i++)
                    {
                        s += DGVThanhToan.Rows[i].Cells[1].Value.ToString() + " : " + DGVThanhToan.Rows[i].Cells[4].Value.ToString() + ",  ";
                        thanhTien += double.Parse(DGVThanhToan.Rows[i].Cells[5].Value.ToString());
                    }

                    double chietKhau = double.Parse(TxtChietKhau.Text.ToString());
                    double m = thanhTien - thanhTien * (chietKhau / 100);

                    string date = DateTime.Text.Trim();
                    string sqlCommand = "insert into donhang values('" + s.ToString() + "','" + date + "','" + m.ToString() + "',N'" + LblAdmin.Text + "')";

                    dataAccess.UpdateData(sqlCommand);

                    string linkBill = "";

                    ExportExcel.ExportBill(DGVThanhToan, linkBill, randomNameFile, LblTien.Text, "Hóa đơn thanh toán", TxtChietKhau.Text);
                    MetroMessageBox.Show(this, "Thực hiện thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DGVThanhToan.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if(MetroMessageBox.Show(this, "Bạn có chắc chắn muốn thoát bán hàng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                IntroForm introForm = new IntroForm();
                introForm.Show();
                this.Hide();
            }
        }

        private void TxtMaSanPham_Leave(object sender, EventArgs e)
        {
            if (TxtMaSanPham.Text == "")
            {
                TxtMaSanPham.Text = "Mã sản phẩm";
                TxtMaSanPham.ForeColor = Color.Gray;
            }
        }

        private void TxtMaSanPham_Enter(object sender, EventArgs e)
        {
            if (TxtMaSanPham.Text == "Mã sản phẩm")
            {
                TxtMaSanPham.Text = "";
                TxtMaSanPham.ForeColor = Color.Black;
            }
        }

        private void TxtTenSanPham_Enter(object sender, EventArgs e)
        {
            if (TxtTenSanPham.Text == "Tên sản phẩm")
            {
                TxtTenSanPham.Text = "";
                TxtTenSanPham.ForeColor = Color.Black;
            }
        }

        private void TxtTenSanPham_Leave(object sender, EventArgs e)
        {
            if (TxtTenSanPham.Text == "")
            {
                TxtTenSanPham.Text = "Tên sản phẩm";
                TxtTenSanPham.ForeColor = Color.Gray;
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

        private void TxtTon_Enter(object sender, EventArgs e)
        {
            if (TxtTon.Text == "Số lượng tồn")
            {
                TxtTon.Text = "";
                TxtTon.ForeColor = Color.Black;
            }
        }

        private void TxtTon_Leave(object sender, EventArgs e)
        {
            if (TxtTon.Text == "")
            {
                TxtTon.Text = "Số lượng tồn";
                TxtTon.ForeColor = Color.Gray;
            }
        }

        private void TxtNhap_Enter(object sender, EventArgs e)
        {
            if (TxtNhap.Text == "Số lượng bán")
            {
                TxtNhap.Text = "";
                TxtNhap.ForeColor = Color.Black;
            }
        }

        private void TxtNhap_Leave(object sender, EventArgs e)
        {
            if (TxtNhap.Text == "")
            {
                TxtNhap.Text = "Số lượng bán";
                TxtNhap.ForeColor = Color.Gray;
            }
        }

        private void TxtChietKhau_Enter(object sender, EventArgs e)
        {
            if (TxtChietKhau.Text == "Chiết khấu %")
            {
                TxtChietKhau.Text = "";
                TxtChietKhau.ForeColor = Color.Black;
            }
        }

        private void TxtChietKhau_Leave(object sender, EventArgs e)
        {
            if (TxtChietKhau.Text == "")
            {
                TxtChietKhau.Text = "Chiết khấu %";
                TxtChietKhau.ForeColor = Color.Gray;
            }
        }

        private void TxtTimKiem_Enter(object sender, EventArgs e)
        {
            if (TxtChietKhau.Text == "Nhập sản phẩm cần tìm kiếm")
            {
                TxtChietKhau.Text = "";
                TxtChietKhau.ForeColor = Color.Black;
            }
        }

        private void TxtTimKiem_Leave(object sender, EventArgs e)
        {
            if (TxtChietKhau.Text == "")
            {
                TxtChietKhau.Text = "Nhập sản phẩm cần tìm kiếm";
                TxtChietKhau.ForeColor = Color.Gray;
            }
        }

    }
}
