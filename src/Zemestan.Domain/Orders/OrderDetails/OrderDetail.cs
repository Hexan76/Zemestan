using Zemestan.Products;

namespace Zemestan.Orders;

public class OrderDetail : FullAuditedAggregateRoot<Guid>
{
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
    public decimal TotalPrice => Price * Quantity;
    public string Description { get; set; }

    public Guid ProductId { get; set; }
    public virtual Product Product { get; set; }
}