using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

public class Enumeration : Entity<Guid>
{
    public string Name { get; set; }
    public string ClusterName { get; set; }

    public ICollection<EnumerationTranslate> Translations { get; set; }
    
}