using System.Collections.Generic;
using UMWTestTask.Core.Domain.Base;

namespace UMWTestTask.Core.Domain
{
    public class Discount : BaseEntity
    {
        public float DiscountedPrice { get; set; }

#nullable enable
        public int? FlagId { get; set; }

        public Flag? Flag { get; set; }

        public IList<Product>? Products { get; set; }

        public IList<Folder>? Folders { get; set; }
#nullable disable
    }
}
