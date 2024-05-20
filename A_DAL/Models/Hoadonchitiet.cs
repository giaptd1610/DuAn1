using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Hoadonchitiet
{
    public Guid Mahd { get; set; }

    public string Masp { get; set; } = null!;

    public decimal Dongia { get; set; }

    public int Soluong { get; set; }

    public virtual Hoadon MahdNavigation { get; set; } = null!;

    public virtual Sanpham MaspNavigation { get; set; } = null!;
}
