using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using EnTT;
using BLL;
using PhanQuyen;
namespace QLKS
{
    public partial class KhachHang : Form
    {
        Bll_KhachHang bll_KH = new Bll_KhachHang();
        En_KhachHang en_KH = new En_KhachHang();

        public KhachHang()
        {
            InitializeComponent();
        }

        public void Anbtn()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }
        public void Hienbtn()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
        }
        public void clear()
        {
            txtGioiTinh.Clear();
            txtMaKH.Clear();
            
            txtSDT.Clear();
            txtSoCMT.Clear();
            txtTenKH.Clear();
            ckVaiTro.Checked = false;
            cbb();
        }
        public void cbb()
        {
            cbbMaTD.DataSource = bll_KH.Taobang("Select * from KhachHang where VaiTro = 1");

            cbbMaTD.DisplayMember = "MaKH";
            cbbMaTD.ValueMember = "MaKH";
            //cbbSoPhong.SelectedIndex = 0;
            cbbMaTD.Text = "0";
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            Anbtn();
            btnThem.Enabled = true;
            txtMaKH.Enabled = false;
            grvKhachHang.DataSource = bll_KH.Taobang("Select * from KhachHang");
            cbb();
            if(_Phanquyen.Phanquyen ==0)
            {
                btnXoa.Enabled = false;
            }
        }
        public int dong;
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                btnLuu.Enabled = false;
                string sql;
                string tenKH = txtTenKH.Text;
                string gtKH = txtGioiTinh.Text;
                string sdtKH = txtSDT.Text;
                string socmtKH = txtSoCMT.Text;
                string tdKH = cbbMaTD.Text;
                int VT = 0;


                if (tenKH == "" | gtKH == "" | socmtKH == "")
                {
                    MessageBox.Show("Bạn nhập chưa đủ thông tin của khách hàng");
                    return;
                }
                if (sdtKH == "")
                {
                    sdtKH = "0";
                }
                //DateTime Dt = Convert.ToDateTime(namsinhKH);
                DateTime Dt = dtpNS.Value;
                int truongdoan;
                try
                { truongdoan = Convert.ToInt16(tdKH); }
                catch (Exception ex) { MessageBox.Show("Chưa Chọn Mã Trưởng Đoàn"); return; }

                if (ckVaiTro.Checked == true) VT = 1;
                else VT = 0;

                sql = @"insert into KhachHang(TenKH,NgaySinh,GT,SDT,SoCMT,MaTD,VaiTro) values(N'" + tenKH + "',N'" + Dt + "',N'" + gtKH + "',N'" + sdtKH + "',N'" + socmtKH + "',N'" + truongdoan + "','" + VT + "')";

                // sql = @"insert into KhachHang(TenKH,NgaySinh,GT,SDT,SoCMT,MaTD,VaiTro) values(N'Tuan','1995/5/6',N'Nam',N'1234567',N'12345',1,1)";

                int i = bll_KH.themDL(sql);

                for (int dem = 0; dem < grvKhachHang.Rows.Count; dem++)
                {
                    int Val = Convert.ToInt16(grvKhachHang.Rows[dem].Cells[6].Value);
                    if(truongdoan != 0 & Val == truongdoan)
                    {
                        if(VT==1)
                        {
                            MessageBox.Show("Lỗi trùng vai trò người trưởng đoàn!");
                            return;
                        }
                    }
                }

                    if (i == 1) MessageBox.Show("Thêm Thành công");
                    else MessageBox.Show("Thêm Không Thành công");

                    grvKhachHang.DataSource = bll_KH.Taobang("Select * from KhachHang");
                clear();
            }
            catch(Exception ex)
            {

            }
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtMa_Khach_Hang_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
                int ma = Convert.ToInt16(grvKhachHang.Rows[dong].Cells[0].Value);
                string ten = Convert.ToString(grvKhachHang.Rows[dong].Cells[1].Value);
                DateTime datetime = Convert.ToDateTime(grvKhachHang.Rows[dong].Cells[2].Value);
                string gioitinh = Convert.ToString(grvKhachHang.Rows[dong].Cells[3].Value);
                string sdt = Convert.ToString(grvKhachHang.Rows[dong].Cells[4].Value);
                string cmt = Convert.ToString(grvKhachHang.Rows[dong].Cells[5].Value);
                int maTD = Convert.ToInt16(grvKhachHang.Rows[dong].Cells[6].Value);
                int vaitro = Convert.ToInt16(grvKhachHang.Rows[dong].Cells[7].Value);
                if (vaitro == 1) ckVaiTro.Checked = true;
                else ckVaiTro.Checked = false;
                txtMaKH.Text = ma.ToString();
                txtTenKH.Text = ten;
                dtpNS.Value = datetime;
                txtGioiTinh.Text = gioitinh;
                txtSDT.Text = sdt;
                txtSoCMT.Text = cmt;
                cbb();
                cbbMaTD.Text = maTD.ToString();

            }
            catch (Exception ex )
            {
                clear();
                return;
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //int d = grvKhachHang.CurrentCell.RowIndex; 
                btnLuu.Enabled = false;
                int ma = Convert.ToInt16(grvKhachHang.Rows[dong].Cells[0].Value);
                string sql = @"Delete from KhachHang Where MaKH = '" + ma + "' ";
                int VaiTro = Convert.ToInt16(grvKhachHang.Rows[dong].Cells[7].Value);
                if (VaiTro == 1 | ma != 0)
                {
                    DialogResult DR = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa", "Show", MessageBoxButtons.OKCancel);
                    if (DialogResult.OK == DR)
                    {
                        int i = bll_KH.xoaDL(sql);
                        if (i == 1) MessageBox.Show("Xóa Thành Công");
                        else MessageBox.Show("Không Xóa Được");
                    }
                    if (DialogResult.Cancel == DR)
                    {
                        return;
                    }
                }
                grvKhachHang.DataSource = bll_KH.Taobang("Select * from KhachHang");
                clear();
            }
            catch(Exception ex)
            {
            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = Convert.ToInt16(txtMaKH.Text);
                string tenKH = txtTenKH.Text;
                string gtKH = txtGioiTinh.Text;
                string sdtKH = txtSDT.Text;
                string socmtKH = txtSoCMT.Text;
                string tdKH = cbbMaTD.Text;
                int VT = 0;
                if (ckVaiTro.Checked) VT = 1;
                else VT = 0;
                DateTime dt = dtpNS.Value;
                int truongdoan = Convert.ToInt16(tdKH);

                string sql = "Update KhachHang Set TenKH = N'" + tenKH + "',NgaySinh = '" + dt + "', GT = N'" + gtKH + "', SDT = '" + sdtKH + "', SoCMT= '" + socmtKH + "', MaTD= '" + truongdoan + "', VaiTro =  '" + VT + "'   from KhachHang where MaKH = '" + ma + "'";

                for (int dem = 0; dem < grvKhachHang.Rows.Count; dem++)
                {
                    int Val = Convert.ToInt16(grvKhachHang.Rows[dem].Cells[6].Value);
                    int vaitro = Convert.ToInt16(grvKhachHang.Rows[dem].Cells[7].Value);
                    if (truongdoan != 0 & Val == truongdoan & vaitro==1 & ma != Val)
                    {
                        if (VT == 1)
                        {
                            MessageBox.Show("Lỗi trùng vai trò người trưởng đoàn!");
                            return;
                        }
                    }
                }

                bll_KH.Luu(sql);

                grvKhachHang.DataSource = bll_KH.Taobang("Select * from KhachHang");
                MessageBox.Show("Lưu Thành Công!");
                clear();
            }
            catch(Exception ex)
            {

            }
        }

        private void grvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            Hienbtn();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string SoCMT = txtSoCMT.Text;
            int kta = 0;
            if(SoCMT!="")
            {
                int socmt = Convert.ToInt32(SoCMT);
                
                for(int i=0; i<grvKhachHang.RowCount; i++)
                {
                    if(socmt==Convert.ToInt32(grvKhachHang.Rows[i].Cells[5].Value))
                    {
                        int maKH = Convert.ToInt16(grvKhachHang.Rows[i].Cells[0].Value);
                        MessageBox.Show("Khách Hàng Đã Có Trong Hệ Thống. Có Mã Là : '"+maKH+"'");
                        kta = 1;
                        return;
                    }
                   
                }
                if(kta==0)
                {
                    MessageBox.Show("Khách Hàng CHưa Có Trong Hệ Thống. Mời Bạn Nhập Đủ Thông Tin Cho Khách Hang!");
                }
                
            }

        }
    }
}
