namespace Zemestan.Purchases;
public class PurchasesRepository : EfCoreRepository<ZemestanDbContext, Purchase, Guid>, IPurchaseRepository
{
    public PurchasesRepository(IDbContextProvider<ZemestanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}