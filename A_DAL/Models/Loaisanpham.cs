using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Loaisanpham
{
    public Guid Maloaisp { get; set; }

    public string Tenloaisp { get; set; } = null!;

    public string? Mota { get; set; }

    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();
}
