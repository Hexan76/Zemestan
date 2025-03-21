using Volo.Abp.Domain.Entities;

public class EnumerationTranslate : Entity
{
    public string Name { get; set; }
    public string Language { get; set; }

    public Enumeration Enumeration { get; set; }
    public Guid EnumerationId { get; set; }

    public override object?[] GetKeys()
    {
        return [EnumerationId, Language];
    }
}