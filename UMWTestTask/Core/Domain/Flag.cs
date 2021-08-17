using UMWTestTask.Core.Domain.Base;

namespace UMWTestTask.Core.Domain
{
    public class Flag : BaseEntity
    {
        public byte Priority { get; set; }

#nullable enable
        public Folder? Folder { get; set; }

        public Discount? Discount { get; set; }

        public Category? Category { get; set; }

        public Product? Product { get; set; }
#nullable disable
    }
}
