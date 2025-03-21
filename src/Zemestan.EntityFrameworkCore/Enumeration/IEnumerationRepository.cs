using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories;
using Zemestan.EntityFrameworkCore;


public class EnumerationRepository : EfCoreRepository<ZemestanDbContext, Enumeration, Guid>, IEnumerationRepository
{
    public EnumerationRepository(IDbContextProvider<ZemestanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Enumeration>> GetQueryableAsync()
    {
        return (await base.GetQueryableAsync()).Include(c=>c.Translations);
    }
}
public interface IEnumerationRepository : IRepository<Enumeration, Guid>
{
    
}