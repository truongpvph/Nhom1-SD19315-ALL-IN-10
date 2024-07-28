using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class TaiKhoan
{
    public string MaTaiKhoan { get; set; } = null!;

    public string? MaVaiTro { get; set; }

    public string? HoTen { get; set; }

    public string? SoDienThoai { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? TaiKhoan1 { get; set; }

    public string? MatKhau { get; set; }

    public string? SoCccd { get; set; }

    public virtual VaiTro? MaVaiTroNavigation { get; set; }

    public virtual ICollection<PhieuMuon> PhieuMuons { get; set; } = new List<PhieuMuon>();
}
