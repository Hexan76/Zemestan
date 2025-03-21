using Zemestan.Samples;
using Xunit;

namespace Zemestan.EntityFrameworkCore.Domains;

[Collection(ZemestanTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ZemestanEntityFrameworkCoreTestModule>
{

}
