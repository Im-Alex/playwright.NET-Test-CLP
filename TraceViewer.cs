
using Microsoft.Playwright;

namespace framework
{
    public class TraceViewer
    {
        [Test]
        public async Task TraceVieweExample()
        {
            //Playwright
            using var playwright = await Playwright.CreateAsync();

            //Browser
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = true
            });

        }
    }
}
