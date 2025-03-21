using Volo.Abp.Modularity;

namespace Zemestan;

[DependsOn(
    typeof(ZemestanDomainModule),
    typeof(ZemestanTestBaseModule)
)]
public class ZemestanDomainTestModule : AbpModule
{

}
