using System.Threading.Tasks;

namespace TextTemplatingTest.Data
{
    public interface ITextTemplatingTestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
