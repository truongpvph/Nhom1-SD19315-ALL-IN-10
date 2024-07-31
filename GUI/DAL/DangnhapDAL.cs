using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangnhapDAL
    {
        QuanLyDuAnNhom1Sd19315Context DuAn1Context = new QuanLyDuAnNhom1Sd19315Context();
        public TaiKhoan Dangnhap(string taikhoan, string matkhau)
        {
            var a = DuAn1Context.TaiKhoans.ToList().FirstOrDefault(t => t.TaiKhoan1 == taikhoan && t.MatKhau == matkhau && t.MaVaiTro == "Admin");
            return a;
        }
        public TaiKhoan dangnhapnv(string taikhoan, string matkhau)
        {
            var a = DuAn1Context.TaiKhoans.ToList().FirstOrDefault(t => t.TaiKhoan1 == taikhoan && t.MatKhau == matkhau && t.MaVaiTro == "NV");
            return a;
        }
    }
}
