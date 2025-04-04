namespace Zemestan.Orders;
public class OrderRepository : EfCoreRepository<ZemestanDbContext, Order, Guid>, IOrderRepository
{
    public OrderRepository(IDbContextProvider<ZemestanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}