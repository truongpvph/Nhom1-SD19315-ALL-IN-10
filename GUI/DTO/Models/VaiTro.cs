using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class VaiTro
{
    public string MaVaiTro { get; set; } = null!;

    public string? Vaitro1 { get; set; }

    public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
}
