using System.Collections.Generic;
using UMWTestTask.Core.Domain.Base;

namespace UMWTestTask.Core.Domain
{
    public class Brand : BaseEntity
    {
        public IList<Product> Products { get; set; }
    }
}
