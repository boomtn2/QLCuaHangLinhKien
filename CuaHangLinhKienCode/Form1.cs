using CuaHangLinhKienCode.DAO;
using CuaHangLinhKienCode.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangLinhKienCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* PhieuNhapDAO dao = new PhieuNhapDAO();
             List<int> SL = new List<int>() { 
             2,4,5
             };
             List<double> Gia = new List<double>() { 
             0,0,0};
             List<Hang> hang = new List<Hang>() {
             new Hang("FLT"),
              new Hang("FLT"),
               new Hang("FLT")
             };
             dao.suaPhieuNhap(new PhieuNhap(52, "03/03/2000", new TaiKhoan(1), hang, Gia, SL));*/

            KhachHangDAO dao = new KhachHangDAO();
            dao.themKhachHang(new KhachHang(52,"Hieu","0421","Hieu", "0421"));
        }
    }
}
