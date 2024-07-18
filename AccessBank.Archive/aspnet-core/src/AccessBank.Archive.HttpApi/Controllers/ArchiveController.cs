using AccessBank.Archive.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AccessBank.Archive.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ArchiveController : AbpControllerBase
{
    protected ArchiveController()
    {
        LocalizationResource = typeof(ArchiveResource);
    }
}
