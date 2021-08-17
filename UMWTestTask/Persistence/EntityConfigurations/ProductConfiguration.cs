using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using UMWTestTask.Core.Domain;

namespace UMWTestTask.Persistence.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            #region properties
            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(256);
            #endregion

            #region navigation properties
            builder
                .HasOne(p => p.Discount)
                .WithMany(d => d.Products)
                .HasForeignKey(p => p.DiscountId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasOne(p => p.Flag)
                .WithOne(f => f.Product)
                .HasForeignKey<Product>(p => p.FlagId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasOne(p => p.Folder)
                .WithMany(f => f.Products)
                .HasForeignKey(p => p.FolderId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(p => p.Image)
                .WithOne(i => i.Product)
                .HasForeignKey<Product>(p => p.ImageId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasMany(p => p.Categories)
                .WithMany(c => c.Products)
                .UsingEntity<ProductCategory>(
                    j => j
                        .HasOne(pc => pc.Category)
                        .WithMany(c => c.ProductCategories)
                        .HasForeignKey(pc => pc.CategoryId),
                    j => j
                        .HasOne(pc => pc.Product)
                        .WithMany(p => p.ProductCategories)
                        .HasForeignKey(pc => pc.ProductId),
                    j =>
                    {
                        j.ToTable("ProductCategories");
                        j.HasKey(t => new { t.CategoryId, t.ProductId });
                    });
            #endregion
        }
    }
}
