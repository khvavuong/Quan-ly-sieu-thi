namespace ManageSuperMarket
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PtbLoading = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.TxtMaHang = new Guna.UI.WinForms.GunaTextBox();
            this.DateTimeNow = new MetroFramework.Controls.MetroDateTime();
            this.TimeWaiting = new System.Windows.Forms.Timer(this.components);
            this.TxtNgayTao = new Guna.UI.WinForms.GunaTextBox();
            this.TxtHoTen = new Guna.UI.WinForms.GunaTextBox();
            this.TxtMaKH = new Guna.UI.WinForms.GunaTextBox();
            this.GrChucNang = new Guna.UI.WinForms.GunaGroupBox();
            this.BtnXoa = new Guna.UI.WinForms.GunaButton();
            this.BtnThoat = new Guna.UI.WinForms.GunaButton();
            this.BtnSua = new Guna.UI.WinForms.GunaButton();
            this.BtnThem = new Guna.UI.WinForms.GunaButton();
            this.TxtTimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.TxtNamGB = new Guna.UI.WinForms.GunaTextBox();
            this.TxtDiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.TxtSDT = new Guna.UI.WinForms.GunaTextBox();
            this.TxtDiem = new Guna.UI.WinForms.GunaTextBox();
            this.GrKhachHang = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.DGVKhachHang = new Guna.UI.WinForms.GunaDataGridView();
            this.LblAdmin = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).BeginInit();
            this.GrChucNang.SuspendLayout();
            this.GrKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // PtbLoading
            // 
            this.PtbLoading.BackColor = System.Drawing.Color.Transparent;
            this.PtbLoading.BaseColor = System.Drawing.Color.Black;
            this.PtbLoading.Image = ((System.Drawing.Image)(resources.GetObject("PtbLoading.Image")));
            this.PtbLoading.Location = new System.Drawing.Point(323, 100);
            this.PtbLoading.Name = "PtbLoading";
            this.PtbLoading.Size = new System.Drawing.Size(500, 504);
            this.PtbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLoading.TabIndex = 53;
            this.PtbLoading.TabStop = false;
            // 
            // TxtMaHang
            // 
            this.TxtMaHang.BaseColor = System.Drawing.Color.White;
            this.TxtMaHang.BorderColor = System.Drawing.Color.Silver;
            this.TxtMaHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMaHang.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtMaHang.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMaHang.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMaHang.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaHang.ForeColor = System.Drawing.Color.Gray;
            this.TxtMaHang.Location = new System.Drawing.Point(12, 369);
            this.TxtMaHang.Name = "TxtMaHang";
            this.TxtMaHang.PasswordChar = '\0';
            this.TxtMaHang.Size = new System.Drawing.Size(355, 34);
            this.TxtMaHang.TabIndex = 29;
            this.TxtMaHang.Text = "Mã mục hàng";
            this.TxtMaHang.Enter += new System.EventHandler(this.TxtMaHang_Enter);
            this.TxtMaHang.Leave += new System.EventHandler(this.TxtMaHang_Leave);
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
            // TimeWaiting
            // 
            this.TimeWaiting.Enabled = true;
            this.TimeWaiting.Interval = 1000;
            this.TimeWaiting.Tick += new System.EventHandler(this.TimeWaiting_Tick);
            // 
            // TxtNgayTao
            // 
            this.TxtNgayTao.BaseColor = System.Drawing.Color.White;
            this.TxtNgayTao.BorderColor = System.Drawing.Color.Silver;
            this.TxtNgayTao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNgayTao.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNgayTao.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNgayTao.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNgayTao.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNgayTao.ForeColor = System.Drawing.Color.Gray;
            this.TxtNgayTao.Location = new System.Drawing.Point(12, 289);
            this.TxtNgayTao.Name = "TxtNgayTao";
            this.TxtNgayTao.PasswordChar = '\0';
            this.TxtNgayTao.Size = new System.Drawing.Size(355, 34);
            this.TxtNgayTao.TabIndex = 24;
            this.TxtNgayTao.Text = "Ngày tạo";
            this.TxtNgayTao.Enter += new System.EventHandler(this.TxtNgayTao_Enter);
            this.TxtNgayTao.Leave += new System.EventHandler(this.TxtNgayTao_Leave);
            // 
            // TxtHoTen
            // 
            this.TxtHoTen.BaseColor = System.Drawing.Color.White;
            this.TxtHoTen.BorderColor = System.Drawing.Color.Silver;
            this.TxtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtHoTen.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtHoTen.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtHoTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtHoTen.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHoTen.ForeColor = System.Drawing.Color.Gray;
            this.TxtHoTen.Location = new System.Drawing.Point(12, 129);
            this.TxtHoTen.Name = "TxtHoTen";
            this.TxtHoTen.PasswordChar = '\0';
            this.TxtHoTen.Size = new System.Drawing.Size(355, 34);
            this.TxtHoTen.TabIndex = 23;
            this.TxtHoTen.Text = "Tên khách hàng";
            this.TxtHoTen.Enter += new System.EventHandler(this.TxtHoTen_Enter);
            this.TxtHoTen.Leave += new System.EventHandler(this.TxtHoTen_Leave);
            // 
            // TxtMaKH
            // 
            this.TxtMaKH.BaseColor = System.Drawing.Color.White;
            this.TxtMaKH.BorderColor = System.Drawing.Color.Silver;
            this.TxtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMaKH.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtMaKH.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMaKH.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMaKH.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaKH.ForeColor = System.Drawing.Color.Gray;
            this.TxtMaKH.Location = new System.Drawing.Point(12, 89);
            this.TxtMaKH.Name = "TxtMaKH";
            this.TxtMaKH.PasswordChar = '\0';
            this.TxtMaKH.Size = new System.Drawing.Size(355, 34);
            this.TxtMaKH.TabIndex = 22;
            this.TxtMaKH.Text = "Mã khách hàng";
            this.TxtMaKH.Enter += new System.EventHandler(this.TxtMaKH_Enter);
            this.TxtMaKH.Leave += new System.EventHandler(this.TxtMaKH_Leave);
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
            this.GrChucNang.Location = new System.Drawing.Point(23, 487);
            this.GrChucNang.Name = "GrChucNang";
            this.GrChucNang.Size = new System.Drawing.Size(383, 170);
            this.GrChucNang.TabIndex = 52;
            this.GrChucNang.Text = "Chức năng";
            this.GrChucNang.TextLocation = new System.Drawing.Point(10, 8);
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
            this.TxtTimKiem.Location = new System.Drawing.Point(428, 49);
            this.TxtTimKiem.Name = "TxtTimKiem";
            this.TxtTimKiem.PasswordChar = '\0';
            this.TxtTimKiem.Size = new System.Drawing.Size(337, 34);
            this.TxtTimKiem.TabIndex = 51;
            this.TxtTimKiem.Text = "Nhập khách hàng cần tìm kiếm";
            this.TxtTimKiem.TextChanged += new System.EventHandler(this.TxtTimKiem_TextChanged);
            this.TxtTimKiem.Enter += new System.EventHandler(this.TxtTimKiem_Enter);
            this.TxtTimKiem.Leave += new System.EventHandler(this.TxtTimKiem_Leave);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(846, 35);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel1.TabIndex = 46;
            this.gunaLabel1.Text = "Nhân viên:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtNamGB
            // 
            this.TxtNamGB.BaseColor = System.Drawing.Color.White;
            this.TxtNamGB.BorderColor = System.Drawing.Color.Silver;
            this.TxtNamGB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNamGB.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNamGB.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNamGB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNamGB.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamGB.ForeColor = System.Drawing.Color.Gray;
            this.TxtNamGB.Location = new System.Drawing.Point(12, 329);
            this.TxtNamGB.Name = "TxtNamGB";
            this.TxtNamGB.PasswordChar = '\0';
            this.TxtNamGB.Size = new System.Drawing.Size(355, 34);
            this.TxtNamGB.TabIndex = 28;
            this.TxtNamGB.Text = "Năm gắn bó";
            this.TxtNamGB.Enter += new System.EventHandler(this.TxtNamGB_Enter);
            this.TxtNamGB.Leave += new System.EventHandler(this.TxtNamGB_Leave);
            // 
            // TxtDiaChi
            // 
            this.TxtDiaChi.BaseColor = System.Drawing.Color.White;
            this.TxtDiaChi.BorderColor = System.Drawing.Color.Silver;
            this.TxtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDiaChi.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtDiaChi.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtDiaChi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtDiaChi.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiaChi.ForeColor = System.Drawing.Color.Gray;
            this.TxtDiaChi.Location = new System.Drawing.Point(12, 169);
            this.TxtDiaChi.Name = "TxtDiaChi";
            this.TxtDiaChi.PasswordChar = '\0';
            this.TxtDiaChi.Size = new System.Drawing.Size(355, 34);
            this.TxtDiaChi.TabIndex = 27;
            this.TxtDiaChi.Text = "Địa chỉ";
            this.TxtDiaChi.Enter += new System.EventHandler(this.TxtDiaChi_Enter);
            this.TxtDiaChi.Leave += new System.EventHandler(this.TxtDiaChi_Leave);
            // 
            // TxtSDT
            // 
            this.TxtSDT.BaseColor = System.Drawing.Color.White;
            this.TxtSDT.BorderColor = System.Drawing.Color.Silver;
            this.TxtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSDT.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtSDT.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtSDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtSDT.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSDT.ForeColor = System.Drawing.Color.Gray;
            this.TxtSDT.Location = new System.Drawing.Point(12, 209);
            this.TxtSDT.Name = "TxtSDT";
            this.TxtSDT.PasswordChar = '\0';
            this.TxtSDT.Size = new System.Drawing.Size(355, 34);
            this.TxtSDT.TabIndex = 26;
            this.TxtSDT.Text = "Số điện thoại";
            this.TxtSDT.Enter += new System.EventHandler(this.TxtSDT_Enter);
            this.TxtSDT.Leave += new System.EventHandler(this.TxtSDT_Leave);
            // 
            // TxtDiem
            // 
            this.TxtDiem.BaseColor = System.Drawing.Color.White;
            this.TxtDiem.BorderColor = System.Drawing.Color.Silver;
            this.TxtDiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDiem.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtDiem.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtDiem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtDiem.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiem.ForeColor = System.Drawing.Color.Gray;
            this.TxtDiem.Location = new System.Drawing.Point(12, 249);
            this.TxtDiem.Name = "TxtDiem";
            this.TxtDiem.PasswordChar = '\0';
            this.TxtDiem.Size = new System.Drawing.Size(355, 34);
            this.TxtDiem.TabIndex = 25;
            this.TxtDiem.Text = "Điểm tích lũy";
            this.TxtDiem.Enter += new System.EventHandler(this.TxtDiem_Enter);
            this.TxtDiem.Leave += new System.EventHandler(this.TxtDiem_Leave);
            // 
            // GrKhachHang
            // 
            this.GrKhachHang.BaseColor = System.Drawing.Color.White;
            this.GrKhachHang.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrKhachHang.BorderSize = 2;
            this.GrKhachHang.Controls.Add(this.TxtMaHang);
            this.GrKhachHang.Controls.Add(this.TxtNamGB);
            this.GrKhachHang.Controls.Add(this.TxtDiaChi);
            this.GrKhachHang.Controls.Add(this.TxtSDT);
            this.GrKhachHang.Controls.Add(this.TxtDiem);
            this.GrKhachHang.Controls.Add(this.TxtNgayTao);
            this.GrKhachHang.Controls.Add(this.TxtHoTen);
            this.GrKhachHang.Controls.Add(this.TxtMaKH);
            this.GrKhachHang.Controls.Add(this.DateTimeNow);
            this.GrKhachHang.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrKhachHang.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrKhachHang.Location = new System.Drawing.Point(23, 69);
            this.GrKhachHang.Name = "GrKhachHang";
            this.GrKhachHang.Size = new System.Drawing.Size(383, 412);
            this.GrKhachHang.TabIndex = 50;
            this.GrKhachHang.Text = "Thêm thông tin";
            this.GrKhachHang.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(311, 29);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(37, 34);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 49;
            this.gunaPictureBox1.TabStop = false;
            // 
            // DGVKhachHang
            // 
            this.DGVKhachHang.AllowUserToAddRows = false;
            this.DGVKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVKhachHang.BackgroundColor = System.Drawing.Color.LightGray;
            this.DGVKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVKhachHang.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVKhachHang.EnableHeadersVisualStyles = false;
            this.DGVKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVKhachHang.Location = new System.Drawing.Point(428, 89);
            this.DGVKhachHang.Name = "DGVKhachHang";
            this.DGVKhachHang.ReadOnly = true;
            this.DGVKhachHang.RowHeadersVisible = false;
            this.DGVKhachHang.RowHeadersWidth = 51;
            this.DGVKhachHang.RowTemplate.Height = 24;
            this.DGVKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVKhachHang.Size = new System.Drawing.Size(686, 568);
            this.DGVKhachHang.TabIndex = 48;
            this.DGVKhachHang.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVKhachHang.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DGVKhachHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVKhachHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVKhachHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVKhachHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVKhachHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVKhachHang.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVKhachHang.ThemeStyle.ReadOnly = true;
            this.DGVKhachHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVKhachHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVKhachHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVKhachHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVKhachHang.ThemeStyle.RowsStyle.Height = 24;
            this.DGVKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVKhachHang.Click += new System.EventHandler(this.DGVKhachHang_Click);
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.Location = new System.Drawing.Point(954, 35);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(160, 28);
            this.LblAdmin.TabIndex = 47;
            this.LblAdmin.Text = "Khuất Văn Vương";
            this.LblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 677);
            this.Controls.Add(this.PtbLoading);
            this.Controls.Add(this.GrChucNang);
            this.Controls.Add(this.TxtTimKiem);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.GrKhachHang);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.DGVKhachHang);
            this.Controls.Add(this.LblAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KhachHang";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).EndInit();
            this.GrChucNang.ResumeLayout(false);
            this.GrKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTransfarantPictureBox PtbLoading;
        private Guna.UI.WinForms.GunaTextBox TxtMaHang;
        private MetroFramework.Controls.MetroDateTime DateTimeNow;
        private System.Windows.Forms.Timer TimeWaiting;
        private Guna.UI.WinForms.GunaTextBox TxtNgayTao;
        private Guna.UI.WinForms.GunaTextBox TxtHoTen;
        private Guna.UI.WinForms.GunaTextBox TxtMaKH;
        private Guna.UI.WinForms.GunaGroupBox GrChucNang;
        private Guna.UI.WinForms.GunaButton BtnXoa;
        private Guna.UI.WinForms.GunaButton BtnThoat;
        private Guna.UI.WinForms.GunaButton BtnSua;
        private Guna.UI.WinForms.GunaButton BtnThem;
        private Guna.UI.WinForms.GunaTextBox TxtTimKiem;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox TxtNamGB;
        private Guna.UI.WinForms.GunaTextBox TxtDiaChi;
        private Guna.UI.WinForms.GunaTextBox TxtSDT;
        private Guna.UI.WinForms.GunaTextBox TxtDiem;
        private Guna.UI.WinForms.GunaGroupBox GrKhachHang;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaDataGridView DGVKhachHang;
        public Guna.UI.WinForms.GunaLabel LblAdmin;
    }
}