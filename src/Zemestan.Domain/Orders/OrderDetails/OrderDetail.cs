using Zemestan.Products;

namespace Zemestan.Orders;
[Table(nameof(OrderDetail), Schema = ZemestanConsts.DbSchema)]
public class OrderDetail : Entity<Guid>
{
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
    public decimal TotalPrice => Price * Quantity;
    public string Description { get; set; }

    public Guid OrderId { get; set; }
    public virtual Order Order { get; set; }
    public Guid ProductId { get; set; }
    public virtual Product Product { get; set; }
}