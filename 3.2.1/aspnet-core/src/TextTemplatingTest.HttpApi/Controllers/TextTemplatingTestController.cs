using TextTemplatingTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TextTemplatingTest.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TextTemplatingTestController : AbpController
    {
        protected TextTemplatingTestController()
        {
            LocalizationResource = typeof(TextTemplatingTestResource);
        }
    }
}