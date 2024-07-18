using Volo.Abp.Modularity;

namespace AccessBank.Archive;

[DependsOn(
    typeof(ArchiveDomainModule),
    typeof(ArchiveTestBaseModule)
)]
public class ArchiveDomainTestModule : AbpModule
{

}
