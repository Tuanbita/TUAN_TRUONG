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
    public partial class NhanVien : Form
    {
        string SQL = "Select * from NhanVien ";
        Bll_NhanVien bll_NhanVien = new Bll_NhanVien();
        public NhanVien()
        {
            InitializeComponent();
        }
        public void HienBt()
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }
        public void AnBt()
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
         public void clear()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            cbbGT.SelectedIndex = 0;
            txtLuongNV.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtSoCMT.Clear();
            
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            AnBt();
            btnThem.Enabled = true;
            txtMaNV.Enabled = false;
            grvNhanVien.DataSource = bll_NhanVien.Taobang(SQL);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string TenNV = txtTenNV.Text;
            DateTime date = dtpNS.Value;
            string GT = cbbGT.Text;
            string Luong = txtLuongNV.Text;
            string DiaChi = txtDiaChi.Text;
            string SDT = txtSDT.Text;
            string SoCMT = txtSoCMT.Text;
            try
            {
                if (TenNV == "" | GT == "" | Luong == "" | DiaChi == "" | SDT == "" | SoCMT == "")
                {
                    MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin");
                    return;
                }
                int luong = Convert.ToInt32(Luong);
                string sql = "insert into NhanVien(TenNV,NgaySinh,GT,Luong,DiaChi,SDT,SoCMT) Values(N'"+TenNV+"',N'"+date+"',N'"+GT+"',N'"+luong+"',N'"+DiaChi+"',N'"+SDT+"',N'"+SoCMT+"')";
                int i = bll_NhanVien.themDL(sql);
                if(i==1)
                {
                    MessageBox.Show("Thêm Dữ Liệu Thành Công!");
                    grvNhanVien.DataSource = bll_NhanVien.Taobang(SQL);
                }
                else
                {
                    MessageBox.Show("Thêm Dữ Liệu Không Thành Công!!!");
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnLuu.Enabled = false;
            clear();

        }
        int dong;
        private void grvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            HienBt();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                int MaNV = Convert.ToInt16(grvNhanVien.Rows[dong].Cells[0].Value);
                string sql = "Delete from Nhanvien where MaNV = N'" + MaNV + "'";
                int i = bll_NhanVien.xoaDL(sql);
                if(i==1)
                {
                    MessageBox.Show("Xóa Thành Công!");
                    grvNhanVien.DataSource= bll_NhanVien.Taobang(SQL);
                }

                else
                {
                    MessageBox.Show("Xóa Không Thành Công!!!");
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnLuu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            try
            {
                txtMaNV.Text = Convert.ToString(grvNhanVien.Rows[dong].Cells[0].Value);
                txtTenNV.Text = Convert.ToString(grvNhanVien.Rows[dong].Cells[1].Value);
                dtpNS.Value = Convert.ToDateTime(grvNhanVien.Rows[dong].Cells[2].Value);
                cbbGT.Text = Convert.ToString(grvNhanVien.Rows[dong].Cells[3].Value);
                txtLuongNV.Text = Convert.ToString(grvNhanVien.Rows[dong].Cells[4].Value);
                txtDiaChi.Text = Convert.ToString(grvNhanVien.Rows[dong].Cells[5].Value);
                txtSDT.Text = Convert.ToString(grvNhanVien.Rows[dong].Cells[6].Value);
                txtSoCMT.Text = Convert.ToString(grvNhanVien.Rows[dong].Cells[7].Value);


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                clear();
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
            string MaNV = txtMaNV.Text;
            string TenNV = txtTenNV.Text;
            DateTime date = dtpNS.Value;
            string GT = cbbGT.Text;
            string Luong = txtLuongNV.Text;
            string DiaChi = txtDiaChi.Text;
            string SDT = txtSDT.Text;
            string SoCMT = txtSoCMT.Text;

            int manv = Convert.ToInt16(MaNV);
            int luong = Convert.ToInt32(Luong);

            string sql = @"update NhanVien  Set TenNV = N'"+TenNV+"', NgaySinh = N'"+date+"', GT = N'"+GT+"', Luong = N'"+luong+"', DiaChi = N'"+DiaChi+"', SDT = N'"+SDT+"', SoCMT =  N'"+SoCMT+"'  where MaNV = N'" + manv + "'";
            int i = bll_NhanVien.Luu(sql);
                if(i==1)
                {
                    MessageBox.Show("Lưu Thành Công!");
                    clear();
                    grvNhanVien.DataSource = bll_NhanVien.Taobang(SQL);
                }
                else
                {
                    MessageBox.Show("Lưu Không THành Công!!!");
                    return;
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }




        }
    }
}
