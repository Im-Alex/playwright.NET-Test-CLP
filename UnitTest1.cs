using System.Text.RegularExpressions;
using Microsoft.Playwright;

namespace framework;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        ////Playwright
        //using var playwright = await Playwright.CreateAsync();

        ////Browser
        //await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        //{
        //    Headless = true
        //});

        //page
        //var page = await browser.NewPageAsync();
        //await page.GotoAsync("https://playwright.dev");
        //await page.ClickAsync("text=Get started");

        Console.WriteLine("ALEX -----> 4");

    }
}