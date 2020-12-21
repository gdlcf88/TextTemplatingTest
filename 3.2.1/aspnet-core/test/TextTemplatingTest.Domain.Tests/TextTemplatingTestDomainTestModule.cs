using TextTemplatingTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TextTemplatingTest
{
    [DependsOn(
        typeof(TextTemplatingTestEntityFrameworkCoreTestModule)
        )]
    public class TextTemplatingTestDomainTestModule : AbpModule
    {

    }
}