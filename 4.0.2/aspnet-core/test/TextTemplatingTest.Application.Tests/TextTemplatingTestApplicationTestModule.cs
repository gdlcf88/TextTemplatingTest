using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace TextTemplatingTest
{
    [DependsOn(
        typeof(TextTemplatingTestApplicationModule),
        typeof(TextTemplatingTestDomainTestModule)
        )]
    public class TextTemplatingTestApplicationTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<TextTemplatingTestApplicationTestModule>("TextTemplatingTest");
            });
        }
    }
}