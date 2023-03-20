namespace BankingManagement
{
    partial class frmManage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTTCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTTTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTTThuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNapTien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRutTien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChuyenTien = new System.Windows.Forms.ToolStripMenuItem();
            this.khoảnVayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoKhoảnVayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảKhoảnVayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gửiTiếtKiệmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoSổTiếtKiệmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rútSổTiếtKiệmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.khoảnVayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gửiTiếtKiệmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchHàngToolStripMenuItem,
            this.giaoDịchToolStripMenuItem,
            this.khoảnVayToolStripMenuItem,
            this.gửiTiếtKiệmToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1497, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTTCaNhan,
            this.menuTTTaiKhoan,
            this.menuTTThuNhap});
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(250, 35);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "&Thông tin khách hàng";
            // 
            // menuTTCaNhan
            // 
            this.menuTTCaNhan.Name = "menuTTCaNhan";
            this.menuTTCaNhan.Size = new System.Drawing.Size(300, 36);
            this.menuTTCaNhan.Text = "&Thông tin cá nhân";
            this.menuTTCaNhan.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // menuTTTaiKhoan
            // 
            this.menuTTTaiKhoan.Name = "menuTTTaiKhoan";
            this.menuTTTaiKhoan.Size = new System.Drawing.Size(300, 36);
            this.menuTTTaiKhoan.Text = "&Thông tin tài khoản";
            this.menuTTTaiKhoan.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // menuTTThuNhap
            // 
            this.menuTTThuNhap.Name = "menuTTThuNhap";
            this.menuTTThuNhap.Size = new System.Drawing.Size(300, 36);
            this.menuTTThuNhap.Text = "&Thông tin thu nhập";
            this.menuTTThuNhap.Click += new System.EventHandler(this.thôngTinThuNhậpToolStripMenuItem_Click);
            // 
            // giaoDịchToolStripMenuItem
            // 
            this.giaoDịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNapTien,
            this.menuRutTien,
            this.menuChuyenTien});
            this.giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            this.giaoDịchToolStripMenuItem.Size = new System.Drawing.Size(125, 35);
            this.giaoDịchToolStripMenuItem.Text = "&Giao dịch";
            // 
            // menuNapTien
            // 
            this.menuNapTien.Name = "menuNapTien";
            this.menuNapTien.Size = new System.Drawing.Size(227, 36);
            this.menuNapTien.Text = "&Nạp tiền";
            this.menuNapTien.Click += new System.EventHandler(this.gửiTiềnToolStripMenuItem_Click);
            // 
            // menuRutTien
            // 
            this.menuRutTien.Name = "menuRutTien";
            this.menuRutTien.Size = new System.Drawing.Size(227, 36);
            this.menuRutTien.Text = "&Rút tiền";
            this.menuRutTien.Click += new System.EventHandler(this.rútTiềnToolStripMenuItem_Click);
            // 
            // menuChuyenTien
            // 
            this.menuChuyenTien.Name = "menuChuyenTien";
            this.menuChuyenTien.Size = new System.Drawing.Size(227, 36);
            this.menuChuyenTien.Text = "&Chuyển Tiền";
            this.menuChuyenTien.Click += new System.EventHandler(this.chuyểnKhoảnToolStripMenuItem_Click);
            // 
            // khoảnVayToolStripMenuItem
            // 
            this.khoảnVayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoKhoảnVayToolStripMenuItem,
            this.trảKhoảnVayToolStripMenuItem});
            this.khoảnVayToolStripMenuItem.Name = "khoảnVayToolStripMenuItem";
            this.khoảnVayToolStripMenuItem.Size = new System.Drawing.Size(132, 35);
            this.khoảnVayToolStripMenuItem.Text = "&Khoản vay";
            // 
            // tạoKhoảnVayToolStripMenuItem
            // 
            this.tạoKhoảnVayToolStripMenuItem.Name = "tạoKhoảnVayToolStripMenuItem";
            this.tạoKhoảnVayToolStripMenuItem.Size = new System.Drawing.Size(247, 36);
            this.tạoKhoảnVayToolStripMenuItem.Text = "&Tạo khoản vay";
            // 
            // trảKhoảnVayToolStripMenuItem
            // 
            this.trảKhoảnVayToolStripMenuItem.Name = "trảKhoảnVayToolStripMenuItem";
            this.trảKhoảnVayToolStripMenuItem.Size = new System.Drawing.Size(247, 36);
            this.trảKhoảnVayToolStripMenuItem.Text = "&Trả khoản vay";
            // 
            // gửiTiếtKiệmToolStripMenuItem
            // 
            this.gửiTiếtKiệmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoSổTiếtKiệmToolStripMenuItem,
            this.rútSổTiếtKiệmToolStripMenuItem});
            this.gửiTiếtKiệmToolStripMenuItem.Name = "gửiTiếtKiệmToolStripMenuItem";
            this.gửiTiếtKiệmToolStripMenuItem.Size = new System.Drawing.Size(159, 35);
            this.gửiTiếtKiệmToolStripMenuItem.Text = "&Gửi tiết kiệm";
            // 
            // tạoSổTiếtKiệmToolStripMenuItem
            // 
            this.tạoSổTiếtKiệmToolStripMenuItem.Name = "tạoSổTiếtKiệmToolStripMenuItem";
            this.tạoSổTiếtKiệmToolStripMenuItem.Size = new System.Drawing.Size(263, 36);
            this.tạoSổTiếtKiệmToolStripMenuItem.Text = "&Tạo sổ tiết kiệm";
            // 
            // rútSổTiếtKiệmToolStripMenuItem
            // 
            this.rútSổTiếtKiệmToolStripMenuItem.Name = "rútSổTiếtKiệmToolStripMenuItem";
            this.rútSổTiếtKiệmToolStripMenuItem.Size = new System.Drawing.Size(263, 36);
            this.rútSổTiếtKiệmToolStripMenuItem.Text = "&Rút sổ tiết kiệm";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaoDịchToolStripMenuItem1,
            this.khoảnVayToolStripMenuItem1,
            this.gửiTiếtKiệmToolStripMenuItem1});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.thốngKêToolStripMenuItem.Text = "&Thống kê";
            // 
            // giaoDịchToolStripMenuItem1
            // 
            this.giaoDịchToolStripMenuItem1.Name = "giaoDịchToolStripMenuItem1";
            this.giaoDịchToolStripMenuItem1.Size = new System.Drawing.Size(233, 36);
            this.giaoDịchToolStripMenuItem1.Text = "&Giao dịch";
            // 
            // khoảnVayToolStripMenuItem1
            // 
            this.khoảnVayToolStripMenuItem1.Name = "khoảnVayToolStripMenuItem1";
            this.khoảnVayToolStripMenuItem1.Size = new System.Drawing.Size(233, 36);
            this.khoảnVayToolStripMenuItem1.Text = "&Khoản vay";
            // 
            // gửiTiếtKiệmToolStripMenuItem1
            // 
            this.gửiTiếtKiệmToolStripMenuItem1.Name = "gửiTiếtKiệmToolStripMenuItem1";
            this.gửiTiếtKiệmToolStripMenuItem1.Size = new System.Drawing.Size(233, 36);
            this.gửiTiếtKiệmToolStripMenuItem1.Text = "&Gửi tiết kiệm";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1497, 758);
            this.panel1.TabIndex = 1;
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 797);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTTCaNhan;
        private System.Windows.Forms.ToolStripMenuItem menuTTTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuTTThuNhap;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNapTien;
        private System.Windows.Forms.ToolStripMenuItem menuRutTien;
        private System.Windows.Forms.ToolStripMenuItem menuChuyenTien;
        private System.Windows.Forms.ToolStripMenuItem khoảnVayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoKhoảnVayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảKhoảnVayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gửiTiếtKiệmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoSổTiếtKiệmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rútSổTiếtKiệmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem khoảnVayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gửiTiếtKiệmToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
    }
}

