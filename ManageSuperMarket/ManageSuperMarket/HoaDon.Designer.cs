namespace ManageSuperMarket
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.GrHoaDon = new Guna.UI.WinForms.GunaGroupBox();
            this.TxtNhanVien = new Guna.UI.WinForms.GunaTextBox();
            this.TxtNgayBan = new Guna.UI.WinForms.GunaTextBox();
            this.TxtTong = new Guna.UI.WinForms.GunaTextBox();
            this.TxtTenSP = new Guna.UI.WinForms.GunaTextBox();
            this.TxtMaPhieu = new Guna.UI.WinForms.GunaTextBox();
            this.DateTimeNow = new MetroFramework.Controls.MetroDateTime();
            this.TimeWaiting = new System.Windows.Forms.Timer(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.LblAdmin = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.TxtTimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.DGVHoaDon = new Guna.UI.WinForms.GunaDataGridView();
            this.PtbLoading = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.BtnThoat = new Guna.UI.WinForms.GunaButton();
            this.GrHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // GrHoaDon
            // 
            this.GrHoaDon.BaseColor = System.Drawing.Color.White;
            this.GrHoaDon.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrHoaDon.BorderSize = 2;
            this.GrHoaDon.Controls.Add(this.BtnThoat);
            this.GrHoaDon.Controls.Add(this.TxtNhanVien);
            this.GrHoaDon.Controls.Add(this.TxtNgayBan);
            this.GrHoaDon.Controls.Add(this.TxtTong);
            this.GrHoaDon.Controls.Add(this.TxtTenSP);
            this.GrHoaDon.Controls.Add(this.TxtMaPhieu);
            this.GrHoaDon.Controls.Add(this.DateTimeNow);
            this.GrHoaDon.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrHoaDon.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrHoaDon.Location = new System.Drawing.Point(23, 86);
            this.GrHoaDon.Name = "GrHoaDon";
            this.GrHoaDon.Size = new System.Drawing.Size(383, 568);
            this.GrHoaDon.TabIndex = 66;
            this.GrHoaDon.Text = "Thêm thông tin";
            this.GrHoaDon.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // TxtNhanVien
            // 
            this.TxtNhanVien.BaseColor = System.Drawing.Color.White;
            this.TxtNhanVien.BorderColor = System.Drawing.Color.Silver;
            this.TxtNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNhanVien.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNhanVien.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNhanVien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNhanVien.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNhanVien.ForeColor = System.Drawing.Color.Gray;
            this.TxtNhanVien.Location = new System.Drawing.Point(12, 313);
            this.TxtNhanVien.Name = "TxtNhanVien";
            this.TxtNhanVien.PasswordChar = '\0';
            this.TxtNhanVien.Size = new System.Drawing.Size(355, 34);
            this.TxtNhanVien.TabIndex = 30;
            this.TxtNhanVien.Text = "Nhân viên xuất hóa đơn";
            this.TxtNhanVien.Enter += new System.EventHandler(this.TxtNhanVien_Enter);
            this.TxtNhanVien.Leave += new System.EventHandler(this.TxtNhanVien_Leave);
            // 
            // TxtNgayBan
            // 
            this.TxtNgayBan.BaseColor = System.Drawing.Color.White;
            this.TxtNgayBan.BorderColor = System.Drawing.Color.Silver;
            this.TxtNgayBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNgayBan.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNgayBan.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNgayBan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNgayBan.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNgayBan.ForeColor = System.Drawing.Color.Gray;
            this.TxtNgayBan.Location = new System.Drawing.Point(12, 202);
            this.TxtNgayBan.Name = "TxtNgayBan";
            this.TxtNgayBan.PasswordChar = '\0';
            this.TxtNgayBan.Size = new System.Drawing.Size(355, 34);
            this.TxtNgayBan.TabIndex = 27;
            this.TxtNgayBan.Text = "Ngày xuất hóa đơn";
            this.TxtNgayBan.Enter += new System.EventHandler(this.TxtNgayBan_Enter);
            this.TxtNgayBan.Leave += new System.EventHandler(this.TxtNgayBan_Leave);
            // 
            // TxtTong
            // 
            this.TxtTong.BaseColor = System.Drawing.Color.White;
            this.TxtTong.BorderColor = System.Drawing.Color.Silver;
            this.TxtTong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTong.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtTong.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtTong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTong.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTong.ForeColor = System.Drawing.Color.Gray;
            this.TxtTong.Location = new System.Drawing.Point(12, 257);
            this.TxtTong.Name = "TxtTong";
            this.TxtTong.PasswordChar = '\0';
            this.TxtTong.Size = new System.Drawing.Size(355, 34);
            this.TxtTong.TabIndex = 26;
            this.TxtTong.Text = "Tổng tiền thanh toán";
            this.TxtTong.Enter += new System.EventHandler(this.TxtTong_Enter);
            this.TxtTong.Leave += new System.EventHandler(this.TxtTong_Leave);
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
            this.TxtTenSP.Location = new System.Drawing.Point(12, 147);
            this.TxtTenSP.Name = "TxtTenSP";
            this.TxtTenSP.PasswordChar = '\0';
            this.TxtTenSP.Size = new System.Drawing.Size(355, 34);
            this.TxtTenSP.TabIndex = 23;
            this.TxtTenSP.Text = "Tên sản phẩm";
            this.TxtTenSP.Enter += new System.EventHandler(this.TxtTenSP_Enter);
            this.TxtTenSP.Leave += new System.EventHandler(this.TxtTenSP_Leave);
            // 
            // TxtMaPhieu
            // 
            this.TxtMaPhieu.BaseColor = System.Drawing.Color.White;
            this.TxtMaPhieu.BorderColor = System.Drawing.Color.Silver;
            this.TxtMaPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMaPhieu.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtMaPhieu.FocusedBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMaPhieu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMaPhieu.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaPhieu.ForeColor = System.Drawing.Color.Gray;
            this.TxtMaPhieu.Location = new System.Drawing.Point(12, 94);
            this.TxtMaPhieu.Name = "TxtMaPhieu";
            this.TxtMaPhieu.PasswordChar = '\0';
            this.TxtMaPhieu.Size = new System.Drawing.Size(355, 34);
            this.TxtMaPhieu.TabIndex = 22;
            this.TxtMaPhieu.Text = "Mã phiếu xuất";
            this.TxtMaPhieu.Enter += new System.EventHandler(this.TxtMaPhieu_Enter);
            this.TxtMaPhieu.Leave += new System.EventHandler(this.TxtMaPhieu_Leave);
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
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(262, 26);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(37, 34);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 65;
            this.gunaPictureBox1.TabStop = false;
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.Location = new System.Drawing.Point(954, 32);
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
            this.gunaLabel1.Location = new System.Drawing.Point(846, 32);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel1.TabIndex = 62;
            this.gunaLabel1.Text = "Nhân viên:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.TxtTimKiem.TabIndex = 67;
            this.TxtTimKiem.Text = "Nhập sản phẩm cần tìm kiếm";
            this.TxtTimKiem.Enter += new System.EventHandler(this.TxtTimKiem_Enter);
            this.TxtTimKiem.Leave += new System.EventHandler(this.TxtTimKiem_Leave);
            // 
            // DGVHoaDon
            // 
            this.DGVHoaDon.AllowUserToAddRows = false;
            this.DGVHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVHoaDon.BackgroundColor = System.Drawing.Color.LightGray;
            this.DGVHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVHoaDon.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVHoaDon.EnableHeadersVisualStyles = false;
            this.DGVHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVHoaDon.Location = new System.Drawing.Point(428, 86);
            this.DGVHoaDon.Name = "DGVHoaDon";
            this.DGVHoaDon.ReadOnly = true;
            this.DGVHoaDon.RowHeadersVisible = false;
            this.DGVHoaDon.RowHeadersWidth = 51;
            this.DGVHoaDon.RowTemplate.Height = 24;
            this.DGVHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVHoaDon.Size = new System.Drawing.Size(686, 568);
            this.DGVHoaDon.TabIndex = 64;
            this.DGVHoaDon.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVHoaDon.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DGVHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVHoaDon.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVHoaDon.ThemeStyle.ReadOnly = true;
            this.DGVHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.DGVHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVHoaDon.Click += new System.EventHandler(this.DGVHoaDon_Click);
            // 
            // PtbLoading
            // 
            this.PtbLoading.BackColor = System.Drawing.Color.Transparent;
            this.PtbLoading.BaseColor = System.Drawing.Color.Black;
            this.PtbLoading.Image = ((System.Drawing.Image)(resources.GetObject("PtbLoading.Image")));
            this.PtbLoading.Location = new System.Drawing.Point(487, -15);
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
            this.BtnThoat.Location = new System.Drawing.Point(207, 511);
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
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 677);
            this.Controls.Add(this.GrHoaDon);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.TxtTimKiem);
            this.Controls.Add(this.DGVHoaDon);
            this.Controls.Add(this.PtbLoading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoaDon";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.GrHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox GrHoaDon;
        private Guna.UI.WinForms.GunaTextBox TxtNhanVien;
        private Guna.UI.WinForms.GunaTextBox TxtNgayBan;
        private Guna.UI.WinForms.GunaTextBox TxtTong;
        private Guna.UI.WinForms.GunaTextBox TxtTenSP;
        private Guna.UI.WinForms.GunaTextBox TxtMaPhieu;
        private MetroFramework.Controls.MetroDateTime DateTimeNow;
        private System.Windows.Forms.Timer TimeWaiting;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public Guna.UI.WinForms.GunaLabel LblAdmin;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox TxtTimKiem;
        private Guna.UI.WinForms.GunaDataGridView DGVHoaDon;
        private Guna.UI.WinForms.GunaTransfarantPictureBox PtbLoading;
        private Guna.UI.WinForms.GunaButton BtnThoat;
    }
}