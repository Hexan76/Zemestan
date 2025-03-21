using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Zemestan.Data;

/* This is used if database provider does't define
 * IZemestanDbSchemaMigrator implementation.
 */
public class NullZemestanDbSchemaMigrator : IZemestanDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
