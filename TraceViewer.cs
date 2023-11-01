
using Microsoft.Playwright;
using NUnit.Framework;

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
                Headless = false
            });

        }

        [Test]
        public async Task TestNightAlex()
        {
            Console.WriteLine("Hello World");
        }

        [Test]
        public async Task TestDemoCarlos()
        {
            Console.WriteLine("Hello World");
        }


        [Test]

        public async Task QaTeamDemo()
        {
            Console.WriteLine("QaTeamDemo");
        }
    }
}