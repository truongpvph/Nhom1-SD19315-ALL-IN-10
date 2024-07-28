using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLQuanLySach
    {
        DALQuanLySach db = new DALQuanLySach();
        public List<Sach> getAllSach()
        {
            var listSach = db.getSachAll().ToList();
            return listSach;
        }

        public List<TacGium> getAllTacGium()
        {
            var listTacGia = db.getTacGiumAll().ToList();
            return listTacGia;
        }
        public List<TheLoai> GetTheLoais()
        {
            var listTheLoai = db.GetTheLoaisAll().ToList();
            return listTheLoai;
        }
        public List<NhaXuatBan> GetNhaXuatBans()
        {
            var listNXB = db.GetNhaXuatBansAll().ToList();
            return listNXB;
        }
        public TacGium GetTacGiumByName(string name)
        {
            foreach (var i in db.getTacGiumAll().ToList())
            {
                if (i.TenTacGia.ToLower().Contains(name.ToLower()))
                {
                    return i;
                }

            }
            return null;
        }
        public TacGium GetTacGiaById(string a)
        {
            foreach (var i in db.getTacGiumAll().ToList())
            {
                if (i.MaTacGia.Equals(a))
                {
                    return i;
                }
            }
            return null;
        }
        public TheLoai GetTheLoaiById(string a)
        {
            foreach (var i in db.GetTheLoaisAll().ToList())
            {
                if (i.MaTheLoai.Equals(a))
                {
                    return i;
                }
            }
            return null;
        }
       
      
        public Sach GetSachById(string a)
        {
            foreach (var i in db.getSachAll().ToList())
            {
                if (i.MaSach.Equals(a))
                {
                    return i;
                }
            }
            return null;
        }
        public NhaXuatBan GetNXBByID(string a)
        {
            foreach (var i in db.GetNhaXuatBansAll().ToList())
            {
                if (i.MaNhaXuatBan.Equals(a))
                {
                    return i;
                }
            }
            return null;
        }
        public TheLoai GetTheLoaiByName(string name)
        {
            foreach (var i in db.GetTheLoaisAll().ToList())
            {
                if (i.TenTheLoai.ToLower().Contains(name.ToLower()))
                {
                    return i;
                }

            }
            return null;
        }
        public NhaXuatBan GetNhaXuatBanByName(string name)
        {
            foreach (var i in db.GetNhaXuatBansAll().ToList())
            {
                if (i.TenNhaXuatBan.ToLower().Contains(name.ToLower()))
                {
                    return i;
                }

            }
            return null;
        }
        public void AddSach(string ms, string b, string c, string d, string e, string f, string g, string h, string i, string k, string l)
        {
            var MaSach = ms;
            var MaTacGia = GetTacGiumByName(b).MaTacGia.ToString();
            var MaTheLoai = GetTheLoaiByName(c).MaTheLoai.ToString();
            var TenSach = d;
            var MaNhaXuatBan = GetNhaXuatBanByName(e).MaNhaXuatBan.ToString();
            var GiaSach = f;
            var SoLuong = Convert.ToInt32(g);
            var TrangThaiSach = h;
            var NgayXuatBan = DateOnly.Parse(i);
            var MoTa = k;
            var ViTri = l;
            Sach sach = new Sach()
            {
                MaSach = MaSach,
                MaTacGia = MaTacGia,
                MaTheLoai = MaTheLoai,
                TenSach = TenSach,
                MaNhaXuatBan = MaNhaXuatBan,
                GiaSach = Convert.ToInt32(f),
                SoLuong = SoLuong,
                TrangThaiSach = TrangThaiSach,
                NgayXuatBan = NgayXuatBan,
                MoTa = MoTa,
                ViTri = ViTri,

            };
            db.AddSach(sach);
        }
        public void Update(string a, string b, string c, string d, string e, string f, string g, string h, string i, string k, string l)
        {
            var maSach = a;
            var maTacGia = GetTacGiumByName(b).MaTacGia.ToString();
            var maTheLoai = GetTheLoaiByName(c).MaTheLoai.ToString();
            var tenSach = d;
            var maNhaXuatBan = GetNhaXuatBanByName(e).MaNhaXuatBan.ToString();
            var giaSach = Convert.ToInt32(f);
            var soLuong = Convert.ToInt32(g);
            var trangThaiSach = h;
            var ngayXuatBan = DateOnly.Parse(i);
            var moTa = k;
            var viTri = l;
            Sach sach = GetSachById(maSach);

            sach.MaSach = maSach;
            sach.MaTacGia = maTacGia;
            sach.MaTheLoai = maTheLoai;
            sach.TenSach = tenSach;
            sach.MaNhaXuatBan = maNhaXuatBan;
            sach.GiaSach = giaSach;
            sach.SoLuong = soLuong;
            sach.TrangThaiSach = trangThaiSach;
            sach.NgayXuatBan = ngayXuatBan;
            sach.MoTa = moTa;
            sach.ViTri = viTri;


            db.Update(sach);
        }
        
    }
}
