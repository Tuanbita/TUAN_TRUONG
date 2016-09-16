namespace QLKS
{
    partial class KhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKH_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCMT_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTN_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaiTro_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.cbbMaTD = new System.Windows.Forms.ComboBox();
            this.txtSoCMT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckVaiTro = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grvKhachHang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // grvKhachHang
            // 
            this.grvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH_KH,
            this.TenKH_KH,
            this.NgaySinh_KH,
            this.GioiTinh_KH,
            this.SoDT_KH,
            this.SoCMT_KH,
            this.MaTN_KH,
            this.VaiTro_KH});
            this.grvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvKhachHang.Location = new System.Drawing.Point(3, 16);
            this.grvKhachHang.Name = "grvKhachHang";
            this.grvKhachHang.Size = new System.Drawing.Size(884, 240);
            this.grvKhachHang.TabIndex = 2;
            this.grvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvKhachHang_CellClick);
            // 
            // MaKH_KH
            // 
            this.MaKH_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH_KH.DataPropertyName = "MaKH";
            this.MaKH_KH.HeaderText = "Mã Khách Hàng";
            this.MaKH_KH.Name = "MaKH_KH";
            // 
            // TenKH_KH
            // 
            this.TenKH_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH_KH.DataPropertyName = "TenKH";
            this.TenKH_KH.HeaderText = "Tên Khách Hàng";
            this.TenKH_KH.Name = "TenKH_KH";
            // 
            // NgaySinh_KH
            // 
            this.NgaySinh_KH.DataPropertyName = "NgaySinh";
            this.NgaySinh_KH.HeaderText = "Ngày Sinh";
            this.NgaySinh_KH.Name = "NgaySinh_KH";
            // 
            // GioiTinh_KH
            // 
            this.GioiTinh_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh_KH.DataPropertyName = "GT";
            this.GioiTinh_KH.HeaderText = "Giới Tính";
            this.GioiTinh_KH.Name = "GioiTinh_KH";
            // 
            // SoDT_KH
            // 
            this.SoDT_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoDT_KH.DataPropertyName = "SDT";
            this.SoDT_KH.HeaderText = "Số Điện Thoại";
            this.SoDT_KH.Name = "SoDT_KH";
            // 
            // SoCMT_KH
            // 
            this.SoCMT_KH.DataPropertyName = "SoCMT";
            this.SoCMT_KH.HeaderText = "Số CMT";
            this.SoCMT_KH.Name = "SoCMT_KH";
            // 
            // MaTN_KH
            // 
            this.MaTN_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTN_KH.DataPropertyName = "MaTD";
            this.MaTN_KH.HeaderText = "Mã Trưởng Đoàn";
            this.MaTN_KH.Name = "MaTN_KH";
            // 
            // VaiTro_KH
            // 
            this.VaiTro_KH.DataPropertyName = "VaiTro";
            this.VaiTro_KH.HeaderText = "Vai Trò";
            this.VaiTro_KH.Name = "VaiTro_KH";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.Location = new System.Drawing.Point(80, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 35);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoa.Location = new System.Drawing.Point(283, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.Location = new System.Drawing.Point(515, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 35);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(890, 60);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Công Cụ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLuu.Location = new System.Drawing.Point(723, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 35);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.dtpNS);
            this.groupBox4.Controls.Add(this.cbbMaTD);
            this.groupBox4.Controls.Add(this.txtSoCMT);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.ckVaiTro);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtTenKH);
            this.groupBox4.Controls.Add(this.txtGioiTinh);
            this.groupBox4.Controls.Add(this.txtSDT);
            this.groupBox4.Controls.Add(this.txtMaKH);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(890, 191);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Chi Tiết";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(726, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(665, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "MM/dd/yyyy";
            // 
            // dtpNS
            // 
            this.dtpNS.CustomFormat = "MM/dd/yyyy";
            this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNS.Location = new System.Drawing.Point(553, 15);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(88, 20);
            this.dtpNS.TabIndex = 33;
            this.dtpNS.Value = new System.DateTime(1995, 10, 14, 0, 0, 0, 0);
            // 
            // cbbMaTD
            // 
            this.cbbMaTD.FormattingEnabled = true;
            this.cbbMaTD.Location = new System.Drawing.Point(553, 94);
            this.cbbMaTD.Name = "cbbMaTD";
            this.cbbMaTD.Size = new System.Drawing.Size(121, 21);
            this.cbbMaTD.TabIndex = 32;
            // 
            // txtSoCMT
            // 
            this.txtSoCMT.Location = new System.Drawing.Point(553, 59);
            this.txtSoCMT.Name = "txtSoCMT";
            this.txtSoCMT.Size = new System.Drawing.Size(100, 20);
            this.txtSoCMT.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "SoCMT";
            // 
            // ckVaiTro
            // 
            this.ckVaiTro.AutoSize = true;
            this.ckVaiTro.Location = new System.Drawing.Point(553, 136);
            this.ckVaiTro.Name = "ckVaiTro";
            this.ckVaiTro.Size = new System.Drawing.Size(15, 14);
            this.ckVaiTro.TabIndex = 29;
            this.ckVaiTro.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Vai Trò";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Mã Trưởng Đoàn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Năm Sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Số Điện Thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(214, 60);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 22);
            this.txtTenKH.TabIndex = 17;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(214, 95);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(100, 20);
            this.txtGioiTinh.TabIndex = 16;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(214, 131);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 15;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(214, 19);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 20);
            this.txtMaKH.TabIndex = 14;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(890, 510);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.CheckBox ckVaiTro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoCMT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMaTD;
        private System.Windows.Forms.DateTimePicker dtpNS;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMT_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTN_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaiTro_KH;
        private System.Windows.Forms.Button button1;
    }
}