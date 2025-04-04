using Zemestan.Categories;

public class CategoryRepository : EfCoreRepository<ZemestanDbContext, Category, Guid>, ICategoryRepository
{
    public CategoryRepository(IDbContextProvider<ZemestanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}