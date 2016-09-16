using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using EnTT;
namespace BLL
{
    public class Bll_PhieuThue
    {

        DAL_KhachHang dal_PT = new DAL_KhachHang();
  
        public int themDL(string sql)
        {
            int i = dal_PT.ThemDL(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public int xoaDL(string sql)
        {
            int i = dal_PT.XoaDL(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public int Luu(string sql)
        {
            int i = dal_PT.Luu(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public DataTable Taobang(string sql)
        {
            return dal_PT.taobang(sql);
        }
    }
}
