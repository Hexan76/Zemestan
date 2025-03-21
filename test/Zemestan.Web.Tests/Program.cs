using Microsoft.AspNetCore.Builder;
using Zemestan;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ZemestanWebTestModule>();

public partial class Program
{
}
