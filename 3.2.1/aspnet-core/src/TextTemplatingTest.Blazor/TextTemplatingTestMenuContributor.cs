using System.Threading.Tasks;
using TextTemplatingTest.Localization;
using Volo.Abp.UI.Navigation;

namespace TextTemplatingTest.Blazor
{
    public class TextTemplatingTestMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<TextTemplatingTestResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "TextTemplatingTest.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
