using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
namespace BLL
{
    public class Bll_CTDV
    {
        DAL_KhachHang dal_CTDV = new DAL_KhachHang();


        public int themDL(string sql)
        {
            int i = dal_CTDV.ThemDL(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public int xoaDL(string sql)
        {
            int i = dal_CTDV.XoaDL(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public int Luu(string sql)
        {
            int i = dal_CTDV.Luu(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public DataTable Taobang(string sql)
        {
            return dal_CTDV.taobang(sql);
        }

    }
}
