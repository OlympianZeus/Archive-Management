using Volo.Abp.Modularity;

namespace AccessBank.Archive;

[DependsOn(
    typeof(ArchiveApplicationModule),
    typeof(ArchiveDomainTestModule)
)]
public class ArchiveApplicationTestModule : AbpModule
{

}
