using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALtaikhoan
    {
        QuanLyDuAnNhom1Sd19315Context context  = new QuanLyDuAnNhom1Sd19315Context();
        public List<TaiKhoan> Load()
        {
            return context.TaiKhoans.ToList();
        }
        public bool ADD(TaiKhoan tk)
        {
            try
            {
                context.TaiKhoans.Add(tk);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(TaiKhoan item)
        {

            var a = context.TaiKhoans.Single(p => p.MaTaiKhoan == item.MaTaiKhoan);

            try
            {
                a.MaTaiKhoan = item.MaTaiKhoan;
                a.MaVaiTro = item.MaVaiTro;
                a.HoTen = item.HoTen;
                a.NgaySinh = item.NgaySinh;
                a.TaiKhoan1 = item.TaiKhoan1;
                a.MatKhau = item.MatKhau;
                a.SoDienThoai = item.SoDienThoai;
                a.SoCccd = item.SoCccd;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool delete(string id)
        {

            var a = context.TaiKhoans.ToList().SingleOrDefault(t => t.MaTaiKhoan == id);
            try
            {
                context.TaiKhoans.Remove(a);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool deletepm(string id)
        {
            var a = context.PhieuMuons.ToList().Find(t => t.MaTaiKhoan == id);
            try
            {
                context.PhieuMuons.Remove(a);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public TaiKhoan kiemtratk(string tk)
        {
            var a = context.TaiKhoans.ToList().FirstOrDefault(t => t.TaiKhoan1 == tk);
            return a;
        }

        public List<VaiTro> loadid()
        {
            return context.VaiTros.ToList();
        }
        public TaiKhoan TKtaikhoan(string tk)
        {
            var a = context.TaiKhoans.ToList().FirstOrDefault(p => p.MaTaiKhoan == tk);
            return a;
        }

        public TaiKhoan socccd(string tk)
        {
            var a = context.TaiKhoans.ToList().FirstOrDefault(p => p.SoCccd == tk);
            return a;
        }
        public TaiKhoan KTxoamataikhoan(string tk)
        {
            var a = context.TaiKhoans.FirstOrDefault(p => p.MaTaiKhoan == tk);
            return a;
        }
        public TaiKhoan SDT(string sdt)
        {
            var a = context.TaiKhoans.FirstOrDefault(p => p.SoDienThoai == sdt);
            return a;
        }
    }
}
