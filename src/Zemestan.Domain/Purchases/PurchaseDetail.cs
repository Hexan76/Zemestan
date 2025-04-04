using Zemestan.Products;

namespace Zemestan.Purchases;
[Table(nameof(PurchaseDetail), Schema = ZemestanConsts.DbSchema)]
public class PurchaseDetail : Entity<Guid>
{
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
    public decimal TotalPrice => Price * Quantity;
    public string Description { get; set; }

    public Guid ProductId { get; set; }
    public virtual Product Product { get; set; }
    public virtual Guid PurchaseId { get; set; }
    public virtual Purchase Purchase { get; set; }


}