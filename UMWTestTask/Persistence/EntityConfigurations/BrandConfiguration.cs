using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMWTestTask.Core.Domain;

namespace UMWTestTask.Persistence.EntityConfigurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");

            #region properties
            builder
                .Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(256);
            #endregion
        }
    }
}
