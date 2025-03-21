using Zemestan.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Zemestan.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ZemestanController : AbpControllerBase
{
    protected ZemestanController()
    {
        LocalizationResource = typeof(ZemestanResource);
    }
}
