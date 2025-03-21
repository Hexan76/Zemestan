using Zemestan.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Zemestan.Permissions;

public class ZemestanPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ZemestanPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ZemestanPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ZemestanResource>(name);
    }
}
