namespace ManageSuperMarket
{
    partial class BaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCao));
            this.PtbLoading = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.BtnThoat = new Guna.UI.WinForms.GunaButton();
            this.TimeWaiting = new System.Windows.Forms.Timer(this.components);
            this.LblAdmin = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.DateTimeNow = new MetroFramework.Controls.MetroDateTime();
            this.GrBaoCao = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.BtnHoaDon = new Guna.UI.WinForms.GunaTileButton();
            this.BtnKho = new Guna.UI.WinForms.GunaTileButton();
            this.BtnNguoiDung = new Guna.UI.WinForms.GunaTileButton();
            this.BtnDoanhThu = new Guna.UI.WinForms.GunaTileButton();
            this.BtnNhanVien = new Guna.UI.WinForms.GunaTileButton();
            this.BtnKhachHang = new Guna.UI.WinForms.GunaTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.GrBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // PtbLoading
            // 
            this.PtbLoading.BackColor = System.Drawing.Color.Transparent;
            this.PtbLoading.BaseColor = System.Drawing.Color.Black;
            this.PtbLoading.Image = ((System.Drawing.Image)(resources.GetObject("PtbLoading.Image")));
            this.PtbLoading.Location = new System.Drawing.Point(335, 45);
            this.PtbLoading.Name = "PtbLoading";
            this.PtbLoading.Size = new System.Drawing.Size(500, 504);
            this.PtbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLoading.TabIndex = 69;
            this.PtbLoading.TabStop = false;
            // 
            // BtnThoat
            // 
            this.BtnThoat.AnimationHoverSpeed = 0.07F;
            this.BtnThoat.AnimationSpeed = 0.03F;
            this.BtnThoat.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtnThoat.BorderColor = System.Drawing.Color.Black;
            this.BtnThoat.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThoat.ForeColor = System.Drawing.Color.White;
            this.BtnThoat.Image = ((System.Drawing.Image)(resources.GetObject("BtnThoat.Image")));
            this.BtnThoat.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnThoat.Location = new System.Drawing.Point(928, 545);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnThoat.OnHoverImage = null;
            this.BtnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.BtnThoat.Size = new System.Drawing.Size(160, 42);
            this.BtnThoat.TabIndex = 2;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // TimeWaiting
            // 
            this.TimeWaiting.Enabled = true;
            this.TimeWaiting.Interval = 1000;
            this.TimeWaiting.Tick += new System.EventHandler(this.TimeWaiting_Tick);
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.Location = new System.Drawing.Point(954, 30);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(160, 28);
            this.LblAdmin.TabIndex = 63;
            this.LblAdmin.Text = "Khuất Văn Vương";
            this.LblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(846, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel1.TabIndex = 62;
            this.gunaLabel1.Text = "Nhân viên:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(276, 26);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(37, 34);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 65;
            this.gunaPictureBox1.TabStop = false;
            // 
            // DateTimeNow
            // 
            this.DateTimeNow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeNow.Location = new System.Drawing.Point(12, 43);
            this.DateTimeNow.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateTimeNow.Name = "DateTimeNow";
            this.DateTimeNow.Size = new System.Drawing.Size(355, 31);
            this.DateTimeNow.TabIndex = 0;
            // 
            // GrBaoCao
            // 
            this.GrBaoCao.BaseColor = System.Drawing.Color.White;
            this.GrBaoCao.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrBaoCao.BorderSize = 2;
            this.GrBaoCao.Controls.Add(this.gunaLabel7);
            this.GrBaoCao.Controls.Add(this.gunaLabel6);
            this.GrBaoCao.Controls.Add(this.gunaLabel5);
            this.GrBaoCao.Controls.Add(this.gunaLabel4);
            this.GrBaoCao.Controls.Add(this.gunaLabel3);
            this.GrBaoCao.Controls.Add(this.gunaLabel2);
            this.GrBaoCao.Controls.Add(this.BtnHoaDon);
            this.GrBaoCao.Controls.Add(this.BtnKho);
            this.GrBaoCao.Controls.Add(this.BtnNguoiDung);
            this.GrBaoCao.Controls.Add(this.BtnDoanhThu);
            this.GrBaoCao.Controls.Add(this.BtnNhanVien);
            this.GrBaoCao.Controls.Add(this.BtnKhachHang);
            this.GrBaoCao.Controls.Add(this.BtnThoat);
            this.GrBaoCao.Controls.Add(this.DateTimeNow);
            this.GrBaoCao.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrBaoCao.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrBaoCao.Location = new System.Drawing.Point(23, 64);
            this.GrBaoCao.Name = "GrBaoCao";
            this.GrBaoCao.Size = new System.Drawing.Size(1091, 590);
            this.GrBaoCao.TabIndex = 66;
            this.GrBaoCao.Text = "Báo cáo";
            this.GrBaoCao.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.Olive;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(756, 326);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(152, 37);
            this.gunaLabel7.TabIndex = 27;
            this.gunaLabel7.Text = "Người dùng";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.DarkCyan;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(501, 326);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(114, 37);
            this.gunaLabel6.TabIndex = 26;
            this.gunaLabel6.Text = "Hóa đơn";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.MediumVioletRed;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(246, 326);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(60, 37);
            this.gunaLabel5.TabIndex = 25;
            this.gunaLabel5.Text = "Kho";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Green;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(761, 108);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(147, 37);
            this.gunaLabel4.TabIndex = 24;
            this.gunaLabel4.Text = "Khách hàng";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.IndianRed;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(485, 108);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(130, 37);
            this.gunaLabel3.TabIndex = 23;
            this.gunaLabel3.Text = "Nhân viên";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(206, 108);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(134, 37);
            this.gunaLabel2.TabIndex = 22;
            this.gunaLabel2.Text = "Doanh thu";
            // 
            // BtnHoaDon
            // 
            this.BtnHoaDon.AnimationHoverSpeed = 0.07F;
            this.BtnHoaDon.AnimationSpeed = 0.03F;
            this.BtnHoaDon.BaseColor = System.Drawing.Color.DarkCyan;
            this.BtnHoaDon.BorderColor = System.Drawing.Color.Black;
            this.BtnHoaDon.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.BtnHoaDon.ForeColor = System.Drawing.Color.White;
            this.BtnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("BtnHoaDon.Image")));
            this.BtnHoaDon.ImageSize = new System.Drawing.Size(52, 52);
            this.BtnHoaDon.Location = new System.Drawing.Point(416, 316);
            this.BtnHoaDon.Name = "BtnHoaDon";
            this.BtnHoaDon.OnHoverBaseColor = System.Drawing.Color.DarkCyan;
            this.BtnHoaDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnHoaDon.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnHoaDon.OnHoverImage = null;
            this.BtnHoaDon.OnPressedColor = System.Drawing.Color.Black;
            this.BtnHoaDon.Size = new System.Drawing.Size(272, 213);
            this.BtnHoaDon.TabIndex = 21;
            this.BtnHoaDon.Text = "Hóa đơn";
            // 
            // BtnKho
            // 
            this.BtnKho.AnimationHoverSpeed = 0.07F;
            this.BtnKho.AnimationSpeed = 0.03F;
            this.BtnKho.BaseColor = System.Drawing.Color.MediumVioletRed;
            this.BtnKho.BorderColor = System.Drawing.Color.Black;
            this.BtnKho.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.BtnKho.ForeColor = System.Drawing.Color.White;
            this.BtnKho.Image = ((System.Drawing.Image)(resources.GetObject("BtnKho.Image")));
            this.BtnKho.ImageSize = new System.Drawing.Size(52, 52);
            this.BtnKho.Location = new System.Drawing.Point(138, 316);
            this.BtnKho.Name = "BtnKho";
            this.BtnKho.OnHoverBaseColor = System.Drawing.Color.MediumVioletRed;
            this.BtnKho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnKho.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnKho.OnHoverImage = null;
            this.BtnKho.OnPressedColor = System.Drawing.Color.Black;
            this.BtnKho.Size = new System.Drawing.Size(272, 213);
            this.BtnKho.TabIndex = 19;
            this.BtnKho.Text = "Kho";
            // 
            // BtnNguoiDung
            // 
            this.BtnNguoiDung.AnimationHoverSpeed = 0.07F;
            this.BtnNguoiDung.AnimationSpeed = 0.03F;
            this.BtnNguoiDung.BaseColor = System.Drawing.Color.Olive;
            this.BtnNguoiDung.BorderColor = System.Drawing.Color.Black;
            this.BtnNguoiDung.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.BtnNguoiDung.ForeColor = System.Drawing.Color.White;
            this.BtnNguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("BtnNguoiDung.Image")));
            this.BtnNguoiDung.ImageSize = new System.Drawing.Size(52, 52);
            this.BtnNguoiDung.Location = new System.Drawing.Point(694, 316);
            this.BtnNguoiDung.Name = "BtnNguoiDung";
            this.BtnNguoiDung.OnHoverBaseColor = System.Drawing.Color.Olive;
            this.BtnNguoiDung.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnNguoiDung.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnNguoiDung.OnHoverImage = null;
            this.BtnNguoiDung.OnPressedColor = System.Drawing.Color.Black;
            this.BtnNguoiDung.Size = new System.Drawing.Size(275, 213);
            this.BtnNguoiDung.TabIndex = 20;
            this.BtnNguoiDung.Text = "Người dùng";
            // 
            // BtnDoanhThu
            // 
            this.BtnDoanhThu.AnimationHoverSpeed = 0.07F;
            this.BtnDoanhThu.AnimationSpeed = 0.03F;
            this.BtnDoanhThu.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnDoanhThu.BorderColor = System.Drawing.Color.Black;
            this.BtnDoanhThu.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.BtnDoanhThu.ForeColor = System.Drawing.Color.White;
            this.BtnDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("BtnDoanhThu.Image")));
            this.BtnDoanhThu.ImageSize = new System.Drawing.Size(52, 52);
            this.BtnDoanhThu.Location = new System.Drawing.Point(138, 97);
            this.BtnDoanhThu.Name = "BtnDoanhThu";
            this.BtnDoanhThu.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnDoanhThu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDoanhThu.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDoanhThu.OnHoverImage = null;
            this.BtnDoanhThu.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDoanhThu.Size = new System.Drawing.Size(272, 213);
            this.BtnDoanhThu.TabIndex = 16;
            this.BtnDoanhThu.Text = "Doanh thu";
            // 
            // BtnNhanVien
            // 
            this.BtnNhanVien.AnimationHoverSpeed = 0.07F;
            this.BtnNhanVien.AnimationSpeed = 0.03F;
            this.BtnNhanVien.BaseColor = System.Drawing.Color.IndianRed;
            this.BtnNhanVien.BorderColor = System.Drawing.Color.Black;
            this.BtnNhanVien.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.BtnNhanVien.ForeColor = System.Drawing.Color.White;
            this.BtnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("BtnNhanVien.Image")));
            this.BtnNhanVien.ImageSize = new System.Drawing.Size(52, 52);
            this.BtnNhanVien.Location = new System.Drawing.Point(416, 97);
            this.BtnNhanVien.Name = "BtnNhanVien";
            this.BtnNhanVien.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.BtnNhanVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnNhanVien.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnNhanVien.OnHoverImage = null;
            this.BtnNhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.BtnNhanVien.Size = new System.Drawing.Size(272, 213);
            this.BtnNhanVien.TabIndex = 17;
            this.BtnNhanVien.Text = "Nhân viên";
            // 
            // BtnKhachHang
            // 
            this.BtnKhachHang.AnimationHoverSpeed = 0.07F;
            this.BtnKhachHang.AnimationSpeed = 0.03F;
            this.BtnKhachHang.BaseColor = System.Drawing.Color.Green;
            this.BtnKhachHang.BorderColor = System.Drawing.Color.Black;
            this.BtnKhachHang.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.BtnKhachHang.ForeColor = System.Drawing.Color.White;
            this.BtnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("BtnKhachHang.Image")));
            this.BtnKhachHang.ImageSize = new System.Drawing.Size(52, 52);
            this.BtnKhachHang.Location = new System.Drawing.Point(694, 97);
            this.BtnKhachHang.Name = "BtnKhachHang";
            this.BtnKhachHang.OnHoverBaseColor = System.Drawing.Color.Green;
            this.BtnKhachHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnKhachHang.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnKhachHang.OnHoverImage = null;
            this.BtnKhachHang.OnPressedColor = System.Drawing.Color.Black;
            this.BtnKhachHang.Size = new System.Drawing.Size(275, 213);
            this.BtnKhachHang.TabIndex = 18;
            this.BtnKhachHang.Text = "Khách hàng";
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 677);
            this.Controls.Add(this.GrBaoCao);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.PtbLoading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaoCao";
            this.Text = "Báo cáo thống kê";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.GrBaoCao.ResumeLayout(false);
            this.GrBaoCao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTransfarantPictureBox PtbLoading;
        private Guna.UI.WinForms.GunaButton BtnThoat;
        private System.Windows.Forms.Timer TimeWaiting;
        public Guna.UI.WinForms.GunaLabel LblAdmin;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private MetroFramework.Controls.MetroDateTime DateTimeNow;
        private Guna.UI.WinForms.GunaGroupBox GrBaoCao;
        private Guna.UI.WinForms.GunaTileButton BtnHoaDon;
        private Guna.UI.WinForms.GunaTileButton BtnKho;
        private Guna.UI.WinForms.GunaTileButton BtnNguoiDung;
        private Guna.UI.WinForms.GunaTileButton BtnDoanhThu;
        private Guna.UI.WinForms.GunaTileButton BtnNhanVien;
        private Guna.UI.WinForms.GunaTileButton BtnKhachHang;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}