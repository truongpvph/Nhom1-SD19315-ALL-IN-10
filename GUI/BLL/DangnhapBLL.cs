using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DangnhapBLL
    {
        DangnhapDAL DALDangNhap = new DangnhapDAL();
        public bool Dangnhap(string tk, string mk)
        {
            var a = DALDangNhap.Dangnhap(tk, mk);
            if (a == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool dangnhapnv(string tk, string mk)
        {
            var a = DALDangNhap.dangnhapnv(tk, mk);
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
