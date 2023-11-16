
using Microsoft.Playwright;
using NUnit.Framework;

namespace framework
{
    public class TraceViewer
    {
        [Test]
        [Category("TES-42")]
        public async Task TraceVieweExample()
        {
            //Playwright
            using var playwright = await Playwright.CreateAsync();

            //Browser
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

        }

        [Test]
        [Category("TES-41")]
        public async Task TestNightAlex()
        {
            Console.WriteLine("Hello World");
        }

        [Test]
        [Category("TES-40")]
        public async Task TestDemoCarlos()
        {
            Console.WriteLine("Hello World");
        }


        [Test]
        [Category("TES-39")]
        public async Task QaTeamDemo()
        {
            Console.WriteLine("QaTeamDemo");
        }
    }
}