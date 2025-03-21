using Zemestan.Domain.Books;

namespace Zemestan.Domain.Categories;
public class Category : Entity<Guid>
{
    public string Title { get; set; }
    public virtual ICollection<Book> Books { get; set; }
    public virtual ICollection<BookCategory> BookCategories { get; set; }

}