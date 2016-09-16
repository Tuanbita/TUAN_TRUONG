using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
namespace BLL
{
    public class Bll_Phong
    {
        DAL_KhachHang dal_Phong = new DAL_KhachHang();
        

        public int themDL(string sql)
        {
            int i = dal_Phong.ThemDL(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public int xoaDL(string sql)
        {
            int i = dal_Phong.XoaDL(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public int Luu(string sql)
        {
            int i = dal_Phong.Luu(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public DataTable Taobang(string sql)
        {
            return dal_Phong.taobang(sql);
        }

    }
}
