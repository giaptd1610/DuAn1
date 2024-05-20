using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Luong
{
    public Guid Maluong { get; set; }

    public decimal? Sotien { get; set; }

    public DateTime? Ngaytra { get; set; }

    public string Manv { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;

    public virtual ICollection<Phucap> Mapcs { get; set; } = new List<Phucap>();
}
