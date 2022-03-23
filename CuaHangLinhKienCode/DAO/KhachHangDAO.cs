using CuaHangLinhKienCode.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLinhKienCode.DAO
{
    public class KhachHangDAO
    {
        string selectALL = "SELECT KhachHang.* FROM [dbo].[KhachHang]";
        public DataTable getSelectALL()
        {
            return DAOProvider.Instance.ExecuteQuery(selectALL);
        }
        public bool themKhachHang(KhachHang khachHang)
        {
            string query = $"INSERT INTO [dbo].[KhachHang] VALUES({khachHang.MaKhachHang},'{khachHang.SDT}','{khachHang.HoTen}','{khachHang.DiaChi}','{khachHang.Email}')";
            if (DAOProvider.Instance.ExecuteNonQuery(query) > 0)
                return false;
            else
                return true;
        }

        public bool xoaKhachHang(KhachHang khachHang)
        {
            string query = $"DELETE FROM [dbo].[KhachHang] WHERE KhachHang.ma_khac_hang = {khachHang.MaKhachHang}";
            if (DAOProvider.Instance.ExecuteNonQuery(query) > 0)
                return false;
            else
                return true;
        }

        public bool suaKhachHang(KhachHang khachHang)
        {
            string query = $"UPDATE [dbo].[KhachHang] SET [so_dien_thoai] = '{khachHang.SDT}', [ho_ten]='{khachHang.HoTen}', [dia_chi]='{khachHang.DiaChi}' ,[email]='{khachHang.Email}' WHERE KhachHang.ma_khac_hang = {khachHang.MaKhachHang}";
            if (DAOProvider.Instance.ExecuteNonQuery(query) > 0)
                return false;
            else
                return true;
        }

        public DataTable timKhachHang()
        {
            return null;
        }
    }
}
