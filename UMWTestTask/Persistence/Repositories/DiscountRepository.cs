using UMWTestTask.Core.Domain;
using UMWTestTask.Core.Repositories;

namespace UMWTestTask.Persistence.Repositories
{
    public class DiscountRepository : Repository<Discount>, IDiscountRepository
    {
        public DiscountRepository(UmwDbContext context) : base(context)
        {
        }
    }
}
