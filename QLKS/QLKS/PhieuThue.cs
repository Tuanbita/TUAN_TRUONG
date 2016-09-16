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
    public partial class PhieuThue : Form
    {
        Bll_PhieuThue bll_PT = new Bll_PhieuThue();
        public PhieuThue()
        {
            InitializeComponent();
        }

        public void cbbMakh()
        {
            //chỉ cho những khách hàng là trưởng đoàn hoặc không là gì cả hiện lên ở chỗ thê phiếu thuê mà thôi
            cbbmaKH_Tim.DataSource = bll_PT.Taobang("Select * from KhachHang where VaiTro = 1");

            cbbmaKH_Tim.DisplayMember = "MaKH";
            cbbmaKH_Tim.ValueMember = "MaKH";
            cbbmaKH_Tim.Text = "";
            

//             cbbMaKH_D.DataSource = bll_PT.Taobang("Select * from KhachHang where VaiTro = 1");
//             cbbMaKH_D.DisplayMember = "MaKH";
//             cbbMaKH_D.ValueMember = "MaKH";
//             //cbbSoPhong.SelectedIndex = 0;
//             cbbMaKH_D.Text = "";

        }

        public void clear()
        {
            txtMaPT.Clear();
            txtMaKH.Clear();
            //cbbTinhTrang_PT.Text = "";
        }

        public void HienBt()
        {
            btnSua_PT.Enabled = true;
            btnThem_PT.Enabled = true;
            btnXoa_PT.Enabled = true;
            btnLuu_PT.Enabled = true;
        }
        public void AnBt()
        {
            btnSua_PT.Enabled = false;
            btnThem_PT.Enabled = false;
            btnXoa_PT.Enabled = false;
            btnLuu_PT.Enabled = false;
        }


        private void PhieuThue_Load(object sender, EventArgs e)
        {
            AnBt(); btnThem_PT.Enabled = true;
            grvPhieuThue.DataSource = bll_PT.Taobang("Select * from PhieuThue ");

            grvKhachHang.DataSource = bll_PT.Taobang(" Select * from KhachHang_PT ");


            cbbMakh();
            //cbbTinhTrang_PT.Text = "0";
            if (_Phanquyen.Phanquyen == 0)
            {
                btnXoa_PT.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int dong;
        private void grvPhieuThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            HienBt();
            btnLuu_PT.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                if (txtMaKH.Text=="")
                {
                    MessageBox.Show("bạn chưa nhập đủ thông tin");
                    return;
                }
                int maKH = int.Parse(txtMaKH.Text);
                DateTime dt = dtpNgayLap.Value;

                string sql;
                sql = @"insert into PhieuThue(MaKH,NgayLap) values(N'" + maKH + "',N'" + dt + "')";

                // sql = @"insert into KhachHang(TenKH,NgaySinh,GT,SDT,SoCMT,MaTD,VaiTro) values(N'Tuan','1995/5/6',N'Nam',N'1234567',N'12345',1,1)";
                int i = bll_PT.themDL(sql);
                if (i == 1)
                {
                    MessageBox.Show("Thêm Thành công");
                }
                else MessageBox.Show("Lỗi!!!");

                grvPhieuThue.DataSource = bll_PT.Taobang("Select * from PhieuThue ");
                clear();
          
            btnLuu_PT.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu_PT.Enabled = true;
            
            try
            {
                clear();
                int TinhTrang = Convert.ToInt16(grvPhieuThue.Rows[dong].Cells[3].Value);
                int maPT = Convert.ToInt16(grvPhieuThue.Rows[dong].Cells[0].Value);
                int maKH = Convert.ToInt16(grvPhieuThue.Rows[dong].Cells[1].Value);
                DateTime datetime = Convert.ToDateTime(grvPhieuThue.Rows[dong].Cells[2].Value);

                txtMaPT.Text = maPT.ToString();
                txtMaKH.Text = maKH.ToString();
                dtpNgayLap.Value = datetime;
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa!");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maPT = Convert.ToInt16(grvPhieuThue.Rows[dong].Cells[0].Value);
                string sql = "Delete from PhieuThue where MaPT = N'" + maPT + "'";

                    DialogResult DR = MessageBox.Show("Do you sure you want to delete?", "Show", MessageBoxButtons.OKCancel);
                    if(DialogResult.OK==DR)
                    {
                        int i = bll_PT.xoaDL(sql);
                        if (i == 0)
                        {
                            MessageBox.Show("Error Delete!!!");
                        }
                        else
                        {
                            MessageBox.Show("Complete Delete!");
                            grvPhieuThue.DataSource = bll_PT.Taobang("Select * from PhieuThue ");
                        }
                    }
                    if(DialogResult.Cancel==DR)
                    {
                        MessageBox.Show("Hủy Thành Công!");
                        return;
                    }
            }catch(Exception ex)
            {
                MessageBox.Show("lỗi!!!", "Show", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       
        private void label1_Click(object sender, EventArgs e)
        {
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int maKH;
                int tinhtrang;
                string s = cbbmaKH_Tim.Text;
                string x = cbbTinhTrang_Tim.Text;
                if (s != "" | x!= "")
                {
                    
                    string sql = @"Select * from phieuthue where ";
                    if (x != "") tinhtrang = Convert.ToInt16(x); else tinhtrang = 0;
                    if (s != "") maKH = Convert.ToInt16(s); else maKH = 0;
                    string s1 = "MaKH = N'" + maKH + "'";
                    string s2 = "TinhTrangThanhToan = N'"+tinhtrang+"'";

                    if (s == "") s1 = "";
                    if (x == "") s2 = "";
                    if (s != "" & x != "") s2 = " and " + s2;
                    sql = sql + s1 + s2;
                    grvPhieuThue.DataSource = bll_PT.Taobang(sql);
                }
                else if (s == "" & x=="")
                {
                    grvPhieuThue.DataSource = bll_PT.Taobang(@"Select * from phieuthue ");
                }

                //cbbmaKH_Tim.Text = "";
                //cbbTinhTrang_Tim.Text = "";
            }
            catch (Exception ex)
            {

            }
//             cbbmaKH_Tim.Text = "";
//             cbbTinhTrang_Tim.Text = "";
        }

        private void btnLuu_PT_Click(object sender, EventArgs e)
        {
            try
            {

                int maPT = Convert.ToInt16(txtMaPT.Text);
                int maKH = int.Parse(txtMaKH.Text);
                //int TinhTrang = Convert.ToInt16(cbbTinhTrang_PT.Text);
                DateTime datetime = dtpNgayLap.Value;

                string sql = @"update PhieuThue Set MaKH = '" + maKH + "', NgayLap = '" + datetime + "'    where MaPT = '" + maPT + "'";
                int i= bll_PT.Luu(sql);
                if(i==1)
                {
                    MessageBox.Show("Lưu Thành Công!");
                    grvPhieuThue.DataSource= bll_PT.Taobang("Select * from PhieuThue ");
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi!!!");
            }
           
            clear();
        }
        private void grvPhieuThue_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        int dongkh;
        private void grvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongkh = e.RowIndex;
                txtMaKH.Text = (grvKhachHang.Rows[dongkh].Cells[0].Value).ToString();
            }catch(Exception ex){}
        }
    }
}
