using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnTT
{
    public class En_KhachHang
    {
        int _MaKH;
        public int MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        string _TenKH;
        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }

        DateTime _NgaySinhKH ;
        public DateTime NgaySinhKH
        {
            get { return _NgaySinhKH; }
            set { _NgaySinhKH = value; }
        }

        string _GT;
        public string GT
        {
            get { return _GT; }
            set { _GT = value; }
        }

        string _SDT;
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        string _SoCMT;
        public string SoCMT
        {
            get { return _SoCMT; }
            set { _SoCMT = value; }
        }

        int _TruongNhom;
        public int TruongNhom
        {
            get { return _TruongNhom; }
            set { _TruongNhom = value; }
        }

        int _VaiTro;
        public int VaiTro
        {
            get { return _VaiTro; }
            set { _VaiTro = value; }
        }

        
    }
}
