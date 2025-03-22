namespace Zemestan.Products;
public class Product : FullAuditedAggregateRoot<Guid>
{
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }

    public Guid? CategoryId { get; set; }
    public virtual Category? Category { get; set; }
    public virtual ICollection<ProductReview> Reviews { get; set; }
}