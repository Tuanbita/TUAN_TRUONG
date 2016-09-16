using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
namespace QLKS
{
    public partial class Phong : Form
    {
        Bll_Phong bll_Phong = new Bll_Phong();
        public Phong()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtMaNV.Clear();
            cbbLoaiPhong.SelectedIndex=0;
            cbbGia.SelectedIndex = 0;
            txtMaNV.Clear();
            cbbTrangThai.SelectedIndex = 0;
        }
        public void cbb()
        {
            cbbGia.SelectedIndex = 0;
            cbbLoaiPhong.SelectedIndex = 0;
            cbbTrangThai.SelectedIndex = 0;
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

        private void PhongBan_Load(object sender, EventArgs e)
        {
            AnBt(); btnThem.Enabled = true; txtSoPhong.Enabled = false; cbbTrangThai.Enabled = false;
            grvPhong.DataSource = bll_Phong.Taobang("Select * from Phong ");
            cbb();
        }

        private void grvPhong_Click(object sender, EventArgs e)
        {
            HienBt(); btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            //string SoPhong = txtSoPhong.Text;
            string LoaiPhong = cbbLoaiPhong.Text;
            string Gia = cbbGia.Text;
            string MaNV = txtMaNV.Text;
            string TinhTrang = cbbTrangThai.Text;
            if(LoaiPhong==""|Gia==""|MaNV==""|TinhTrang=="")
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin");
                return;
            }
            try
            {
                //int sophong = Convert.ToInt16(SoPhong);
                int gia = Convert.ToInt32(Gia);
                int manv = Convert.ToInt16(MaNV);
                int tinhtrang = Convert.ToInt16(TinhTrang);

                string sql = @"Insert Into Phong(LoaiPhong, Gia, MaNV,TrangThai) values(N'" + LoaiPhong + "',N'" + gia + "',N'" + manv + "',N'" + tinhtrang + "')";
                int i = bll_Phong.themDL(sql);
                if(i==1)
                {
                    MessageBox.Show("Thêm Thành Công!");
                    grvPhong.DataSource = bll_Phong.Taobang("Select * from Phong ");
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công");
                    return;
                }
                clear();
            }catch(Exception ex)
            {
            }
        }
        int dong;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int sophong = Convert.ToInt16(grvPhong.Rows[dong].Cells[0].Value);
                string sql = "Delete From Phong Where SoPhong = '" + sophong + "'";
                int i = bll_Phong.xoaDL(sql);
                if(i==1)
                {
                    MessageBox.Show("Xóa Thành Công!");
                    grvPhong.DataSource = bll_Phong.Taobang("Select * from Phong ");
                }
                else
                {
                    MessageBox.Show("Xóa Không Thành Công!!!");
                    return;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Xóa Không Thành Công!!!");
                return;
            }
            clear();
        }
        private void grvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            try
            {
                txtSoPhong.Text = Convert.ToString(grvPhong.Rows[dong].Cells[0].Value);
                cbbLoaiPhong.Text = Convert.ToString(grvPhong.Rows[dong].Cells[1].Value);
                cbbGia.Text = Convert.ToString(grvPhong.Rows[dong].Cells[2].Value);
                txtMaNV.Text = Convert.ToString(grvPhong.Rows[dong].Cells[3].Value);
                cbbTrangThai.Text = Convert.ToString(grvPhong.Rows[dong].Cells[4].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string SoPhong = txtSoPhong.Text;
                string LoaiPhong = cbbLoaiPhong.Text;
                string Gia = cbbGia.Text;
                string MaNV = txtMaNV.Text;
                string TrangThai = cbbTrangThai.Text;

                int sophong = Convert.ToInt16(SoPhong);
                int gia = Convert.ToInt32(Gia);
                int manv = Convert.ToInt16(MaNV);
                int trangthai = Convert.ToInt16(TrangThai);

                string sql = @"update Phong Set LoaiPhong = N'"+LoaiPhong+"', Gia =N'"+gia+"' , MaNV = N' "+manv+" ', TrangThai = N'"+trangthai+"'   Where SoPhong = N'"+sophong+"' ";
                int i = bll_Phong.Luu(sql);
                if(i==1)
                {
                    MessageBox.Show("Lưu Thành Công!");
                    grvPhong.DataSource = bll_Phong.Taobang("Select * from Phong ");
                }
                else
                {
                    MessageBox.Show("Lưu Không Thành Công!!!");
                    return;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lưu Không Thành Công!!!");
                return;
            }
            clear();
        }
    }
}
