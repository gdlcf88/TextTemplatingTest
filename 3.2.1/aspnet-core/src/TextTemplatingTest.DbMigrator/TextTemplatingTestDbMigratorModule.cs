using TextTemplatingTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TextTemplatingTest.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TextTemplatingTestEntityFrameworkCoreDbMigrationsModule),
        typeof(TextTemplatingTestApplicationContractsModule)
        )]
    public class TextTemplatingTestDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
