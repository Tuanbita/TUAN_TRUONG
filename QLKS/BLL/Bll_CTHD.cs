using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
namespace BLL
{
    public  class Bll_CTHD
    {
        DAL_CTHD dal_CTHD = new DAL_CTHD();

        public int themDL(string sql)
        {
            int i = dal_CTHD.ThemDL(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public int xoaDL(string sql)
        {
            int i = dal_CTHD.XoaDL(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public int Luu(string sql)
        {
            int i = dal_CTHD.Luu(sql);
            if (i == 1) return 1;
            else return 0;

        }
        
        public object laygiatridon(string sql)
        {
            return dal_CTHD.laygiatridon(sql);
        }
        public DataTable Taobang(string sql)
        {
            return dal_CTHD.taobang(sql);
        }

    }
}
