using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TextTemplatingTest.Data
{
    /* This is used if database provider does't define
     * ITextTemplatingTestDbSchemaMigrator implementation.
     */
    public class NullTextTemplatingTestDbSchemaMigrator : ITextTemplatingTestDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}