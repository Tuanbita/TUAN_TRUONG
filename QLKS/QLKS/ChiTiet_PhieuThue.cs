using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using PhanQuyen;
namespace QLKS
{
    //đang ngắt ngứ ở chỗ thêm phiếu thuê
    //
    public partial class ChiTiet_PhieuThue : Form
    {
        Bll_CTPT bll_CTPT = new Bll_CTPT();
        public ChiTiet_PhieuThue()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtMaCTPT.Text = "";
            cbbSoPhong_CTPT.Text = "";
            cbbMaPT_CTPT.Text = "";
            cbbMaKH_CTPT.Text = "";
            cbbTienDatCoc_CTPT.Text = "";
            cbbThanhToan_CTPT.Text = "";
            dtpNgayLap_CTPT.Value = DateTime.Today;

        }
        public void HienBt()
        {
            btnThem_CTPT.Enabled = true;
            btnSua_CTPT.Enabled = true;
            btnXoa_CTPT.Enabled = true;
            btnLuu_CTPT.Enabled = true;
        }

        public void AnBt()
        {
            btnThem_CTPT.Enabled = false;
            btnSua_CTPT.Enabled = false;
            btnXoa_CTPT.Enabled = false;
            btnLuu_CTPT.Enabled = false;
        }

        public void cbbSoPhong()
        {
            try
            {
                string sql = @"Select * From Phong where TrangThai = 0";
                cbbSoPhong_CTPT.DataSource = bll_CTPT.Taobang(sql);
                cbbSoPhong_CTPT.DisplayMember = "SoPhong";
                cbbSoPhong_CTPT.ValueMember = "SoPhong";
                //cbbSoPhong_CTPT.SelectedIndex = 0;
                cbbSoPhong_CTPT.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi load Số Phòng!");
            }
        }
        public void cbbLoaiPhong()
        {
            try
            {
                string sql = @"Select distinct LoaiPhong From Phong ";
                cbbLoaiPhong_CTPT.DataSource = bll_CTPT.Taobang(sql);
                cbbLoaiPhong_CTPT.DisplayMember = "LoaiPhong";
                cbbLoaiPhong_CTPT.ValueMember = "LoaiPhong";
                //cbbSoPhong_CTPT.SelectedIndex = 0;
                cbbLoaiPhong_CTPT.Text = "";
            }catch(Exception ex)
            { }
        }
        public void cbbMaPT()
        {
            try
            {
                string sql = @"Select * from PhieuThue where TinhTrangThanhToan =0 ";

                cbbMaPT_CTPT.DataSource = bll_CTPT.Taobang(sql);
                cbbMaPT_CTPT.DisplayMember = "MaPT";
                cbbMaPT_CTPT.ValueMember = "MaPT";
               // cbbMaPT_CTPT.SelectedIndex = 0;
                cbbMaPT_CTPT.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Load Mã Phiếu Thuê!");
            }
        }
        public void cbbMaKH()
        {
            try
            {
                if (cbbMaPT_CTPT.Text != "")
                {
                    string s = cbbMaPT_CTPT.Text;
                    int maKH_CTPT=0;
                    try
                    {
                      maKH_CTPT = Convert.ToInt16(s);//
                    }catch(Exception ex)
                    {
                        //MessageBox.Show("chuyen doi");
                    }

                    string sql = @" Select * from KhachHang where MaTD = (Select MaKH from PhieuThue where MaPT  = '" + maKH_CTPT + "' ) ";

                    cbbMaKH_CTPT.DataSource = bll_CTPT.Taobang(sql);
                    cbbMaKH_CTPT.DisplayMember = "MaKH";
                    cbbMaKH_CTPT.ValueMember = "MaKH";
                    cbbMaKH_CTPT.Text = "";
                    cbbThanhToan_CTPT.Text = "0";
                }
                else
                {
                    MessageBox.Show("Mã Phieu Thue Chưa Được Chọn");
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Looi cbbMaKH");
            }
        }
        public void cbbTienDatCoc()
        {
            cbbTienDatCoc_CTPT.Text = "";
        }

        private void ChiTiet_PhieuThue_Load(object sender, EventArgs e)
        {
            clear();
            grvCTPT.DataSource = bll_CTPT.Taobang("Select * from ChiTiet_PhieuThue ");
            txtMaCTPT.Enabled = false;
            btnThem_CTPT.Enabled = true;
            cbbSoPhong();
            cbbMaPT();
            cbbLoaiPhong();
            if(_Phanquyen.Phanquyen==0)
            {
                btnXoa_CTPT.Enabled = false;
            }

        }

        private void btnThem_CTPT_Click(object sender, EventArgs e)
        {
            cbbThanhToan_CTPT.Text = "0";
            try
            {
                string SoPhong = cbbSoPhong_CTPT.Text;
                string MaPT = cbbMaPT_CTPT.Text;
                
                string TienDC = cbbTienDatCoc_CTPT.Text;
                string ThanhToan = cbbThanhToan_CTPT.Text;

                if (SoPhong == "" | MaPT == ""  | TienDC == ""| ThanhToan=="")
                {
                    MessageBox.Show("Bạn Chưa NHập Đủ Thông Tin!!!");
                    return;
                }
                int sophong = Convert.ToInt16(SoPhong);
                int mapt = Convert.ToInt16(MaPT);
                int makh = Convert.ToInt32(grvKhachHang.Rows[dongkh].Cells[0].Value);
                int tiendc = Convert.ToInt32(TienDC);
               DateTime date = dtpNgayLap_CTPT.Value;
               int tinhtrangTT = Convert.ToInt16(ThanhToan);

                string sql = @"insert into ChiTiet_PhieuThue(SoPhong,MaPT,MaKH,NgayLap,TienDatCoc,TinhTrangThanhToan) Values (N'"+sophong+"',N'"+mapt+"', N'"+makh+"','"+date+"','"+tiendc+"','"+tinhtrangTT+"')";
                int i = bll_CTPT.themDL(sql);
                if (i == 1)
                {
                    MessageBox.Show("Thêm Thành Công!");
                    cbbSoPhong();
                    grvCTPT.DataSource = bll_CTPT.Taobang("Select * from Chitiet_PhieuThue ");
                    bool them = true;
                    
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công!!!");
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi!!!");
            }
            clear();
        }

        private void cbbMaPT_CTPT_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cbbMaKH();

            try
            {
                int maPT = int.Parse(cbbMaPT_CTPT.Text);

                string sql = "Select MaKH from PhieuThue where MaPT = N'" + maPT + "'";
                cbbMaKH_CTPT.DataSource = bll_CTPT.Taobang(sql);
                cbbMaKH_CTPT.DisplayMember = "MaKH";
                cbbMaKH_CTPT.ValueMember = "MaKH";
                cbbMaKH_CTPT.Text = "";


            }
            catch(Exception ex){}


        }

        private void btnXoa_CTPT_Click(object sender, EventArgs e)
        {
            try
            {
                int maCTPT = Convert.ToInt16(grvCTPT.Rows[dong].Cells[0].Value);
                int tinhtrang = Convert.ToInt16(grvCTPT.Rows[dong].Cells[6].Value);
                string sql = @"delete from ChiTiet_PhieuThue where MaCTPT =N'" + maCTPT + "' ";
                if (tinhtrang == 0)
                {
                    MessageBox.Show("Phiếu Thuê Này Chưa Thanh Toán. KHông Xóa Được!");
                    return;
                }
                else
                {
                    int i = bll_CTPT.xoaDL(sql);
                    if (i == 1)
                    {
                        MessageBox.Show("Xóa Thành Công!");
                        grvCTPT.DataSource = bll_CTPT.Taobang("Select * from Chitiet_PhieuThue ");
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không Thành Công!!!");
                        return;
                    }
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        int dong;
        private void grvCTPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            HienBt();
            btnLuu_CTPT.Enabled = false;
        }

        private void btnSua_CTPT_Click(object sender, EventArgs e)
        {
            btnLuu_CTPT.Enabled = true;
            try
            {
                txtMaCTPT.Text = Convert.ToString(grvCTPT.Rows[dong].Cells[0].Value);
                cbbSoPhong_CTPT.Text = Convert.ToString(grvCTPT.Rows[dong].Cells[2].Value);
                cbbMaPT_CTPT.Text = Convert.ToString(grvCTPT.Rows[dong].Cells[1].Value);
                cbbMaKH_CTPT.Text = Convert.ToString(grvCTPT.Rows[dong].Cells[3].Value);
                dtpNgayLap_CTPT.Value = Convert.ToDateTime(grvCTPT.Rows[dong].Cells[4].Value);
                cbbTienDatCoc_CTPT.Text = Convert.ToString(grvCTPT.Rows[dong].Cells[5].Value);
                cbbThanhToan_CTPT.Text = Convert.ToString(grvCTPT.Rows[dong].Cells[6].Value);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuu_CTPT_Click(object sender, EventArgs e)
        {
            try
            {
                string MaCTPT = txtMaCTPT.Text;
                string SoPhong = cbbSoPhong_CTPT.Text;
                string MaPT = cbbMaPT_CTPT.Text;
                string MaKH = cbbMaKH_CTPT.Text;
                DateTime NgayLap = dtpNgayLap_CTPT.Value;
                string TienDC = cbbTienDatCoc_CTPT.Text;
                string ThanhToan = cbbThanhToan_CTPT.Text;

                int maCTPT = Convert.ToInt16(MaCTPT);
                int sophong = Convert.ToInt16(SoPhong);
                int maPT = Convert.ToInt16(MaPT);
                int maKH = Convert.ToInt16(MaKH);
                int tienDC = Convert.ToInt32(TienDC);
                int thanhtoan = Convert.ToInt16(ThanhToan);

                string sql = @"update CHiTiet_PhieuThue Set SoPhong = N'" + sophong + "', MaPT =N'" + maPT + "' , MaKH = N' " + maKH + " ', NgayLap = N'" + NgayLap + "', TienDatCoc = N'"+tienDC+"', TinhTrangThanhToan= N'"+thanhtoan+"'  Where MaCTPT = N'" + maCTPT + "' ";
                int i = bll_CTPT.Luu(sql);
                if (i == 1)
                {
                    MessageBox.Show("Lưu Thành Công!");
                    grvCTPT.DataSource = bll_CTPT.Taobang("Select * from ChiTiet_PhieuThue ");
                }
                else
                {
                    MessageBox.Show("Lưu Không Thành Công!!!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu Không Thành Công!!!");
                return;
            }
            clear();

        }
        private void grvCTPT_CellStyleChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cbbLoaiPhong_CTPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string LoaiPhong = (cbbLoaiPhong_CTPT.Text).ToString();
                string sql = @"Select * From Phong where TrangThai = 0 and LoaiPhong = N'" + LoaiPhong + "'";
                cbbSoPhong_CTPT.DataSource = bll_CTPT.Taobang(sql);
                cbbSoPhong_CTPT.DisplayMember = "SoPhong";
                cbbSoPhong_CTPT.ValueMember = "SoPhong";
                //cbbSoPhong_CTPT.SelectedIndex = 0;
                cbbSoPhong_CTPT.Text = "";

            }catch(Exception ex){}

        }

        private void cbbMaKH_CTPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int maKH = int.Parse(cbbMaKH_CTPT.Text);
                string sql = "Select * from KhachHang_CTPT where MaTD = '" + maKH + "'or (MaKH =   '" + maKH + "' and MaTD = 0 and VaiTro =0 )";
                grvKhachHang.DataSource = bll_CTPT.Taobang(sql);

            }catch(Exception ex){}
        }
        int dongkh;
        private void grvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongkh = e.RowIndex;
                cbbMaKH_CTPT.Text = (grvKhachHang.Rows[dong].Cells[0].Value).ToString();

            }catch(Exception ex){}

        }
    }
}
