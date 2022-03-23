using CuaHangLinhKienCode.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLinhKienCode.DAO
{
    public class HangDAO
    {
        string selectALL = "SELECT Hang.*FROM [Hang]";

        public DataTable getSelectALL()
        {
            return DAOProvider.Instance.ExecuteQuery(selectALL);
        }
        public bool themHang(Hang hang)
        {
            string query = $"INSERT INTO [dbo].[Hang] VALUES ('{hang.MaHang}','{hang.TenHang}',{hang.GiaBan},0)";
            if (DAOProvider.Instance.ExecuteNonQuery(query) > 0)
                return false;
            else
                return true;
        }

        public bool xoaHang(Hang hang)
        {
            string query = $"DELETE FROM [dbo].[Hang] WHERE Hang.ma_hang =  '{hang.MaHang}'";
            if (DAOProvider.Instance.ExecuteNonQuery(query) > 0)
                return false;
            else
                return true;
        }

        public bool suaHang(Hang hang)
        {
            string query = $"UPDATE [dbo].[Hang] SET [ten_hang] = '{hang.TenHang}',[gia_ban] = {hang.GiaBan},[so_luong] ={hang.SoLuong} WHERE Hang.ma_hang = '{hang.MaHang}'";
            if (DAOProvider.Instance.ExecuteNonQuery(query) > 0)
                return false;
            else
                return true;
        }

        public DataTable tkMaHang(Hang hang)
        {
            string query = $"SELECT Hang.* from Hang where Hang.ma_hang Like '{hang.MaHang}%'";
            return DAOProvider.Instance.ExecuteQuery(query);
        }

        public DataTable tkTenHang(Hang hang)
        {
            string query = $"SELECT Hang.* from Hang where Hang.ten_hang Like '%{hang.TenHang}%'";
            return DAOProvider.Instance.ExecuteQuery(query);
        }
    }
}
