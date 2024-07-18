using Xunit;

namespace AccessBank.Archive.EntityFrameworkCore;

[CollectionDefinition(ArchiveTestConsts.CollectionDefinitionName)]
public class ArchiveEntityFrameworkCoreCollection : ICollectionFixture<ArchiveEntityFrameworkCoreFixture>
{

}
