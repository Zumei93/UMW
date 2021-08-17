using System;
using System.Collections.Generic;
using UMWTestTask.Core.Domain.Base;

namespace UMWTestTask.Core.Domain
{
    public class Product : BaseEntity
    {
        public string Description { get; set; }

        public int InStock { get; set; }

        public DateTime CreatedDate { get; set; }

        public int FolderId { get; set; }

        public Folder Folder { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public IList<ProductCategory> ProductCategories { get; set; }

#nullable enable
        public int? ImageId { get; set; }

        public virtual Image? Image { get; set; }

        public IList<Category>? Categories { get; set; }

        public int? DiscountId { get; set; }

        public Discount? Discount { get; set; }

        public int? FlagId { get; set; }

        public Flag? Flag { get; set; }
#nullable disable
    }
}
