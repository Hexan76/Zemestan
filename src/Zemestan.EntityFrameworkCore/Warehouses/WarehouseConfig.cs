
namespace Zemestan.Warehouses;
public class WarehouseConfig : IEntityTypeConfiguration<Warehouse>
{
    public void Configure(EntityTypeBuilder<Warehouse> builder)
    {
        builder.ToTable(nameof(Warehouse), ZemestanConsts.DbSchema);
        builder.ConfigureByConvention();

    }
}