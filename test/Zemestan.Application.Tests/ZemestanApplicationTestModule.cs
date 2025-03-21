using Volo.Abp.Modularity;

namespace Zemestan;

[DependsOn(
    typeof(ZemestanApplicationModule),
    typeof(ZemestanDomainTestModule)
)]
public class ZemestanApplicationTestModule : AbpModule
{

}
