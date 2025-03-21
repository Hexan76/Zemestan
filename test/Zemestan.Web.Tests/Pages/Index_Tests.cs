using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Zemestan.Pages;

public class Index_Tests : ZemestanWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
