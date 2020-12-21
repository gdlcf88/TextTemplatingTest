using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TextTemplatingTest
{
    [Dependency(ReplaceServices = true)]
    public class TextTemplatingTestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "TextTemplatingTest";
    }
}
