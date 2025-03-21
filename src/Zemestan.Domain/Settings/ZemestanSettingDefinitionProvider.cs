using Volo.Abp.Settings;

namespace Zemestan.Settings;

public class ZemestanSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ZemestanSettings.MySetting1));
    }
}
