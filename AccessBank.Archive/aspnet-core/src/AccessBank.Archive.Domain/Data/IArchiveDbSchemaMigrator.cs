using System.Threading.Tasks;

namespace AccessBank.Archive.Data;

public interface IArchiveDbSchemaMigrator
{
    Task MigrateAsync();
}
