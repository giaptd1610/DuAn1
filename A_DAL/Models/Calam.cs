using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Calam
{
    public string Maca { get; set; } = null!;

    public TimeSpan Giobd { get; set; }

    public TimeSpan Giokt { get; set; }

    public DateTime Ngaylamviec { get; set; }

    public string? Manv { get; set; }

    public virtual Nhanvien? ManvNavigation { get; set; }
}
