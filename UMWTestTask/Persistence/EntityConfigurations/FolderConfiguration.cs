using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMWTestTask.Core.Domain;

namespace UMWTestTask.Persistence.EntityConfigurations
{
    public class FolderConfiguration : IEntityTypeConfiguration<Folder>
    {
        public void Configure(EntityTypeBuilder<Folder> builder)
        {
            #region properties
            builder
                .Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(256);
            #endregion

            #region navigation properties
            builder
                .HasOne(f => f.Discount)
                .WithMany(d => d.Folders)
                .HasForeignKey(f => f.DiscountId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasOne(f => f.Flag)
                .WithOne(fg => fg.Folder)
                .HasForeignKey<Folder>(f => f.FlagId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasOne(f => f.Parent)
                .WithMany(f => f.SubFolders)
                .HasForeignKey(f => f.ParentId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}
