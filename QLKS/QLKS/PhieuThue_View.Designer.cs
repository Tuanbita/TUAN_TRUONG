namespace QLKS
{
    partial class PhieuThue_View
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.grvPhieuThue = new System.Windows.Forms.DataGridView();
            this.SoPhong_PT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH_PT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen_PT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi_PT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDatCoc_PT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuThue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.grvPhieuThue);
            this.groupBox1.Location = new System.Drawing.Point(-2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(935, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel1.Text = "Find";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // grvPhieuThue
            // 
            this.grvPhieuThue.AllowUserToOrderColumns = true;
            this.grvPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhong_PT,
            this.MaKH_PT,
            this.NgayDen_PT,
            this.NgayDi_PT,
            this.TienDatCoc_PT});
            this.grvPhieuThue.Location = new System.Drawing.Point(-1, 34);
            this.grvPhieuThue.Name = "grvPhieuThue";
            this.grvPhieuThue.Size = new System.Drawing.Size(936, 338);
            this.grvPhieuThue.TabIndex = 22;
            // 
            // SoPhong_PT
            // 
            this.SoPhong_PT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoPhong_PT.DataPropertyName = "SoPhong";
            this.SoPhong_PT.HeaderText = "SoPhong";
            this.SoPhong_PT.Name = "SoPhong_PT";
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
            this.NgayDen_PT.DataPropertyName = "NgayDen";
            this.NgayDen_PT.HeaderText = "Ngày Đến";
            this.NgayDen_PT.Name = "NgayDen_PT";
            // 
            // NgayDi_PT
            // 
            this.NgayDi_PT.DataPropertyName = "NgayDi";
            this.NgayDi_PT.HeaderText = "Ngày ĐI";
            this.NgayDi_PT.Name = "NgayDi_PT";
            // 
            // TienDatCoc_PT
            // 
            this.TienDatCoc_PT.DataPropertyName = "TienDatCoc";
            this.TienDatCoc_PT.HeaderText = "Tiền Đặt Cọc";
            this.TienDatCoc_PT.Name = "TienDatCoc_PT";
            // 
            // PhieuThue_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 383);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhieuThue_View";
            this.Text = "PhieuThue_View";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView grvPhieuThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong_PT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH_PT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen_PT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi_PT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDatCoc_PT;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    }
}