using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class ChiTietPhieuMuon
{
    public string MaChiTiet { get; set; } = null!;

    public string? MaPhieuMuon { get; set; }

    public string? MaSach { get; set; }

    public int? SoLuong { get; set; }

    public double? TongTien { get; set; }

    public DateOnly? NgayMuon { get; set; }

    public DateOnly? NgayTra { get; set; }

    public string? GhiChu { get; set; }

    public bool? TrangThai { get; set; }

    public virtual PhieuMuon? MaPhieuMuonNavigation { get; set; }

    public virtual Sach? MaSachNavigation { get; set; }
}
