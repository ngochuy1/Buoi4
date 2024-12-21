using System;

namespace Buoi4
{
    internal class Nhanvien
    {
        public String MSNV { get; set; }
        public String TenNV { get; set; }
        public String LuongCB { get; set; }

        public Nhanvien(String MSNV, String TenNV, String LuongCB)
        {
            this.MSNV = MSNV;
            this.TenNV = TenNV;
            this.LuongCB = LuongCB;
        }
    }
}
