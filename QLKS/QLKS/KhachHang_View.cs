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
    public partial class KhachHang_View : Form
    {
        Bll_KhachHang bll_KH = new Bll_KhachHang();
        public KhachHang_View()
        {
            InitializeComponent();
        }
        public void cbb_Clear()
        {
            cbbMa.Text = "";
            cbbHoTen.Text = "";
            cbbMaTD.Text = "";
            ckBVaiTro.Checked = false;
            txtSoCMT.Clear();
        }
        private void KhachHang_View_Load(object sender, EventArgs e)
        {
            grvKhachHang_View.DataSource = bll_KH.Taobang("Select * from KhachHang");

            DataTable dt1 = new DataTable();
            dt1 = bll_KH.Taobang("Select * from KhachHang");
            cbbMa.DataSource = dt1;
            cbbMa.DisplayMember = "MaKH";
            cbbMa.ValueMember = "MaKH";
            //cbbMa.SelectedIndex = 0;

            DataTable dt2 = new DataTable();
            dt2 = bll_KH.Taobang("Select * from KhachHang");
            cbbHoTen.DataSource= dt2;
            cbbHoTen.DisplayMember = "TenKH";
            cbbHoTen.ValueMember = "TenKH";

            DataTable dt3 = new DataTable();
            dt3 = bll_KH.Taobang("Select distinct MaTD from KhachHang");
            cbbMaTD.DataSource= dt3;
            cbbMaTD.DisplayMember = "MaTD";
            cbbMaTD.ValueMember = "MaTD";
            //cbbMaTD.SelectedIndex = 0;

            cbb_Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ckbSuDungNgay.Checked == false)
            {
                string ma = cbbMa.Text;
                string hoten = cbbHoTen.Text;
                string maTD = cbbMaTD.Text;
                int ck;
                if (ckBVaiTro.Checked == true) ck = 1;
                else ck = 0;
                string SoCMT = txtSoCMT.Text;

                if (ma == "" & hoten == "" & maTD == "" & ck == 0 & SoCMT == "")
                {
                    string sql1 = "Select * from KhachHang";
                    grvKhachHang_View.DataSource = bll_KH.Taobang(sql1);
                    return;
                }

                string sql = "Select * from KhachHang where ";
                string s1, s2, s3, s4, s5;
                s1 = " MaKH like N'%" + ma + "%' ";
                s2 = " TenKH like N'%" + hoten + "%' ";
                s3 = "  MaTD like N'%" + maTD + "%' ";
                s4 = " VaiTro = " + ck + " ";
                s5 = "SoCMT like N'%" + SoCMT + "%'";
                if (ma == "") s1 = "";
                if (hoten == "") s2 = "";
                if (maTD == "") s3 = "";
                if (ck == 0) s4 = "";
                if (SoCMT == "") s5 = "";

                if (ma != "" && hoten != "") s2 = " and " + s2;
                if ((ma != "" | hoten != "") & maTD != "") s3 = " and " + s3;
                if ((ma != "" | hoten != "" | s3 != "") & ck == 1) s4 = " and " + s4;
                if ((ma != "" | hoten != "" | s3 != "" | ck == 1) & SoCMT != "") s5 = " and " + s5;


                string str = sql + s1 + s2 + s3 + s4 + s5;


                grvKhachHang_View.DataSource = bll_KH.Taobang(str);

                cbb_Clear();
            }
            else
            {
                cbb_Clear();
                



            }
        }
    }
}
