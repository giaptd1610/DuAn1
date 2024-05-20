using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Nhanvien
{
    public string Manv { get; set; } = null!;

    public string Hoten { get; set; } = null!;

    public string Gioitinh { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public string Email { get; set; } = null!;

    public Guid Chucvu { get; set; }

    public string Taikhoan { get; set; } = null!;

    public string Matkhau { get; set; } = null!;

    public string Trangthai { get; set; } = null!;

    public virtual ICollection<Calam> Calams { get; set; } = new List<Calam>();

    public virtual Chucvu ChucvuNavigation { get; set; } = null!;

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual ICollection<Luong> Luongs { get; set; } = new List<Luong>();
}
