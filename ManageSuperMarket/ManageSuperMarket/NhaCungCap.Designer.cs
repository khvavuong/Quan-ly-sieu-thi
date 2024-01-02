namespace ManageSuperMarket
{
    partial class NhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCungCap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrNCC = new Guna.UI.WinForms.GunaGroupBox();
            this.TxtDiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.TxtSDT = new Guna.UI.WinForms.GunaTextBox();
            this.TxtCongNo = new Guna.UI.WinForms.GunaTextBox();
            this.TxtTenNCC = new Guna.UI.WinForms.GunaTextBox();
            this.TxtMaNCC = new Guna.UI.WinForms.GunaTextBox();
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
            this.DGVNCC = new Guna.UI.WinForms.GunaDataGridView();
            this.TimeWaiting = new System.Windows.Forms.Timer(this.components);
            this.PtbLoading = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.GrNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.GrChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // GrNCC
            // 
            this.GrNCC.BaseColor = System.Drawing.Color.White;
            this.GrNCC.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrNCC.BorderSize = 2;
            this.GrNCC.Controls.Add(this.TxtDiaChi);
            this.GrNCC.Controls.Add(this.TxtSDT);
            this.GrNCC.Controls.Add(this.TxtCongNo);
            this.GrNCC.Controls.Add(this.TxtTenNCC);
            this.GrNCC.Controls.Add(this.TxtMaNCC);
            this.GrNCC.Controls.Add(this.DateTimeNow);
            this.GrNCC.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrNCC.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrNCC.Location = new System.Drawing.Point(23, 95);
            this.GrNCC.Name = "GrNCC";
            this.GrNCC.Size = new System.Drawing.Size(383, 337);
            this.GrNCC.TabIndex = 58;
            this.GrNCC.Text = "Thêm thông tin";
            this.GrNCC.TextLocation = new System.Drawing.Point(10, 8);
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
            this.TxtDiaChi.Location = new System.Drawing.Point(12, 183);
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
            this.TxtSDT.Location = new System.Drawing.Point(12, 232);
            this.TxtSDT.Name = "TxtSDT";
            this.TxtSDT.PasswordChar = '\0';
            this.TxtSDT.Size = new System.Drawing.Size(355, 34);
            this.TxtSDT.TabIndex = 26;
            this.TxtSDT.Text = "Số điện thoại";
            this.TxtSDT.Enter += new System.EventHandler(this.TxtSDT_Enter);
            this.TxtSDT.Leave += new System.EventHandler(this.TxtSDT_Leave);
            // 
            // TxtCongNo
            // 
            this.TxtCongNo.BaseColor = System.Drawing.Color.White;
            this.TxtCongNo.BorderColor = System.Drawing.Color.Silver;
            this.TxtCongNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCongNo.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtCongNo.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtCongNo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtCongNo.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCongNo.ForeColor = System.Drawing.Color.Gray;
            this.TxtCongNo.Location = new System.Drawing.Point(12, 281);
            this.TxtCongNo.Name = "TxtCongNo";
            this.TxtCongNo.PasswordChar = '\0';
            this.TxtCongNo.Size = new System.Drawing.Size(355, 34);
            this.TxtCongNo.TabIndex = 25;
            this.TxtCongNo.Text = "Công nợ";
            this.TxtCongNo.Enter += new System.EventHandler(this.TxtCongNo_Enter);
            this.TxtCongNo.Leave += new System.EventHandler(this.TxtCongNo_Leave);
            // 
            // TxtTenNCC
            // 
            this.TxtTenNCC.BaseColor = System.Drawing.Color.White;
            this.TxtTenNCC.BorderColor = System.Drawing.Color.Silver;
            this.TxtTenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTenNCC.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtTenNCC.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtTenNCC.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTenNCC.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenNCC.ForeColor = System.Drawing.Color.Gray;
            this.TxtTenNCC.Location = new System.Drawing.Point(12, 136);
            this.TxtTenNCC.Name = "TxtTenNCC";
            this.TxtTenNCC.PasswordChar = '\0';
            this.TxtTenNCC.Size = new System.Drawing.Size(355, 34);
            this.TxtTenNCC.TabIndex = 23;
            this.TxtTenNCC.Text = "Tên nhà cung cấp";
            this.TxtTenNCC.Enter += new System.EventHandler(this.TxtTenNCC_Enter);
            this.TxtTenNCC.Leave += new System.EventHandler(this.TxtTenNCC_Leave);
            // 
            // TxtMaNCC
            // 
            this.TxtMaNCC.BaseColor = System.Drawing.Color.White;
            this.TxtMaNCC.BorderColor = System.Drawing.Color.Silver;
            this.TxtMaNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMaNCC.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtMaNCC.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMaNCC.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMaNCC.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaNCC.ForeColor = System.Drawing.Color.Gray;
            this.TxtMaNCC.Location = new System.Drawing.Point(12, 87);
            this.TxtMaNCC.Name = "TxtMaNCC";
            this.TxtMaNCC.PasswordChar = '\0';
            this.TxtMaNCC.Size = new System.Drawing.Size(355, 34);
            this.TxtMaNCC.TabIndex = 22;
            this.TxtMaNCC.Text = "Mã nhà cung cấp";
            this.TxtMaNCC.Enter += new System.EventHandler(this.TxtMaNCC_Enter);
            this.TxtMaNCC.Leave += new System.EventHandler(this.TxtMaNCC_Leave);
            // 
            // DateTimeNow
            // 
            this.DateTimeNow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeNow.Location = new System.Drawing.Point(12, 41);
            this.DateTimeNow.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateTimeNow.Name = "DateTimeNow";
            this.DateTimeNow.Size = new System.Drawing.Size(355, 31);
            this.DateTimeNow.TabIndex = 0;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(230, 27);
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
            this.LblAdmin.Location = new System.Drawing.Point(954, 41);
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
            this.gunaLabel1.Location = new System.Drawing.Point(846, 41);
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
            this.BtnXoa.Location = new System.Drawing.Point(12, 110);
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
            this.BtnThoat.Location = new System.Drawing.Point(207, 110);
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
            this.TxtTimKiem.Location = new System.Drawing.Point(428, 55);
            this.TxtTimKiem.Name = "TxtTimKiem";
            this.TxtTimKiem.PasswordChar = '\0';
            this.TxtTimKiem.Size = new System.Drawing.Size(337, 34);
            this.TxtTimKiem.TabIndex = 59;
            this.TxtTimKiem.Text = "Nhập nhà cung cấp cần tìm kiếm";
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
            this.BtnSua.Location = new System.Drawing.Point(207, 47);
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
            this.GrChucNang.Location = new System.Drawing.Point(23, 451);
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
            this.BtnThem.Location = new System.Drawing.Point(12, 47);
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
            // DGVNCC
            // 
            this.DGVNCC.AllowUserToAddRows = false;
            this.DGVNCC.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.DGVNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DGVNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVNCC.BackgroundColor = System.Drawing.Color.LightGray;
            this.DGVNCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVNCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVNCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DGVNCC.ColumnHeadersHeight = 40;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVNCC.DefaultCellStyle = dataGridViewCellStyle15;
            this.DGVNCC.EnableHeadersVisualStyles = false;
            this.DGVNCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVNCC.Location = new System.Drawing.Point(428, 95);
            this.DGVNCC.Name = "DGVNCC";
            this.DGVNCC.ReadOnly = true;
            this.DGVNCC.RowHeadersVisible = false;
            this.DGVNCC.RowHeadersWidth = 51;
            this.DGVNCC.RowTemplate.Height = 24;
            this.DGVNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVNCC.Size = new System.Drawing.Size(686, 568);
            this.DGVNCC.TabIndex = 56;
            this.DGVNCC.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVNCC.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVNCC.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVNCC.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVNCC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVNCC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVNCC.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DGVNCC.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVNCC.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVNCC.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVNCC.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVNCC.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVNCC.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVNCC.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVNCC.ThemeStyle.ReadOnly = true;
            this.DGVNCC.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVNCC.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVNCC.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVNCC.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVNCC.ThemeStyle.RowsStyle.Height = 24;
            this.DGVNCC.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVNCC.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVNCC.Click += new System.EventHandler(this.DGVNCC_Click);
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
            this.PtbLoading.Location = new System.Drawing.Point(323, 106);
            this.PtbLoading.Name = "PtbLoading";
            this.PtbLoading.Size = new System.Drawing.Size(500, 504);
            this.PtbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLoading.TabIndex = 61;
            this.PtbLoading.TabStop = false;
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 677);
            this.Controls.Add(this.GrNCC);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.TxtTimKiem);
            this.Controls.Add(this.GrChucNang);
            this.Controls.Add(this.DGVNCC);
            this.Controls.Add(this.PtbLoading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhaCungCap";
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.GrNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.GrChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox GrNCC;
        private Guna.UI.WinForms.GunaTextBox TxtDiaChi;
        private Guna.UI.WinForms.GunaTextBox TxtSDT;
        private Guna.UI.WinForms.GunaTextBox TxtCongNo;
        private Guna.UI.WinForms.GunaTextBox TxtTenNCC;
        private Guna.UI.WinForms.GunaTextBox TxtMaNCC;
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
        private Guna.UI.WinForms.GunaDataGridView DGVNCC;
        private System.Windows.Forms.Timer TimeWaiting;
        private Guna.UI.WinForms.GunaTransfarantPictureBox PtbLoading;
    }
}