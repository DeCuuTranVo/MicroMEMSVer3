using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MicroMEMSVer3.Entities
{
    public partial class TBYTDbContext : DbContext
    {
        public TBYTDbContext()
        {
        }

        public TBYTDbContext(DbContextOptions<TBYTDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tbyt> Tbyts { get; set; } = null!;
        public virtual DbSet<TbytLk> TbytLks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=TBYTDb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbyt>(entity =>
            {
                entity.ToTable("TBYT");

                entity.Property(e => e.Dvt).HasMaxLength(50);

                entity.Property(e => e.HangSx)
                    .HasMaxLength(50)
                    .HasColumnName("HangSX");

                entity.Property(e => e.LoaiTb)
                    .HasMaxLength(50)
                    .HasColumnName("LoaiTB");

                entity.Property(e => e.MaTb)
                    .HasMaxLength(50)
                    .HasColumnName("MaTB");

                entity.Property(e => e.NamSx).HasColumnName("NamSX");

                entity.Property(e => e.NhomTb)
                    .HasMaxLength(50)
                    .HasColumnName("NhomTB");

                entity.Property(e => e.NuocSx)
                    .HasMaxLength(50)
                    .HasColumnName("NuocSX");

                entity.Property(e => e.TenTb)
                    .HasMaxLength(50)
                    .HasColumnName("TenTB");
            });

            modelBuilder.Entity<TbytLk>(entity =>
            {
                entity.ToTable("TBYT_LK");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MaLk)
                    .HasMaxLength(50)
                    .HasColumnName("MaLK")
                    .IsFixedLength();

                entity.Property(e => e.Tbytid).HasColumnName("TBYTId");

                entity.Property(e => e.TenLk)
                    .HasMaxLength(50)
                    .HasColumnName("TenLK")
                    .IsFixedLength();

                entity.HasOne(d => d.Tbyt)
                    .WithMany(p => p.TbytLks)
                    .HasForeignKey(d => d.Tbytid)
                    .HasConstraintName("FK_LKTBYT_Table_TBYT_Table");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
