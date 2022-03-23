using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLinhKienCode.Model
{
    public class HoaDon
    {
        int maHoaDon;
        string ngayTao;
        string thanhTien;
        TaiKhoan nhanVien;
        KhachHang khachHang;
        List<Hang> hangs;
        List<int> soLuong;


        public HoaDon(int maHoaDon, string ngayTao, string thanhTien, TaiKhoan nhanVien, KhachHang khachHang, List<Hang> hangs, List<int> soluong)
        {
            this.maHoaDon = maHoaDon;
            this.ngayTao = ngayTao;
            this.thanhTien = thanhTien;
            this.nhanVien = nhanVien;
            this.khachHang = khachHang;
            this.hangs = hangs;
            this.soLuong = soluong;
        }



        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string NgayTao { get => ngayTao; set => ngayTao = value; }
        public string ThanhTien { get => thanhTien; set => thanhTien = value; }
        public TaiKhoan NhanVien { get => nhanVien; set => nhanVien = value; }
        public KhachHang KhachHang { get => khachHang; set => khachHang = value; }
        public List<Hang> Hangs { get => hangs; set => hangs = value; }
        public List<int> SoLuong { get => soLuong; set => soLuong = value; }
    }
}
