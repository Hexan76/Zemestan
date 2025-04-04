namespace Zemestan.Transactions;
public class Transaction : FullAuditedAggregateRoot<Guid>
{
    public decimal Quantity { get; set; }
    public string Description { get; set; }
    
    public virtual Guid TransactionId { get; set; }
    public virtual TransactionHeader Header { get; set; }
}