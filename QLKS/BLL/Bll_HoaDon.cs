using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
namespace BLL
{
    public class Bll_HoaDon
    {
        DAL_HoaDon dal_HoaDon = new DAL_HoaDon();

        public int themDL(string sql)
        {
            int i = dal_HoaDon.ThemDL(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public int xoaDL(string sql)
        {
            int i = dal_HoaDon.XoaDL(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public int Luu(string sql)
        {
            int i = dal_HoaDon.Luu(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public DataTable Taobang(string sql)
        {
            return dal_HoaDon.taobang(sql);
        }
    }
}
