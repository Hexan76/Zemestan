using Zemestan.Domain.Categories;
using Zemestan.EntityFrameworkCore;

public class CategoryRepository : EfCoreRepository<ZemestanDbContext, Category, Guid>
{
    public CategoryRepository(IDbContextProvider<ZemestanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}