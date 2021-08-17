using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMWTestTask.Core.Domain;

namespace UMWTestTask.Persistence.EntityConfigurations
{
    public class FlagConfiguration : IEntityTypeConfiguration<Flag>
    {
        public void Configure(EntityTypeBuilder<Flag> builder)
        {
            #region properties
            builder
                .Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(256);
            #endregion
        }
    }
}
