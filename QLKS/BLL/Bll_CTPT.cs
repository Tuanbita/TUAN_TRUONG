using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
namespace BLL
{
   public class Bll_CTPT
   {
       DAL_CTPT dal_CTPT = new DAL_CTPT();

       public int themDL(string sql)
       {
           int i = dal_CTPT.ThemDL(sql);
           if (i == 1) return 1;
           else return 0;

       }
       public int xoaDL(string sql)
       {
           int i = dal_CTPT.XoaDL(sql);
           if (i == 1) return 1;
           else return 0;

       }
       public int Luu(string sql)
       {
           int i = dal_CTPT.Luu(sql);
           if (i == 1) return 1;
           else return 0;

       }
       public DataTable Taobang(string sql)
       {
           return dal_CTPT.taobang(sql);
       }

   }
}
