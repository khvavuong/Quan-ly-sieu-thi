namespace ManageSuperMarket
{
    partial class MainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdmin));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.TimeWaiting = new System.Windows.Forms.Timer(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.LblAdmin = new Guna.UI.WinForms.GunaLabel();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.gunaTileButton3 = new Guna.UI.WinForms.GunaTileButton();
            this.BtnNCC = new Guna.UI.WinForms.GunaTileButton();
            this.BtnHoaDon = new Guna.UI.WinForms.GunaTileButton();
            this.BtnKho = new Guna.UI.WinForms.GunaTileButton();
            this.BtnBaoCao = new Guna.UI.WinForms.GunaTileButton();
            this.BtnNhanVien = new Guna.UI.WinForms.GunaTileButton();
            this.BtnKhachHang = new Guna.UI.WinForms.GunaTileButton();
            this.BtnBanHang = new Guna.UI.WinForms.GunaTileButton();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaTileButton1 = new Guna.UI.WinForms.GunaTileButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.BtnDangXuat = new Guna.UI.WinForms.GunaTileButton();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.PtbLoading = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.TabControl.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(247, 30);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(37, 34);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // TimeWaiting
            // 
            this.TimeWaiting.Enabled = true;
            this.TimeWaiting.Interval = 1000;
            this.TimeWaiting.Tick += new System.EventHandler(this.TimeWaiting_Tick);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(827, 36);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(72, 28);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Text = "Admin:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.Location = new System.Drawing.Point(899, 36);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(160, 28);
            this.LblAdmin.TabIndex = 14;
            this.LblAdmin.Text = "Khuất Văn Vương";
            this.LblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.metroTabPage2);
            this.TabControl.Controls.Add(this.metroTabPage1);
            this.TabControl.Controls.Add(this.metroTabPage3);
            this.TabControl.Location = new System.Drawing.Point(23, 70);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1091, 539);
            this.TabControl.TabIndex = 15;
            this.TabControl.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.gunaTileButton3);
            this.metroTabPage2.Controls.Add(this.BtnNCC);
            this.metroTabPage2.Controls.Add(this.BtnHoaDon);
            this.metroTabPage2.Controls.Add(this.BtnKho);
            this.metroTabPage2.Controls.Add(this.BtnBaoCao);
            this.metroTabPage2.Controls.Add(this.BtnNhanVien);
            this.metroTabPage2.Controls.Add(this.BtnKhachHang);
            this.metroTabPage2.Controls.Add(this.BtnBanHang);
            this.metroTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1083, 497);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Quản lý";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // gunaTileButton3
            // 
            this.gunaTileButton3.AnimationHoverSpeed = 0.07F;
            this.gunaTileButton3.AnimationSpeed = 0.03F;
            this.gunaTileButton3.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.gunaTileButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaTileButton3.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaTileButton3.ForeColor = System.Drawing.Color.White;
            this.gunaTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaTileButton3.Image")));
            this.gunaTileButton3.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaTileButton3.Location = new System.Drawing.Point(818, 251);
            this.gunaTileButton3.Name = "gunaTileButton3";
            this.gunaTileButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaTileButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaTileButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaTileButton3.OnHoverImage = null;
            this.gunaTileButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaTileButton3.Size = new System.Drawing.Size(262, 231);
            this.gunaTileButton3.TabIndex = 28;
            this.gunaTileButton3.Text = "   ";
            // 
            // BtnNCC
            // 
            this.BtnNCC.AnimationHoverSpeed = 0.07F;
            this.BtnNCC.AnimationSpeed = 0.03F;
            this.BtnNCC.BaseColor = System.Drawing.Color.SlateBlue;
            this.BtnNCC.BorderColor = System.Drawing.Color.Black;
            this.BtnNCC.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.BtnNCC.ForeColor = System.Drawing.Color.White;
            this.BtnNCC.Image = ((System.Drawing.Image)(resources.GetObject("BtnNCC.Image")));
            this.BtnNCC.ImageSize = new System.Drawing.Size(52, 52);
            this.BtnNCC.Location = new System.Drawing.Point(818, 14);
            this.BtnNCC.Name = "BtnNCC";
            this.BtnNCC.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnNCC.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnNCC.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnNCC.OnHoverImage = null;
            this.BtnNCC.OnPressedColor = System.Drawing.Color.Black;
            this.BtnNCC.Size = new System.Drawing.Size(262, 231);
            this.BtnNCC.TabIndex = 27;
            this.BtnNCC.Text = "Nhà cung cấp";
            this.BtnNCC.Click += new System.EventHandler(this.BtnNCC_Click);
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
            this.BtnHoaDon.Location = new System.Drawing.Point(282, 251);
            this.BtnHoaDon.Name = "BtnHoaDon";
            this.BtnHoaDon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnHoaDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnHoaDon.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnHoaDon.OnHoverImage = null;
            this.BtnHoaDon.OnPressedColor = System.Drawing.Color.Black;
            this.BtnHoaDon.Size = new System.Drawing.Size(262, 231);
            this.BtnHoaDon.TabIndex = 26;
            this.BtnHoaDon.Text = "Hóa đơn";
            this.BtnHoaDon.Click += new System.EventHandler(this.BtnHoaDon_Click);
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
            this.BtnKho.Location = new System.Drawing.Point(14, 251);
            this.BtnKho.Name = "BtnKho";
            this.BtnKho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnKho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnKho.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnKho.OnHoverImage = null;
            this.BtnKho.OnPressedColor = System.Drawing.Color.Black;
            this.BtnKho.Size = new System.Drawing.Size(262, 231);
            this.BtnKho.TabIndex = 24;
            this.BtnKho.Text = "Kho";
            this.BtnKho.Click += new System.EventHandler(this.BtnKho_Click);
            // 
            // BtnBaoCao
            // 
            this.BtnBaoCao.AnimationHoverSpeed = 0.07F;
            this.BtnBaoCao.AnimationSpeed = 0.03F;
            this.BtnBaoCao.BaseColor = System.Drawing.Color.Olive;
            this.BtnBaoCao.BorderColor = System.Drawing.Color.Black;
            this.BtnBaoCao.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.BtnBaoCao.ForeColor = System.Drawing.Color.White;
            this.BtnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("BtnBaoCao.Image")));
            this.BtnBaoCao.ImageSize = new System.Drawing.Size(52, 52);
            this.BtnBaoCao.Location = new System.Drawing.Point(550, 251);
            this.BtnBaoCao.Name = "BtnBaoCao";
            this.BtnBaoCao.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnBaoCao.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnBaoCao.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnBaoCao.OnHoverImage = null;
            this.BtnBaoCao.OnPressedColor = System.Drawing.Color.Black;
            this.BtnBaoCao.Size = new System.Drawing.Size(262, 231);
            this.BtnBaoCao.TabIndex = 25;
            this.BtnBaoCao.Text = "Báo cáo";
            this.BtnBaoCao.Click += new System.EventHandler(this.BtnBaoCao_Click);
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
            this.BtnNhanVien.Location = new System.Drawing.Point(282, 14);
            this.BtnNhanVien.Name = "BtnNhanVien";
            this.BtnNhanVien.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnNhanVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnNhanVien.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnNhanVien.OnHoverImage = null;
            this.BtnNhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.BtnNhanVien.Size = new System.Drawing.Size(262, 231);
            this.BtnNhanVien.TabIndex = 22;
            this.BtnNhanVien.Text = "Nhân viên";
            this.BtnNhanVien.Click += new System.EventHandler(this.BtnNhanVien_Click);
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
            this.BtnKhachHang.Location = new System.Drawing.Point(550, 14);
            this.BtnKhachHang.Name = "BtnKhachHang";
            this.BtnKhachHang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnKhachHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnKhachHang.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnKhachHang.OnHoverImage = null;
            this.BtnKhachHang.OnPressedColor = System.Drawing.Color.Black;
            this.BtnKhachHang.Size = new System.Drawing.Size(262, 231);
            this.BtnKhachHang.TabIndex = 23;
            this.BtnKhachHang.Text = "Khách hàng";
            this.BtnKhachHang.Click += new System.EventHandler(this.BtnKhachHang_Click);
            // 
            // BtnBanHang
            // 
            this.BtnBanHang.AnimationHoverSpeed = 0.07F;
            this.BtnBanHang.AnimationSpeed = 0.03F;
            this.BtnBanHang.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnBanHang.BorderColor = System.Drawing.Color.Black;
            this.BtnBanHang.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.BtnBanHang.ForeColor = System.Drawing.Color.White;
            this.BtnBanHang.Image = ((System.Drawing.Image)(resources.GetObject("BtnBanHang.Image")));
            this.BtnBanHang.ImageSize = new System.Drawing.Size(52, 52);
            this.BtnBanHang.Location = new System.Drawing.Point(14, 14);
            this.BtnBanHang.Name = "BtnBanHang";
            this.BtnBanHang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnBanHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnBanHang.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnBanHang.OnHoverImage = null;
            this.BtnBanHang.OnPressedColor = System.Drawing.Color.Black;
            this.BtnBanHang.Size = new System.Drawing.Size(262, 231);
            this.BtnBanHang.TabIndex = 6;
            this.BtnBanHang.Text = "Bán hàng";
            this.BtnBanHang.Click += new System.EventHandler(this.BtnBanHang_Click);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.gunaPictureBox3);
            this.metroTabPage1.Controls.Add(this.gunaTileButton1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1083, 497);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Thông tin";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.Location = new System.Drawing.Point(3, 0);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(1084, 518);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox3.TabIndex = 2;
            this.gunaPictureBox3.TabStop = false;
            // 
            // gunaTileButton1
            // 
            this.gunaTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaTileButton1.AnimationSpeed = 0.03F;
            this.gunaTileButton1.BaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaTileButton1.Image")));
            this.gunaTileButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaTileButton1.Location = new System.Drawing.Point(912, 339);
            this.gunaTileButton1.Name = "gunaTileButton1";
            this.gunaTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaTileButton1.OnHoverImage = null;
            this.gunaTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaTileButton1.Size = new System.Drawing.Size(168, 162);
            this.gunaTileButton1.TabIndex = 7;
            this.gunaTileButton1.Text = "Bán hàng";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.BtnDangXuat);
            this.metroTabPage3.Controls.Add(this.label6);
            this.metroTabPage3.Controls.Add(this.gunaPictureBox2);
            this.metroTabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1083, 497);
            this.metroTabPage3.TabIndex = 3;
            this.metroTabPage3.Text = "Đăng xuất";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // BtnDangXuat
            // 
            this.BtnDangXuat.AnimationHoverSpeed = 0.07F;
            this.BtnDangXuat.AnimationSpeed = 0.03F;
            this.BtnDangXuat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnDangXuat.BorderColor = System.Drawing.Color.Black;
            this.BtnDangXuat.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.BtnDangXuat.ForeColor = System.Drawing.Color.White;
            this.BtnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("BtnDangXuat.Image")));
            this.BtnDangXuat.ImageSize = new System.Drawing.Size(52, 52);
            this.BtnDangXuat.Location = new System.Drawing.Point(465, 332);
            this.BtnDangXuat.Name = "BtnDangXuat";
            this.BtnDangXuat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnDangXuat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDangXuat.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDangXuat.OnHoverImage = null;
            this.BtnDangXuat.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDangXuat.Size = new System.Drawing.Size(152, 145);
            this.BtnDangXuat.TabIndex = 48;
            this.BtnDangXuat.Text = "Đăng xuất";
            this.BtnDangXuat.Click += new System.EventHandler(this.BtnDangXuat_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(-38, 480);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1146, 60);
            this.label6.TabIndex = 47;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(64, -38);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(958, 568);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 3;
            this.gunaPictureBox2.TabStop = false;
            // 
            // PtbLoading
            // 
            this.PtbLoading.BackColor = System.Drawing.Color.Transparent;
            this.PtbLoading.BaseColor = System.Drawing.Color.Black;
            this.PtbLoading.Image = ((System.Drawing.Image)(resources.GetObject("PtbLoading.Image")));
            this.PtbLoading.Location = new System.Drawing.Point(308, 63);
            this.PtbLoading.Name = "PtbLoading";
            this.PtbLoading.Size = new System.Drawing.Size(513, 510);
            this.PtbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLoading.TabIndex = 5;
            this.PtbLoading.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this.BtnDangXuat;
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 632);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.PtbLoading);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainAdmin";
            this.Text = "Quản lý siêu thị";
            this.Load += new System.EventHandler(this.MainAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Timer TimeWaiting;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaLabel LblAdmin;
        private MetroFramework.Controls.MetroTabControl TabControl;
        private Guna.UI.WinForms.GunaTransfarantPictureBox PtbLoading;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaTileButton BtnDangXuat;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private Guna.UI.WinForms.GunaTileButton BtnBanHang;
        private Guna.UI.WinForms.GunaTileButton gunaTileButton1;
        private Guna.UI.WinForms.GunaTileButton BtnHoaDon;
        private Guna.UI.WinForms.GunaTileButton BtnKho;
        private Guna.UI.WinForms.GunaTileButton BtnBaoCao;
        private Guna.UI.WinForms.GunaTileButton BtnNhanVien;
        private Guna.UI.WinForms.GunaTileButton BtnKhachHang;
        private Guna.UI.WinForms.GunaTileButton gunaTileButton3;
        private Guna.UI.WinForms.GunaTileButton BtnNCC;
    }
}