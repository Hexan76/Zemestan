using Zemestan.Samples;
using Xunit;

namespace Zemestan.EntityFrameworkCore.Applications;

[Collection(ZemestanTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ZemestanEntityFrameworkCoreTestModule>
{

}
