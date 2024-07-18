using AccessBank.Archive.Samples;
using Xunit;

namespace AccessBank.Archive.EntityFrameworkCore.Domains;

[Collection(ArchiveTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ArchiveEntityFrameworkCoreTestModule>
{

}
