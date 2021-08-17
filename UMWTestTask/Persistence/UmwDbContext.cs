using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using UMWTestTask.Core.Domain;
using UMWTestTask.Persistence.EntityConfigurations;

namespace UMWTestTask.Persistence
{
    public class UmwDbContext : DbContext
    {
        public UmwDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Folder> Folders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Flag> Flags { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlagConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new DiscountConfiguration());
            modelBuilder.ApplyConfiguration(new FolderConfiguration());
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
