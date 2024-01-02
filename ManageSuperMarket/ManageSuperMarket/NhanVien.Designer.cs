namespace ManageSuperMarket
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle133 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle134 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle135 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle136 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle137 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle138 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PtbLoading = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.DGVTaiKhoan = new Guna.UI.WinForms.GunaDataGridView();
            this.BtnThoat = new Guna.UI.WinForms.GunaButton();
            this.BtnSua = new Guna.UI.WinForms.GunaButton();
            this.BtnThem = new Guna.UI.WinForms.GunaButton();
            this.TxtTenDN = new Guna.UI.WinForms.GunaTextBox();
            this.TxtDiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.TxtSDT = new Guna.UI.WinForms.GunaTextBox();
            this.TxtGioiTinh = new Guna.UI.WinForms.GunaTextBox();
            this.BtnXoa = new Guna.UI.WinForms.GunaButton();
            this.GrChucNang = new Guna.UI.WinForms.GunaGroupBox();
            this.TxtTimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.TxtNgaySinh = new Guna.UI.WinForms.GunaTextBox();
            this.TxtHoTen = new Guna.UI.WinForms.GunaTextBox();
            this.TxtMaNhanVien = new Guna.UI.WinForms.GunaTextBox();
            this.TimeWaiting = new System.Windows.Forms.Timer(this.components);
            this.GrNhanVien = new Guna.UI.WinForms.GunaGroupBox();
            this.TxtTrangThai = new Guna.UI.WinForms.GunaTextBox();
            this.TxtMaCV = new Guna.UI.WinForms.GunaTextBox();
            this.DateTimeNow = new MetroFramework.Controls.MetroDateTime();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.DGVNhanVien = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.LblAdmin = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTaiKhoan)).BeginInit();
            this.GrChucNang.SuspendLayout();
            this.GrNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // PtbLoading
            // 
            this.PtbLoading.BackColor = System.Drawing.Color.Transparent;
            this.PtbLoading.BaseColor = System.Drawing.Color.Black;
            this.PtbLoading.Image = ((System.Drawing.Image)(resources.GetObject("PtbLoading.Image")));
            this.PtbLoading.Location = new System.Drawing.Point(311, 95);
            this.PtbLoading.Name = "PtbLoading";
            this.PtbLoading.Size = new System.Drawing.Size(500, 504);
            this.PtbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLoading.TabIndex = 44;
            this.PtbLoading.TabStop = false;
            // 
            // DGVTaiKhoan
            // 
            this.DGVTaiKhoan.AllowUserToAddRows = false;
            this.DGVTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle133.BackColor = System.Drawing.Color.White;
            this.DGVTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle133;
            this.DGVTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTaiKhoan.BackgroundColor = System.Drawing.Color.LightGray;
            this.DGVTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVTaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle134.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle134.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle134.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle134.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle134.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle134.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle134.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle134;
            this.DGVTaiKhoan.ColumnHeadersHeight = 40;
            dataGridViewCellStyle135.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle135.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle135.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle135.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle135.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle135.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle135.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVTaiKhoan.DefaultCellStyle = dataGridViewCellStyle135;
            this.DGVTaiKhoan.EnableHeadersVisualStyles = false;
            this.DGVTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTaiKhoan.Location = new System.Drawing.Point(428, 442);
            this.DGVTaiKhoan.Name = "DGVTaiKhoan";
            this.DGVTaiKhoan.ReadOnly = true;
            this.DGVTaiKhoan.RowHeadersVisible = false;
            this.DGVTaiKhoan.RowHeadersWidth = 51;
            this.DGVTaiKhoan.RowTemplate.Height = 24;
            this.DGVTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTaiKhoan.Size = new System.Drawing.Size(686, 212);
            this.DGVTaiKhoan.TabIndex = 45;
            this.DGVTaiKhoan.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVTaiKhoan.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DGVTaiKhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTaiKhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVTaiKhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVTaiKhoan.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVTaiKhoan.ThemeStyle.ReadOnly = true;
            this.DGVTaiKhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVTaiKhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVTaiKhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVTaiKhoan.ThemeStyle.RowsStyle.Height = 24;
            this.DGVTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // TxtTenDN
            // 
            this.TxtTenDN.BaseColor = System.Drawing.Color.White;
            this.TxtTenDN.BorderColor = System.Drawing.Color.Silver;
            this.TxtTenDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTenDN.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtTenDN.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtTenDN.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTenDN.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenDN.ForeColor = System.Drawing.Color.Gray;
            this.TxtTenDN.Location = new System.Drawing.Point(12, 329);
            this.TxtTenDN.Name = "TxtTenDN";
            this.TxtTenDN.PasswordChar = '\0';
            this.TxtTenDN.Size = new System.Drawing.Size(355, 34);
            this.TxtTenDN.TabIndex = 28;
            this.TxtTenDN.Text = "Tên đăng nhập";
            this.TxtTenDN.Enter += new System.EventHandler(this.TxtTenDN_Enter);
            this.TxtTenDN.Leave += new System.EventHandler(this.TxtTenDN_Leave);
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
            this.TxtDiaChi.Location = new System.Drawing.Point(12, 289);
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
            this.TxtSDT.Location = new System.Drawing.Point(12, 249);
            this.TxtSDT.Name = "TxtSDT";
            this.TxtSDT.PasswordChar = '\0';
            this.TxtSDT.Size = new System.Drawing.Size(355, 34);
            this.TxtSDT.TabIndex = 26;
            this.TxtSDT.Text = "Số điện thoại";
            this.TxtSDT.Enter += new System.EventHandler(this.TxtSDT_Enter);
            this.TxtSDT.Leave += new System.EventHandler(this.TxtSDT_Leave);
            // 
            // TxtGioiTinh
            // 
            this.TxtGioiTinh.BaseColor = System.Drawing.Color.White;
            this.TxtGioiTinh.BorderColor = System.Drawing.Color.Silver;
            this.TxtGioiTinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtGioiTinh.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtGioiTinh.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtGioiTinh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtGioiTinh.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGioiTinh.ForeColor = System.Drawing.Color.Gray;
            this.TxtGioiTinh.Location = new System.Drawing.Point(12, 209);
            this.TxtGioiTinh.Name = "TxtGioiTinh";
            this.TxtGioiTinh.PasswordChar = '\0';
            this.TxtGioiTinh.Size = new System.Drawing.Size(355, 34);
            this.TxtGioiTinh.TabIndex = 25;
            this.TxtGioiTinh.Text = "Giới tính";
            this.TxtGioiTinh.Enter += new System.EventHandler(this.TxtGioiTinh_Enter);
            this.TxtGioiTinh.Leave += new System.EventHandler(this.TxtGioiTinh_Leave);
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
            this.GrChucNang.TabIndex = 43;
            this.GrChucNang.Text = "Chức năng";
            this.GrChucNang.TextLocation = new System.Drawing.Point(10, 8);
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
            this.TxtTimKiem.TabIndex = 42;
            this.TxtTimKiem.Text = "Nhập nhân viên cần tìm kiếm";
            this.TxtTimKiem.TextChanged += new System.EventHandler(this.TxtTimKiem_TextChanged);
            this.TxtTimKiem.Enter += new System.EventHandler(this.TxtTimKiem_Enter);
            this.TxtTimKiem.Leave += new System.EventHandler(this.TxtTimKiem_Leave);
            // 
            // TxtNgaySinh
            // 
            this.TxtNgaySinh.BaseColor = System.Drawing.Color.White;
            this.TxtNgaySinh.BorderColor = System.Drawing.Color.Silver;
            this.TxtNgaySinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNgaySinh.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNgaySinh.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNgaySinh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNgaySinh.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNgaySinh.ForeColor = System.Drawing.Color.Gray;
            this.TxtNgaySinh.Location = new System.Drawing.Point(12, 169);
            this.TxtNgaySinh.Name = "TxtNgaySinh";
            this.TxtNgaySinh.PasswordChar = '\0';
            this.TxtNgaySinh.Size = new System.Drawing.Size(355, 34);
            this.TxtNgaySinh.TabIndex = 24;
            this.TxtNgaySinh.Text = "Ngày sinh";
            this.TxtNgaySinh.Enter += new System.EventHandler(this.TxtNgaySinh_Enter);
            this.TxtNgaySinh.Leave += new System.EventHandler(this.TxtNgaySinh_Leave);
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
            this.TxtHoTen.Text = "Họ và tên";
            this.TxtHoTen.Enter += new System.EventHandler(this.TxtHoTen_Enter);
            this.TxtHoTen.Leave += new System.EventHandler(this.TxtHoTen_Leave);
            // 
            // TxtMaNhanVien
            // 
            this.TxtMaNhanVien.BaseColor = System.Drawing.Color.White;
            this.TxtMaNhanVien.BorderColor = System.Drawing.Color.Silver;
            this.TxtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMaNhanVien.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtMaNhanVien.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMaNhanVien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMaNhanVien.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaNhanVien.ForeColor = System.Drawing.Color.Gray;
            this.TxtMaNhanVien.Location = new System.Drawing.Point(12, 89);
            this.TxtMaNhanVien.Name = "TxtMaNhanVien";
            this.TxtMaNhanVien.PasswordChar = '\0';
            this.TxtMaNhanVien.Size = new System.Drawing.Size(355, 34);
            this.TxtMaNhanVien.TabIndex = 22;
            this.TxtMaNhanVien.Text = "Mã nhân viên";
            this.TxtMaNhanVien.Enter += new System.EventHandler(this.TxtMaNhanVien_Enter);
            this.TxtMaNhanVien.Leave += new System.EventHandler(this.TxtMaNhanVien_Leave);
            // 
            // TimeWaiting
            // 
            this.TimeWaiting.Enabled = true;
            this.TimeWaiting.Interval = 1000;
            this.TimeWaiting.Tick += new System.EventHandler(this.TimeWaiting_Tick);
            // 
            // GrNhanVien
            // 
            this.GrNhanVien.BaseColor = System.Drawing.Color.White;
            this.GrNhanVien.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrNhanVien.BorderSize = 2;
            this.GrNhanVien.Controls.Add(this.TxtTrangThai);
            this.GrNhanVien.Controls.Add(this.TxtMaCV);
            this.GrNhanVien.Controls.Add(this.TxtTenDN);
            this.GrNhanVien.Controls.Add(this.TxtDiaChi);
            this.GrNhanVien.Controls.Add(this.TxtSDT);
            this.GrNhanVien.Controls.Add(this.TxtGioiTinh);
            this.GrNhanVien.Controls.Add(this.TxtNgaySinh);
            this.GrNhanVien.Controls.Add(this.TxtHoTen);
            this.GrNhanVien.Controls.Add(this.TxtMaNhanVien);
            this.GrNhanVien.Controls.Add(this.DateTimeNow);
            this.GrNhanVien.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrNhanVien.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrNhanVien.Location = new System.Drawing.Point(23, 66);
            this.GrNhanVien.Name = "GrNhanVien";
            this.GrNhanVien.Size = new System.Drawing.Size(383, 412);
            this.GrNhanVien.TabIndex = 41;
            this.GrNhanVien.Text = "Thêm thông tin";
            this.GrNhanVien.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // TxtTrangThai
            // 
            this.TxtTrangThai.BaseColor = System.Drawing.Color.White;
            this.TxtTrangThai.BorderColor = System.Drawing.Color.Silver;
            this.TxtTrangThai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTrangThai.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtTrangThai.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtTrangThai.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTrangThai.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTrangThai.ForeColor = System.Drawing.Color.Gray;
            this.TxtTrangThai.Location = new System.Drawing.Point(207, 369);
            this.TxtTrangThai.Name = "TxtTrangThai";
            this.TxtTrangThai.PasswordChar = '\0';
            this.TxtTrangThai.Size = new System.Drawing.Size(160, 34);
            this.TxtTrangThai.TabIndex = 30;
            this.TxtTrangThai.Text = "Trạng thái";
            this.TxtTrangThai.Enter += new System.EventHandler(this.TxtTrangThai_Enter);
            this.TxtTrangThai.Leave += new System.EventHandler(this.TxtTrangThai_Leave);
            // 
            // TxtMaCV
            // 
            this.TxtMaCV.BaseColor = System.Drawing.Color.White;
            this.TxtMaCV.BorderColor = System.Drawing.Color.Silver;
            this.TxtMaCV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMaCV.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtMaCV.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMaCV.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMaCV.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaCV.ForeColor = System.Drawing.Color.Gray;
            this.TxtMaCV.Location = new System.Drawing.Point(12, 369);
            this.TxtMaCV.Name = "TxtMaCV";
            this.TxtMaCV.PasswordChar = '\0';
            this.TxtMaCV.Size = new System.Drawing.Size(160, 34);
            this.TxtMaCV.TabIndex = 29;
            this.TxtMaCV.Text = "Mã chức vụ";
            this.TxtMaCV.Enter += new System.EventHandler(this.TxtMaCV_Enter);
            this.TxtMaCV.Leave += new System.EventHandler(this.TxtMaCV_Leave);
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
            this.gunaPictureBox1.Location = new System.Drawing.Point(282, 26);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(37, 34);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 40;
            this.gunaPictureBox1.TabStop = false;
            // 
            // DGVNhanVien
            // 
            this.DGVNhanVien.AllowUserToAddRows = false;
            this.DGVNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle136.BackColor = System.Drawing.Color.White;
            this.DGVNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle136;
            this.DGVNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVNhanVien.BackgroundColor = System.Drawing.Color.LightGray;
            this.DGVNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle137.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle137.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle137.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle137.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle137.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle137.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle137.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle137;
            this.DGVNhanVien.ColumnHeadersHeight = 40;
            dataGridViewCellStyle138.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle138.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle138.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle138.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle138.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle138.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle138.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVNhanVien.DefaultCellStyle = dataGridViewCellStyle138;
            this.DGVNhanVien.EnableHeadersVisualStyles = false;
            this.DGVNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVNhanVien.Location = new System.Drawing.Point(428, 86);
            this.DGVNhanVien.Name = "DGVNhanVien";
            this.DGVNhanVien.ReadOnly = true;
            this.DGVNhanVien.RowHeadersVisible = false;
            this.DGVNhanVien.RowHeadersWidth = 51;
            this.DGVNhanVien.RowTemplate.Height = 24;
            this.DGVNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVNhanVien.Size = new System.Drawing.Size(686, 333);
            this.DGVNhanVien.TabIndex = 39;
            this.DGVNhanVien.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVNhanVien.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DGVNhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVNhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVNhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVNhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVNhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVNhanVien.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVNhanVien.ThemeStyle.ReadOnly = true;
            this.DGVNhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVNhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVNhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVNhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVNhanVien.ThemeStyle.RowsStyle.Height = 24;
            this.DGVNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVNhanVien.Click += new System.EventHandler(this.DGVNhanVien_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(846, 32);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel1.TabIndex = 37;
            this.gunaLabel1.Text = "Nhân viên:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.Location = new System.Drawing.Point(954, 32);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(160, 28);
            this.LblAdmin.TabIndex = 38;
            this.LblAdmin.Text = "Khuất Văn Vương";
            this.LblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 677);
            this.Controls.Add(this.PtbLoading);
            this.Controls.Add(this.DGVTaiKhoan);
            this.Controls.Add(this.GrChucNang);
            this.Controls.Add(this.TxtTimKiem);
            this.Controls.Add(this.GrNhanVien);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.DGVNhanVien);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.LblAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTaiKhoan)).EndInit();
            this.GrChucNang.ResumeLayout(false);
            this.GrNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTransfarantPictureBox PtbLoading;
        private Guna.UI.WinForms.GunaDataGridView DGVTaiKhoan;
        private Guna.UI.WinForms.GunaButton BtnThoat;
        private Guna.UI.WinForms.GunaButton BtnSua;
        private Guna.UI.WinForms.GunaButton BtnThem;
        private Guna.UI.WinForms.GunaTextBox TxtTenDN;
        private Guna.UI.WinForms.GunaTextBox TxtDiaChi;
        private Guna.UI.WinForms.GunaTextBox TxtSDT;
        private Guna.UI.WinForms.GunaTextBox TxtGioiTinh;
        private Guna.UI.WinForms.GunaButton BtnXoa;
        private Guna.UI.WinForms.GunaGroupBox GrChucNang;
        private Guna.UI.WinForms.GunaTextBox TxtTimKiem;
        private Guna.UI.WinForms.GunaTextBox TxtNgaySinh;
        private Guna.UI.WinForms.GunaTextBox TxtHoTen;
        private Guna.UI.WinForms.GunaTextBox TxtMaNhanVien;
        private System.Windows.Forms.Timer TimeWaiting;
        private Guna.UI.WinForms.GunaGroupBox GrNhanVien;
        private MetroFramework.Controls.MetroDateTime DateTimeNow;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaDataGridView DGVNhanVien;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaLabel LblAdmin;
        private Guna.UI.WinForms.GunaTextBox TxtTrangThai;
        private Guna.UI.WinForms.GunaTextBox TxtMaCV;
    }
}