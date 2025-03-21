using Zemestan.Domain.Authors;
using Zemestan.EntityFrameworkCore;

public class PublisherRepository : EfCoreRepository<ZemestanDbContext, Publisher, Guid>
{
    public PublisherRepository(IDbContextProvider<ZemestanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}