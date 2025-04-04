
namespace Zemestan.Purchases;
public class PurchaseDeatilsConfig : IEntityTypeConfiguration<PurchaseDeatilsConfig>
{
    public void Configure(EntityTypeBuilder<PurchaseDeatilsConfig> builder)
    {
        builder.ToTable(nameof(PurchaseDetail), ZemestanConsts.DbSchema);
        builder.ConfigureByConvention();

    }
}