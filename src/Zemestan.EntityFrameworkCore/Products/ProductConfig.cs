
namespace Zemestan.Products;
public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable(nameof(Product), ZemestanConsts.DbSchema);
        builder.ConfigureByConvention();

        builder.HasMany(p => p.Reviews)
        .WithOne(reviewer => reviewer.Product)
        .HasForeignKey(fk => fk.ProductId);

        builder.HasOne(p => p.Category)
        .WithMany().HasForeignKey(fk => fk.CategoryId);

    }
}