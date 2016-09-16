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
    public partial class ChiTiet_DichVu : Form
    {
        Bll_CTDV bll_CTDV = new Bll_CTDV();
        string SQL = "Select * from ChiTiet_DichVu ";
        public ChiTiet_DichVu()
        {
            InitializeComponent();
        }
        public void cbbmaNV()
        {
            cbbMaNV.DataSource = bll_CTDV.Taobang("Select * from NhanVIen ");

            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.ValueMember = "MaNV";
            //cbbSoPhong.SelectedIndex = 0;
            cbbMaNV.Text = "0";
        }
//         public void cbbmaPT()
//         {
//             cbbMaPT.DataSource = bll_CTDV.Taobang("Select * from KhachHang ");
// 
//             cbbMaPT.DisplayMember = "MakH";
//             cbbMaPT.ValueMember = "MaKH";
//             //cbbSoPhong.SelectedIndex = 0;
//             cbbMaPT.Text = "0";
//         }

        public void cbbSoPhong()
        {
            string sql = @"Select * from ChiTiet_PhieuThue where TinhTrangThanhToan =0";
            cbbSoPhong_.DataSource = bll_CTDV.Taobang(sql);

            cbbSoPhong_.DisplayMember = "SoPhong";
            cbbSoPhong_.ValueMember = "SoPhong";
            //cbbSoPhong.SelectedIndex = 0;
            cbbSoPhong_.Text = "0";
        }
        public void cbbmaDv()
        {
            cbbMaDV.DataSource = bll_CTDV.Taobang("Select * from DichVu ");

            cbbMaDV.DisplayMember = "MaDV";
            cbbMaDV.ValueMember = "MaDV";
            //cbbSoPhong.SelectedIndex = 0;
            cbbMaDV.Text = "0";
        }
        public void cbbgiaDV()
        {
            cbbGiaDV.DataSource = bll_CTDV.Taobang("Select * from DichVu ");

            cbbGiaDV.DisplayMember = "Gia";
            cbbGiaDV.ValueMember = "Gia";
            //cbbSoPhong.SelectedIndex = 0;
            cbbGiaDV.Text = "0";
        }
        public void cbb()
            {
                cbbmaNV();
                cbbSoPhong();
                cbbmaDv();
                cbbgiaDV();
            }
        private void ChiTiet_DichVu_Load(object sender, EventArgs e)
        {
            grvCTDV.DataSource = bll_CTDV.Taobang(SQL);
            txtMaCTDV.Enabled = false;
            cbbMaPT_.Text = "";
            cbb();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                string MaNV = cbbMaNV.Text;
                string MaPT = cbbMaPT_.Text;
                string MaDV = cbbMaDV.Text;
                string Gia = cbbGiaDV.Text;
                string SoPhong = cbbSoPhong_.Text;
                DateTime date = dtpNgayLap_CTDV.Value;

                int maNV = Convert.ToInt16(MaNV);
                int maPT = Convert.ToInt16(MaPT);
                int sophong = Convert.ToInt16(SoPhong);
                int maDV = Convert.ToInt16(MaDV);
                int gia = Convert.ToInt32(Gia);

                string sql = "insert into ChiTiet_DichVu(MaNV, MaPT,SoPhong,MaDv,Gia,NgayLap) values(N'" + maNV + "',N'" + maPT + "',N'"+sophong+"',N'" + maDV + "',N'" + gia + "',N'" + date + "')";

                int i= bll_CTDV.themDL(sql);
                if(i==1)
                {
                    MessageBox.Show("Thêm Thành Công!");
                    grvCTDV.DataSource = bll_CTDV.Taobang(SQL);
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công!");
                    return;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi!!!");
            }
        }

        private void cbbSoPhong__SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string SoPhong = cbbSoPhong_.Text;
                int sophong = Convert.ToInt16(SoPhong);
                string sql = "Select * from Chitiet_PhieuThue where SoPhong = N'" + sophong + "' and TinhTrangThanhToan = 0 ";
                cbbMaPT_.DataSource = bll_CTDV.Taobang(sql);


                cbbMaPT_.DisplayMember = "MaPT";
                cbbMaPT_.ValueMember = "MaPT";
                //cbbSoPhong.SelectedIndex = 0;
                cbbMaPT_.Text = "0";
            }
            catch(Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void cbbMaDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MaDV = cbbMaDV.Text;
                int maDV = Convert.ToInt16(MaDV);
                string sql = "Select * from dichvu where MaDV = N'" + maDV + "'";
                cbbGiaDV.DataSource = bll_CTDV.Taobang(sql);
                cbbGiaDV.DisplayMember = "Gia";
                cbbGiaDV.ValueMember = "Gia";
            }
            catch(Exception ex)
            {

            }
        }
    }
}
