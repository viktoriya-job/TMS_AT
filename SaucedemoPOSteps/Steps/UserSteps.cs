using OpenQA.Selenium;
using SaucedemoPOSteps.Pages;


namespace SaucedemoPOSteps.Steps
{
    public class UserSteps : BaseStep
    {
        public UserSteps(IWebDriver driver) : base(driver) { }

        private void Login(string username, string password)
        {
            LoginPage.UsernameInput().SendKeys(username);
            LoginPage.PasswordInput().SendKeys(password);
            LoginPage.LoginButton().Click();
        }

        public InventoryPage SuccessLogin(string username, string password)
        {
            Login(username, password);
            return InventoryPage;
        }

        public LoginPage FailureLogin(string username, string password)
        {
            Login(username, password);
            return LoginPage;
        }
    }
}