namespace ManageSuperMarket
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrSanPham = new Guna.UI.WinForms.GunaGroupBox();
            this.TxtSoLuong = new Guna.UI.WinForms.GunaTextBox();
            this.TxtDonViTinh = new Guna.UI.WinForms.GunaTextBox();
            this.TxtNoiSX = new Guna.UI.WinForms.GunaTextBox();
            this.TxtNCC = new Guna.UI.WinForms.GunaTextBox();
            this.TxtGiaNhap = new Guna.UI.WinForms.GunaTextBox();
            this.TxtGiaBan = new Guna.UI.WinForms.GunaTextBox();
            this.TxtHSD = new Guna.UI.WinForms.GunaTextBox();
            this.TxtTenSP = new Guna.UI.WinForms.GunaTextBox();
            this.TxtMaSP = new Guna.UI.WinForms.GunaTextBox();
            this.DateTimeNow = new MetroFramework.Controls.MetroDateTime();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.LblAdmin = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.BtnXoa = new Guna.UI.WinForms.GunaButton();
            this.BtnThoat = new Guna.UI.WinForms.GunaButton();
            this.TxtTimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.BtnSua = new Guna.UI.WinForms.GunaButton();
            this.GrChucNang = new Guna.UI.WinForms.GunaGroupBox();
            this.BtnThem = new Guna.UI.WinForms.GunaButton();
            this.DGVSanPham = new Guna.UI.WinForms.GunaDataGridView();
            this.TimeWaiting = new System.Windows.Forms.Timer(this.components);
            this.PtbLoading = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.GrSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.GrChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // GrSanPham
            // 
            this.GrSanPham.BaseColor = System.Drawing.Color.White;
            this.GrSanPham.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrSanPham.BorderSize = 2;
            this.GrSanPham.Controls.Add(this.TxtSoLuong);
            this.GrSanPham.Controls.Add(this.TxtDonViTinh);
            this.GrSanPham.Controls.Add(this.TxtNoiSX);
            this.GrSanPham.Controls.Add(this.TxtNCC);
            this.GrSanPham.Controls.Add(this.TxtGiaNhap);
            this.GrSanPham.Controls.Add(this.TxtGiaBan);
            this.GrSanPham.Controls.Add(this.TxtHSD);
            this.GrSanPham.Controls.Add(this.TxtTenSP);
            this.GrSanPham.Controls.Add(this.TxtMaSP);
            this.GrSanPham.Controls.Add(this.DateTimeNow);
            this.GrSanPham.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrSanPham.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrSanPham.Location = new System.Drawing.Point(23, 66);
            this.GrSanPham.Name = "GrSanPham";
            this.GrSanPham.Size = new System.Drawing.Size(383, 412);
            this.GrSanPham.TabIndex = 58;
            this.GrSanPham.Text = "Thêm thông tin";
            this.GrSanPham.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // TxtSoLuong
            // 
            this.TxtSoLuong.BaseColor = System.Drawing.Color.White;
            this.TxtSoLuong.BorderColor = System.Drawing.Color.Silver;
            this.TxtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSoLuong.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtSoLuong.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtSoLuong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtSoLuong.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSoLuong.ForeColor = System.Drawing.Color.Gray;
            this.TxtSoLuong.Location = new System.Drawing.Point(12, 249);
            this.TxtSoLuong.Name = "TxtSoLuong";
            this.TxtSoLuong.PasswordChar = '\0';
            this.TxtSoLuong.Size = new System.Drawing.Size(355, 34);
            this.TxtSoLuong.TabIndex = 30;
            this.TxtSoLuong.Text = "Số lượng tồn";
            this.TxtSoLuong.Enter += new System.EventHandler(this.TxtSoLuong_Enter);
            this.TxtSoLuong.Leave += new System.EventHandler(this.TxtSoLuong_Leave);
            // 
            // TxtDonViTinh
            // 
            this.TxtDonViTinh.BaseColor = System.Drawing.Color.White;
            this.TxtDonViTinh.BorderColor = System.Drawing.Color.Silver;
            this.TxtDonViTinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDonViTinh.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtDonViTinh.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtDonViTinh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtDonViTinh.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDonViTinh.ForeColor = System.Drawing.Color.Gray;
            this.TxtDonViTinh.Location = new System.Drawing.Point(12, 369);
            this.TxtDonViTinh.Name = "TxtDonViTinh";
            this.TxtDonViTinh.PasswordChar = '\0';
            this.TxtDonViTinh.Size = new System.Drawing.Size(355, 34);
            this.TxtDonViTinh.TabIndex = 29;
            this.TxtDonViTinh.Text = "Đơn vị tính";
            this.TxtDonViTinh.Enter += new System.EventHandler(this.TxtDonViTinh_Enter);
            this.TxtDonViTinh.Leave += new System.EventHandler(this.TxtDonViTinh_Leave);
            // 
            // TxtNoiSX
            // 
            this.TxtNoiSX.BaseColor = System.Drawing.Color.White;
            this.TxtNoiSX.BorderColor = System.Drawing.Color.Silver;
            this.TxtNoiSX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNoiSX.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNoiSX.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNoiSX.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNoiSX.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoiSX.ForeColor = System.Drawing.Color.Gray;
            this.TxtNoiSX.Location = new System.Drawing.Point(12, 329);
            this.TxtNoiSX.Name = "TxtNoiSX";
            this.TxtNoiSX.PasswordChar = '\0';
            this.TxtNoiSX.Size = new System.Drawing.Size(355, 34);
            this.TxtNoiSX.TabIndex = 28;
            this.TxtNoiSX.Text = "Nơi sản xuất";
            this.TxtNoiSX.Enter += new System.EventHandler(this.TxtNoiSX_Enter);
            this.TxtNoiSX.Leave += new System.EventHandler(this.TxtNoiSX_Leave);
            // 
            // TxtNCC
            // 
            this.TxtNCC.BaseColor = System.Drawing.Color.White;
            this.TxtNCC.BorderColor = System.Drawing.Color.Silver;
            this.TxtNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNCC.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNCC.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNCC.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNCC.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNCC.ForeColor = System.Drawing.Color.Gray;
            this.TxtNCC.Location = new System.Drawing.Point(12, 169);
            this.TxtNCC.Name = "TxtNCC";
            this.TxtNCC.PasswordChar = '\0';
            this.TxtNCC.Size = new System.Drawing.Size(355, 34);
            this.TxtNCC.TabIndex = 27;
            this.TxtNCC.Text = "Mã nhà cung cấp";
            this.TxtNCC.Enter += new System.EventHandler(this.TxtNCC_Enter);
            this.TxtNCC.Leave += new System.EventHandler(this.TxtNCC_Leave);
            // 
            // TxtGiaNhap
            // 
            this.TxtGiaNhap.BaseColor = System.Drawing.Color.White;
            this.TxtGiaNhap.BorderColor = System.Drawing.Color.Silver;
            this.TxtGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtGiaNhap.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtGiaNhap.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtGiaNhap.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtGiaNhap.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGiaNhap.ForeColor = System.Drawing.Color.Gray;
            this.TxtGiaNhap.Location = new System.Drawing.Point(12, 209);
            this.TxtGiaNhap.Name = "TxtGiaNhap";
            this.TxtGiaNhap.PasswordChar = '\0';
            this.TxtGiaNhap.Size = new System.Drawing.Size(176, 34);
            this.TxtGiaNhap.TabIndex = 26;
            this.TxtGiaNhap.Text = "Giá nhập";
            this.TxtGiaNhap.Enter += new System.EventHandler(this.TxtGiaNhap_Enter);
            this.TxtGiaNhap.Leave += new System.EventHandler(this.TxtGiaNhap_Leave);
            // 
            // TxtGiaBan
            // 
            this.TxtGiaBan.BaseColor = System.Drawing.Color.White;
            this.TxtGiaBan.BorderColor = System.Drawing.Color.Silver;
            this.TxtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtGiaBan.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtGiaBan.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtGiaBan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtGiaBan.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGiaBan.ForeColor = System.Drawing.Color.Gray;
            this.TxtGiaBan.Location = new System.Drawing.Point(194, 209);
            this.TxtGiaBan.Name = "TxtGiaBan";
            this.TxtGiaBan.PasswordChar = '\0';
            this.TxtGiaBan.Size = new System.Drawing.Size(173, 34);
            this.TxtGiaBan.TabIndex = 25;
            this.TxtGiaBan.Text = "Giá bán";
            this.TxtGiaBan.Enter += new System.EventHandler(this.TxtGiaBan_Enter);
            this.TxtGiaBan.Leave += new System.EventHandler(this.TxtGiaBan_Leave);
            // 
            // TxtHSD
            // 
            this.TxtHSD.BaseColor = System.Drawing.Color.White;
            this.TxtHSD.BorderColor = System.Drawing.Color.Silver;
            this.TxtHSD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtHSD.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtHSD.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtHSD.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtHSD.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHSD.ForeColor = System.Drawing.Color.Gray;
            this.TxtHSD.Location = new System.Drawing.Point(12, 289);
            this.TxtHSD.Name = "TxtHSD";
            this.TxtHSD.PasswordChar = '\0';
            this.TxtHSD.Size = new System.Drawing.Size(355, 34);
            this.TxtHSD.TabIndex = 24;
            this.TxtHSD.Text = "Hạn sử dụng";
            this.TxtHSD.Enter += new System.EventHandler(this.TxtHSD_Enter);
            this.TxtHSD.Leave += new System.EventHandler(this.TxtHSD_Leave);
            // 
            // TxtTenSP
            // 
            this.TxtTenSP.BaseColor = System.Drawing.Color.White;
            this.TxtTenSP.BorderColor = System.Drawing.Color.Silver;
            this.TxtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTenSP.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtTenSP.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtTenSP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTenSP.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenSP.ForeColor = System.Drawing.Color.Gray;
            this.TxtTenSP.Location = new System.Drawing.Point(12, 129);
            this.TxtTenSP.Name = "TxtTenSP";
            this.TxtTenSP.PasswordChar = '\0';
            this.TxtTenSP.Size = new System.Drawing.Size(355, 34);
            this.TxtTenSP.TabIndex = 23;
            this.TxtTenSP.Text = "Tên sản phẩm";
            this.TxtTenSP.Enter += new System.EventHandler(this.TxtTenSP_Enter);
            this.TxtTenSP.Leave += new System.EventHandler(this.TxtTenSP_Leave);
            // 
            // TxtMaSP
            // 
            this.TxtMaSP.BaseColor = System.Drawing.Color.White;
            this.TxtMaSP.BorderColor = System.Drawing.Color.Silver;
            this.TxtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMaSP.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtMaSP.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMaSP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMaSP.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaSP.ForeColor = System.Drawing.Color.Gray;
            this.TxtMaSP.Location = new System.Drawing.Point(12, 89);
            this.TxtMaSP.Name = "TxtMaSP";
            this.TxtMaSP.PasswordChar = '\0';
            this.TxtMaSP.Size = new System.Drawing.Size(355, 34);
            this.TxtMaSP.TabIndex = 22;
            this.TxtMaSP.Text = "Mã sản phẩm";
            this.TxtMaSP.Enter += new System.EventHandler(this.TxtMaSP_Enter);
            this.TxtMaSP.Leave += new System.EventHandler(this.TxtMaSP_Leave);
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
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(230, 26);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(37, 34);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 57;
            this.gunaPictureBox1.TabStop = false;
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.Location = new System.Drawing.Point(954, 32);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(160, 28);
            this.LblAdmin.TabIndex = 55;
            this.LblAdmin.Text = "Khuất Văn Vương";
            this.LblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(846, 32);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel1.TabIndex = 54;
            this.gunaLabel1.Text = "Nhân viên:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnXoa
            // 
            this.BtnXoa.AnimationHoverSpeed = 0.07F;
            this.BtnXoa.AnimationSpeed = 0.03F;
            this.BtnXoa.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtnXoa.BorderColor = System.Drawing.Color.Black;
            this.BtnXoa.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.ForeColor = System.Drawing.Color.White;
            this.BtnXoa.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoa.Image")));
            this.BtnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnXoa.Location = new System.Drawing.Point(12, 111);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnXoa.OnHoverImage = null;
            this.BtnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.BtnXoa.Size = new System.Drawing.Size(160, 42);
            this.BtnXoa.TabIndex = 3;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
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
            this.BtnThoat.Location = new System.Drawing.Point(207, 111);
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
            // TxtTimKiem
            // 
            this.TxtTimKiem.BaseColor = System.Drawing.Color.White;
            this.TxtTimKiem.BorderColor = System.Drawing.Color.Silver;
            this.TxtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTimKiem.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtTimKiem.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtTimKiem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTimKiem.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.TxtTimKiem.Location = new System.Drawing.Point(428, 46);
            this.TxtTimKiem.Name = "TxtTimKiem";
            this.TxtTimKiem.PasswordChar = '\0';
            this.TxtTimKiem.Size = new System.Drawing.Size(337, 34);
            this.TxtTimKiem.TabIndex = 59;
            this.TxtTimKiem.Text = "Nhập sản phẩm cần tìm kiếm";
            this.TxtTimKiem.TextChanged += new System.EventHandler(this.TxtTimKiem_TextChanged);
            this.TxtTimKiem.Enter += new System.EventHandler(this.TxtTimKiem_Enter);
            this.TxtTimKiem.Leave += new System.EventHandler(this.TxtTimKiem_Leave);
            // 
            // BtnSua
            // 
            this.BtnSua.AnimationHoverSpeed = 0.07F;
            this.BtnSua.AnimationSpeed = 0.03F;
            this.BtnSua.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtnSua.BorderColor = System.Drawing.Color.Black;
            this.BtnSua.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.ForeColor = System.Drawing.Color.White;
            this.BtnSua.Image = ((System.Drawing.Image)(resources.GetObject("BtnSua.Image")));
            this.BtnSua.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSua.Location = new System.Drawing.Point(207, 48);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSua.OnHoverImage = null;
            this.BtnSua.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSua.Size = new System.Drawing.Size(160, 42);
            this.BtnSua.TabIndex = 1;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // GrChucNang
            // 
            this.GrChucNang.BaseColor = System.Drawing.Color.White;
            this.GrChucNang.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrChucNang.BorderSize = 2;
            this.GrChucNang.Controls.Add(this.BtnXoa);
            this.GrChucNang.Controls.Add(this.BtnThoat);
            this.GrChucNang.Controls.Add(this.BtnSua);
            this.GrChucNang.Controls.Add(this.BtnThem);
            this.GrChucNang.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrChucNang.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrChucNang.Location = new System.Drawing.Point(23, 484);
            this.GrChucNang.Name = "GrChucNang";
            this.GrChucNang.Size = new System.Drawing.Size(383, 170);
            this.GrChucNang.TabIndex = 60;
            this.GrChucNang.Text = "Chức năng";
            this.GrChucNang.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // BtnThem
            // 
            this.BtnThem.AnimationHoverSpeed = 0.07F;
            this.BtnThem.AnimationSpeed = 0.03F;
            this.BtnThem.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtnThem.BorderColor = System.Drawing.Color.Black;
            this.BtnThem.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.ForeColor = System.Drawing.Color.White;
            this.BtnThem.Image = ((System.Drawing.Image)(resources.GetObject("BtnThem.Image")));
            this.BtnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnThem.Location = new System.Drawing.Point(12, 48);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnThem.OnHoverImage = null;
            this.BtnThem.OnPressedColor = System.Drawing.Color.Black;
            this.BtnThem.Size = new System.Drawing.Size(160, 42);
            this.BtnThem.TabIndex = 0;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // DGVSanPham
            // 
            this.DGVSanPham.AllowUserToAddRows = false;
            this.DGVSanPham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSanPham.BackgroundColor = System.Drawing.Color.LightGray;
            this.DGVSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVSanPham.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVSanPham.EnableHeadersVisualStyles = false;
            this.DGVSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVSanPham.Location = new System.Drawing.Point(428, 86);
            this.DGVSanPham.Name = "DGVSanPham";
            this.DGVSanPham.ReadOnly = true;
            this.DGVSanPham.RowHeadersVisible = false;
            this.DGVSanPham.RowHeadersWidth = 51;
            this.DGVSanPham.RowTemplate.Height = 24;
            this.DGVSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSanPham.Size = new System.Drawing.Size(686, 568);
            this.DGVSanPham.TabIndex = 56;
            this.DGVSanPham.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVSanPham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVSanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVSanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVSanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVSanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVSanPham.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DGVSanPham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVSanPham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVSanPham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVSanPham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVSanPham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVSanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVSanPham.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVSanPham.ThemeStyle.ReadOnly = true;
            this.DGVSanPham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVSanPham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVSanPham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVSanPham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVSanPham.ThemeStyle.RowsStyle.Height = 24;
            this.DGVSanPham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVSanPham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVSanPham.Click += new System.EventHandler(this.DGVSanPham_Click);
            // 
            // TimeWaiting
            // 
            this.TimeWaiting.Enabled = true;
            this.TimeWaiting.Interval = 1000;
            this.TimeWaiting.Tick += new System.EventHandler(this.TimeWaiting_Tick);
            // 
            // PtbLoading
            // 
            this.PtbLoading.BackColor = System.Drawing.Color.Transparent;
            this.PtbLoading.BaseColor = System.Drawing.Color.Black;
            this.PtbLoading.Image = ((System.Drawing.Image)(resources.GetObject("PtbLoading.Image")));
            this.PtbLoading.Location = new System.Drawing.Point(343, 95);
            this.PtbLoading.Name = "PtbLoading";
            this.PtbLoading.Size = new System.Drawing.Size(500, 504);
            this.PtbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLoading.TabIndex = 61;
            this.PtbLoading.TabStop = false;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 677);
            this.Controls.Add(this.PtbLoading);
            this.Controls.Add(this.GrSanPham);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.TxtTimKiem);
            this.Controls.Add(this.GrChucNang);
            this.Controls.Add(this.DGVSanPham);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SanPham";
            this.Text = "Kho sản phẩm";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.GrSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.GrChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox GrSanPham;
        private Guna.UI.WinForms.GunaTextBox TxtDonViTinh;
        private Guna.UI.WinForms.GunaTextBox TxtNoiSX;
        private Guna.UI.WinForms.GunaTextBox TxtNCC;
        private Guna.UI.WinForms.GunaTextBox TxtGiaNhap;
        private Guna.UI.WinForms.GunaTextBox TxtGiaBan;
        private Guna.UI.WinForms.GunaTextBox TxtHSD;
        private Guna.UI.WinForms.GunaTextBox TxtTenSP;
        private Guna.UI.WinForms.GunaTextBox TxtMaSP;
        private MetroFramework.Controls.MetroDateTime DateTimeNow;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public Guna.UI.WinForms.GunaLabel LblAdmin;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton BtnXoa;
        private Guna.UI.WinForms.GunaButton BtnThoat;
        private Guna.UI.WinForms.GunaTextBox TxtTimKiem;
        private Guna.UI.WinForms.GunaButton BtnSua;
        private Guna.UI.WinForms.GunaGroupBox GrChucNang;
        private Guna.UI.WinForms.GunaButton BtnThem;
        private Guna.UI.WinForms.GunaDataGridView DGVSanPham;
        private System.Windows.Forms.Timer TimeWaiting;
        private Guna.UI.WinForms.GunaTransfarantPictureBox PtbLoading;
        private Guna.UI.WinForms.GunaTextBox TxtSoLuong;
    }
}