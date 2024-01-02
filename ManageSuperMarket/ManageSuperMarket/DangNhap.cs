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
    public partial class DangNhap : MetroFramework.Forms.MetroForm
    {

        public static string strConnection = @"Data Source=DESKTOP-KN8R2E4;Initial Catalog=QLST;Integrated Security=True";

        public static SqlConnection objConnection;
        public DangNhap()
        {
            InitializeComponent();
        }

        int x = 0;
        private void TimeWaiting_Tick(object sender, EventArgs e)
        {
            x++;
            if(x == 5)
            {
                TimeWaiting.Stop();
                PtbLoading.Hide();
                PtbBackground.Show();
                GroupBoxDN.Show();
                BtnBack.Show();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            PtbBackground.Hide();
            GroupBoxDN.Hide();
            BtnBack.Hide();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (TxtTenDN.Text == "")
            {
                TxtTenDN.Text = "Nhập tên đăng nhập";
                TxtTenDN.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (TxtTenDN.Text == "Nhập tên đăng nhập")
            {
                TxtTenDN.Text = "";
                TxtTenDN.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (TxtMatKhau.Text == "Nhập mật khẩu")
            {
                TxtMatKhau.Text = "";
                TxtMatKhau.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (TxtMatKhau.Text == "")
            {
                TxtMatKhau.Text = "Nhập mật khẩu";
                TxtMatKhau.ForeColor = Color.Gray;
            }
        }

        private void LblDangKy_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            IntroForm introForm = new IntroForm();
            introForm.Show();
            this.Hide();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            if(TxtMatKhau.Text == "" || TxtTenDN.Text == "")
            {
                MetroMessageBox.Show(this, "Bạn phải nhập đầy đủ thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int a = 0;

                SqlCommand sqlCmd = new SqlCommand();

                sqlCmd = new SqlCommand("Select count(*) from taikhoan where username='" + TxtTenDN.Text.Trim() + "' and password='" + TxtMatKhau.Text.Trim() + "' ", objConnection);
                a = (int)sqlCmd.ExecuteScalar();

                if(a == 0)
                {
                    MetroMessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu sai! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand getIsAdmin = new SqlCommand("Select isAdmin from taikhoan where username= '" + TxtTenDN.Text.Trim() + "' ", objConnection);
                    int getRole = (int)getIsAdmin.ExecuteScalar();

                    if(getRole == 0)
                    {
                        MetroMessageBox.Show(this, "Bạn đăng nhập với quyền ADMIN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        MainAdmin mainAdmin = new MainAdmin();
                        mainAdmin.LblAdmin.Text = GetFullname(0, TxtTenDN.Text.Trim());
                        objConnection.Close();
                        mainAdmin.Show();
                        this.Hide();
                        //show main admin
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Bạn đăng nhập với quyền Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //show nhân viên main
                        BanHang banHang = new BanHang();
                        banHang.LblAdmin.Text = GetFullname(1, TxtTenDN.Text.Trim());
                        banHang.Show();
                        this.Hide();
                    }
                }
            }
        }

        public static string GetFullname(int isAdmin, string username)
        {
            objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            string sqlGetFullname = "Select fullname from taikhoan where isAdmin=" + isAdmin + " and username='" + username + "'";
            SqlCommand getFullname = new SqlCommand(sqlGetFullname, objConnection);
            string Fullname = getFullname.ExecuteScalar().ToString();

            return Fullname;
        }
    }
}
