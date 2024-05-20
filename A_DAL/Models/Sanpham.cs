using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Sanpham
{
    public string Masp { get; set; } = null!;

    public string Tensp { get; set; } = null!;

    public string? Mota { get; set; }

    public byte[]? Hinhanh { get; set; }

    public decimal Giaban { get; set; }

    public string Trangthai { get; set; } = null!;

    public Guid Maloaisp { get; set; }

    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();

    public virtual Loaisanpham MaloaispNavigation { get; set; } = null!;
}
