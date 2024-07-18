using Volo.Abp.Modularity;

namespace AccessBank.Archive;

/* Inherit from this class for your domain layer tests. */
public abstract class ArchiveDomainTestBase<TStartupModule> : ArchiveTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
