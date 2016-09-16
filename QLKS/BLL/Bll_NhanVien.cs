using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
namespace BLL
{
    public class Bll_NhanVien
    {
        DAL_KhachHang dal_Kh = new DAL_KhachHang();
        
        public int themDL(string sql)
        {
            int i = dal_Kh.ThemDL(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public int xoaDL(string sql)
        {
            int i = dal_Kh.XoaDL(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public int Luu(string sql)
        {
            int i = dal_Kh.Luu(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public DataTable Taobang(string sql)
        {
            return dal_Kh.taobang(sql);
        }
    }
}
