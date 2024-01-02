namespace ManageSuperMarket
{
    partial class BanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblAdmin = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.DGVSanPham = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.GrBanHang = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.LblTien = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TxtChietKhau = new Guna.UI.WinForms.GunaTextBox();
            this.TxtNhap = new Guna.UI.WinForms.GunaTextBox();
            this.TxtTon = new Guna.UI.WinForms.GunaTextBox();
            this.TxtGiaNhap = new Guna.UI.WinForms.GunaTextBox();
            this.TxtDonViTinh = new Guna.UI.WinForms.GunaTextBox();
            this.TxtTenSanPham = new Guna.UI.WinForms.GunaTextBox();
            this.TxtMaSanPham = new Guna.UI.WinForms.GunaTextBox();
            this.DateTime = new MetroFramework.Controls.MetroDateTime();
            this.TxtTimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.GrChucNang = new Guna.UI.WinForms.GunaGroupBox();
            this.BtnThanhToan = new Guna.UI.WinForms.GunaButton();
            this.BtnThoat = new Guna.UI.WinForms.GunaButton();
            this.BtnNhapLai = new Guna.UI.WinForms.GunaButton();
            this.BtnThem = new Guna.UI.WinForms.GunaButton();
            this.PtbLoading = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.TimeWaiting = new System.Windows.Forms.Timer(this.components);
            this.DGVThanhToan = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.GrBanHang.SuspendLayout();
            this.GrChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.Location = new System.Drawing.Point(954, 35);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(160, 28);
            this.LblAdmin.TabIndex = 16;
            this.LblAdmin.Text = "Khuất Văn Vương";
            this.LblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(846, 35);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "Nhân viên:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.DGVSanPham.Location = new System.Drawing.Point(428, 89);
            this.DGVSanPham.Name = "DGVSanPham";
            this.DGVSanPham.ReadOnly = true;
            this.DGVSanPham.RowHeadersVisible = false;
            this.DGVSanPham.RowHeadersWidth = 51;
            this.DGVSanPham.RowTemplate.Height = 24;
            this.DGVSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSanPham.Size = new System.Drawing.Size(686, 333);
            this.DGVSanPham.TabIndex = 17;
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
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(168, 29);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(37, 34);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 19;
            this.gunaPictureBox1.TabStop = false;
            // 
            // GrBanHang
            // 
            this.GrBanHang.BaseColor = System.Drawing.Color.White;
            this.GrBanHang.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrBanHang.BorderSize = 2;
            this.GrBanHang.Controls.Add(this.gunaLabel4);
            this.GrBanHang.Controls.Add(this.LblTien);
            this.GrBanHang.Controls.Add(this.gunaLabel2);
            this.GrBanHang.Controls.Add(this.TxtChietKhau);
            this.GrBanHang.Controls.Add(this.TxtNhap);
            this.GrBanHang.Controls.Add(this.TxtTon);
            this.GrBanHang.Controls.Add(this.TxtGiaNhap);
            this.GrBanHang.Controls.Add(this.TxtDonViTinh);
            this.GrBanHang.Controls.Add(this.TxtTenSanPham);
            this.GrBanHang.Controls.Add(this.TxtMaSanPham);
            this.GrBanHang.Controls.Add(this.DateTime);
            this.GrBanHang.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrBanHang.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrBanHang.Location = new System.Drawing.Point(23, 69);
            this.GrBanHang.Name = "GrBanHang";
            this.GrBanHang.Size = new System.Drawing.Size(383, 409);
            this.GrBanHang.TabIndex = 20;
            this.GrBanHang.Text = "Thêm thông tin";
            this.GrBanHang.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(319, 375);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(48, 25);
            this.gunaLabel4.TabIndex = 31;
            this.gunaLabel4.Text = "VNĐ";
            // 
            // LblTien
            // 
            this.LblTien.AutoSize = true;
            this.LblTien.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTien.Location = new System.Drawing.Point(107, 375);
            this.LblTien.Name = "LblTien";
            this.LblTien.Size = new System.Drawing.Size(204, 25);
            this.LblTien.TabIndex = 30;
            this.LblTien.Text = "................................................";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(7, 375);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(98, 25);
            this.gunaLabel2.TabIndex = 29;
            this.gunaLabel2.Text = "Thành tiền:";
            // 
            // TxtChietKhau
            // 
            this.TxtChietKhau.BaseColor = System.Drawing.Color.White;
            this.TxtChietKhau.BorderColor = System.Drawing.Color.Silver;
            this.TxtChietKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtChietKhau.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtChietKhau.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtChietKhau.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtChietKhau.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtChietKhau.ForeColor = System.Drawing.Color.Gray;
            this.TxtChietKhau.Location = new System.Drawing.Point(12, 329);
            this.TxtChietKhau.Name = "TxtChietKhau";
            this.TxtChietKhau.PasswordChar = '\0';
            this.TxtChietKhau.Size = new System.Drawing.Size(355, 34);
            this.TxtChietKhau.TabIndex = 28;
            this.TxtChietKhau.Text = "Chiết khấu %";
            this.TxtChietKhau.Enter += new System.EventHandler(this.TxtChietKhau_Enter);
            this.TxtChietKhau.Leave += new System.EventHandler(this.TxtChietKhau_Leave);
            // 
            // TxtNhap
            // 
            this.TxtNhap.BaseColor = System.Drawing.Color.White;
            this.TxtNhap.BorderColor = System.Drawing.Color.Silver;
            this.TxtNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNhap.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNhap.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNhap.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNhap.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNhap.ForeColor = System.Drawing.Color.Gray;
            this.TxtNhap.Location = new System.Drawing.Point(12, 289);
            this.TxtNhap.Name = "TxtNhap";
            this.TxtNhap.PasswordChar = '\0';
            this.TxtNhap.Size = new System.Drawing.Size(355, 34);
            this.TxtNhap.TabIndex = 27;
            this.TxtNhap.Text = "Số lượng bán";
            this.TxtNhap.Enter += new System.EventHandler(this.TxtNhap_Enter);
            this.TxtNhap.Leave += new System.EventHandler(this.TxtNhap_Leave);
            // 
            // TxtTon
            // 
            this.TxtTon.BaseColor = System.Drawing.Color.White;
            this.TxtTon.BorderColor = System.Drawing.Color.Silver;
            this.TxtTon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTon.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtTon.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtTon.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTon.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTon.ForeColor = System.Drawing.Color.Gray;
            this.TxtTon.Location = new System.Drawing.Point(12, 249);
            this.TxtTon.Name = "TxtTon";
            this.TxtTon.PasswordChar = '\0';
            this.TxtTon.Size = new System.Drawing.Size(355, 34);
            this.TxtTon.TabIndex = 26;
            this.TxtTon.Text = "Số lượng tồn";
            this.TxtTon.Enter += new System.EventHandler(this.TxtTon_Enter);
            this.TxtTon.Leave += new System.EventHandler(this.TxtTon_Leave);
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
            this.TxtGiaNhap.Size = new System.Drawing.Size(355, 34);
            this.TxtGiaNhap.TabIndex = 25;
            this.TxtGiaNhap.Text = "Giá nhập";
            this.TxtGiaNhap.Enter += new System.EventHandler(this.TxtGiaNhap_Enter);
            this.TxtGiaNhap.Leave += new System.EventHandler(this.TxtGiaNhap_Leave);
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
            this.TxtDonViTinh.Location = new System.Drawing.Point(12, 169);
            this.TxtDonViTinh.Name = "TxtDonViTinh";
            this.TxtDonViTinh.PasswordChar = '\0';
            this.TxtDonViTinh.Size = new System.Drawing.Size(355, 34);
            this.TxtDonViTinh.TabIndex = 24;
            this.TxtDonViTinh.Text = "Đơn vị tính";
            this.TxtDonViTinh.Enter += new System.EventHandler(this.TxtDonViTinh_Enter);
            this.TxtDonViTinh.Leave += new System.EventHandler(this.TxtDonViTinh_Leave);
            // 
            // TxtTenSanPham
            // 
            this.TxtTenSanPham.BaseColor = System.Drawing.Color.White;
            this.TxtTenSanPham.BorderColor = System.Drawing.Color.Silver;
            this.TxtTenSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTenSanPham.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtTenSanPham.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtTenSanPham.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTenSanPham.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenSanPham.ForeColor = System.Drawing.Color.Gray;
            this.TxtTenSanPham.Location = new System.Drawing.Point(12, 129);
            this.TxtTenSanPham.Name = "TxtTenSanPham";
            this.TxtTenSanPham.PasswordChar = '\0';
            this.TxtTenSanPham.Size = new System.Drawing.Size(355, 34);
            this.TxtTenSanPham.TabIndex = 23;
            this.TxtTenSanPham.Text = "Tên sản phẩm";
            this.TxtTenSanPham.Enter += new System.EventHandler(this.TxtTenSanPham_Enter);
            this.TxtTenSanPham.Leave += new System.EventHandler(this.TxtTenSanPham_Leave);
            // 
            // TxtMaSanPham
            // 
            this.TxtMaSanPham.BaseColor = System.Drawing.Color.White;
            this.TxtMaSanPham.BorderColor = System.Drawing.Color.Silver;
            this.TxtMaSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMaSanPham.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtMaSanPham.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMaSanPham.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMaSanPham.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaSanPham.ForeColor = System.Drawing.Color.Gray;
            this.TxtMaSanPham.Location = new System.Drawing.Point(12, 89);
            this.TxtMaSanPham.Name = "TxtMaSanPham";
            this.TxtMaSanPham.PasswordChar = '\0';
            this.TxtMaSanPham.Size = new System.Drawing.Size(355, 34);
            this.TxtMaSanPham.TabIndex = 22;
            this.TxtMaSanPham.Text = "Mã sản phẩm";
            this.TxtMaSanPham.Enter += new System.EventHandler(this.TxtMaSanPham_Enter);
            this.TxtMaSanPham.Leave += new System.EventHandler(this.TxtMaSanPham_Leave);
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(12, 43);
            this.DateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(355, 31);
            this.DateTime.TabIndex = 0;
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
            this.TxtTimKiem.TabIndex = 21;
            this.TxtTimKiem.Text = "Nhập sản phẩm cần tìm kiếm";
            this.TxtTimKiem.TextChanged += new System.EventHandler(this.TxtTimKiem_TextChanged);
            this.TxtTimKiem.Enter += new System.EventHandler(this.TxtTimKiem_Enter);
            this.TxtTimKiem.Leave += new System.EventHandler(this.TxtTimKiem_Leave);
            // 
            // GrChucNang
            // 
            this.GrChucNang.BaseColor = System.Drawing.Color.White;
            this.GrChucNang.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrChucNang.BorderSize = 2;
            this.GrChucNang.Controls.Add(this.BtnThanhToan);
            this.GrChucNang.Controls.Add(this.BtnThoat);
            this.GrChucNang.Controls.Add(this.BtnNhapLai);
            this.GrChucNang.Controls.Add(this.BtnThem);
            this.GrChucNang.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrChucNang.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrChucNang.Location = new System.Drawing.Point(23, 484);
            this.GrChucNang.Name = "GrChucNang";
            this.GrChucNang.Size = new System.Drawing.Size(383, 170);
            this.GrChucNang.TabIndex = 32;
            this.GrChucNang.Text = "Chức năng";
            this.GrChucNang.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // BtnThanhToan
            // 
            this.BtnThanhToan.AnimationHoverSpeed = 0.07F;
            this.BtnThanhToan.AnimationSpeed = 0.03F;
            this.BtnThanhToan.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtnThanhToan.BorderColor = System.Drawing.Color.Black;
            this.BtnThanhToan.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThanhToan.ForeColor = System.Drawing.Color.White;
            this.BtnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("BtnThanhToan.Image")));
            this.BtnThanhToan.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnThanhToan.Location = new System.Drawing.Point(12, 111);
            this.BtnThanhToan.Name = "BtnThanhToan";
            this.BtnThanhToan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnThanhToan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnThanhToan.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnThanhToan.OnHoverImage = null;
            this.BtnThanhToan.OnPressedColor = System.Drawing.Color.Black;
            this.BtnThanhToan.Size = new System.Drawing.Size(160, 42);
            this.BtnThanhToan.TabIndex = 3;
            this.BtnThanhToan.Text = "Thanh toán";
            this.BtnThanhToan.Click += new System.EventHandler(this.BtnThanhToan_Click);
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
            // BtnNhapLai
            // 
            this.BtnNhapLai.AnimationHoverSpeed = 0.07F;
            this.BtnNhapLai.AnimationSpeed = 0.03F;
            this.BtnNhapLai.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtnNhapLai.BorderColor = System.Drawing.Color.Black;
            this.BtnNhapLai.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNhapLai.ForeColor = System.Drawing.Color.White;
            this.BtnNhapLai.Image = ((System.Drawing.Image)(resources.GetObject("BtnNhapLai.Image")));
            this.BtnNhapLai.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnNhapLai.Location = new System.Drawing.Point(207, 48);
            this.BtnNhapLai.Name = "BtnNhapLai";
            this.BtnNhapLai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnNhapLai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnNhapLai.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnNhapLai.OnHoverImage = null;
            this.BtnNhapLai.OnPressedColor = System.Drawing.Color.Black;
            this.BtnNhapLai.Size = new System.Drawing.Size(160, 42);
            this.BtnNhapLai.TabIndex = 1;
            this.BtnNhapLai.Text = "Nhập lại";
            this.BtnNhapLai.Click += new System.EventHandler(this.BtnNhapLai_Click);
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
            // PtbLoading
            // 
            this.PtbLoading.BackColor = System.Drawing.Color.Transparent;
            this.PtbLoading.BaseColor = System.Drawing.Color.Black;
            this.PtbLoading.Image = ((System.Drawing.Image)(resources.GetObject("PtbLoading.Image")));
            this.PtbLoading.Location = new System.Drawing.Point(319, 98);
            this.PtbLoading.Name = "PtbLoading";
            this.PtbLoading.Size = new System.Drawing.Size(500, 504);
            this.PtbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLoading.TabIndex = 33;
            this.PtbLoading.TabStop = false;
            // 
            // TimeWaiting
            // 
            this.TimeWaiting.Enabled = true;
            this.TimeWaiting.Interval = 1000;
            this.TimeWaiting.Tick += new System.EventHandler(this.TimeWaiting_Tick);
            // 
            // DGVThanhToan
            // 
            this.DGVThanhToan.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVThanhToan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVThanhToan.BackgroundColor = System.Drawing.Color.LightGray;
            this.DGVThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVThanhToan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVThanhToan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVThanhToan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVThanhToan.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVThanhToan.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVThanhToan.EnableHeadersVisualStyles = false;
            this.DGVThanhToan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVThanhToan.Location = new System.Drawing.Point(428, 445);
            this.DGVThanhToan.Name = "DGVThanhToan";
            this.DGVThanhToan.ReadOnly = true;
            this.DGVThanhToan.RowHeadersVisible = false;
            this.DGVThanhToan.RowHeadersWidth = 51;
            this.DGVThanhToan.RowTemplate.Height = 24;
            this.DGVThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVThanhToan.Size = new System.Drawing.Size(686, 209);
            this.DGVThanhToan.TabIndex = 36;
            this.DGVThanhToan.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVThanhToan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVThanhToan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVThanhToan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVThanhToan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVThanhToan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVThanhToan.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DGVThanhToan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVThanhToan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVThanhToan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVThanhToan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVThanhToan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVThanhToan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVThanhToan.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVThanhToan.ThemeStyle.ReadOnly = true;
            this.DGVThanhToan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVThanhToan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVThanhToan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVThanhToan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVThanhToan.ThemeStyle.RowsStyle.Height = 24;
            this.DGVThanhToan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVThanhToan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 677);
            this.Controls.Add(this.PtbLoading);
            this.Controls.Add(this.DGVThanhToan);
            this.Controls.Add(this.GrChucNang);
            this.Controls.Add(this.TxtTimKiem);
            this.Controls.Add(this.GrBanHang);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.DGVSanPham);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.gunaLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BanHang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.GrBanHang.ResumeLayout(false);
            this.GrBanHang.PerformLayout();
            this.GrChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaLabel LblAdmin;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView DGVSanPham;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaGroupBox GrBanHang;
        private MetroFramework.Controls.MetroDateTime DateTime;
        private Guna.UI.WinForms.GunaTextBox TxtTimKiem;
        private Guna.UI.WinForms.GunaTextBox TxtMaSanPham;
        private Guna.UI.WinForms.GunaTextBox TxtChietKhau;
        private Guna.UI.WinForms.GunaTextBox TxtNhap;
        private Guna.UI.WinForms.GunaTextBox TxtTon;
        private Guna.UI.WinForms.GunaTextBox TxtGiaNhap;
        private Guna.UI.WinForms.GunaTextBox TxtDonViTinh;
        private Guna.UI.WinForms.GunaTextBox TxtTenSanPham;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel LblTien;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaGroupBox GrChucNang;
        private Guna.UI.WinForms.GunaButton BtnThanhToan;
        private Guna.UI.WinForms.GunaButton BtnThoat;
        private Guna.UI.WinForms.GunaButton BtnNhapLai;
        private Guna.UI.WinForms.GunaButton BtnThem;
        private Guna.UI.WinForms.GunaTransfarantPictureBox PtbLoading;
        private System.Windows.Forms.Timer TimeWaiting;
        private Guna.UI.WinForms.GunaDataGridView DGVThanhToan;
    }
}