namespace Zemestan.Domain.Books;
public class Book : Entity<Guid>
{
    public string Name { get; set; }
    public virtual ICollection<Category> Categories { get; set; }
    public virtual ICollection<BookCategory> BookCategories { get; set; }
}