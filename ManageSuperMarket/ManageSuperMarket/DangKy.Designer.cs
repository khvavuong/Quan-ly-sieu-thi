namespace ManageSuperMarket
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.TimeWaiting = new System.Windows.Forms.Timer(this.components);
            this.PtbLoading = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.GroupBoxDK = new Guna.UI.WinForms.GunaGroupBox();
            this.CBChucVu = new Guna.UI.WinForms.GunaComboBox();
            this.TxtReMatKhau = new Guna.UI.WinForms.GunaLineTextBox();
            this.TxtHoTen = new Guna.UI.WinForms.GunaLineTextBox();
            this.LblDangNhap = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.BtnDangKy = new Guna.UI.WinForms.GunaButton();
            this.TxtMatKhau = new Guna.UI.WinForms.GunaLineTextBox();
            this.TxtTenDN = new Guna.UI.WinForms.GunaLineTextBox();
            this.PtbBackground = new Guna.UI.WinForms.GunaPictureBox();
            this.BtnBack = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).BeginInit();
            this.GroupBoxDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.PtbLoading.Location = new System.Drawing.Point(334, 99);
            this.PtbLoading.Name = "PtbLoading";
            this.PtbLoading.Size = new System.Drawing.Size(513, 510);
            this.PtbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLoading.TabIndex = 4;
            this.PtbLoading.TabStop = false;
            // 
            // GroupBoxDK
            // 
            this.GroupBoxDK.BaseColor = System.Drawing.Color.White;
            this.GroupBoxDK.BorderColor = System.Drawing.Color.Gainsboro;
            this.GroupBoxDK.Controls.Add(this.CBChucVu);
            this.GroupBoxDK.Controls.Add(this.TxtReMatKhau);
            this.GroupBoxDK.Controls.Add(this.TxtHoTen);
            this.GroupBoxDK.Controls.Add(this.LblDangNhap);
            this.GroupBoxDK.Controls.Add(this.gunaLabel2);
            this.GroupBoxDK.Controls.Add(this.BtnDangKy);
            this.GroupBoxDK.Controls.Add(this.TxtMatKhau);
            this.GroupBoxDK.Controls.Add(this.TxtTenDN);
            this.GroupBoxDK.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.GroupBoxDK.ForeColor = System.Drawing.Color.White;
            this.GroupBoxDK.LineColor = System.Drawing.Color.DodgerBlue;
            this.GroupBoxDK.LineTop = 41;
            this.GroupBoxDK.Location = new System.Drawing.Point(376, 99);
            this.GroupBoxDK.Name = "GroupBoxDK";
            this.GroupBoxDK.Size = new System.Drawing.Size(424, 497);
            this.GroupBoxDK.TabIndex = 78;
            this.GroupBoxDK.Text = "Register";
            this.GroupBoxDK.TextLocation = new System.Drawing.Point(115, 8);
            // 
            // CBChucVu
            // 
            this.CBChucVu.BackColor = System.Drawing.Color.Transparent;
            this.CBChucVu.BaseColor = System.Drawing.Color.White;
            this.CBChucVu.BorderColor = System.Drawing.Color.Silver;
            this.CBChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBChucVu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CBChucVu.ForeColor = System.Drawing.Color.Black;
            this.CBChucVu.FormattingEnabled = true;
            this.CBChucVu.Items.AddRange(new object[] {
            "Quản lý",
            "Bán hàng"});
            this.CBChucVu.Location = new System.Drawing.Point(46, 326);
            this.CBChucVu.Name = "CBChucVu";
            this.CBChucVu.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CBChucVu.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CBChucVu.Size = new System.Drawing.Size(319, 33);
            this.CBChucVu.TabIndex = 6;
            // 
            // TxtReMatKhau
            // 
            this.TxtReMatKhau.BackColor = System.Drawing.Color.White;
            this.TxtReMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtReMatKhau.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtReMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TxtReMatKhau.ForeColor = System.Drawing.Color.Gray;
            this.TxtReMatKhau.LineColor = System.Drawing.Color.Gainsboro;
            this.TxtReMatKhau.Location = new System.Drawing.Point(46, 246);
            this.TxtReMatKhau.Name = "TxtReMatKhau";
            this.TxtReMatKhau.PasswordChar = '●';
            this.TxtReMatKhau.Size = new System.Drawing.Size(319, 35);
            this.TxtReMatKhau.TabIndex = 5;
            this.TxtReMatKhau.Text = "Nhập lại mật khẩu";
            this.TxtReMatKhau.UseSystemPasswordChar = true;
            this.TxtReMatKhau.Enter += new System.EventHandler(this.TxtReMatKhau_Enter);
            this.TxtReMatKhau.Leave += new System.EventHandler(this.TxtReMatKhau_Leave);
            // 
            // TxtHoTen
            // 
            this.TxtHoTen.BackColor = System.Drawing.Color.White;
            this.TxtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtHoTen.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtHoTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TxtHoTen.ForeColor = System.Drawing.Color.Gray;
            this.TxtHoTen.LineColor = System.Drawing.Color.Gainsboro;
            this.TxtHoTen.Location = new System.Drawing.Point(46, 60);
            this.TxtHoTen.Name = "TxtHoTen";
            this.TxtHoTen.PasswordChar = '\0';
            this.TxtHoTen.Size = new System.Drawing.Size(319, 35);
            this.TxtHoTen.TabIndex = 2;
            this.TxtHoTen.Text = "Nhập họ và tên";
            this.TxtHoTen.Enter += new System.EventHandler(this.TxtHoTen_Enter);
            this.TxtHoTen.Leave += new System.EventHandler(this.TxtHoTen_Leave);
            // 
            // LblDangNhap
            // 
            this.LblDangNhap.AutoSize = true;
            this.LblDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDangNhap.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblDangNhap.Location = new System.Drawing.Point(241, 457);
            this.LblDangNhap.Name = "LblDangNhap";
            this.LblDangNhap.Size = new System.Drawing.Size(82, 20);
            this.LblDangNhap.TabIndex = 68;
            this.LblDangNhap.Text = "Đăng nhập";
            this.LblDangNhap.Click += new System.EventHandler(this.LblDangNhap_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(100, 457);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(120, 20);
            this.gunaLabel2.TabIndex = 65;
            this.gunaLabel2.Text = "Đã có tài khoản?";
            // 
            // BtnDangKy
            // 
            this.BtnDangKy.AnimationHoverSpeed = 0.07F;
            this.BtnDangKy.AnimationSpeed = 0.03F;
            this.BtnDangKy.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnDangKy.BorderColor = System.Drawing.Color.Black;
            this.BtnDangKy.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.BtnDangKy.ForeColor = System.Drawing.Color.White;
            this.BtnDangKy.Image = null;
            this.BtnDangKy.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnDangKy.Location = new System.Drawing.Point(46, 400);
            this.BtnDangKy.Name = "BtnDangKy";
            this.BtnDangKy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnDangKy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDangKy.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDangKy.OnHoverImage = null;
            this.BtnDangKy.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDangKy.Size = new System.Drawing.Size(319, 45);
            this.BtnDangKy.TabIndex = 59;
            this.BtnDangKy.Text = "Đăng ký";
            this.BtnDangKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDangKy.Click += new System.EventHandler(this.BtnDangKy_Click);
            // 
            // TxtMatKhau
            // 
            this.TxtMatKhau.BackColor = System.Drawing.Color.White;
            this.TxtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMatKhau.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TxtMatKhau.ForeColor = System.Drawing.Color.Gray;
            this.TxtMatKhau.LineColor = System.Drawing.Color.Gainsboro;
            this.TxtMatKhau.Location = new System.Drawing.Point(46, 188);
            this.TxtMatKhau.Name = "TxtMatKhau";
            this.TxtMatKhau.PasswordChar = '●';
            this.TxtMatKhau.Size = new System.Drawing.Size(319, 35);
            this.TxtMatKhau.TabIndex = 4;
            this.TxtMatKhau.Text = "Nhập mật khẩu";
            this.TxtMatKhau.UseSystemPasswordChar = true;
            this.TxtMatKhau.Enter += new System.EventHandler(this.TxtMatKhau_Enter);
            this.TxtMatKhau.Leave += new System.EventHandler(this.TxtMatKhau_Leave);
            // 
            // TxtTenDN
            // 
            this.TxtTenDN.BackColor = System.Drawing.Color.White;
            this.TxtTenDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTenDN.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtTenDN.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TxtTenDN.ForeColor = System.Drawing.Color.Gray;
            this.TxtTenDN.LineColor = System.Drawing.Color.Gainsboro;
            this.TxtTenDN.Location = new System.Drawing.Point(46, 123);
            this.TxtTenDN.Name = "TxtTenDN";
            this.TxtTenDN.PasswordChar = '\0';
            this.TxtTenDN.Size = new System.Drawing.Size(319, 35);
            this.TxtTenDN.TabIndex = 3;
            this.TxtTenDN.Tag = "";
            this.TxtTenDN.Text = "Nhập tên đăng nhập";
            this.TxtTenDN.Enter += new System.EventHandler(this.TxtTenDN_Enter);
            this.TxtTenDN.Leave += new System.EventHandler(this.TxtTenDN_Leave);
            // 
            // PtbBackground
            // 
            this.PtbBackground.BaseColor = System.Drawing.Color.White;
            this.PtbBackground.Image = ((System.Drawing.Image)(resources.GetObject("PtbBackground.Image")));
            this.PtbBackground.Location = new System.Drawing.Point(-2, 73);
            this.PtbBackground.Name = "PtbBackground";
            this.PtbBackground.Size = new System.Drawing.Size(1142, 585);
            this.PtbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbBackground.TabIndex = 5;
            this.PtbBackground.TabStop = false;
            // 
            // BtnBack
            // 
            this.BtnBack.AnimationHoverSpeed = 0.07F;
            this.BtnBack.AnimationSpeed = 0.03F;
            this.BtnBack.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnBack.BorderColor = System.Drawing.Color.Black;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnBack.Location = new System.Drawing.Point(924, 564);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnBack.OnHoverImage = null;
            this.BtnBack.OnPressedColor = System.Drawing.Color.Black;
            this.BtnBack.Size = new System.Drawing.Size(202, 45);
            this.BtnBack.TabIndex = 79;
            this.BtnBack.Text = "Màn hình chính";
            this.BtnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(280, 28);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(40, 35);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 82;
            this.gunaPictureBox1.TabStop = false;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 632);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.PtbLoading);
            this.Controls.Add(this.GroupBoxDK);
            this.Controls.Add(this.PtbBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangKy";
            this.Text = "Đăng ký tài khoản";
            this.Load += new System.EventHandler(this.DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).EndInit();
            this.GroupBoxDK.ResumeLayout(false);
            this.GroupBoxDK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimeWaiting;
        private Guna.UI.WinForms.GunaTransfarantPictureBox PtbLoading;
        private Guna.UI.WinForms.GunaGroupBox GroupBoxDK;
        private Guna.UI.WinForms.GunaLabel LblDangNhap;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton BtnDangKy;
        private Guna.UI.WinForms.GunaLineTextBox TxtMatKhau;
        private Guna.UI.WinForms.GunaLineTextBox TxtTenDN;
        private Guna.UI.WinForms.GunaPictureBox PtbBackground;
        private Guna.UI.WinForms.GunaComboBox CBChucVu;
        private Guna.UI.WinForms.GunaLineTextBox TxtReMatKhau;
        private Guna.UI.WinForms.GunaLineTextBox TxtHoTen;
        private Guna.UI.WinForms.GunaButton BtnBack;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}