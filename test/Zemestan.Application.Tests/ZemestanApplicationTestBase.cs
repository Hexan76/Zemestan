using Volo.Abp.Modularity;

namespace Zemestan;

public abstract class ZemestanApplicationTestBase<TStartupModule> : ZemestanTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
