using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TextTemplatingTest.Data;
using Volo.Abp.DependencyInjection;

namespace TextTemplatingTest.EntityFrameworkCore
{
    public class EntityFrameworkCoreTextTemplatingTestDbSchemaMigrator
        : ITextTemplatingTestDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreTextTemplatingTestDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the TextTemplatingTestMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<TextTemplatingTestMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}