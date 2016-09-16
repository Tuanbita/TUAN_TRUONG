namespace QLKS
{
    partial class KhachHang_View
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbSuDungNgay = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoCMT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckBVaiTro = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMaTD = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbHoTen = new System.Windows.Forms.ComboBox();
            this.cbbMa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grvKhachHang_View = new System.Windows.Forms.DataGridView();
            this.MaKH_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCMT_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTN_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaiTro_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang_View)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbSuDungNgay);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpNgayDi);
            this.groupBox2.Controls.Add(this.dtpNgayLap);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSoCMT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ckBVaiTro);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbbMaTD);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbbHoTen);
            this.groupBox2.Controls.Add(this.cbbMa);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // ckbSuDungNgay
            // 
            this.ckbSuDungNgay.AutoSize = true;
            this.ckbSuDungNgay.Location = new System.Drawing.Point(478, 128);
            this.ckbSuDungNgay.Name = "ckbSuDungNgay";
            this.ckbSuDungNgay.Size = new System.Drawing.Size(15, 14);
            this.ckbSuDungNgay.TabIndex = 55;
            this.ckbSuDungNgay.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(361, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "Sử Dụng Ngày";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "MM/dd/yyyyy";
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(800, 122);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayDi.TabIndex = 53;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "MM/dd/yyyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(624, 122);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayLap.TabIndex = 52;
            this.dtpNgayLap.Value = new System.DateTime(2016, 5, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(738, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Ngày Đi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(550, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ngày Đến";
            // 
            // txtSoCMT
            // 
            this.txtSoCMT.Location = new System.Drawing.Point(116, 36);
            this.txtSoCMT.Name = "txtSoCMT";
            this.txtSoCMT.Size = new System.Drawing.Size(121, 20);
            this.txtSoCMT.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Số CMT";
            // 
            // ckBVaiTro
            // 
            this.ckBVaiTro.AutoSize = true;
            this.ckBVaiTro.Location = new System.Drawing.Point(478, 78);
            this.ckBVaiTro.Name = "ckBVaiTro";
            this.ckBVaiTro.Size = new System.Drawing.Size(15, 14);
            this.ckBVaiTro.TabIndex = 40;
            this.ckBVaiTro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(361, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "VaiTrò:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(361, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã Trưởng Đoàn";
            // 
            // cbbMaTD
            // 
            this.cbbMaTD.FormattingEnabled = true;
            this.cbbMaTD.Location = new System.Drawing.Point(478, 34);
            this.cbbMaTD.Name = "cbbMaTD";
            this.cbbMaTD.Size = new System.Drawing.Size(121, 21);
            this.cbbMaTD.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 36;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbHoTen
            // 
            this.cbbHoTen.FormattingEnabled = true;
            this.cbbHoTen.Location = new System.Drawing.Point(116, 121);
            this.cbbHoTen.Name = "cbbHoTen";
            this.cbbHoTen.Size = new System.Drawing.Size(121, 21);
            this.cbbHoTen.TabIndex = 35;
            // 
            // cbbMa
            // 
            this.cbbMa.FormattingEnabled = true;
            this.cbbMa.Location = new System.Drawing.Point(116, 75);
            this.cbbMa.Name = "cbbMa";
            this.cbbMa.Size = new System.Drawing.Size(121, 21);
            this.cbbMa.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Họ Tên";
            // 
            // grvKhachHang_View
            // 
            this.grvKhachHang_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvKhachHang_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH_KH,
            this.TenKH_KH,
            this.NgaySinh_KH,
            this.GioiTinh_KH,
            this.SoDT_KH,
            this.SoCMT_KH,
            this.MaTN_KH,
            this.VaiTro_KH});
            this.grvKhachHang_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvKhachHang_View.Location = new System.Drawing.Point(3, 16);
            this.grvKhachHang_View.Name = "grvKhachHang_View";
            this.grvKhachHang_View.Size = new System.Drawing.Size(898, 240);
            this.grvKhachHang_View.TabIndex = 21;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grvKhachHang_View);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 259);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // KhachHang_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(904, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhachHang_View";
            this.Text = "KhachHang_TimKiem";
            this.Load += new System.EventHandler(this.KhachHang_View_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang_View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMaTD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbHoTen;
        private System.Windows.Forms.ComboBox cbbMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grvKhachHang_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMT_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTN_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaiTro_KH;
        private System.Windows.Forms.CheckBox ckBVaiTro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoCMT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.CheckBox ckbSuDungNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;




    }
}