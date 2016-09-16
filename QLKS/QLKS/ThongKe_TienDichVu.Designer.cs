namespace QLKS
{
    partial class ThongKe_TienDichVu
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.doanhThu_DichVuTableAdapter = new QLKS.QLKSDataSet1TableAdapters.DoanhThu_DichVuTableAdapter();
            this.doanhThuDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKSDataSet1 = new QLKS.QLKSDataSet1();
            this.qlksDataSet2 = new QLKS.QLKSDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThuDichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlksDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.doanhThu_DichVuTableAdapter;
            this.chartControl1.DataSource = this.doanhThuDichVuBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "Thang";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "ThongKeDichVu";
            series1.ValueDataMembersSerializable = "DoanhThu";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Thang";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "DoanhThu";
            this.chartControl1.Size = new System.Drawing.Size(780, 524);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Font = new System.Drawing.Font("Tahoma", 16F);
            chartTitle1.Text = "Doanh Thu Dịch Vụ Theo Năm";
            chartTitle1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // doanhThu_DichVuTableAdapter
            // 
            this.doanhThu_DichVuTableAdapter.ClearBeforeFill = true;
            // 
            // doanhThuDichVuBindingSource
            // 
            this.doanhThuDichVuBindingSource.DataMember = "DoanhThu_DichVu";
            this.doanhThuDichVuBindingSource.DataSource = this.qLKSDataSet1;
            // 
            // qLKSDataSet1
            // 
            this.qLKSDataSet1.DataSetName = "QLKSDataSet1";
            this.qLKSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlksDataSet2
            // 
            this.qlksDataSet2.DataSetName = "QLKSDataSet";
            this.qlksDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ThongKe_TienDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 524);
            this.Controls.Add(this.chartControl1);
            this.Name = "ThongKe_TienDichVu";
            this.Text = "ThongKe_TienDichVu";
            this.Load += new System.EventHandler(this.ThongKe_TienDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThuDichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlksDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private QLKSDataSet1TableAdapters.DoanhThu_DichVuTableAdapter doanhThu_DichVuTableAdapter;
        private QLKSDataSet1 qLKSDataSet1;
        private System.Windows.Forms.BindingSource doanhThuDichVuBindingSource;
        private QLKSDataSet qlksDataSet2;
    }
}