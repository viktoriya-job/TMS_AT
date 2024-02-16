using OpenQA.Selenium;
using SaucedemoPOSteps.Pages;

namespace SaucedemoPOSteps.Steps
{
    public class LoginSteps : BaseStep
    {
        public LoginSteps(IWebDriver driver) : base(driver) { }

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
    }
}