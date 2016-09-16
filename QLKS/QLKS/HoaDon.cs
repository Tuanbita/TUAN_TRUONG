using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DevExpress.XtraReports.UI;
namespace QLKS
{
    public partial class HoaDon : Form
    {
        Bll_HoaDon bll_HoaDon = new Bll_HoaDon();
        string SQL = "Select * from HoaDon ";
        public HoaDon()
        {
            InitializeComponent();
        }

        public void cbbMaNV()
        {
            try
            {
                string sql = @"Select * From Nhanvien ";
                cbbMaNV_HD.DataSource = bll_HoaDon.Taobang(sql);
                cbbMaNV_HD.DisplayMember = "MaNV";
                cbbMaNV_HD.ValueMember = "MaNV";
                //cbbSoPhong_CTPT.SelectedIndex = 0;
                cbbMaNV_HD.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load Mã Nhân Viên!");
            }
        }
        public void AnBt()
        {
            btnLapHD.Enabled = false;
            btnThem.Enabled = false;
            btnTimKiem.Enabled = false;
        }
        public void HienBt()
        {
            btnLapHD.Enabled = true;
            btnThem.Enabled = true;
            btnTimKiem.Enabled = true;
        }
        public void clear()
        {
            txtMa_CTHD.Clear();
            txtMaPT_HD.Clear();
            txtTongTien.Clear();
            txtMaPT_HD.Clear();
            cbbMaNV();
        }
        public void AnCT()
        {
            txtMaPT_HD.Enabled = false;
            txtTongTien.Enabled = false;
            txtKhachHang_.Enabled = false;
            txtMa_CTHD.Enabled = false;

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            grvHoaDon.DataSource = bll_HoaDon.Taobang(SQL);
            cbbMaNV();
        }
        int dong;
        private void btnThem_Click(object sender, EventArgs e)//Lưu hóa đơn vào
        {
            string MaCTHD = txtMa_CTHD.Text;
            string cbbMaNV_ = cbbMaNV_HD.Text;
            string MaPT = txtMaPT_HD.Text;
            string MaKH = txtKhachHang_.Text;
            DateTime date = dtpNgayLap.Value;
            string TongTien = txtTongTien.Text;
            try
            {
                
                int maCTHD = Convert.ToInt16(MaCTHD);
                int maNV = Convert.ToInt16(cbbMaNV_);
                int maPT = Convert.ToInt16(MaPT);
                int makH = Convert.ToInt16(MaKH);
                int tongtien = Convert.ToInt32(TongTien);

                string sql = @"update HoaDon  Set MaNV = '"+maNV+"', MaPT = '"+maPT+"', MaKH = '"+makH+"', TongTien = '"+tongtien+"',NgayLap = '"+date+"'   where MaHD = '"+maCTHD+"'";

                int i = bll_HoaDon.Luu(sql);
                if(i==1)
                {
                    MessageBox.Show("Thêm Hóa Đơn Thành Công!");
                    grvHoaDon.DataSource = bll_HoaDon.Taobang(SQL);
                    clear();
                        return;
                }
                else
                {
                    MessageBox.Show("Lập Hóa Đơn Chưa Thành Công!");
                    grvHoaDon.DataSource = bll_HoaDon.Taobang(SQL);
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi!!!");
                grvHoaDon.DataSource = bll_HoaDon.Taobang(SQL);
            }
        }

        private void grvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AnCT();
                txtMa_CTHD.Text = Convert.ToString(grvHoaDon.Rows[dong].Cells[0].Value);
                cbbMaNV_HD.Text = Convert.ToString(grvHoaDon.Rows[dong].Cells[1].Value);
                if(cbbMaNV_HD.Text =="")
                {
                    cbbMaNV();
                }
                txtMaPT_HD.Text = Convert.ToString(grvHoaDon.Rows[dong].Cells[2].Value);
                txtKhachHang_.Text = Convert.ToString(grvHoaDon.Rows[dong].Cells[3].Value);
                txtTongTien.Text = Convert.ToString(grvHoaDon.Rows[dong].Cells[4].Value);
                dtpNgayLap.Text = Convert.ToString(grvHoaDon.Rows[dong].Cells[5].Value);
                //cbbMaNV();

            }catch(Exception ex)
            {
//                 txtMa_CTHD.Text = Convert.ToString(grvHoaDon.Rows[dong].Cells[0].Value);
//                 cbbMaNV_HD.Text = Convert.ToString(grvHoaDon.Rows[dong].Cells[1].Value);
//                 txtMaPT_HD.Text = Convert.ToString(grvHoaDon.Rows[dong].Cells[2].Value);
//                 txtKhachHang_.Text = Convert.ToString(grvHoaDon.Rows[dong].Cells[3].Value);
//                 txtTongTien.Text = Convert.ToString(grvHoaDon.Rows[dong].Cells[4].Value);
//                 dtpNgayLap.Text = Convert.ToString(grvHoaDon.Rows[dong].Cells[5].Value);
//                 cbbMaNV();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Select * from HoaDon where MaNV is null";
            grvHoaDon.DataSource = bll_HoaDon.Taobang(sql);
            clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int maPT ;
                try
                {
                    maPT= Convert.ToInt16(grvHoaDon.Rows[dong].Cells[2].Value);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Chưa Lập Mã Nhân Viên");
                    return;
                }
                string sql = @"Select * from InHoaDon where MaPT = N'" + maPT + "'";

                XtraReport1 report = new XtraReport1();
                report.DataSource = bll_HoaDon.Taobang(sql);
                report.ShowPreviewDialog();
                
            }catch(Exception ex)
            {

            }
        }
    }
}
