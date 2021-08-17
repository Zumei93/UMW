using UMWTestTask.Core.Domain;
using UMWTestTask.Core.Repositories;

namespace UMWTestTask.Persistence.Repositories
{
    public class FolderRepository : Repository<Folder>, IFolderRepository
    {
        public FolderRepository(UmwDbContext context) : base(context)
        {
        }
    }
}
