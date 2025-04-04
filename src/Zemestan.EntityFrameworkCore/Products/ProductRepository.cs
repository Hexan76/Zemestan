
namespace Zemestan.Products;
public class ProductRepository : EfCoreRepository<ZemestanDbContext, Product, Guid>, IProductRepository
{
    public ProductRepository(IDbContextProvider<ZemestanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}