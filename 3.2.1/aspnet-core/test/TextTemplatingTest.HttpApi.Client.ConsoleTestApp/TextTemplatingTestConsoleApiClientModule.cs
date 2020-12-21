using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace TextTemplatingTest.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(TextTemplatingTestHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class TextTemplatingTestConsoleApiClientModule : AbpModule
    {
        
    }
}
