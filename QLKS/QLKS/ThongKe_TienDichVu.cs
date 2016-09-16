using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLKS
{
    public partial class ThongKe_TienDichVu : Form
    {
        public ThongKe_TienDichVu()
        {
            InitializeComponent();
        }

        private void ThongKe_TienDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = null;
                //SqlDataReader rdr = null;
                conn = new SqlConnection(@"Data Source=DESKTOP-UDEEE13\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.TK_DV_Thang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                // TODO: This line of code loads data into the 'qLKSDataSet1.DoanhThu_DichVu' table. You can move, or remove it, as needed.
                this.doanhThu_DichVuTableAdapter.Fill(this.qLKSDataSet1.DoanhThu_DichVu);
                chartControl1.DataSource = this.qLKSDataSet1.DoanhThu_DichVu;
                this.chartControl1.Size = new System.Drawing.Size(1000, 600);
                chartControl1.ExportToImage("F:\\ThongKeTienDVTheoNam2016.png", System.Drawing.Imaging.ImageFormat.Png);
            }
            catch(Exception ex){
                MessageBox.Show("Lỗi!!!");
            }
        }
    }
}
