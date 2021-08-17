using UMWTestTask.Core.Domain;
using UMWTestTask.Core.Repositories;

namespace UMWTestTask.Persistence.Repositories
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(UmwDbContext context) : base(context)
        {
        }
    }
}
