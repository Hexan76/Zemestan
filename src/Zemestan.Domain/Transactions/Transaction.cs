namespace Zemestan.Transactions;
[Table(nameof(Transaction), Schema = ZemestanConsts.DbSchema)]
public class Transaction : FullAuditedAggregateRoot<Guid>
{
    public decimal Quantity { get; set; }
    public string Description { get; set; }
    
    public virtual Guid HeaderId { get; set; }
    public virtual TransactionHeader Header { get; set; }
}