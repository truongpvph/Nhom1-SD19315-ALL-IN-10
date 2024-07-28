using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class TacGium
{
    public string MaTacGia { get; set; } = null!;

    public string? TenTacGia { get; set; }

    public string? GioiTinh { get; set; }

    public string? QuocGia { get; set; }

    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}
