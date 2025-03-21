using Zemestan.Domain.Books;

namespace Zemestan.Domain.Authors;
public class Publisher : Entity<Guid>
{
    public string Title { get; set; }
    public ICollection<Book> Books { get; set; }
    
}