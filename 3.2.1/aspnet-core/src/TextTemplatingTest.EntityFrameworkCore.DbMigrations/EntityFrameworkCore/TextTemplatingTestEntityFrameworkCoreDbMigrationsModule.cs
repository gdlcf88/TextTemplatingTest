using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace TextTemplatingTest.EntityFrameworkCore
{
    [DependsOn(
        typeof(TextTemplatingTestEntityFrameworkCoreModule)
        )]
    public class TextTemplatingTestEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TextTemplatingTestMigrationsDbContext>();
        }
    }
}
