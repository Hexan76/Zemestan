
namespace Zemestan.Transactions;
public class TransactionHeaderConfig : IEntityTypeConfiguration<TransactionHeader>
{
    public void Configure(EntityTypeBuilder<TransactionHeader> builder)
    {
        builder.ToTable(nameof(TransactionHeader), ZemestanConsts.DbSchema);
        builder.ConfigureByConvention();

        builder.HasMany(c => c.Transactions)
        .WithOne(parent => parent.Header)
        .HasForeignKey(fk => fk.HeaderId);

    }
}