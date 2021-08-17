using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMWTestTask.Core.Domain;

namespace UMWTestTask.Persistence.EntityConfigurations
{
    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            #region properties
            builder
                .Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(256);
            #endregion

            #region navigation properties
            builder
                .HasOne(d => d.Flag)
                .WithOne(f => f.Discount)
                .HasForeignKey<Discount>(d => d.FlagId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
            #endregion
        }
    }
}
