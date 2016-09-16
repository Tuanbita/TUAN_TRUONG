using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
namespace QLKS
{
    public partial class ChiTiet_HoaDon : Form
    {
        Bll_CTHD bll_CTHD = new Bll_CTHD();
        string SQL = "Select * from ChiTiet_HoaDon ";
        public ChiTiet_HoaDon()
        {
            InitializeComponent();
        }
        public void AnThuocTinh()
        {
            txtMa_CTHD.Enabled = false;
            cbbMaNV_.Enabled = false;
            cbbSoPhong_.Enabled = false;
            cbbMaPT_.Enabled = false;
            cbbMaKH_.Enabled = false;
           // dtpNgayDen.Enabled = false;
            dtpNgayLap.Enabled = false;
            txtTongTienPhong.Enabled = false;
            txtTongTienDV.Enabled = false;
            txtTongTien.Enabled = false;
        }
        public void cbbMaNV()
        {
            try
            {
                string sql = @"Select * From Nhanvien ";
                cbbMaNV_.DataSource = bll_CTHD.Taobang(sql);
                cbbMaNV_.DisplayMember = "MaNV";
                cbbMaNV_.ValueMember = "MaNV";
                //cbbSoPhong_CTPT.SelectedIndex = 0;
                cbbMaNV_.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load Mã Nhân Viên!");
            }
        }
        public void cbbSoPhong()
        {
            try
            {
                string sql = @"Select * From chitiet_PhieuThue where TinhTrangThanhToan =0 ";
                cbbSoPhong_.DataSource = bll_CTHD.Taobang(sql);
                cbbSoPhong_.DisplayMember = "SoPhong";
                cbbSoPhong_.ValueMember = "SoPhong";
                //cbbSoPhong_CTPT.SelectedIndex = 0;
                cbbSoPhong_.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load Số Phòng!");
            }
        }
        private void ChiTiet_HoaDon_Load(object sender, EventArgs e)
        {
            cbbMaNV();
            cbbSoPhong();
            AnThuocTinh();
            cbbMaNV_.Enabled = true;
            cbbSoPhong_.Enabled = true;
            dtpNgayLap.Enabled = true;
            grvCTHD.DataSource = bll_CTHD.Taobang(SQL);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = cbbMaNV_.Text;
                string SoPhong = cbbSoPhong_.Text;
                DateTime date = dtpNgayLap.Value;

                int maNV = Convert.ToInt16(MaNV);
                int sophong = Convert.ToInt16(SoPhong);

                string sql = "insert into ChiTiet_HoaDon(MaNV, SoPhong, NgayLap) Values(N'"+maNV+"',N'"+sophong+"',N'"+date+"')";

                int i = bll_CTHD.themDL(sql);
                if(i==1){
                    MessageBox.Show("Thêm Thành Công!");
                    grvCTHD.DataSource=bll_CTHD.Taobang(SQL);
                    cbbSoPhong();
                }
                else
                {
                    MessageBox.Show("Them không Thành Công!!!");
                    return;
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
