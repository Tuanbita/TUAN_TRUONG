﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnTT;
using System.Data;
namespace DAL
{
    public class DAL_PhieuThue
    {
        KetNoi ketnoi = new KetNoi();


        public int ThemDL(string sql)
        {

            int i = ketnoi.thucthilenh(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public int XoaDL(string sql)
        {
            int i = ketnoi.thucthilenh(sql);
            if (i == 1) return 1;
            else return 0;
        }

        public int Luu(string sql)
        {
            int i = ketnoi.thucthilenh(sql);
            if (i == 1) return 1;
            else return 0;

        }
        public DataTable taobang(string str)
        {
            try
            {
                return ketnoi.taobang(str);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
