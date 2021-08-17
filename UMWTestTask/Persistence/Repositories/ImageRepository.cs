using UMWTestTask.Core.Domain;
using UMWTestTask.Core.Repositories;

namespace UMWTestTask.Persistence.Repositories
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        public ImageRepository(UmwDbContext context) : base(context)
        {
        }
    }
}
