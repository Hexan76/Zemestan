namespace Zemestan.Orders;
[Table(nameof(Order), Schema = ZemestanConsts.DbSchema)]
public class Order : FullAuditedAggregateRoot<Guid>
{
    public string Title { get; set; }
    public OrderTypes Type { get; set; }
    public OrderStatuses Status { get; set; }
    public string? Description { get; set; }

    public virtual ICollection<OrderDetail> Orders { get; set; }
}