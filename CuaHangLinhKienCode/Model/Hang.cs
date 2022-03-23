using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLinhKienCode.Model
{
    public class Hang
    {
        string maHang;
        string tenHang;
        double giaBan;
        int soLuong;

        public Hang(string maHang, string tenHang, double giaBan, int soLuong)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.giaBan = giaBan;
            this.soLuong = soLuong;
        }

        public Hang(string maHang)
        {
            this.maHang = maHang;
        }


        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
