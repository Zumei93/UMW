using System;
using System.Threading.Tasks;
using UMWTestTask.Core.Repositories;

namespace UMWTestTask.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBrandRepository Brands { get; }
        ICategoryRepository Categories { get; }
        IDiscountRepository Discounts { get; }
        IFlagRepository Flags { get; }
        IFolderRepository Folders { get; }
        IImageRepository Images { get; }
        IProductRepository Products { get; }

        Task<int> CompleteAsync();
    }
}
