using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Zemestan.Data;
using Volo.Abp.DependencyInjection;

namespace Zemestan.EntityFrameworkCore;

public class EntityFrameworkCoreZemestanDbSchemaMigrator
    : IZemestanDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreZemestanDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ZemestanDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ZemestanDbContext>()
            .Database
            .MigrateAsync();
    }
}
