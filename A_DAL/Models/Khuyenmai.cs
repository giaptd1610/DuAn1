using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Khuyenmai
{
    public string Makm { get; set; } = null!;

    public string Tenkm { get; set; } = null!;

    public DateTime Ngaytao { get; set; }

    public DateTime? Ngaybd { get; set; }

    public DateTime? Ngaykt { get; set; }

    public string? Mota { get; set; }

    public int? Soptgiam { get; set; }

    public decimal? Sotiengiam { get; set; }

    public string? Dkgiam { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
