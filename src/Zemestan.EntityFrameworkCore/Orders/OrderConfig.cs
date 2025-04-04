namespace Zemestan.Orders;
public class OrderConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable(nameof(Order), ZemestanConsts.DbSchema);
        builder.ConfigureByConvention();

        builder.HasMany(order => order.Orders)
        .WithOne(details => details.Order)
        .HasForeignKey(fk => fk.OrderId);
    }
}