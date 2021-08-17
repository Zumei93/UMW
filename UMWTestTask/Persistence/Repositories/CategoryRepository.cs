using UMWTestTask.Core.Domain;
using UMWTestTask.Core.Repositories;

namespace UMWTestTask.Persistence.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(UmwDbContext context) : base(context)
        {
        }
    }
}
