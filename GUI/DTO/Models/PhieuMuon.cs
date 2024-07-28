using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class PhieuMuon
{
    public string MaPhieuMuon { get; set; } = null!;

    public string? MaDocGia { get; set; }

    public string? MaTaiKhoan { get; set; }

    public virtual ICollection<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; } = new List<ChiTietPhieuMuon>();

    public virtual DocGium? MaDocGiaNavigation { get; set; }

    public virtual TaiKhoan? MaTaiKhoanNavigation { get; set; }
}
