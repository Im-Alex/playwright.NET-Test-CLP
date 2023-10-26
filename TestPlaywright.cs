

using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace framework
{

    [Parallelizable(ParallelScope.Self)]
    [TestFixture]

    public class TestPlaywright : PageTest
    {
        [Test]
        public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
        {
           

            //Expect a title "to contain" a substring
            await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

            // Create a locator
            var getStarted = Page.GetByRole(AriaRole.Link, new() { Name = "Get started" });

            // Expect an attribute "to be strictly equal" to the value
            await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

            // Click the get started link
            await getStarted.ClickAsync();

            //Expects page to have a heading with the name of installation
            await Expect(Page
            .GetByRole(AriaRole.Heading, new() { Name = "Installation" }))
            .ToBeVisibleAsync();
        }

        [SetUp]
        public async Task SetUp()
        {
            

           
            await Page.GotoAsync("https://playwright.dev");
        }
    }
}
