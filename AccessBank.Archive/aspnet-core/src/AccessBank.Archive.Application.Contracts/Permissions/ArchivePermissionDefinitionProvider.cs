using AccessBank.Archive.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AccessBank.Archive.Permissions;

public class ArchivePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //var myGroup = context.AddGroup(ArchivePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ArchivePermissions.MyPermission1, L("Permission:MyPermission1"));
        var ArchiveGroup = context.AddGroup(ArchivePermissions.GroupName, L("Permission:Archive"));

        var customersPermission = ArchiveGroup.AddPermission(ArchivePermissions.Customers.Default, L("Permission:Customers"));
        customersPermission.AddChild(ArchivePermissions.Customers.Create, L("Permission:Customers.Create"));
        customersPermission.AddChild(ArchivePermissions.Customers.Edit, L("Permission:Customers.Edit"));
        customersPermission.AddChild(ArchivePermissions.Customers.Delete, L("Permission:Customers.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ArchiveResource>(name);
    }
}
