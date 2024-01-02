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
    public partial class DangKy : MetroFramework.Forms.MetroForm
    {
        public static string strConnection = @"Data Source=DESKTOP-KN8R2E4;Initial Catalog=QLST;Integrated Security=True";
        public static SqlConnection objConnection = new SqlConnection(strConnection);

        DataAccess dataAccess = new DataAccess();
        public DangKy()
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
                PtbBackground.Show();
                GroupBoxDK.Show();
                BtnBack.Show();
            }
        }
        private void DangKy_Load(object sender, EventArgs e)
        {
            PtbBackground.Hide();
            GroupBoxDK.Hide();
            BtnBack.Hide();
        }
        private void TxtHoTen_Enter(object sender, EventArgs e)
        {
            if (TxtHoTen.Text == "Nhập họ và tên")
            {
                TxtHoTen.Text = "";
                TxtHoTen.ForeColor = Color.Black;
            }
        }

        private void TxtHoTen_Leave(object sender, EventArgs e)
        {
            if (TxtHoTen.Text == "")
            {
                TxtHoTen.Text = "Nhập họ và tên";
                TxtHoTen.ForeColor = Color.Gray;
            }
        }

        private void TxtTenDN_Enter(object sender, EventArgs e)
        {
            if (TxtTenDN.Text == "Nhập tên đăng nhập")
            {
                TxtTenDN.Text = "";
                TxtTenDN.ForeColor = Color.Black;
            }
        }

        private void TxtTenDN_Leave(object sender, EventArgs e)
        {
            if (TxtTenDN.Text == "")
            {
                TxtTenDN.Text = "Nhập tên đăng nhập";
                TxtTenDN.ForeColor = Color.Gray;
            }
        }

        private void TxtMatKhau_Enter(object sender, EventArgs e)
        {
            if (TxtMatKhau.Text == "Nhập mật khẩu")
            {
                TxtMatKhau.Text = "";
                TxtMatKhau.ForeColor = Color.Black;
            }
        }

        private void TxtMatKhau_Leave(object sender, EventArgs e)
        {
            if (TxtMatKhau.Text == "")
            {
                TxtMatKhau.Text = "Nhập mật khẩu";
                TxtMatKhau.ForeColor = Color.Gray;
            }
        }

        private void TxtReMatKhau_Enter(object sender, EventArgs e)
        {
            if (TxtReMatKhau.Text == "Nhập lại mật khẩu")
            {
                TxtReMatKhau.Text = "";
                TxtReMatKhau.ForeColor = Color.Black;
            }
        }

        private void TxtReMatKhau_Leave(object sender, EventArgs e)
        {
            if (TxtReMatKhau.Text == "")
            {
                TxtReMatKhau.Text = "Nhập lại mật khẩu";
                TxtReMatKhau.ForeColor = Color.Gray;
            }
        }

        private void LblDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            IntroForm introForm = new IntroForm();
            introForm.Show();
            this.Hide();
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            string hoVaTen = TxtHoTen.Text.ToString().Trim();
            string matKhau = TxtMatKhau.Text.ToString().Trim();
            string reMatKhau = TxtReMatKhau.Text.ToString().Trim();
            string tenDangNhap = TxtTenDN.Text.ToString().Trim();
            string isAdmin = CBChucVu.SelectedIndex.ToString();

            string i_boolCmdAccount = "select count(*) from taikhoan where username = '" + tenDangNhap + "'";
            string i_insertCmdAccount = "insert into taikhoan (username,password,fullname,isAdmin) values('" + tenDangNhap + "','" + matKhau + "','" + hoVaTen + "','" + isAdmin + "')";

            if (hoVaTen == "" || tenDangNhap == "" || matKhau.ToString().Trim() == "" || reMatKhau.ToString().Trim() == "")
            {
                MetroMessageBox.Show(this, "Bạn phải nhập đầy đủ thông tin đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(matKhau != reMatKhau)
                {
                    MetroMessageBox.Show(this, "Mật khẩu phải trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(matKhau.Length < 6)
                    {
                        MetroMessageBox.Show(this, "Mật khẩu phải dài hơn 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        dataAccess.InsertAccount(i_boolCmdAccount, i_insertCmdAccount);
                    }
                }
            }
        }
    }
}
