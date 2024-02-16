using OpenQA.Selenium;
using SaucedemoPOSteps.Pages;
using SaucedemoPOSteps.Helpers.Configuration;

namespace SaucedemoPOSteps.Steps
{
    public class NavigationSteps : BaseStep
    {
        public NavigationSteps(IWebDriver driver) : base(driver) { }

        public InventoryPage SuccessLogin(string username, string password)
        {
            LoginPage.UsernameInput().SendKeys(username);
            LoginPage.PasswordInput().SendKeys(password);
            LoginPage.LoginButton().Click();

            return new InventoryPage(Driver);
        }

        public LoginPage FailureLogin(string username, string password)
        {
            LoginPage.UsernameInput().SendKeys(username);
            LoginPage.PasswordInput().SendKeys(password);
            LoginPage.LoginButton().Click();

            return LoginPage;
        }

        public LoginPage NavigateToLoginPage() => LoginPage;
        public CartPage NavigateToCartPage()
        {
            //NavigateToLoginPage();
            //SuccessLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            return new CartPage(Driver, true);
        }
    }
}
