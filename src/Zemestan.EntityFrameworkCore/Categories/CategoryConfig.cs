
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Zemestan.Categories;
public class CategoryConfig : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable(nameof(Category), ZemestanConsts.DbSchema);
        builder.ConfigureByConvention();

        builder.HasMany(c => c.Children)
        .WithOne(parent => parent.Parent)
        .HasForeignKey(fk => fk.CategoryId);
    }
}