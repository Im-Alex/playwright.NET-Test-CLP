using Microsoft.Playwright;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;
using System.Runtime.CompilerServices;

namespace framework.Pages
{
    public class LoginPage 
    {
        private static IPage _page;



        #region LOCATORS
        private ILocator _txtUserName => _page.GetByPlaceholder("Email, phone, or Skype");
        private ILocator _btnNext => _page.Locator("#idSIButton9");
        private ILocator _txtPassword => _page.Locator("#i0118");
        private ILocator _btnSingIn => _page.GetByRole(AriaRole.Button, new() { Name = "Sign in" });
        private ILocator _btnYes => _page.GetByRole(AriaRole.Button, new() { Name = "Yes" });
        private ILocator _btnNo => _page.GetByRole(AriaRole.Button, new() { Name = "No" });
        //private ILocator _btnDashboard => _page.GetByRole(AriaRole.Heading, new() { Name = "Dashboard" });
        private ILocator _btnDashboard => _page.GetByText("menu Dashboard");
        //private ILocator _btnDashboard => _page.Locator("h3.truncate");
        private ILocator _btnLoading => _page.Locator("div#app>div>div>p");
        //private ILocator _txtLogginIn => _page.GetByRole(AriaRole.Heading, new() { Name = "Logging in..." });
        //private ILocator _txtLogginIn => _page.Locator("h2[dir='auto']"); 
        private ILocator _txtLogginIn => _page.GetByRole(AriaRole.Heading, new() { Name = "Logging in..." });
        private ILocator _btnUserAccountDetails => _page.GetByRole(AriaRole.Button, new() { Name = "User account details" });
        #endregion
        //Constructor
        public LoginPage(IPage page) 
        {
            _page = page;
        }
        
        public async Task DoLogin (string username, string password, bool staySignIn = false)
        {

            try
            {
                await _txtUserName.FillAsync(username);
                await _btnNext.ClickAsync();

                //await _page.WaitForSelectorAsync("#i0118", new PageWaitForSelectorOptions()
                //{
                //    Timeout = 50
                //});
                
                await _txtPassword.FillAsync(password);
                await _btnSingIn.ClickAsync();
                await _page.WaitForLoadStateAsync();
                await TakePictureWithName("clickAssing");
                if (staySignIn)
                {
                    Console.WriteLine("YES" + staySignIn);
                    await _btnYes.ClickAsync();
                    await TakePictureWithName("Nostayed");
                    await _page.WaitForLoadStateAsync();

                    
                }
                else
                {
                    Console.WriteLine("NO" + staySignIn);
                    await _btnNo.ClickAsync();
                    await _page.WaitForLoadStateAsync();
                    
                }
                await Assertions.Expect(_btnLoading).Not.ToBeVisibleAsync(new() { Timeout = 5000});
                await TakePictureWithName("btnLogin");
                await Assertions.Expect(_txtLogginIn).ToBeVisibleAsync(new() { Timeout = 50000 });

                //await _btnUserAccountDetails.IsVisibleAsync();
                
                await Assertions.Expect(_btnUserAccountDetails).ToBeEnabledAsync(new() { Timeout = 10000 });
                await TakePictureWithName("WaitingBtnUserAccount");
                //await _btnUserAccountDetails.IsVisibleAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }

        public async Task<bool> isDashboardVisible() => await _btnDashboard.IsVisibleAsync(new() { Timeout = 10000});

        public async Task takeScreenShot()
        {
            await _page.WaitForLoadStateAsync();
            await _page.ScreenshotAsync(new()
            {
                Path = "C:\\Frameworks\\Playwright.NET\\framework\\Images\\Dashboard.png",
            });
        }

        public async Task TakePictureWithName(string name)
        {
            await _page.ScreenshotAsync(new()
            {
                Path = "C:\\Frameworks\\Playwright.NET\\framework\\Images\\" + $"{name}" + ".png",
                FullPage = true
            });
        }
        

    }
}
