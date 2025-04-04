
namespace Zemestan.Transactions;
public class TransactionConfig : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable(nameof(Transaction), ZemestanConsts.DbSchema);
        builder.ConfigureByConvention();
    }
}