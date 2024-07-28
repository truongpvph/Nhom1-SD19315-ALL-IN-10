using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class DocGium
{
    public string MaDocGia { get; set; } = null!;

    public string? TenDocGia { get; set; }

    public string? Sdt { get; set; }

    public virtual ICollection<PhieuMuon> PhieuMuons { get; set; } = new List<PhieuMuon>();
}
