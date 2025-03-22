using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Zemestan.Books;
public class BookConfig : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable(nameof(Book), ZemestanConsts.DbSchema);
        builder.ConfigureByConvention();
    }
}