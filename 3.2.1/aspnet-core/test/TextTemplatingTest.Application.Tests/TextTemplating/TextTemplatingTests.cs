using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using Volo.Abp.TextTemplating;
using Xunit;

namespace TextTemplatingTest.TextTemplating
{
    public class TextTemplatingTests : TextTemplatingTestApplicationTestBase
    {
        [Fact]
        public async Task Should_Render_Correct_Text_With_Snake_Camel_Property()
        {
            var templateRenderer = ServiceProvider.GetRequiredService<ITemplateRenderer>();

            var text = await templateRenderer.RenderAsync("Welcome", new {UserName = "gdlcf88"});

            text.ShouldBe("Welcome, gdlcf88");
        }

        [Fact]
        public async Task Should_Render_Correct_Text_With_Snake_Case_Property()
        {
            var templateRenderer = ServiceProvider.GetRequiredService<ITemplateRenderer>();

            var text = await templateRenderer.RenderAsync("Welcome2", new {UserName = "gdlcf88"});

            text.ShouldBe("Welcome, gdlcf88");
        }
    }
}