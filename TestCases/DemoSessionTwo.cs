
using framework.Pages;
using Microsoft.Playwright;
using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;

namespace framework.TestCases
{
    public class DemoSessionTwo 
    {



        [SetUp]
        public async Task Setup()
        {

        }

        [Test, Property("REGRESSION", "LOGIN")]
        [Author("Alejandro Velazquez Valenzuela", "alejandrovelazquezvalenzuela@gmail.com")]
        [Category("TES-56")]
        [Description("This test case validates the Login with valid credentials")]
        public async Task LoginWithValidCredentials1()
        {
           

            
            try
            {
                //Playwright
                using var playwright = await Playwright.CreateAsync();

                //Browser
                await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false
                });
                var context = await browser.NewContextAsync();


                var page = await context.NewPageAsync();
                await page.GotoAsync("https://cloudadmin.dev.biosero.com/dashboard");
                await page.FillAsync("#i0116", "alejandrovelazquez@biosero.com");
                await page.ClickAsync("#idSIButton9");
                await page.FillAsync("#i0118", "HolaMundo.1*");
                await page.ClickAsync("#idSIButton9");


                var loginPage = new LoginPage(page);
                
                await loginPage.DoLogin("alejandrovelazquez@biosero.com", "HolaMundo.1*");
                
                var isDashboardExist = await loginPage.isDashboardVisible();


                //await loginPage.takeScreenShot();
                await loginPage.TakePictureWithName("SuccesfullyLogin");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
