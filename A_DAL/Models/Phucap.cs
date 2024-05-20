using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Phucap
{
    public Guid Mapc { get; set; }

    public string Tenphucap { get; set; } = null!;

    public decimal Sotienphucap { get; set; }

    public virtual ICollection<Luong> Maluongs { get; set; } = new List<Luong>();
}
