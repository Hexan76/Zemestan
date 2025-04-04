
namespace Zemestan.Products;
public class ProductReviewConfig : IEntityTypeConfiguration<ProductReview>
{
    public void Configure(EntityTypeBuilder<ProductReview> builder)
    {
        builder.ToTable(nameof(ProductReview), ZemestanConsts.DbSchema);
        builder.ConfigureByConvention();
    }
}