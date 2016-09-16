namespace QLKS
{
    partial class PhieuThue
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
            this.grvPhieuThue = new System.Windows.Forms.DataGridView();
            this.MaPT_PT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH_PT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen_PT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLuu_PT = new System.Windows.Forms.Button();
            this.btnXoa_PT = new System.Windows.Forms.Button();
            this.btnThem_PT = new System.Windows.Forms.Button();
            this.btnSua_PT = new System.Windows.Forms.Button();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbmaKH_Tim = new System.Windows.Forms.ComboBox();
            this.cbbTinhTrang_Tim = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuThue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvPhieuThue
            // 
            this.grvPhieuThue.AllowUserToOrderColumns = true;
            this.grvPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPT_PT,
            this.MaKH_PT,
            this.NgayDen_PT,
            this.TinhTrang});
            this.grvPhieuThue.Location = new System.Drawing.Point(3, 9);
            this.grvPhieuThue.Name = "grvPhieuThue";
            this.grvPhieuThue.Size = new System.Drawing.Size(365, 226);
            this.grvPhieuThue.TabIndex = 1;
            this.grvPhieuThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPhieuThue_CellClick);
            this.grvPhieuThue.Click += new System.EventHandler(this.grvPhieuThue_Click);
            // 
            // MaPT_PT
            // 
            this.MaPT_PT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPT_PT.DataPropertyName = "MaPT";
            this.MaPT_PT.HeaderText = "Mã Phiếu Thuê";
            this.MaPT_PT.Name = "MaPT_PT";
            // 
            // MaKH_PT
            // 
            this.MaKH_PT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH_PT.DataPropertyName = "MaKH";
            this.MaKH_PT.HeaderText = "Mã Khách Hàng";
            this.MaKH_PT.Name = "MaKH_PT";
            // 
            // NgayDen_PT
            // 
            this.NgayDen_PT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayDen_PT.DataPropertyName = "NgayLap";
            this.NgayDen_PT.HeaderText = "Ngày Lập";
            this.NgayDen_PT.Name = "NgayDen_PT";
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrang.DataPropertyName = "TinhTrangThanhToan";
            this.TinhTrang.HeaderText = "Tình Trạng Thanh Toán";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grvPhieuThue);
            this.groupBox1.Location = new System.Drawing.Point(2, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã KH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày Lập";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLuu_PT);
            this.groupBox3.Controls.Add(this.btnXoa_PT);
            this.groupBox3.Controls.Add(this.btnThem_PT);
            this.groupBox3.Controls.Add(this.btnSua_PT);
            this.groupBox3.Location = new System.Drawing.Point(5, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(897, 61);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Công Cụ";
            // 
            // btnLuu_PT
            // 
            this.btnLuu_PT.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLuu_PT.Location = new System.Drawing.Point(704, 19);
            this.btnLuu_PT.Name = "btnLuu_PT";
            this.btnLuu_PT.Size = new System.Drawing.Size(91, 35);
            this.btnLuu_PT.TabIndex = 5;
            this.btnLuu_PT.Text = "Lưu";
            this.btnLuu_PT.UseVisualStyleBackColor = false;
            this.btnLuu_PT.Click += new System.EventHandler(this.btnLuu_PT_Click);
            // 
            // btnXoa_PT
            // 
            this.btnXoa_PT.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoa_PT.Location = new System.Drawing.Point(323, 19);
            this.btnXoa_PT.Name = "btnXoa_PT";
            this.btnXoa_PT.Size = new System.Drawing.Size(91, 35);
            this.btnXoa_PT.TabIndex = 3;
            this.btnXoa_PT.Text = "Xóa";
            this.btnXoa_PT.UseVisualStyleBackColor = false;
            this.btnXoa_PT.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem_PT
            // 
            this.btnThem_PT.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem_PT.Location = new System.Drawing.Point(99, 19);
            this.btnThem_PT.Name = "btnThem_PT";
            this.btnThem_PT.Size = new System.Drawing.Size(91, 35);
            this.btnThem_PT.TabIndex = 1;
            this.btnThem_PT.Text = "Thêm";
            this.btnThem_PT.UseVisualStyleBackColor = false;
            this.btnThem_PT.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua_PT
            // 
            this.btnSua_PT.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua_PT.Location = new System.Drawing.Point(515, 19);
            this.btnSua_PT.Name = "btnSua_PT";
            this.btnSua_PT.Size = new System.Drawing.Size(91, 35);
            this.btnSua_PT.TabIndex = 4;
            this.btnSua_PT.Text = "Sửa";
            this.btnSua_PT.UseVisualStyleBackColor = false;
            this.btnSua_PT.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "MM/dd/yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(686, 383);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(114, 20);
            this.dtpNgayLap.TabIndex = 19;
            this.dtpNgayLap.Value = new System.DateTime(2016, 5, 9, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mã Phiếu Thuê";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Enabled = false;
            this.txtMaPT.Location = new System.Drawing.Point(95, 387);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(100, 20);
            this.txtMaPT.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(806, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "MM/dd/yyyy";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(281, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbmaKH_Tim
            // 
            this.cbbmaKH_Tim.FormattingEnabled = true;
            this.cbbmaKH_Tim.Location = new System.Drawing.Point(55, 20);
            this.cbbmaKH_Tim.Name = "cbbmaKH_Tim";
            this.cbbmaKH_Tim.Size = new System.Drawing.Size(84, 21);
            this.cbbmaKH_Tim.TabIndex = 26;
            // 
            // cbbTinhTrang_Tim
            // 
            this.cbbTinhTrang_Tim.FormattingEnabled = true;
            this.cbbTinhTrang_Tim.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbbTinhTrang_Tim.Location = new System.Drawing.Point(232, 20);
            this.cbbTinhTrang_Tim.Name = "cbbTinhTrang_Tim";
            this.cbbTinhTrang_Tim.Size = new System.Drawing.Size(43, 21);
            this.cbbTinhTrang_Tim.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tình Trạng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbmaKH_Tim);
            this.groupBox2.Controls.Add(this.cbbTinhTrang_Tim);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 47);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // grvKhachHang
            // 
            this.grvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.SoCMT,
            this.MaTD,
            this.VaiTro});
            this.grvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvKhachHang.Location = new System.Drawing.Point(3, 16);
            this.grvKhachHang.Name = "grvKhachHang";
            this.grvKhachHang.Size = new System.Drawing.Size(528, 224);
            this.grvKhachHang.TabIndex = 2;
            this.grvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvKhachHang_CellClick);
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            // 
            // SoCMT
            // 
            this.SoCMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoCMT.DataPropertyName = "SoCMT";
            this.SoCMT.HeaderText = "Số CMT";
            this.SoCMT.Name = "SoCMT";
            // 
            // MaTD
            // 
            this.MaTD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTD.DataPropertyName = "MaTD";
            this.MaTD.HeaderText = "Mã Trường Đoàn";
            this.MaTD.Name = "MaTD";
            // 
            // VaiTro
            // 
            this.VaiTro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VaiTro.DataPropertyName = "VaiTro";
            this.VaiTro.HeaderText = "Vai Trò";
            this.VaiTro.Name = "VaiTro";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grvKhachHang);
            this.groupBox4.Location = new System.Drawing.Point(368, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(534, 243);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " ";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(328, 391);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 20);
            this.txtMaKH.TabIndex = 33;
            // 
            // PhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(902, 494);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaPT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhieuThue";
            this.Text = "PhieuThue";
            this.Load += new System.EventHandler(this.PhieuThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuThue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvPhieuThue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoa_PT;
        private System.Windows.Forms.Button btnThem_PT;
        private System.Windows.Forms.Button btnSua_PT;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLuu_PT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbmaKH_Tim;
        private System.Windows.Forms.ComboBox cbbTinhTrang_Tim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT_PT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH_PT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen_PT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaiTro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMaKH;
    }
}