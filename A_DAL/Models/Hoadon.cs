using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Hoadon
{
    public Guid Mahd { get; set; }

    public DateTime Ngaytaohd { get; set; }

    public DateTime? Ngaythanhtoan { get; set; }

    public decimal Tongtien { get; set; }

    public string Trangthai { get; set; } = null!;

    public string Manv { get; set; } = null!;

    public string? Makm { get; set; }

    public virtual ICollection<BanHoadon> BanHoadons { get; set; } = new List<BanHoadon>();

    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();

    public virtual Khuyenmai MakmNavigation { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;
}
