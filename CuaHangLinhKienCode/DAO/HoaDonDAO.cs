using CuaHangLinhKienCode.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLinhKienCode.DAO
{
    public class HoaDonDAO
    {
        public bool taoHoaDon(HoaDon hoaDon)
        {
            string query = $"INSERT INTO [dbo].[HoaDon]VALUES({hoaDon.MaHoaDon},'{hoaDon.NgayTao}',{hoaDon.ThanhTien},{hoaDon.NhanVien.MaTaiKhoan},{hoaDon.KhachHang.MaKhachHang})";
            DAOProvider.Instance.ExecuteNonQuery(query);

            int i = 0;

            foreach(Hang item in hoaDon.Hangs)
            {
                try
                {
                    query = $"INSERT INTO[dbo].[ChiTietHoaDon] VALUES({hoaDon.MaHoaDon},'{item.MaHang}',{hoaDon.SoLuong[i]})";
                    i++;
                }catch(Exception e)
                {
                    return false;
                }
            }
            return true;
        }

        public bool xoaHoaDon(HoaDon hoaDon)
        {
            string query = $"DELETE FROM [dbo].[ChiTietHoaDon] WHERE ChiTietHoaDon.ma_hoa_don = {hoaDon.MaHoaDon}";
            DAOProvider.Instance.ExecuteNonQuery(query);

            query = $"DELETE FROM [dbo].[HoaDon] WHERE HoaDon.ma_hoa_don = {hoaDon.MaHoaDon}";
            DAOProvider.Instance.ExecuteNonQuery(query);

            if (DAOProvider.Instance.ExecuteNonQuery(query) > 0)
                return false;
            else
                return true;
        }

        public bool suaHoaDon(HoaDon hoaDon)
        {
           
            string query = $"UPDATE [dbo].[HoaDon] SET [ngay_tao] = '{hoaDon.NgayTao}' ,[thanh_tien] = {hoaDon.ThanhTien},[ma_nhan_vien] = {hoaDon.NhanVien.MaTaiKhoan},[ma_khach_hang] = {hoaDon.KhachHang.MaKhachHang} WHERE HoaDon.ma_hoa_don = {hoaDon.MaHoaDon}";
            DAOProvider.Instance.ExecuteNonQuery(query);

            int i = 0;

            foreach (Hang item in hoaDon.Hangs)
            {
                try
                {
                    query = $" UPDATE[dbo].[ChiTietHoaDon] SET [ma_hang] ='{item.MaHang}' ,[so_luong] = {hoaDon.SoLuong[i]} WHERE ChiTietHoaDon.ma_hoa_don = {hoaDon.MaHoaDon}";
                    i++;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return true;
        }

        public DataTable timKiemHoaDon(HoaDon hoaDon)
        {
            string query = $"SELECT HoaDon.* From HoaDon Where HoaDon.ma_hoa_don = {hoaDon.MaHoaDon}";
            return DAOProvider.Instance.ExecuteQuery(query);
        }
    }
}
