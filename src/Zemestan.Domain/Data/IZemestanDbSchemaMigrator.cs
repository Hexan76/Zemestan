using System.Threading.Tasks;

namespace Zemestan.Data;

public interface IZemestanDbSchemaMigrator
{
    Task MigrateAsync();
}
