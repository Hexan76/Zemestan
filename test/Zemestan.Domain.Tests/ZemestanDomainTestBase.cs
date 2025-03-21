using Volo.Abp.Modularity;

namespace Zemestan;

/* Inherit from this class for your domain layer tests. */
public abstract class ZemestanDomainTestBase<TStartupModule> : ZemestanTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
