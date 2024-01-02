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
    public partial class IntroForm : MetroFramework.Forms.MetroForm
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        public int i = -1;
        public int j = 3;

        private void CoutDownTime_Tick(object sender, EventArgs e)
        {
            LblLeft.Location = new Point(LblLeft.Location.X - j, LblLeft.Location.Y);
            LblRight.Location = new Point(LblRight.Location.X + j, LblRight.Location.Y);
            if (LblLeft.Location.X <= -100) PtbLogo.Visible = true;
        }

        private void TimerCout_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.02;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if(MetroMessageBox.Show(this, "Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.Show();
            this.Hide();
        }
    }
}
