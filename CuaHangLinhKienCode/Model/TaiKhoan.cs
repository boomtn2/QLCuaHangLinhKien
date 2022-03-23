using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLinhKienCode.Model
{
    public class TaiKhoan: Nguoi
    {
        int maTaiKhoan;
        string tenTaiKhoan;
        string matKhau;
        string chucVu;

        public TaiKhoan(int maTaiKhoan, string tenTaiKhoan, string matKhau, string chucVu, string hoTen, string sDT, string diaChi, string email)
        {
            this.maTaiKhoan = maTaiKhoan;
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.chucVu = chucVu;
            this.HoTen = hoTen;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.Email = email;
        }

        public TaiKhoan( string tenTaiKhoan, string matKhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
        }

        public TaiKhoan(int maTaiKhoan)
        {
            this.maTaiKhoan = maTaiKhoan;
        }

        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }


    }
}
