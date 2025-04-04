
namespace Zemestan.Purchases;
public class PurchaseConfig : IEntityTypeConfiguration<Purchase>
{
    public void Configure(EntityTypeBuilder<Purchase> builder)
    {
        builder.ToTable(nameof(Purchase), ZemestanConsts.DbSchema);
        builder.ConfigureByConvention();

        builder.HasMany(c => c.Details)
        .WithOne(parent => parent.Purchase)
        .HasForeignKey(fk => fk.PurchaseId);

    }
}