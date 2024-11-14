using Microsoft.EntityFrameworkCore;

namespace asdasda.Models
{
    public class PhucDbContext : DbContext
    {
        public PhucDbContext(DbContextOptions<PhucDbContext> options) : base(options)
        {
        }

        public DbSet<SinhVien> sinhViens { get; set; }
        public DbSet<KhoaHoc> khoaHoc { get; set; }
        public DbSet<KHCT> KHCTs { get; set; }

    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVien>().HasKey(x => x.id);
            modelBuilder.Entity<KhoaHoc>().HasKey(x => x.MaPB);
            modelBuilder.Entity<KHCT>().HasKey(x => x.id);

            modelBuilder.Entity<KHCT>()
                .HasOne(x => x.SinhVien)
                .WithMany(x => x.KHCTs)
                .HasForeignKey(x => x.SinhVienID);

            modelBuilder.Entity<KHCT>()
                .HasOne(x => x.KhoaHoc)
                .WithMany(x => x.KHCTs)
                .HasForeignKey(x => x.KhoaHocID);
        }
    }
}
