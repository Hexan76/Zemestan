using Xunit;

namespace Zemestan.EntityFrameworkCore;

[CollectionDefinition(ZemestanTestConsts.CollectionDefinitionName)]
public class ZemestanEntityFrameworkCoreCollection : ICollectionFixture<ZemestanEntityFrameworkCoreFixture>
{

}
