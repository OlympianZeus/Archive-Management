using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AccessBank.Archive;

[Dependency(ReplaceServices = true)]
public class ArchiveBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Archive";
}
