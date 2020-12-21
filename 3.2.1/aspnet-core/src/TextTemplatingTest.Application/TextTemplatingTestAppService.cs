using System;
using System.Collections.Generic;
using System.Text;
using TextTemplatingTest.Localization;
using Volo.Abp.Application.Services;

namespace TextTemplatingTest
{
    /* Inherit your application services from this class.
     */
    public abstract class TextTemplatingTestAppService : ApplicationService
    {
        protected TextTemplatingTestAppService()
        {
            LocalizationResource = typeof(TextTemplatingTestResource);
        }
    }
}
