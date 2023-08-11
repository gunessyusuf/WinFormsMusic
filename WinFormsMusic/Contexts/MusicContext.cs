using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WinFormsMusic.Entities;

namespace WinFormsMusic.Contexts;

public partial class MusicContext : DbContext
{
    public MusicContext()
    {
    }

    public MusicContext(DbContextOptions<MusicContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sarki> Sarki { get; set; }

    public virtual DbSet<SarkiTur> SarkiTur { get; set; }

    public virtual DbSet<Sarkici> Sarkici { get; set; }

    public virtual DbSet<Tur> Tur { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Music;trusted_connection=true;trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sarki>(entity =>
        {
            entity.Property(e => e.Adi)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Sarkici).WithMany(p => p.Sarki)
                .HasForeignKey(d => d.SarkiciId)
                .HasConstraintName("FK_Sarki_Sarkici");
        });

        modelBuilder.Entity<SarkiTur>(entity =>
        {
            entity.HasKey(e => new { e.SarkiId, e.TurId });

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Sarki).WithMany(p => p.SarkiTur)
                .HasForeignKey(d => d.SarkiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SarkiTur_Sarki");

            entity.HasOne(d => d.Tur).WithMany(p => p.SarkiTur)
                .HasForeignKey(d => d.TurId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SarkiTur_Tur");
        });

        modelBuilder.Entity<Sarkici>(entity =>
        {
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tur>(entity =>
        {
            entity.Property(e => e.Adi)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
