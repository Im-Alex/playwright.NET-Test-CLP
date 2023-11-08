using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace framework
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class CustomizeBrowser : PageTest
    {
        [Test]
        public async Task TestWithCustomContextOptions()
        {
            Console.WriteLine("ALEX1");

        }

        public override BrowserNewContextOptions ContextOptions()
        {
            return new BrowserNewContextOptions()
            {
                ColorScheme = ColorScheme.Light,
                ViewportSize = new()
                {
                    Width = 1920,
                    Height = 1080
                },
                BaseURL = "https://github.com",
            };
        }
    }
}
