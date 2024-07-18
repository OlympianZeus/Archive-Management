using Volo.Abp.Modularity;

namespace AccessBank.Archive;

public abstract class ArchiveApplicationTestBase<TStartupModule> : ArchiveTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
