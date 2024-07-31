using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLtaikhoan
    {
        DALtaikhoan DALQLnhanvien = new DALtaikhoan();
        public List<TaiKhoan> Load()
        {
            return DALQLnhanvien.Load();
        }
        public bool ADD(TaiKhoan khoan)
        {
            return DALQLnhanvien.ADD(khoan);
        }
        public bool Update(TaiKhoan item)
        {
            return DALQLnhanvien.Update(item);
        }
        public bool Delete(string id)
        {
            return DALQLnhanvien.delete(id);
        }
        public bool deletepm(string id)
        {
            return DALQLnhanvien.deletepm(id);
        }
        public List<VaiTro> loadten()
        {
            return DALQLnhanvien.loadid();
        }
        public List<TaiKhoan> TimKiem(string ten)
        {
            var a = DALQLnhanvien.Load().Where(p => p.HoTen.ToLower().Contains(ten.ToLower())).ToList();
            return a;
        }
        public bool SDT(string sdt)
        {
            return sdt.Trim().Length < 10 || sdt.Trim().Length > 10;
        }
        public bool Scccd(string sdt)
        {
            return sdt.Trim().Length < 12 || sdt.Trim().Length > 12;
        }
        public bool Taikhoan(string sdt)
        {
            return sdt.Trim().Length < 8 ;
        }
        public bool MatKhau(string sdt)
        {
            return  sdt.Trim().Length <8;
        }
        public bool kiemtratk(string tk)
        {
            var a = DALQLnhanvien.kiemtratk(tk);
            if (a == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool KTMaTK(string tk)
        {
            var a = DALQLnhanvien.TKtaikhoan(tk);
            if (a == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool KTsocccd(string tk)
        {
            var a = DALQLnhanvien.socccd(tk);
            if (a == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ktXoamatk(string tk)
        {
            var a = DALQLnhanvien.KTxoamataikhoan(tk);
            if (a == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool SDTduynhat(string sdt)
        {
            var a = DALQLnhanvien.SDT(sdt);
            if (a == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
