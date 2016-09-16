namespace QLKS
{
    partial class ChiTiet_DichVu
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
            this.grvCTDV = new System.Windows.Forms.DataGridView();
            this.MaCTDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPT_CTDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia_CTDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap_CTDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbMaPT_ = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbSoPhong_ = new System.Windows.Forms.ComboBox();
            this.cbbGiaDV = new System.Windows.Forms.ComboBox();
            this.cbbMaDV = new System.Windows.Forms.ComboBox();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.dtpNgayLap_CTDV = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaCTDV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvCTDV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvCTDV
            // 
            this.grvCTDV.AllowUserToOrderColumns = true;
            this.grvCTDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCTDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCTDV,
            this.MaNV_DV,
            this.MaPT_CTDV,
            this.SoPhong,
            this.MaDV,
            this.Gia_CTDV,
            this.NgayLap_CTDV});
            this.grvCTDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.grvCTDV.Location = new System.Drawing.Point(0, 0);
            this.grvCTDV.Name = "grvCTDV";
            this.grvCTDV.Size = new System.Drawing.Size(871, 158);
            this.grvCTDV.TabIndex = 1;
            // 
            // MaCTDV
            // 
            this.MaCTDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCTDV.DataPropertyName = "MaCTDV";
            this.MaCTDV.HeaderText = "Mã CTDV";
            this.MaCTDV.Name = "MaCTDV";
            // 
            // MaNV_DV
            // 
            this.MaNV_DV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV_DV.DataPropertyName = "MaNV";
            this.MaNV_DV.HeaderText = "Mã Nhân Viên";
            this.MaNV_DV.Name = "MaNV_DV";
            // 
            // MaPT_CTDV
            // 
            this.MaPT_CTDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPT_CTDV.DataPropertyName = "MaPT";
            this.MaPT_CTDV.HeaderText = "Mã PT";
            this.MaPT_CTDV.Name = "MaPT_CTDV";
            // 
            // SoPhong
            // 
            this.SoPhong.DataPropertyName = "SoPhong";
            this.SoPhong.HeaderText = "Số Phòng";
            this.SoPhong.Name = "SoPhong";
            // 
            // MaDV
            // 
            this.MaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã DV";
            this.MaDV.Name = "MaDV";
            // 
            // Gia_CTDV
            // 
            this.Gia_CTDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia_CTDV.DataPropertyName = "Gia";
            this.Gia_CTDV.HeaderText = "Giá";
            this.Gia_CTDV.Name = "Gia_CTDV";
            // 
            // NgayLap_CTDV
            // 
            this.NgayLap_CTDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayLap_CTDV.DataPropertyName = "NgayLap";
            this.NgayLap_CTDV.HeaderText = "Ngày Lập";
            this.NgayLap_CTDV.Name = "NgayLap_CTDV";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(871, 60);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Công Cụ";
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
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.Location = new System.Drawing.Point(515, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 35);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbMaPT_);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbbSoPhong_);
            this.groupBox2.Controls.Add(this.cbbGiaDV);
            this.groupBox2.Controls.Add(this.cbbMaDV);
            this.groupBox2.Controls.Add(this.cbbMaNV);
            this.groupBox2.Controls.Add(this.dtpNgayLap_CTDV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMaCTDV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 219);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết";
            // 
            // cbbMaPT_
            // 
            this.cbbMaPT_.FormattingEnabled = true;
            this.cbbMaPT_.Items.AddRange(new object[] {
            "100000",
            "150000"});
            this.cbbMaPT_.Location = new System.Drawing.Point(236, 155);
            this.cbbMaPT_.Name = "cbbMaPT_";
            this.cbbMaPT_.Size = new System.Drawing.Size(100, 21);
            this.cbbMaPT_.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Số Phòng";
            // 
            // cbbSoPhong_
            // 
            this.cbbSoPhong_.FormattingEnabled = true;
            this.cbbSoPhong_.Items.AddRange(new object[] {
            "100000",
            "150000"});
            this.cbbSoPhong_.Location = new System.Drawing.Point(236, 113);
            this.cbbSoPhong_.Name = "cbbSoPhong_";
            this.cbbSoPhong_.Size = new System.Drawing.Size(100, 21);
            this.cbbSoPhong_.TabIndex = 56;
            this.cbbSoPhong_.SelectedValueChanged += new System.EventHandler(this.cbbSoPhong__SelectedValueChanged);
            // 
            // cbbGiaDV
            // 
            this.cbbGiaDV.FormattingEnabled = true;
            this.cbbGiaDV.Items.AddRange(new object[] {
            "100000",
            "150000"});
            this.cbbGiaDV.Location = new System.Drawing.Point(556, 66);
            this.cbbGiaDV.Name = "cbbGiaDV";
            this.cbbGiaDV.Size = new System.Drawing.Size(100, 21);
            this.cbbGiaDV.TabIndex = 55;
            // 
            // cbbMaDV
            // 
            this.cbbMaDV.FormattingEnabled = true;
            this.cbbMaDV.Items.AddRange(new object[] {
            "100000",
            "150000"});
            this.cbbMaDV.Location = new System.Drawing.Point(556, 31);
            this.cbbMaDV.Name = "cbbMaDV";
            this.cbbMaDV.Size = new System.Drawing.Size(100, 21);
            this.cbbMaDV.TabIndex = 54;
            this.cbbMaDV.SelectedIndexChanged += new System.EventHandler(this.cbbMaDV_SelectedIndexChanged);
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Items.AddRange(new object[] {
            "100000",
            "150000"});
            this.cbbMaNV.Location = new System.Drawing.Point(236, 71);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(100, 21);
            this.cbbMaNV.TabIndex = 52;
            // 
            // dtpNgayLap_CTDV
            // 
            this.dtpNgayLap_CTDV.CustomFormat = "MM/dd/yyyyy";
            this.dtpNgayLap_CTDV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap_CTDV.Location = new System.Drawing.Point(556, 110);
            this.dtpNgayLap_CTDV.Name = "dtpNgayLap_CTDV";
            this.dtpNgayLap_CTDV.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayLap_CTDV.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày Lập";
            // 
            // txtMaCTDV
            // 
            this.txtMaCTDV.Location = new System.Drawing.Point(236, 32);
            this.txtMaCTDV.Name = "txtMaCTDV";
            this.txtMaCTDV.Size = new System.Drawing.Size(100, 20);
            this.txtMaCTDV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã NV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã PT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã DV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã CTDV";
            // 
            // ChiTiet_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(871, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grvCTDV);
            this.Name = "ChiTiet_DichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTiet_DichVu";
            this.Load += new System.EventHandler(this.ChiTiet_DichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCTDV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvCTDV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaCTDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayLap_CTDV;
        private System.Windows.Forms.ComboBox cbbGiaDV;
        private System.Windows.Forms.ComboBox cbbMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT_CTDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia_CTDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap_CTDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbSoPhong_;
        private System.Windows.Forms.ComboBox cbbMaPT_;
    }
}