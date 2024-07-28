using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Sach
{
    public string MaSach { get; set; } = null!;

    public string? MaTheLoai { get; set; }

    public string? MaTacGia { get; set; }

    public string? MaNhaXuatBan { get; set; }

    public string? TenSach { get; set; }

    public int? GiaSach { get; set; }

    public int? SoLuong { get; set; }

    public string? TrangThaiSach { get; set; }

    public DateOnly? NgayXuatBan { get; set; }

    public string? MoTa { get; set; }

    public string? ViTri { get; set; }

    public virtual ICollection<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; } = new List<ChiTietPhieuMuon>();

    public virtual NhaXuatBan? MaNhaXuatBanNavigation { get; set; }

    public virtual TacGium? MaTacGiaNavigation { get; set; }

    public virtual TheLoai? MaTheLoaiNavigation { get; set; }
}
