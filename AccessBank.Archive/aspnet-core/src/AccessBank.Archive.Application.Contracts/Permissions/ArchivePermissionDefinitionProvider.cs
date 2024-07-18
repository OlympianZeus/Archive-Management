using AccessBank.Archive.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AccessBank.Archive.Permissions;

public class ArchivePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ArchivePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ArchivePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ArchiveResource>(name);
    }
}
