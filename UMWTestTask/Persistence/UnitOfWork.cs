using System.Threading.Tasks;
using UMWTestTask.Core;
using UMWTestTask.Core.Repositories;
using UMWTestTask.Persistence.Repositories;

namespace UMWTestTask.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UmwDbContext _context;

        public UnitOfWork(UmwDbContext context)
        {
            this._context = context;
            this.Brands = new BrandRepository(context);
            this.Categories = new CategoryRepository(context);
            this.Discounts = new DiscountRepository(context);
            this.Flags = new FlagRepository(context);
            this.Folders = new FolderRepository(context);
            this.Images = new ImageRepository(context);
            this.Products = new ProductRepository(context);
        }

        #region properties
        public IBrandRepository Brands { get; private set; }
        public ICategoryRepository Categories { get; private set; }
        public IDiscountRepository Discounts { get; private set; }
        public IFlagRepository Flags { get; private set; }
        public IFolderRepository Folders { get; private set; }
        public IImageRepository Images { get; private set; }
        public IProductRepository Products { get; private set; }
        #endregion

        public Task<int> CompleteAsync()
        {
            return this._context.SaveChangesAsync();
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
