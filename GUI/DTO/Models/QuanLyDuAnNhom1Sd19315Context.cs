using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DTO.Models;

public partial class QuanLyDuAnNhom1Sd19315Context : DbContext
{
    public QuanLyDuAnNhom1Sd19315Context()
    {
    }

    public QuanLyDuAnNhom1Sd19315Context(DbContextOptions<QuanLyDuAnNhom1Sd19315Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }

    public virtual DbSet<DocGium> DocGia { get; set; }

    public virtual DbSet<NhaXuatBan> NhaXuatBans { get; set; }

    public virtual DbSet<PhieuMuon> PhieuMuons { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<TacGium> TacGia { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<TheLoai> TheLoais { get; set; }

    public virtual DbSet<VaiTro> VaiTros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-PQPRDCV\\SQLEXPRESS;Database=QuanLyDuAn_Nhom1_SD19315;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietPhieuMuon>(entity =>
        {
            entity.HasKey(e => e.MaChiTiet).HasName("PK__ChiTietP__CDF0A114B83D88C8");

            entity.ToTable("ChiTietPhieuMuon");

            entity.Property(e => e.MaChiTiet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.MaPhieuMuon)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaSach)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MaPhieuMuonNavigation).WithMany(p => p.ChiTietPhieuMuons)
                .HasForeignKey(d => d.MaPhieuMuon)
                .HasConstraintName("FK__ChiTietPh__MaPhi__4CA06362");

            entity.HasOne(d => d.MaSachNavigation).WithMany(p => p.ChiTietPhieuMuons)
                .HasForeignKey(d => d.MaSach)
                .HasConstraintName("FK__ChiTietPh__MaSac__4D94879B");
        });

        modelBuilder.Entity<DocGium>(entity =>
        {
            entity.HasKey(e => e.MaDocGia).HasName("PK__DocGia__F165F945C201B340");

            entity.Property(e => e.MaDocGia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenDocGia).HasMaxLength(50);
        });

        modelBuilder.Entity<NhaXuatBan>(entity =>
        {
            entity.HasKey(e => e.MaNhaXuatBan).HasName("PK__NhaXuatB__1AED0BFAED581F9E");

            entity.ToTable("NhaXuatBan");

            entity.Property(e => e.MaNhaXuatBan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenNhaXuatBan).HasMaxLength(50);
        });

        modelBuilder.Entity<PhieuMuon>(entity =>
        {
            entity.HasKey(e => e.MaPhieuMuon).HasName("PK__PhieuMuo__C4C822220FCEBC42");

            entity.ToTable("PhieuMuon");

            entity.Property(e => e.MaPhieuMuon)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaDocGia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaTaiKhoan)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MaDocGiaNavigation).WithMany(p => p.PhieuMuons)
                .HasForeignKey(d => d.MaDocGia)
                .HasConstraintName("FK__PhieuMuon__MaDoc__440B1D61");

            entity.HasOne(d => d.MaTaiKhoanNavigation).WithMany(p => p.PhieuMuons)
                .HasForeignKey(d => d.MaTaiKhoan)
                .HasConstraintName("FK__PhieuMuon__MaTai__44FF419A");
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__Sach__B235742DA0199EE4");

            entity.ToTable("Sach");

            entity.Property(e => e.MaSach)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaNhaXuatBan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaTacGia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaTheLoai)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MoTa).HasMaxLength(50);
            entity.Property(e => e.TenSach).HasMaxLength(50);
            entity.Property(e => e.TrangThaiSach).HasMaxLength(50);
            entity.Property(e => e.ViTri).HasMaxLength(50);

            entity.HasOne(d => d.MaNhaXuatBanNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.MaNhaXuatBan)
                .HasConstraintName("FK__Sach__MaNhaXuatB__49C3F6B7");

            entity.HasOne(d => d.MaTacGiaNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.MaTacGia)
                .HasConstraintName("FK__Sach__MaTacGia__48CFD27E");

            entity.HasOne(d => d.MaTheLoaiNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.MaTheLoai)
                .HasConstraintName("FK__Sach__MaTheLoai__47DBAE45");
        });

        modelBuilder.Entity<TacGium>(entity =>
        {
            entity.HasKey(e => e.MaTacGia).HasName("PK__TacGia__F24E6756B5056233");

            entity.Property(e => e.MaTacGia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GioiTinh).HasMaxLength(50);
            entity.Property(e => e.QuocGia).HasMaxLength(50);
            entity.Property(e => e.TenTacGia).HasMaxLength(50);
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaTaiKhoan).HasName("PK__TaiKhoan__AD7C65293F19F2D5");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.MaTaiKhoan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.MaVaiTro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            entity.Property(e => e.SoCccd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SoCCCD");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaiKhoan1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TaiKhoan");

            entity.HasOne(d => d.MaVaiTroNavigation).WithMany(p => p.TaiKhoans)
                .HasForeignKey(d => d.MaVaiTro)
                .HasConstraintName("FK__TaiKhoan__MaVaiT__412EB0B6");
        });

        modelBuilder.Entity<TheLoai>(entity =>
        {
            entity.HasKey(e => e.MaTheLoai).HasName("PK__TheLoai__D73FF34A117E46D1");

            entity.ToTable("TheLoai");

            entity.Property(e => e.MaTheLoai)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenTheLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<VaiTro>(entity =>
        {
            entity.HasKey(e => e.MaVaiTro).HasName("PK__VaiTro__C24C41CF07122B19");

            entity.ToTable("VaiTro");

            entity.Property(e => e.MaVaiTro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vaitro1)
                .HasMaxLength(50)
                .HasColumnName("Vaitro");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
