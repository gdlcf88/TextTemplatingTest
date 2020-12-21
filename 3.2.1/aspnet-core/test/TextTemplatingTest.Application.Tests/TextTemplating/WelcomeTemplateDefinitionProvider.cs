using Volo.Abp.TextTemplating;

namespace TextTemplatingTest.TextTemplating
{
    public class WelcomeTemplateDefinitionProvider : TemplateDefinitionProvider
    {
        public override void Define(ITemplateDefinitionContext context)
        {
            context.Add(
                new TemplateDefinition("Welcome")
                    .WithVirtualFilePath(
                        "/TextTemplating/Welcome.tpl",
                        isInlineLocalized: true
                    )
            );
            
            context.Add(
                new TemplateDefinition("Welcome2")
                    .WithVirtualFilePath(
                        "/TextTemplating/Welcome2.tpl",
                        isInlineLocalized: true
                    )
            );
        }
    }
}