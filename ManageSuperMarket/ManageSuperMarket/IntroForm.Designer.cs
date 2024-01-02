namespace ManageSuperMarket
{
    partial class IntroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            this.LblMonHoc = new System.Windows.Forms.Label();
            this.LblText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblTieuDe = new Guna.UI.WinForms.GunaLabel();
            this.LblRight = new System.Windows.Forms.Label();
            this.LblLeft = new System.Windows.Forms.Label();
            this.CoutDownTime = new System.Windows.Forms.Timer(this.components);
            this.TimerCout = new System.Windows.Forms.Timer(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.BtnDangNhap = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.BtnThoat = new Guna.UI.WinForms.GunaButton();
            this.PtbLogo = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.BtnDangKy = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMonHoc
            // 
            this.LblMonHoc.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.LblMonHoc.Location = new System.Drawing.Point(283, 174);
            this.LblMonHoc.Name = "LblMonHoc";
            this.LblMonHoc.Size = new System.Drawing.Size(581, 44);
            this.LblMonHoc.TabIndex = 50;
            this.LblMonHoc.Text = "LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG";
            this.LblMonHoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.BackColor = System.Drawing.Color.Transparent;
            this.LblText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblText.Location = new System.Drawing.Point(382, 531);
            this.LblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(348, 41);
            this.LblText.TabIndex = 48;
            this.LblText.Text = "GVHD : Trần Ngọc Thăng";
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(-8, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1146, 60);
            this.label6.TabIndex = 46;
            // 
            // LblTieuDe
            // 
            this.LblTieuDe.AutoSize = true;
            this.LblTieuDe.BackColor = System.Drawing.Color.DodgerBlue;
            this.LblTieuDe.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTieuDe.ForeColor = System.Drawing.Color.Transparent;
            this.LblTieuDe.Location = new System.Drawing.Point(214, 89);
            this.LblTieuDe.Name = "LblTieuDe";
            this.LblTieuDe.Size = new System.Drawing.Size(728, 59);
            this.LblTieuDe.TabIndex = 52;
            this.LblTieuDe.Text = "HỆ THỐNG QUẢN LÝ SIÊU THỊ MINI";
            // 
            // LblRight
            // 
            this.LblRight.AutoEllipsis = true;
            this.LblRight.Location = new System.Drawing.Point(553, 70);
            this.LblRight.Name = "LblRight";
            this.LblRight.Size = new System.Drawing.Size(585, 564);
            this.LblRight.TabIndex = 54;
            // 
            // LblLeft
            // 
            this.LblLeft.AutoEllipsis = true;
            this.LblLeft.Location = new System.Drawing.Point(-8, 70);
            this.LblLeft.Name = "LblLeft";
            this.LblLeft.Size = new System.Drawing.Size(565, 564);
            this.LblLeft.TabIndex = 53;
            // 
            // CoutDownTime
            // 
            this.CoutDownTime.Enabled = true;
            this.CoutDownTime.Interval = 10;
            this.CoutDownTime.Tick += new System.EventHandler(this.CoutDownTime_Tick);
            // 
            // TimerCout
            // 
            this.TimerCout.Tick += new System.EventHandler(this.TimerCout_Tick);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.BtnDangNhap;
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.AnimationHoverSpeed = 0.07F;
            this.BtnDangNhap.AnimationSpeed = 0.03F;
            this.BtnDangNhap.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnDangNhap.BorderColor = System.Drawing.Color.Black;
            this.BtnDangNhap.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.BtnDangNhap.ForeColor = System.Drawing.Color.White;
            this.BtnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("BtnDangNhap.Image")));
            this.BtnDangNhap.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnDangNhap.Location = new System.Drawing.Point(916, 353);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnDangNhap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDangNhap.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDangNhap.OnHoverImage = null;
            this.BtnDangNhap.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDangNhap.Size = new System.Drawing.Size(198, 61);
            this.BtnDangNhap.TabIndex = 58;
            this.BtnDangNhap.Text = "    Đăng nhập";
            this.BtnDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.BtnThoat;
            // 
            // BtnThoat
            // 
            this.BtnThoat.AnimationHoverSpeed = 0.07F;
            this.BtnThoat.AnimationSpeed = 0.03F;
            this.BtnThoat.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnThoat.BorderColor = System.Drawing.Color.Black;
            this.BtnThoat.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.BtnThoat.ForeColor = System.Drawing.Color.White;
            this.BtnThoat.Image = ((System.Drawing.Image)(resources.GetObject("BtnThoat.Image")));
            this.BtnThoat.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnThoat.Location = new System.Drawing.Point(916, 511);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnThoat.OnHoverImage = null;
            this.BtnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.BtnThoat.Size = new System.Drawing.Size(198, 61);
            this.BtnThoat.TabIndex = 59;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // PtbLogo
            // 
            this.PtbLogo.BaseColor = System.Drawing.Color.White;
            this.PtbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PtbLogo.Image")));
            this.PtbLogo.Location = new System.Drawing.Point(464, 231);
            this.PtbLogo.Name = "PtbLogo";
            this.PtbLogo.Size = new System.Drawing.Size(200, 271);
            this.PtbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLogo.TabIndex = 56;
            this.PtbLogo.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(9, 546);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(79, 78);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 60;
            this.gunaPictureBox1.TabStop = false;
            // 
            // BtnDangKy
            // 
            this.BtnDangKy.AnimationHoverSpeed = 0.07F;
            this.BtnDangKy.AnimationSpeed = 0.03F;
            this.BtnDangKy.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnDangKy.BorderColor = System.Drawing.Color.Black;
            this.BtnDangKy.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.BtnDangKy.ForeColor = System.Drawing.Color.White;
            this.BtnDangKy.Image = ((System.Drawing.Image)(resources.GetObject("BtnDangKy.Image")));
            this.BtnDangKy.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnDangKy.Location = new System.Drawing.Point(916, 431);
            this.BtnDangKy.Name = "BtnDangKy";
            this.BtnDangKy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnDangKy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDangKy.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDangKy.OnHoverImage = null;
            this.BtnDangKy.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDangKy.Size = new System.Drawing.Size(198, 61);
            this.BtnDangKy.TabIndex = 61;
            this.BtnDangKy.Text = "  Đăng ký";
            this.BtnDangKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDangKy.Click += new System.EventHandler(this.BtnDangKy_Click);
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.BtnDangKy;
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 632);
            this.Controls.Add(this.LblRight);
            this.Controls.Add(this.BtnDangKy);
            this.Controls.Add(this.LblLeft);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnDangNhap);
            this.Controls.Add(this.LblTieuDe);
            this.Controls.Add(this.LblMonHoc);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PtbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntroForm";
            this.Text = "Quản lý siêu thị - Nhóm 44 - 146159 ";
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMonHoc;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaLabel LblTieuDe;
        private System.Windows.Forms.Label LblRight;
        private System.Windows.Forms.Label LblLeft;
        private System.Windows.Forms.Timer CoutDownTime;
        private System.Windows.Forms.Timer TimerCout;
        private Guna.UI.WinForms.GunaPictureBox PtbLogo;
        private Guna.UI.WinForms.GunaButton BtnDangNhap;
        private Guna.UI.WinForms.GunaButton BtnThoat;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton BtnDangKy;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
    }
}

