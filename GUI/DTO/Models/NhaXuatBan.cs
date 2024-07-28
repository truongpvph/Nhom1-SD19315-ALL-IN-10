using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class NhaXuatBan
{
    public string MaNhaXuatBan { get; set; } = null!;

    public string? TenNhaXuatBan { get; set; }

    public string? DiaChi { get; set; }

    public string? Sdt { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}
