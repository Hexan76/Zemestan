using System.Diagnostics;
using System.Linq;
using System.Reflection;
using AutoMapper.Internal;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace Zemestan.EntityFrameworkCore;

public static class ZemestanEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();


    public static void ConfigureZemestanEf(this ModelBuilder builder, Assembly assembly)
    {
        var configurationTypes = assembly.GetTypes()
                    .Where(t => t.GetInterfaces()
                        .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))
                        && t.IsClass && !t.IsAbstract);
        foreach (dynamic item in configurationTypes)
        {
            _ = builder.ApplyConfiguration(item);
        }
    }
    public static void Configure()
    {
        ZemestanGlobalFeatureConfigurator.Configure();
        ZemestanModuleExtensionConfigurator.Configure();

        OneTimeRunner.Run(() =>
        {
            /* You can configure extra properties for the
             * entities defined in the modules used by your application.
             *
             * This class can be used to map these extra properties to table fields in the database.
             *
             * USE THIS CLASS ONLY TO CONFIGURE EF CORE RELATED MAPPING.
             * USE ZemestanModuleExtensionConfigurator CLASS (in the Domain.Shared project)
             * FOR A HIGH LEVEL API TO DEFINE EXTRA PROPERTIES TO ENTITIES OF THE USED MODULES
             *
             * Example: Map a property to a table field:

                 ObjectExtensionManager.Instance
                     .MapEfCoreProperty<IdentityUser, string>(
                         "MyProperty",
                         (entityBuilder, propertyBuilder) =>
                         {
                             propertyBuilder.HasMaxLength(128);
                         }
                     );

             * See the documentation for more:
             * https://docs.abp.io/en/abp/latest/Customizing-Application-Modules-Extending-Entities
             */
        });
    }
}
