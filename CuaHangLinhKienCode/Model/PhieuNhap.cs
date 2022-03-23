using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLinhKienCode.Model
{
    public class PhieuNhap
    {
        int maPhieuNhap;
        string ngayTao;
        TaiKhoan maNhanVien;
        List<Hang> hangs;
        List<double> giaNhap;
        List<int> soLuong;

        public PhieuNhap(int maPhieuNhap, string ngayTao, TaiKhoan maNhanVien, List<Hang> hangs, List<double> giaNhap, List<int> soLuong)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.ngayTao = ngayTao;
            this.maNhanVien = maNhanVien;
            this.hangs = hangs;
            this.giaNhap = giaNhap;
            this.soLuong = soLuong;
        }

        public int MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public string NgayTao { get => ngayTao; set => ngayTao = value; }
        public TaiKhoan MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public List<Hang> Hangs { get => hangs; set => hangs = value; }
        public List<double> GiaNhap { get => giaNhap; set => giaNhap = value; }
        public List<int> SoLuong { get => soLuong; set => soLuong = value; }
    }
}
