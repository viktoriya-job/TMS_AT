using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Helpers.Configuration;
using PageObjectStepsSauceDemo.Pages;

namespace PageObjectStepsSauceDemo.Steps
{
    public class LoginSteps : BaseStep
    {
        private LoginPage _loginPage;
        public LoginSteps(IWebDriver driver) : base(driver) 
        {
            _loginPage = new LoginPage(Driver);
        }

        public InventoryPage SuccessLogin()
        {
            LoginPage.UsernameInput().SendKeys(Configurator.AppSettings.Username);
            LoginPage.PasswordInput().SendKeys(Configurator.AppSettings.Password);
            LoginPage.LoginButton().Click();

            return new InventoryPage(Driver);
        }
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