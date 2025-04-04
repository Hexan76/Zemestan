namespace Zemestan.Purchases;
[Table(nameof(Purchase), Schema = ZemestanConsts.DbSchema)]
public class Purchase : FullAuditedAggregateRoot<Guid>
{
    public string Title { get; set; }
    public OrderTypes Type { get; set; }
    public OrderStatuses Status { get; set; }
    public string? Description { get; set; }

    public virtual ICollection<PurchaseDetail> Details { get; set; }

}