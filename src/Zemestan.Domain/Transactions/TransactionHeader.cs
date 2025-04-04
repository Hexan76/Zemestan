using Zemestan.Orders;
using Zemestan.Purchases;

namespace Zemestan.Transactions;
public class TransactionHeader : FullAuditedAggregateRoot<Guid>
{
    public TransactionTypes Type { get; set; }
    public virtual ICollection<Transaction> Transactions { get; set; }

    public Guid? OrderId { get; set; }
    public Order? Order { get; set; }
    public Guid? PurchaseId { get; set; }
    public Purchase? Purchase { get; set; }
}