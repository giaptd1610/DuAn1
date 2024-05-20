using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class BanHoadon
{
    public string Maban { get; set; } = null!;

    public Guid? Mahd { get; set; }

    public string Trangthai { get; set; } = null!;

    public virtual Ban MabanNavigation { get; set; } = null!;

    public virtual Hoadon MahdNavigation { get; set; } = null!;
}
