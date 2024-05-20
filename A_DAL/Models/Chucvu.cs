using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Chucvu
{
    public Guid Machucvu { get; set; }

    public string? Tenchucvu { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
