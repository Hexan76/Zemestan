using System;
using System.Collections.Generic;
using System.Text;
using Zemestan.Localization;
using Volo.Abp.Application.Services;

namespace Zemestan;

/* Inherit your application services from this class.
 */
public abstract class ZemestanAppService : ApplicationService
{
    protected ZemestanAppService()
    {
        LocalizationResource = typeof(ZemestanResource);
    }
}
