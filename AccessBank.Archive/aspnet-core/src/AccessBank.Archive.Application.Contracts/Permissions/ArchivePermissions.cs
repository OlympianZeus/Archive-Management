namespace AccessBank.Archive.Permissions;

public static class ArchivePermissions
{
    public const string GroupName = "Archive";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public static class Customers
    {
        public const string Default = GroupName + ".Customers";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
