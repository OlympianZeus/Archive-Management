using System;
using System.Collections.Generic;
using System.Text;
using AccessBank.Archive.Localization;
using Volo.Abp.Application.Services;

namespace AccessBank.Archive;

/* Inherit your application services from this class.
 */
public abstract class ArchiveAppService : ApplicationService
{
    protected ArchiveAppService()
    {
        LocalizationResource = typeof(ArchiveResource);
    }
}
