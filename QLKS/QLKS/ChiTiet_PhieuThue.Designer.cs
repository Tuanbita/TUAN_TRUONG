namespace QLKS
{
    partial class ChiTiet_PhieuThue
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
            this.grvCTPT = new System.Windows.Forms.DataGridView();
            this.MaCTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPT_CTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhong_CTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH_CTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen_CTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDatCoc_CTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLuu_CTPT = new System.Windows.Forms.Button();
            this.btnXoa_CTPT = new System.Windows.Forms.Button();
            this.btnThem_CTPT = new System.Windows.Forms.Button();
            this.btnSua_CTPT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbThanhToan_CTPT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayLap_CTPT = new System.Windows.Forms.DateTimePicker();
            this.cbbMaPT_CTPT = new System.Windows.Forms.ComboBox();
            this.cbbMaKH_CTPT = new System.Windows.Forms.ComboBox();
            this.cbbSoPhong_CTPT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaCTPT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTienDatCoc_CTPT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbLoaiPhong_CTPT = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvCTPT)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // grvCTPT
            // 
            this.grvCTPT.AllowUserToOrderColumns = true;
            this.grvCTPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCTPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCTPT,
            this.MaPT_CTPT,
            this.SoPhong_CTPT,
            this.MaKH_CTPT,
            this.NgayDen_CTPT,
            this.TienDatCoc_CTPT,
            this.TinhTrangThanhToan});
            this.grvCTPT.Location = new System.Drawing.Point(0, -1);
            this.grvCTPT.Name = "grvCTPT";
            this.grvCTPT.Size = new System.Drawing.Size(530, 207);
            this.grvCTPT.TabIndex = 23;
            this.grvCTPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCTPT_CellClick);
            this.grvCTPT.CellStyleChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCTPT_CellStyleChanged);
            // 
            // MaCTPT
            // 
            this.MaCTPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCTPT.DataPropertyName = "MaCTPT";
            this.MaCTPT.HeaderText = "Mã CTPT";
            this.MaCTPT.Name = "MaCTPT";
            // 
            // MaPT_CTPT
            // 
            this.MaPT_CTPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPT_CTPT.DataPropertyName = "MaPT";
            this.MaPT_CTPT.HeaderText = "Mã Phiếu Thuê";
            this.MaPT_CTPT.Name = "MaPT_CTPT";
            // 
            // SoPhong_CTPT
            // 
            this.SoPhong_CTPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoPhong_CTPT.DataPropertyName = "SoPhong";
            this.SoPhong_CTPT.HeaderText = "Số Phòng";
            this.SoPhong_CTPT.Name = "SoPhong_CTPT";
            // 
            // MaKH_CTPT
            // 
            this.MaKH_CTPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH_CTPT.DataPropertyName = "MaKH";
            this.MaKH_CTPT.HeaderText = "Mã Khách Hàng";
            this.MaKH_CTPT.Name = "MaKH_CTPT";
            // 
            // NgayDen_CTPT
            // 
            this.NgayDen_CTPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayDen_CTPT.DataPropertyName = "NgayLap";
            this.NgayDen_CTPT.HeaderText = "Ngày Lập";
            this.NgayDen_CTPT.Name = "NgayDen_CTPT";
            // 
            // TienDatCoc_CTPT
            // 
            this.TienDatCoc_CTPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienDatCoc_CTPT.DataPropertyName = "TienDatCoc";
            this.TienDatCoc_CTPT.HeaderText = "Tiền Đặt Cọc";
            this.TienDatCoc_CTPT.Name = "TienDatCoc_CTPT";
            // 
            // TinhTrangThanhToan
            // 
            this.TinhTrangThanhToan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrangThanhToan.DataPropertyName = "TinhTrangThanhToan";
            this.TinhTrangThanhToan.HeaderText = "Tình Trạng Thanh Toán";
            this.TinhTrangThanhToan.Name = "TinhTrangThanhToan";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLuu_CTPT);
            this.groupBox3.Controls.Add(this.btnXoa_CTPT);
            this.groupBox3.Controls.Add(this.btnThem_CTPT);
            this.groupBox3.Controls.Add(this.btnSua_CTPT);
            this.groupBox3.Location = new System.Drawing.Point(0, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(922, 72);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Công Cụ";
            // 
            // btnLuu_CTPT
            // 
            this.btnLuu_CTPT.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLuu_CTPT.Location = new System.Drawing.Point(704, 19);
            this.btnLuu_CTPT.Name = "btnLuu_CTPT";
            this.btnLuu_CTPT.Size = new System.Drawing.Size(91, 35);
            this.btnLuu_CTPT.TabIndex = 5;
            this.btnLuu_CTPT.Text = "Lưu";
            this.btnLuu_CTPT.UseVisualStyleBackColor = false;
            this.btnLuu_CTPT.Click += new System.EventHandler(this.btnLuu_CTPT_Click);
            // 
            // btnXoa_CTPT
            // 
            this.btnXoa_CTPT.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoa_CTPT.Location = new System.Drawing.Point(295, 19);
            this.btnXoa_CTPT.Name = "btnXoa_CTPT";
            this.btnXoa_CTPT.Size = new System.Drawing.Size(91, 35);
            this.btnXoa_CTPT.TabIndex = 3;
            this.btnXoa_CTPT.Text = "Xóa";
            this.btnXoa_CTPT.UseVisualStyleBackColor = false;
            this.btnXoa_CTPT.Click += new System.EventHandler(this.btnXoa_CTPT_Click);
            // 
            // btnThem_CTPT
            // 
            this.btnThem_CTPT.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem_CTPT.Location = new System.Drawing.Point(99, 19);
            this.btnThem_CTPT.Name = "btnThem_CTPT";
            this.btnThem_CTPT.Size = new System.Drawing.Size(91, 35);
            this.btnThem_CTPT.TabIndex = 1;
            this.btnThem_CTPT.Text = "Thêm";
            this.btnThem_CTPT.UseVisualStyleBackColor = false;
            this.btnThem_CTPT.Click += new System.EventHandler(this.btnThem_CTPT_Click);
            // 
            // btnSua_CTPT
            // 
            this.btnSua_CTPT.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua_CTPT.Location = new System.Drawing.Point(515, 19);
            this.btnSua_CTPT.Name = "btnSua_CTPT";
            this.btnSua_CTPT.Size = new System.Drawing.Size(91, 35);
            this.btnSua_CTPT.TabIndex = 4;
            this.btnSua_CTPT.Text = "Sửa";
            this.btnSua_CTPT.UseVisualStyleBackColor = false;
            this.btnSua_CTPT.Click += new System.EventHandler(this.btnSua_CTPT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbLoaiPhong_CTPT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbbThanhToan_CTPT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpNgayLap_CTPT);
            this.groupBox1.Controls.Add(this.cbbMaPT_CTPT);
            this.groupBox1.Controls.Add(this.cbbMaKH_CTPT);
            this.groupBox1.Controls.Add(this.cbbSoPhong_CTPT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaCTPT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbTienDatCoc_CTPT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 222);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // cbbThanhToan_CTPT
            // 
            this.cbbThanhToan_CTPT.FormattingEnabled = true;
            this.cbbThanhToan_CTPT.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbbThanhToan_CTPT.Location = new System.Drawing.Point(648, 109);
            this.cbbThanhToan_CTPT.Name = "cbbThanhToan_CTPT";
            this.cbbThanhToan_CTPT.Size = new System.Drawing.Size(100, 21);
            this.cbbThanhToan_CTPT.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(538, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Thanh Toán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(782, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Tháng/Ngày/Năm";
            // 
            // dtpNgayLap_CTPT
            // 
            this.dtpNgayLap_CTPT.CustomFormat = "MM/dd/yyyyy";
            this.dtpNgayLap_CTPT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap_CTPT.Location = new System.Drawing.Point(650, 19);
            this.dtpNgayLap_CTPT.Name = "dtpNgayLap_CTPT";
            this.dtpNgayLap_CTPT.Size = new System.Drawing.Size(110, 20);
            this.dtpNgayLap_CTPT.TabIndex = 50;
            // 
            // cbbMaPT_CTPT
            // 
            this.cbbMaPT_CTPT.FormattingEnabled = true;
            this.cbbMaPT_CTPT.Location = new System.Drawing.Point(205, 104);
            this.cbbMaPT_CTPT.Name = "cbbMaPT_CTPT";
            this.cbbMaPT_CTPT.Size = new System.Drawing.Size(100, 21);
            this.cbbMaPT_CTPT.TabIndex = 49;
            this.cbbMaPT_CTPT.SelectedIndexChanged += new System.EventHandler(this.cbbMaPT_CTPT_SelectedIndexChanged);
            // 
            // cbbMaKH_CTPT
            // 
            this.cbbMaKH_CTPT.FormattingEnabled = true;
            this.cbbMaKH_CTPT.Location = new System.Drawing.Point(205, 142);
            this.cbbMaKH_CTPT.Name = "cbbMaKH_CTPT";
            this.cbbMaKH_CTPT.Size = new System.Drawing.Size(100, 21);
            this.cbbMaKH_CTPT.TabIndex = 48;
            this.cbbMaKH_CTPT.SelectedIndexChanged += new System.EventHandler(this.cbbMaKH_CTPT_SelectedIndexChanged);
            // 
            // cbbSoPhong_CTPT
            // 
            this.cbbSoPhong_CTPT.FormattingEnabled = true;
            this.cbbSoPhong_CTPT.Location = new System.Drawing.Point(99, 63);
            this.cbbSoPhong_CTPT.Name = "cbbSoPhong_CTPT";
            this.cbbSoPhong_CTPT.Size = new System.Drawing.Size(100, 21);
            this.cbbSoPhong_CTPT.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Ngày Lập";
            // 
            // txtMaCTPT
            // 
            this.txtMaCTPT.Location = new System.Drawing.Point(205, 21);
            this.txtMaCTPT.Name = "txtMaCTPT";
            this.txtMaCTPT.Size = new System.Drawing.Size(100, 20);
            this.txtMaCTPT.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Mã CTPT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Số Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mã Phiếu Thuê";
            // 
            // cbbTienDatCoc_CTPT
            // 
            this.cbbTienDatCoc_CTPT.FormattingEnabled = true;
            this.cbbTienDatCoc_CTPT.Items.AddRange(new object[] {
            "100000",
            "200000",
            "300000",
            "400000"});
            this.cbbTienDatCoc_CTPT.Location = new System.Drawing.Point(650, 63);
            this.cbbTienDatCoc_CTPT.Name = "cbbTienDatCoc_CTPT";
            this.cbbTienDatCoc_CTPT.Size = new System.Drawing.Size(100, 21);
            this.cbbTienDatCoc_CTPT.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tiền Đặt Cọc";
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
            this.grvKhachHang.Location = new System.Drawing.Point(529, -1);
            this.grvKhachHang.Name = "grvKhachHang";
            this.grvKhachHang.Size = new System.Drawing.Size(393, 207);
            this.grvKhachHang.TabIndex = 30;
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
            // cbbLoaiPhong_CTPT
            // 
            this.cbbLoaiPhong_CTPT.FormattingEnabled = true;
            this.cbbLoaiPhong_CTPT.Location = new System.Drawing.Point(315, 63);
            this.cbbLoaiPhong_CTPT.Name = "cbbLoaiPhong_CTPT";
            this.cbbLoaiPhong_CTPT.Size = new System.Drawing.Size(100, 21);
            this.cbbLoaiPhong_CTPT.TabIndex = 55;
            this.cbbLoaiPhong_CTPT.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiPhong_CTPT_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Loại Phòng";
            // 
            // ChiTiet_PhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(925, 506);
            this.Controls.Add(this.grvKhachHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grvCTPT);
            this.Name = "ChiTiet_PhieuThue";
            this.Text = "ChiTiet_PhieuThue";
            this.Load += new System.EventHandler(this.ChiTiet_PhieuThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCTPT)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvCTPT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLuu_CTPT;
        private System.Windows.Forms.Button btnXoa_CTPT;
        private System.Windows.Forms.Button btnThem_CTPT;
        private System.Windows.Forms.Button btnSua_CTPT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayLap_CTPT;
        private System.Windows.Forms.ComboBox cbbMaKH_CTPT;
        private System.Windows.Forms.ComboBox cbbSoPhong_CTPT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaCTPT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTienDatCoc_CTPT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbThanhToan_CTPT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT_CTPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong_CTPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH_CTPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen_CTPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDatCoc_CTPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangThanhToan;
        private System.Windows.Forms.ComboBox cbbMaPT_CTPT;
        private System.Windows.Forms.DataGridView grvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaiTro;
        private System.Windows.Forms.ComboBox cbbLoaiPhong_CTPT;
        private System.Windows.Forms.Label label9;
    }
}