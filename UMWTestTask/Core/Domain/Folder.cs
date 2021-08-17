using System.Collections.Generic;
using UMWTestTask.Core.Domain.Base;

namespace UMWTestTask.Core.Domain
{
    public class Folder : BaseEntity
    {
#nullable enable
        public int? ParentId { get; set; }

        public Folder? Parent { get; set; }

        public IList<Folder>? SubFolders { get; set; }

        public IList<Product>? Products { get; set; }

        public int? DiscountId { get; set; }

        public Discount? Discount { get; set; }

        public int? FlagId { get; set; }

        public Flag? Flag { get; set; }
#nullable disable
    }
}
