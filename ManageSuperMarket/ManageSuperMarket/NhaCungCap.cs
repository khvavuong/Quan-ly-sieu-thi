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
    public partial class NhaCungCap : MetroFramework.Forms.MetroForm
    {
        public NhaCungCap()
        {
            InitializeComponent();
            LoadData();
        }

        int x=0;
        private void TimeWaiting_Tick(object sender, EventArgs e)
        {
            x++;
            if (x == 5)
            {
                TimeWaiting.Stop();
                PtbLoading.Hide();
                GrNCC.Show();
                GrChucNang.Show();
                TxtTimKiem.Show();
                DGVNCC.Show();
            }
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            GrNCC.Hide();
            GrChucNang.Hide();
            TxtTimKiem.Hide();
            DGVNCC.Hide();
            PtbLoading.Show();
        }

        private DataAccess dataAccess = new DataAccess();
        void LoadData()
        {
            DGVNCC.DataSource = dataAccess.GetDataTable("select * from nhacungcap");

            DGVNCC.Columns[0].HeaderText = "Mã nhà cung cấp";
            DGVNCC.Columns[1].HeaderText = "Tên nhà cung cấp";
            DGVNCC.Columns[2].HeaderText = "Địa chỉ";
            DGVNCC.Columns[3].HeaderText = "Số điện thoại";
            DGVNCC.Columns[4].HeaderText = "Công nợ";
        }
        private void DGVNCC_Click(object sender, EventArgs e)
        {
            int id = DGVNCC.CurrentRow.Index;
            TxtMaNCC.Text = DGVNCC.Rows[id].Cells[0].Value.ToString();
            TxtTenNCC.Text = DGVNCC.Rows[id].Cells[1].Value.ToString();
            TxtDiaChi.Text = DGVNCC.Rows[id].Cells[2].Value.ToString();
            TxtSDT.Text = DGVNCC.Rows[id].Cells[3].Value.ToString();
            TxtCongNo.Text = DGVNCC.Rows[id].Cells[4].Value.ToString();
        }
        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "Nhập nhà cung cấp cần tìm kiếm")
            {
                LoadData();
            }
            else
            {
                DGVNCC.DataSource = dataAccess.GetDataTable("Select * from nhacungcap  where tenNCC like N'%" + TxtTimKiem.Text + "%'");

                DGVNCC.Columns[0].HeaderText = "Mã nhà cung cấp";
                DGVNCC.Columns[1].HeaderText = "Tên nhà cung cấp";
                DGVNCC.Columns[2].HeaderText = "Địa chỉ";
                DGVNCC.Columns[3].HeaderText = "Số điện thoại";
                DGVNCC.Columns[4].HeaderText = "Công nợ";
            }
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Bạn có chắc chắn muốn thoát quản lý nhà cung cấp?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
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
                "insert into nhacungcap values ('" + TxtMaNCC.Text + "'," + " '" + TxtTenNCC.Text + "'" + ", " + " '" + TxtDiaChi.Text + "'" + ", " + " '" + TxtSDT.Text + "'" + "," + " '" + TxtCongNo.Text + "'" + ")";
                dataAccess.UpdateData(i_insertCommand);
            }
            finally
            {
                MetroMessageBox.Show(this, "Thêm nhà cung cấp mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TxtMaNCC.Text = "Mã nhà cung cấp";
                TxtTenNCC.Text = "Tên nhà cung cấp";
                TxtDiaChi.Text = "Địa chỉ";
                TxtSDT.Text = "Số điện thoại";
                TxtCongNo.Text = "Công nợ";
            }
        }
        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string i_updateCommand =
                "update nhacungcap set MaNCC = '" + TxtMaNCC.Text + "', TenNCC = '" + TxtTenNCC.Text + "', DiaChi = '" + TxtDiaChi.Text + "',SDT = '" + TxtSDT.Text + "', CongNo = '" + TxtCongNo.Text + "' ";
                dataAccess.UpdateData(i_updateCommand);
            }

            finally
            {
                MetroMessageBox.Show(this, "Cập nhật thông tin nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TxtMaNCC.Text = "Mã nhà cung cấp";
                TxtTenNCC.Text = "Tên nhà cung cấp";
                TxtDiaChi.Text = "Địa chỉ";
                TxtSDT.Text = "Số điện thoại";
                TxtCongNo.Text = "Công nợ";
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string i_deleteCommand =
                "delete from nhacungcap where MaNCC = '" + TxtMaNCC.Text + "' ";
                dataAccess.UpdateData(i_deleteCommand);
            }

            finally
            {
                MetroMessageBox.Show(this, "Xóa thông tin nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TxtMaNCC.Text = "Mã nhà cung cấp";
                TxtTenNCC.Text = "Tên nhà cung cấp";
                TxtDiaChi.Text = "Địa chỉ";
                TxtSDT.Text = "Số điện thoại";
                TxtCongNo.Text = "Công nợ";
            }
        }
        private void TxtMaNCC_Enter(object sender, EventArgs e)
        {
            if (TxtMaNCC.Text == "Mã nhà cung cấp")
            {
                TxtMaNCC.Text = "";
                TxtMaNCC.ForeColor = Color.Black;
            }
        }

        private void TxtMaNCC_Leave(object sender, EventArgs e)
        {
            if (TxtMaNCC.Text == "")
            {
                TxtMaNCC.Text = "Mã nhà cung cấp";
                TxtMaNCC.ForeColor = Color.Gray;
            }
        }
        private void TxtTenNCC_Enter(object sender, EventArgs e)
        {
            if (TxtTenNCC.Text == "Tên nhà cung cấp")
            {
                TxtTenNCC.Text = "";
                TxtTenNCC.ForeColor = Color.Black;
            }
        }

        private void TxtTenNCC_Leave(object sender, EventArgs e)
        {
            if (TxtTenNCC.Text == "")
            {
                TxtTenNCC.Text = "Tên nhà cung cấp";
                TxtTenNCC.ForeColor = Color.Gray;
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
            if(TxtSDT.Text == "Số điện thoại")
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
        private void TxtCongNo_Enter(object sender, EventArgs e)
        {
            if (TxtCongNo.Text == "Công nợ")
            {
                TxtCongNo.Text = "";
                TxtCongNo.ForeColor = Color.Black;
            }
        }

        private void TxtCongNo_Leave(object sender, EventArgs e)
        {
            if (TxtCongNo.Text == "")
            {
                TxtCongNo.Text = "Công nợ";
                TxtCongNo.ForeColor = Color.Gray;
            }
        }

        private void TxtTimKiem_Enter(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "Nhập nhà cung cấp cần tìm kiếm")
            {
                TxtTimKiem.Text = "";
                TxtTimKiem.ForeColor = Color.Black;
            }
        }

        private void TxtTimKiem_Leave(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "")
            {
                TxtTimKiem.Text = "Nhập nhà cung cấp cần tìm kiếm";
                TxtTimKiem.ForeColor = Color.Gray;
            }
        }
    }
}
