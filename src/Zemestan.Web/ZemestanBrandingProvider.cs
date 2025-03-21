using Microsoft.Extensions.Localization;
using Zemestan.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Zemestan.Web;

[Dependency(ReplaceServices = true)]
public class ZemestanBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ZemestanResource> _localizer;

    public ZemestanBrandingProvider(IStringLocalizer<ZemestanResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
