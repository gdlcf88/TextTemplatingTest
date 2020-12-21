using Volo.Abp.Settings;

namespace TextTemplatingTest.Settings
{
    public class TextTemplatingTestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(TextTemplatingTestSettings.MySetting1));
        }
    }
}
