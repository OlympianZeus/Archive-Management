using AccessBank.Archive.Samples;
using Xunit;

namespace AccessBank.Archive.EntityFrameworkCore.Applications;

[Collection(ArchiveTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ArchiveEntityFrameworkCoreTestModule>
{

}
