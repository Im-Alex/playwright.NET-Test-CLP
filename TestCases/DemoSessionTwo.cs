
using framework.Pages;
using Microsoft.Playwright;
using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;

namespace framework.TestCases
{
    public class DemoSessionTwo 
    {

        [Test]
        [Category("TES-48")]
        public async Task LoginWithValidCredentials()
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
                await page.GotoAsync("https://cloudadmin.dev.biosero.com/authentication/login?returnUrl=https%3A%2F%2Fcloudadmin.dev.biosero.com%2Fdashboard");
                await page.GotoAsync("https://login.microsoftonline.com/7eea9ea5-c8db-4890-96f4-80fa06f834c5/oauth2/v2.0/authorize?client_id=8ec5cade-b551-43ec-95fb-583cd3a6b07d&scope=https%3A%2F%2Fgraph.microsoft.com%2FUser.Read%20openid%20profile%20offline_access&redirect_uri=https%3A%2F%2Fcloudadmin.dev.biosero.com%2Fauthentication%2Flogin-callback&client-request-id=72f6c392-89d5-47eb-8c3b-4c8531ec2265&response_mode=fragment&response_type=code&x-client-SKU=msal.js.browser&x-client-VER=2.16.1&x-client-OS=&x-client-CPU=&client_info=1&code_challenge=BVWfgMIW73RnPUY2JW6SrcF3sbs5tzjRO_3FRrl3Wtg&code_challenge_method=S256&nonce=75f29bc9-5e80-4314-80a0-f759e07fdd86&state=eyJpZCI6IjJjOWNjNDQ4LTJkOWItNDcxMi1hOGE4LTc0NzFhMmFjZjc2MSIsIm1ldGEiOnsiaW50ZXJhY3Rpb25UeXBlIjoicmVkaXJlY3QifX0%3D%7CuZ1gSazxKUe1smVhMgYDnOrPuUaMtM1UOdIm1ftC9MQ");
                await page.GotoAsync("https://login.microsoftonline.com/7eea9ea5-c8db-4890-96f4-80fa06f834c5/oauth2/v2.0/authorize?client_id=8ec5cade-b551-43ec-95fb-583cd3a6b07d&scope=https%3A%2F%2Fgraph.microsoft.com%2FUser.Read%20openid%20profile%20offline_access&redirect_uri=https%3A%2F%2Fcloudadmin.dev.biosero.com%2Fauthentication%2Flogin-callback&client-request-id=72f6c392-89d5-47eb-8c3b-4c8531ec2265&response_mode=fragment&response_type=code&x-client-SKU=msal.js.browser&x-client-VER=2.16.1&x-client-OS=&x-client-CPU=&client_info=1&code_challenge=BVWfgMIW73RnPUY2JW6SrcF3sbs5tzjRO_3FRrl3Wtg&code_challenge_method=S256&nonce=75f29bc9-5e80-4314-80a0-f759e07fdd86&state=eyJpZCI6IjJjOWNjNDQ4LTJkOWItNDcxMi1hOGE4LTc0NzFhMmFjZjc2MSIsIm1ldGEiOnsiaW50ZXJhY3Rpb25UeXBlIjoicmVkaXJlY3QifX0%3D%7CuZ1gSazxKUe1smVhMgYDnOrPuUaMtM1UOdIm1ftC9MQ&sso_reload=true");
               
                var loginPage = new LoginPage(page);
                
                await loginPage.DoLogin("alejandrovelazquez@biosero.com", "HolaMundo.1*");
                
                var isDashboardExist = await loginPage.isDashboardVisible();
                
                Assert.IsTrue(isDashboardExist);
                await loginPage.takeScreenShot();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




    }
}
