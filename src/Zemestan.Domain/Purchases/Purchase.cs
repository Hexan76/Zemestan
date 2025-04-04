namespace Zemestan.Purchases;
public class Purchase : FullAuditedAggregateRoot<Guid>
{
    public string Title { get; set; }
    public OrderTypes Type { get; set; }
    public OrderStatuses Status { get; set; }
    public string? Description { get; set; }

    public virtual ICollection<PurchaseDetails> Details { get; set; }

}