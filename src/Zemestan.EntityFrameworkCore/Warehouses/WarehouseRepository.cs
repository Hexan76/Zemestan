namespace Zemestan.Warehouses;
public class WarehouseRepository : EfCoreRepository<ZemestanDbContext, Warehouse, Guid>, IWarehouseRepository
{
    public WarehouseRepository(IDbContextProvider<ZemestanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}