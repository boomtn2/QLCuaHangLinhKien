using CuaHangLinhKienCode.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLinhKienCode.DAO
{
    public class TaiKhoanDAO
    {
        string selectALL = "SELECT TaiKhoan.* FROM[dbo].[TaiKhoan]";

        //"USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count }
        public DataTable getSelectALL()
        {
            return DAOProvider.Instance.ExecuteQuery(selectALL);
        }

        public string dangNhap(TaiKhoan taiKhoan)
        {
            string query = $"SELECT TaiKhoan.chucvu FROM[dbo].[TaiKhoan] WHERE ten_tai_khoan = '{taiKhoan.TenTaiKhoan}' and mat_khau = '{taiKhoan.MatKhau}'";
            DataTable data = DAOProvider.Instance.ExecuteQuery(query);
            DataRow[] rows = data.Select();
            try
            {
                return rows[0]["chucvu"].ToString();
            }
            catch(Exception e)
            {
                return "false";
            }
        }

        public bool suaTaiKhoan(TaiKhoan taiKhoan)
        {
 
            string query = $"UPDATE [dbo].[TaiKhoan] SET ten_tai_khoan='{taiKhoan.TenTaiKhoan}' , mat_khau='{taiKhoan.MatKhau}' ,chucvu='{taiKhoan.ChucVu}' , ho_ten='{taiKhoan.HoTen}' , so_dien_thoai ='{taiKhoan.SDT}' , dia_chi='{taiKhoan.DiaChi}' , email='{taiKhoan.Email}' WHERE ma_tai_khoan={taiKhoan.MaTaiKhoan}";
           
            if (DAOProvider.Instance.ExecuteNonQuery(query) > 0)
                return false;
            else
                return true;
        }

        public bool taoTaiKhoan(TaiKhoan taiKhoan)
        {
            string query = $"INSERT INTO [dbo].[TaiKhoan] VALUES  ({taiKhoan.MaTaiKhoan}, '{taiKhoan.TenTaiKhoan}' , '{taiKhoan.MatKhau}' ,'{taiKhoan.ChucVu}' , '{taiKhoan.HoTen}' , '{taiKhoan.SDT}' , '{taiKhoan.DiaChi}' , '{taiKhoan.Email}')";

            if (DAOProvider.Instance.ExecuteNonQuery(query) > 0)
                return false;
            else
                return true;
        }

        public bool xoaTaiKhoan(TaiKhoan taiKhoan)
        {
            string query = $"DELETE FROM [dbo].[TaiKhoan] WHERE TaiKhoan.ma_tai_khoan =  {taiKhoan.MaTaiKhoan}";
            if (DAOProvider.Instance.ExecuteNonQuery(query) > 0)
                return false;
            else
                return true;
        }

        public DataTable timKiemTaiKhoan(TaiKhoan taiKhoan)
        {
            string query = $"SELECT TaiKhoan.* FROM[dbo].[TaiKhoan] WHERE TaiKhoan.so_dien_thoai Like '{taiKhoan.SDT}%'";
            return DAOProvider.Instance.ExecuteQuery(query);
        }
    }
}
