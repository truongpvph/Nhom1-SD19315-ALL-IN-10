using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALQuanLySach
    {

        QuanLyDuAnNhom1Sd19315Context db = new QuanLyDuAnNhom1Sd19315Context();
        public List<Sach> getSachAll()
        {
            var listSach = db.Saches.ToList();
            return listSach;
        }
        public List<TacGium> getTacGiumAll()
        {
            var listTacgia = db.TacGia.ToList();
            return listTacgia;
        }
        public List<TheLoai> GetTheLoaisAll()
        {
            var listTheLoai = db.TheLoais.ToList();
            return listTheLoai;
        }
        public List<NhaXuatBan> GetNhaXuatBansAll()
        {
            var listNXB = db.NhaXuatBans.ToList();
            return listNXB;
        }
        public void AddSach(Sach sach)
        {
            db.Saches.Add(sach);
            db.SaveChanges();
        }
        
        public void Update(Sach sach)
        {
            db.Saches.Update(sach);
            db.SaveChanges();
        }
    }
}
