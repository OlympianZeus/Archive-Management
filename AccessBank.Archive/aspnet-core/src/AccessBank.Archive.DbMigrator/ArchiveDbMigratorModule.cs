using AccessBank.Archive.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AccessBank.Archive.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ArchiveEntityFrameworkCoreModule),
    typeof(ArchiveApplicationContractsModule)
    )]
public class ArchiveDbMigratorModule : AbpModule
{
}
