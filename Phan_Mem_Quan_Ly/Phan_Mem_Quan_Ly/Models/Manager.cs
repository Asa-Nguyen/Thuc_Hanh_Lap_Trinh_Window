using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Phan_Mem_Quan_Ly.Models
{
    public partial class Manager : DbContext
    {
        public Manager()
            : base("name=Manager")
        {
        }

        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<ChiTiet> ChiTiets { get; set; }
        public virtual DbSet<Danh_Muc> Danh_Mucs { get; set; }
        public virtual DbSet<Hoa_Don> Hoa_Dons { get; set; }
        public virtual DbSet<Mon> Mons { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .HasMany(e => e.Hoa_Don)
                .WithRequired(e => e.Ban)
                .HasForeignKey(e => e.MaBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Danh_Muc>()
                .HasMany(e => e.Mons)
                .WithRequired(e => e.Danh_Muc)
                .HasForeignKey(e => e.Ma_Danh_Muc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hoa_Don>()
                .HasMany(e => e.ChiTiets)
                .WithOptional(e => e.Hoa_Don)
                .HasForeignKey(e => e.MaHoaDon);

            modelBuilder.Entity<Mon>()
                .HasMany(e => e.ChiTiets)
                .WithOptional(e => e.Mon)
                .HasForeignKey(e => e.MaMon);
        }
    }
}
