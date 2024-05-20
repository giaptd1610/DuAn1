using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Models;

public partial class Duan1Context : DbContext
{
    public Duan1Context()
    {
    }

    public Duan1Context(DbContextOptions<Duan1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Ban> Bans { get; set; }

    public virtual DbSet<BanHoadon> BanHoadons { get; set; }

    public virtual DbSet<Calam> Calams { get; set; }

    public virtual DbSet<Chucvu> Chucvus { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Hoadonchitiet> Hoadonchitiets { get; set; }

    public virtual DbSet<Khuyenmai> Khuyenmais { get; set; }

    public virtual DbSet<Loaisanpham> Loaisanphams { get; set; }

    public virtual DbSet<Luong> Luongs { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Phucap> Phucaps { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public string connectiongString() { return "Data Source=MSI\\MSI;Initial Catalog=DUAN1;Trust Server Certificate=True; Trusted_Connection=true;"; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(connectiongString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ban>(entity =>
        {
            entity.HasKey(e => e.Maban).HasName("PK__BAN__4033B61AAB33A962");

            entity.ToTable("BAN");

            entity.Property(e => e.Maban)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MABAN");
            entity.Property(e => e.Tenban)
                .HasMaxLength(255)
                .HasColumnName("TENBAN");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(20)
                .HasColumnName("TRANGTHAI");
        });

        modelBuilder.Entity<BanHoadon>(entity =>
        {
            entity.HasKey(e => new { e.Maban, e.Mahd }).HasName("PK__BAN_HOAD__B63044163449EF51");

            entity.ToTable("BAN_HOADON");

            entity.Property(e => e.Maban)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MABAN");
            entity.Property(e => e.Mahd).HasColumnName("MAHD");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(20)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MabanNavigation).WithMany(p => p.BanHoadons)
                .HasForeignKey(d => d.Maban)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BAN_HOADO__MABAN__5812160E");

            entity.HasOne(d => d.MahdNavigation).WithMany(p => p.BanHoadons)
                .HasForeignKey(d => d.Mahd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BAN_HOADON__MAHD__59063A47");
        });

        modelBuilder.Entity<Calam>(entity =>
        {
            entity.HasKey(e => e.Maca).HasName("PK__CALAM__603F1829367B348C");

            entity.ToTable("CALAM");

            entity.Property(e => e.Maca)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MACA");
            entity.Property(e => e.Giobd)
                .HasColumnType("BIGINT")
                .HasColumnName("GIOBD");
            entity.Property(e => e.Giokt)
                .HasColumnType("BIGINT")
                .HasColumnName("GIOKT");
            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .HasColumnName("MANV");
            entity.Property(e => e.Ngaylamviec)
                .HasColumnType("date")
                .HasColumnName("NGAYLAMVIEC");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Calams)
                .HasForeignKey(d => d.Manv)
                .HasConstraintName("FK__CALAM__MANV__44FF419A");
        });

        modelBuilder.Entity<Chucvu>(entity =>
        {
            entity.HasKey(e => e.Machucvu).HasName("PK__CHUCVU__9FA9FD6AB728C8FB");

            entity.ToTable("CHUCVU");

            entity.Property(e => e.Machucvu)
                .ValueGeneratedNever()
                .HasColumnName("MACHUCVU");
            entity.Property(e => e.Tenchucvu)
                .HasMaxLength(255)
                .HasColumnName("TENCHUCVU");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.Mahd).HasName("PK__HOADON__603F20CE1126D14B");

            entity.ToTable("HOADON");

            entity.Property(e => e.Mahd)
                .ValueGeneratedNever()
                .HasColumnName("MAHD");
            entity.Property(e => e.Makm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAKM");
            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .HasColumnName("MANV");
            entity.Property(e => e.Ngaytaohd)
                .HasColumnType("date")
                .HasColumnName("NGAYTAOHD");
            entity.Property(e => e.Ngaythanhtoan)
                .HasColumnType("date")
                .HasColumnName("NGAYTHANHTOAN");
            entity.Property(e => e.Tongtien)
                .HasColumnType("money")
                .HasColumnName("TONGTIEN");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(20)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MakmNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Makm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MAKM__4F7CD00D");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Manv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MANV__4E88ABD4");
        });

        modelBuilder.Entity<Hoadonchitiet>(entity =>
        {
            entity.HasKey(e => new { e.Mahd, e.Masp }).HasName("PK__HOADONCH__563D086D5AFD9279");

            entity.ToTable("HOADONCHITIET");

            entity.Property(e => e.Mahd).HasColumnName("MAHD");
            entity.Property(e => e.Masp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASP");
            entity.Property(e => e.Dongia)
                .HasColumnType("money")
                .HasColumnName("DONGIA");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

            entity.HasOne(d => d.MahdNavigation).WithMany(p => p.Hoadonchitiets)
                .HasForeignKey(d => d.Mahd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADONCHIT__MAHD__52593CB8");

            entity.HasOne(d => d.MaspNavigation).WithMany(p => p.Hoadonchitiets)
                .HasForeignKey(d => d.Masp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADONCHIT__MASP__534D60F1");
        });

        modelBuilder.Entity<Khuyenmai>(entity =>
        {
            entity.HasKey(e => e.Makm).HasName("PK__KHUYENMA__603F592B0B750413");

            entity.ToTable("KHUYENMAI");

            entity.Property(e => e.Makm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAKM");
            entity.Property(e => e.Dkgiam)
                .HasMaxLength(255)
                .HasColumnName("DKGIAM");
            entity.Property(e => e.Mota)
                .HasMaxLength(255)
                .HasColumnName("MOTA");
            entity.Property(e => e.Ngaybd)
                .HasColumnType("date")
                .HasColumnName("NGAYBD");
            entity.Property(e => e.Ngaykt)
                .HasColumnType("date")
                .HasColumnName("NGAYKT");
            entity.Property(e => e.Ngaytao)
                .HasColumnType("date")
                .HasColumnName("NGAYTAO");
            entity.Property(e => e.Soptgiam).HasColumnName("SOPTGIAM");
            entity.Property(e => e.Sotiengiam)
                .HasColumnType("money")
                .HasColumnName("SOTIENGIAM");
            entity.Property(e => e.Tenkm)
                .HasMaxLength(255)
                .HasColumnName("TENKM");
        });

        modelBuilder.Entity<Loaisanpham>(entity =>
        {
            entity.HasKey(e => e.Maloaisp).HasName("PK__LOAISANP__AFCB0D365D4ABE2D");

            entity.ToTable("LOAISANPHAM");

            entity.Property(e => e.Maloaisp)
                .ValueGeneratedNever()
                .HasColumnName("MALOAISP");
            entity.Property(e => e.Mota)
                .HasMaxLength(255)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenloaisp)
                .HasMaxLength(255)
                .HasColumnName("TENLOAISP");
        });

        modelBuilder.Entity<Luong>(entity =>
        {
            entity.HasKey(e => e.Maluong).HasName("PK__LUONG__D9BA4D00987D550A");

            entity.ToTable("LUONG");

            entity.Property(e => e.Maluong)
                .ValueGeneratedNever()
                .HasColumnName("MALUONG");
            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .HasColumnName("MANV");
            entity.Property(e => e.Ngaytra)
                .HasColumnType("date")
                .HasColumnName("NGAYTRA");
            entity.Property(e => e.Sotien)
                .HasColumnType("money")
                .HasColumnName("SOTIEN");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Luongs)
                .HasForeignKey(d => d.Manv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LUONG__MANV__3C69FB99");

            entity.HasMany(d => d.Mapcs).WithMany(p => p.Maluongs)
                .UsingEntity<Dictionary<string, object>>(
                    "Luongchitiet",
                    r => r.HasOne<Phucap>().WithMany()
                        .HasForeignKey("Mapc")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__LUONGCHITI__MAPC__4222D4EF"),
                    l => l.HasOne<Luong>().WithMany()
                        .HasForeignKey("Maluong")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__LUONGCHIT__MALUO__412EB0B6"),
                    j =>
                    {
                        j.HasKey("Maluong", "Mapc").HasName("PK__LUONGCHI__FFB9BB1CAC11FC93");
                        j.ToTable("LUONGCHITIET");
                        j.IndexerProperty<Guid>("Maluong").HasColumnName("MALUONG");
                        j.IndexerProperty<Guid>("Mapc").HasColumnName("MAPC");
                    });
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Manv).HasName("PK__NHANVIEN__603F511460319496");

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .HasColumnName("MANV");
            entity.Property(e => e.Chucvu).HasColumnName("CHUCVU");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(3)
                .HasColumnName("GIOITINH");
            entity.Property(e => e.Hoten)
                .HasMaxLength(50)
                .HasColumnName("HOTEN");
            entity.Property(e => e.Matkhau)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MATKHAU");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Taikhoan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAIKHOAN");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(20)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.ChucvuNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.Chucvu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NHANVIEN__CHUCVU__398D8EEE");
        });

        modelBuilder.Entity<Phucap>(entity =>
        {
            entity.HasKey(e => e.Mapc).HasName("PK__PHUCAP__603F61C35A284DE1");

            entity.ToTable("PHUCAP");

            entity.Property(e => e.Mapc)
                .ValueGeneratedNever()
                .HasColumnName("MAPC");
            entity.Property(e => e.Sotienphucap)
                .HasColumnType("money")
                .HasColumnName("SOTIENPHUCAP");
            entity.Property(e => e.Tenphucap)
                .HasMaxLength(255)
                .HasColumnName("TENPHUCAP");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Masp).HasName("PK__SANPHAM__60228A321B862654");

            entity.ToTable("SANPHAM");

            entity.Property(e => e.Masp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASP");
            entity.Property(e => e.Giaban)
                .HasColumnType("money")
                .HasColumnName("GIABAN");
            entity.Property(e => e.Hinhanh).HasColumnName("HINHANH");
            entity.Property(e => e.Maloaisp).HasColumnName("MALOAISP");
            entity.Property(e => e.Mota)
                .HasMaxLength(255)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tensp)
                .HasMaxLength(255)
                .HasColumnName("TENSP");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(20)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MaloaispNavigation).WithMany(p => p.Sanphams)
                .HasForeignKey(d => d.Maloaisp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAM__MALOAIS__49C3F6B7");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
