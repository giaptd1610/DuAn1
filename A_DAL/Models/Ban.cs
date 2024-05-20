using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Ban
{
    public string Maban { get; set; } = null!;

    public string Tenban { get; set; } = null!;

    public string Trangthai { get; set; } = null!;

    public virtual ICollection<BanHoadon> BanHoadons { get; set; } = new List<BanHoadon>();
}
