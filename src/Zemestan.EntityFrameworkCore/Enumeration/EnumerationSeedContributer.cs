using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using Volo.Abp.AutoMapper;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Uow;
public class EnumerationSeedContributer(IEnumerationRepository repository) : IDataSeedContributor, ITransientDependency
{

    private ICollection<Enumeration> EnumList { get; set; } = new List<Enumeration>()
    {
        new Enumeration
        {
            Name = "Home",
            ClusterName = "PhoneType",
            Translations = new List<EnumerationTranslate>
            {
                new EnumerationTranslate
                {
                    Language = "fa",
                    Name = "خانه"
                },
                // new EnumerationTranslate
                // {
                //     Language = "en",
                //     Name = "Home"
                // },
            }
        },

    };
    public async Task SeedAsync(DataSeedContext context)
    {
        var existing = (await repository.GetQueryableAsync()).ToList();

        var mapper = CreataMapper();

        mapper.Map(EnumList, existing);
        await repository.UpdateManyAsync(existing);
    }

    static IMapper CreataMapper()
    {
        var config = new MapperConfiguration(c =>
        {
            c.AddCollectionMappers();
            c.CreateMap<Enumeration, Enumeration>()
            .Ignore(c=>c.Id)
            .EqualityComparison((src, dst) => src.Name == dst.Name && src.ClusterName == dst.ClusterName)
            ;
        c.CreateMap<EnumerationTranslate, EnumerationTranslate>()
        .Ignore(c => c.Enumeration)
        .Ignore(c => c.EnumerationId)
        ;
    });
        return config.CreateMapper();
    }
}