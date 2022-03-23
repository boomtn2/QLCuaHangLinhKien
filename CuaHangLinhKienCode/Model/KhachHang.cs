using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLinhKienCode.Model
{
    public class KhachHang : Nguoi
    {
        int maKhachHang;
        List<HoaDon> hoaDons;

        public KhachHang(int maKhachHang)
        {
            this.maKhachHang = maKhachHang;
        }

        public KhachHang(int maKhachHang, string hoTen, string sDT, string diaChi, string email)
        {
            this.maKhachHang = maKhachHang;
            this.HoTen = hoTen;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.Email = email;
        }

        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }

    }
}
