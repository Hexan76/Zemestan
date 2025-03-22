namespace Zemestan.Categories;
public class Category : Entity<Guid>
{
    public string Title { get; set; }
    public string Descrption { get; set; }

    public Guid CategoryId { get; set; }
    public virtual Category Parent { get; set; }
    public virtual ICollection<Category> Children { get; set; }
}