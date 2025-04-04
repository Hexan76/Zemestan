
namespace Zemestan.Transactions;
public class TransactionRepository : EfCoreRepository<ZemestanDbContext, TransactionHeader, Guid>, ITransactionHeaderRepository
{
    public TransactionRepository(IDbContextProvider<ZemestanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}