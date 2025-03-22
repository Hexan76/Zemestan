namespace Zemestan.Warehouses;
public class Warehouse : FullAuditedAggregateRoot<Guid>
{
    public string Title { get; set; }
    public int Code { get; set; }
    public string Description { get; set; }
}