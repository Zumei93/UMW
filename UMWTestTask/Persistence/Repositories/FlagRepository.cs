using UMWTestTask.Core.Domain;
using UMWTestTask.Core.Repositories;

namespace UMWTestTask.Persistence.Repositories
{
    public class FlagRepository : Repository<Flag>, IFlagRepository
    {
        public FlagRepository(UmwDbContext context) : base(context)
        {
        }
    }
}
