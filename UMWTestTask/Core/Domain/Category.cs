using System.Collections.Generic;
using UMWTestTask.Core.Domain.Base;

namespace UMWTestTask.Core.Domain
{
    public class Category : BaseEntity
    {
        public IList<ProductCategory> ProductCategories { get; set; }

#nullable enable
        public IList<Product>? Products { get; set; }

        public int? FlagId { get; set; }

        public Flag? Flag { get; set; }
#nullable disable
    }
}
