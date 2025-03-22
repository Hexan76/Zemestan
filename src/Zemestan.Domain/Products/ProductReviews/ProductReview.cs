using Volo.Abp.Identity;

namespace Zemestan.Products;
public class ProductReview : FullAuditedAggregateRoot<Guid>
{
    public int Rating { get; set; }
    public string? Comment { get; set; }
    public Guid UserId { get; set; }
    public virtual IdentityUser User { get; set; }
    public Guid ProductId { get; set; }
    public virtual Product Product { get; set; }
}