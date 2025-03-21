using Zemestan.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Zemestan.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ZemestanEntityFrameworkCoreModule),
    typeof(ZemestanApplicationContractsModule)
    )]
public class ZemestanDbMigratorModule : AbpModule
{
}
