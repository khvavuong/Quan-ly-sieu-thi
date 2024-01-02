namespace ManageSuperMarket
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.TimeWaiting = new System.Windows.Forms.Timer(this.components);
            this.PtbLoading = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.PtbBackground = new Guna.UI.WinForms.GunaPictureBox();
            this.GroupBoxDN = new Guna.UI.WinForms.GunaGroupBox();
            this.LblQuenMatKhau = new Guna.UI.WinForms.GunaLabel();
            this.LblDangKy = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransfarantPictureBox2 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.BtnDangNhap = new Guna.UI.WinForms.GunaButton();
            this.TxtMatKhau = new Guna.UI.WinForms.GunaLineTextBox();
            this.TxtTenDN = new Guna.UI.WinForms.GunaLineTextBox();
            this.BtnBack = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbBackground)).BeginInit();
            this.GroupBoxDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
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
            this.PtbLoading.Location = new System.Drawing.Point(333, 105);
            this.PtbLoading.Name = "PtbLoading";
            this.PtbLoading.Size = new System.Drawing.Size(500, 504);
            this.PtbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLoading.TabIndex = 1;
            this.PtbLoading.TabStop = false;
            // 
            // PtbBackground
            // 
            this.PtbBackground.BaseColor = System.Drawing.Color.White;
            this.PtbBackground.Image = ((System.Drawing.Image)(resources.GetObject("PtbBackground.Image")));
            this.PtbBackground.Location = new System.Drawing.Point(-3, 83);
            this.PtbBackground.Name = "PtbBackground";
            this.PtbBackground.Size = new System.Drawing.Size(1142, 595);
            this.PtbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbBackground.TabIndex = 2;
            this.PtbBackground.TabStop = false;
            // 
            // GroupBoxDN
            // 
            this.GroupBoxDN.BaseColor = System.Drawing.Color.White;
            this.GroupBoxDN.BorderColor = System.Drawing.Color.Gainsboro;
            this.GroupBoxDN.Controls.Add(this.LblQuenMatKhau);
            this.GroupBoxDN.Controls.Add(this.LblDangKy);
            this.GroupBoxDN.Controls.Add(this.gunaLabel2);
            this.GroupBoxDN.Controls.Add(this.gunaTransfarantPictureBox2);
            this.GroupBoxDN.Controls.Add(this.gunaTransfarantPictureBox1);
            this.GroupBoxDN.Controls.Add(this.gunaLabel1);
            this.GroupBoxDN.Controls.Add(this.BtnDangNhap);
            this.GroupBoxDN.Controls.Add(this.TxtMatKhau);
            this.GroupBoxDN.Controls.Add(this.TxtTenDN);
            this.GroupBoxDN.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.GroupBoxDN.ForeColor = System.Drawing.Color.White;
            this.GroupBoxDN.LineColor = System.Drawing.Color.DodgerBlue;
            this.GroupBoxDN.LineTop = 41;
            this.GroupBoxDN.Location = new System.Drawing.Point(375, 119);
            this.GroupBoxDN.Name = "GroupBoxDN";
            this.GroupBoxDN.Size = new System.Drawing.Size(424, 487);
            this.GroupBoxDN.TabIndex = 3;
            this.GroupBoxDN.Text = "Đăng nhập";
            this.GroupBoxDN.TextLocation = new System.Drawing.Point(110, 8);
            // 
            // LblQuenMatKhau
            // 
            this.LblQuenMatKhau.AutoSize = true;
            this.LblQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblQuenMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuenMatKhau.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblQuenMatKhau.Location = new System.Drawing.Point(154, 432);
            this.LblQuenMatKhau.Name = "LblQuenMatKhau";
            this.LblQuenMatKhau.Size = new System.Drawing.Size(116, 20);
            this.LblQuenMatKhau.TabIndex = 69;
            this.LblQuenMatKhau.Text = "Quên mật khẩu?";
            // 
            // LblDangKy
            // 
            this.LblDangKy.AutoSize = true;
            this.LblDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblDangKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDangKy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblDangKy.Location = new System.Drawing.Point(242, 402);
            this.LblDangKy.Name = "LblDangKy";
            this.LblDangKy.Size = new System.Drawing.Size(63, 20);
            this.LblDangKy.TabIndex = 68;
            this.LblDangKy.Text = "Đăng ký";
            this.LblDangKy.Click += new System.EventHandler(this.LblDangKy_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(101, 402);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(135, 20);
            this.gunaLabel2.TabIndex = 65;
            this.gunaLabel2.Text = "Chưa có tài khoản?";
            // 
            // gunaTransfarantPictureBox2
            // 
            this.gunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransfarantPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaTransfarantPictureBox2.Image")));
            this.gunaTransfarantPictureBox2.Location = new System.Drawing.Point(213, 332);
            this.gunaTransfarantPictureBox2.Name = "gunaTransfarantPictureBox2";
            this.gunaTransfarantPictureBox2.Size = new System.Drawing.Size(57, 53);
            this.gunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox2.TabIndex = 64;
            this.gunaTransfarantPictureBox2.TabStop = false;
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransfarantPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaTransfarantPictureBox1.Image")));
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(141, 332);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(57, 53);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 63;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel1.Location = new System.Drawing.Point(189, 294);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(37, 25);
            this.gunaLabel1.TabIndex = 60;
            this.gunaLabel1.Text = "OR";
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.AnimationHoverSpeed = 0.07F;
            this.BtnDangNhap.AnimationSpeed = 0.03F;
            this.BtnDangNhap.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnDangNhap.BorderColor = System.Drawing.Color.Black;
            this.BtnDangNhap.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.BtnDangNhap.ForeColor = System.Drawing.Color.White;
            this.BtnDangNhap.Image = null;
            this.BtnDangNhap.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnDangNhap.Location = new System.Drawing.Point(47, 232);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnDangNhap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDangNhap.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDangNhap.OnHoverImage = null;
            this.BtnDangNhap.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDangNhap.Size = new System.Drawing.Size(319, 45);
            this.BtnDangNhap.TabIndex = 59;
            this.BtnDangNhap.Text = "Đăng nhập";
            this.BtnDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // TxtMatKhau
            // 
            this.TxtMatKhau.BackColor = System.Drawing.Color.White;
            this.TxtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMatKhau.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TxtMatKhau.ForeColor = System.Drawing.Color.Gray;
            this.TxtMatKhau.LineColor = System.Drawing.Color.Gainsboro;
            this.TxtMatKhau.Location = new System.Drawing.Point(47, 159);
            this.TxtMatKhau.Name = "TxtMatKhau";
            this.TxtMatKhau.PasswordChar = '●';
            this.TxtMatKhau.Size = new System.Drawing.Size(319, 35);
            this.TxtMatKhau.TabIndex = 4;
            this.TxtMatKhau.Text = "Nhập mật khẩu";
            this.TxtMatKhau.UseSystemPasswordChar = true;
            this.TxtMatKhau.Enter += new System.EventHandler(this.textBox2_Enter);
            this.TxtMatKhau.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // TxtTenDN
            // 
            this.TxtTenDN.BackColor = System.Drawing.Color.White;
            this.TxtTenDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTenDN.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtTenDN.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TxtTenDN.ForeColor = System.Drawing.Color.Gray;
            this.TxtTenDN.LineColor = System.Drawing.Color.Gainsboro;
            this.TxtTenDN.Location = new System.Drawing.Point(47, 92);
            this.TxtTenDN.Name = "TxtTenDN";
            this.TxtTenDN.PasswordChar = '\0';
            this.TxtTenDN.Size = new System.Drawing.Size(319, 35);
            this.TxtTenDN.TabIndex = 3;
            this.TxtTenDN.Tag = "";
            this.TxtTenDN.Text = "Nhập tên đăng nhập";
            this.TxtTenDN.Enter += new System.EventHandler(this.textBox1_Enter);
            this.TxtTenDN.Leave += new System.EventHandler(this.textBox1_Leave);
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
            this.BtnBack.Location = new System.Drawing.Point(912, 564);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnBack.OnHoverImage = null;
            this.BtnBack.OnPressedColor = System.Drawing.Color.Black;
            this.BtnBack.Size = new System.Drawing.Size(202, 45);
            this.BtnBack.TabIndex = 80;
            this.BtnBack.Text = "Màn hình chính";
            this.BtnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(375, 31);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(37, 34);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 81;
            this.gunaPictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 632);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.PtbLoading);
            this.Controls.Add(this.GroupBoxDN);
            this.Controls.Add(this.PtbBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhap";
            this.Tag = "";
            this.Text = "Đăng nhập vào hệ thống";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbBackground)).EndInit();
            this.GroupBoxDN.ResumeLayout(false);
            this.GroupBoxDN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TimeWaiting;
        private Guna.UI.WinForms.GunaTransfarantPictureBox PtbLoading;
        private Guna.UI.WinForms.GunaPictureBox PtbBackground;
        private Guna.UI.WinForms.GunaGroupBox GroupBoxDN;
        private Guna.UI.WinForms.GunaLineTextBox TxtMatKhau;
        private Guna.UI.WinForms.GunaLineTextBox TxtTenDN;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton BtnDangNhap;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox2;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel LblQuenMatKhau;
        private Guna.UI.WinForms.GunaLabel LblDangKy;
        private Guna.UI.WinForms.GunaButton BtnBack;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}