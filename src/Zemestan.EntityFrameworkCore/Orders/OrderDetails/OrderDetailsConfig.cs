
namespace Zemestan.Orders;
public class OrderDetailsConfig : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.ToTable(nameof(OrderDetail), ZemestanConsts.DbSchema);
        builder.ConfigureByConvention();

    }
}