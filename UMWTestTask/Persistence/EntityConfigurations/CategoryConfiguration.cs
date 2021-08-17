using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMWTestTask.Core.Domain;

namespace UMWTestTask.Persistence.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            #region properties
            builder
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(256);
            #endregion

            #region navigation properties
            builder
                .HasOne(c => c.Flag)
                .WithOne(f => f.Category)
                .HasForeignKey<Category>(c => c.FlagId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
            #endregion
        }
    }
}
