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
    public partial class DichVu : Form
    {
        Bll_DichVu bll_DichVu = new Bll_DichVu();

        string SQL = "Select * from DichVu";

        public DichVu()
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
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtGiaDV.Clear();
        }


        private void DichVu_Load(object sender, EventArgs e)
        {
            grvDichVu.DataSource = bll_DichVu.Taobang(SQL);
            txtMaDV.Enabled = false;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //string MaDV = txtMaDV.Text;
            string TenDV = txtTenDV.Text;
            string GiaDV = txtGiaDV.Text;


            if(TenDV==""|GiaDV =="")
            {
                MessageBox.Show("Bạn Chưa NHập Đủ Thông Tin");
                return;
            }
            try
            {
                //int maDV = Convert.ToInt16(MaDV);
                int giaDV = Convert.ToInt32(GiaDV);

                string sql = "insert into DichVu(TenDV, Gia) values (N'" + TenDV + "',N'" + giaDV + "') ";
                int i = bll_DichVu.themDL(sql);
                if(i==1)
                {
                    MessageBox.Show("Thêm Thành Công!");
                    grvDichVu.DataSource = bll_DichVu.Taobang(SQL);

                }
                else
                {
                    MessageBox.Show("Thêm Chưa Thành Công!");
                    return;
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi Form Dịch Vụ!");
            }

            btnLuu.Enabled = false;
        }
        int dong;
        private void grvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            HienBt();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maDv = Convert.ToInt16(grvDichVu.Rows[dong].Cells[0].Value);

                string sql = "Delete from DichVu where MaDV = N'" + maDv + "'";
                int i = bll_DichVu.xoaDL(sql);
                if (i == 1)
                {
                    MessageBox.Show("Xóa Thành Công!");
                    grvDichVu.DataSource = bll_DichVu.Taobang(SQL);
                }
                else
                {
                    MessageBox.Show("KHông Xóa Được!");
                    return;
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi!!!");
            }
            btnLuu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string MaDV = Convert.ToString(grvDichVu.Rows[dong].Cells[0].Value);
                string TenDV = Convert.ToString(grvDichVu.Rows[dong].Cells[1].Value);
                string GiaDV = Convert.ToString(grvDichVu.Rows[dong].Cells[2].Value);

                txtGiaDV.Text = GiaDV;
                txtMaDV.Text = MaDV;
                txtTenDV.Text = TenDV;


            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi!!!");
            }

            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string MaDV = txtMaDV.Text;
                string TenDV = txtTenDV.Text;
                string GiaDV = txtGiaDV.Text;

                int maDV = Convert.ToInt16(MaDV);
                int gia = Convert.ToInt32(GiaDV);

                string sql = "Update Dichvu Set TenDV = N'" + TenDV + "', Gia = N'" + gia + "' where MaDV = N'" + maDV + "'";
                int i = bll_DichVu.Luu(sql);
                if(i==1)
                {
                    MessageBox.Show("Lưu Thành Công!");
                    grvDichVu.DataSource = bll_DichVu.Taobang(SQL);
                }
                else
                {
                    MessageBox.Show("Lưu Không Thành Công!!!");
                    return;
                }


            }catch(Exception ex)
            {
                
            }



        }
    }
}
