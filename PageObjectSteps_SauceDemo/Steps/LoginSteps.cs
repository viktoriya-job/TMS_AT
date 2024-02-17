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
            _loginPage.UsernameInput.SendKeys(Configurator.AppSettings.Username);
            _loginPage.PasswordInput.SendKeys(Configurator.AppSettings.Password);
            _loginPage.LoginButton.Click();

            return new InventoryPage(Driver);
        }
        public InventoryPage SuccessLogin(string username, string password)
        {
            _loginPage.UsernameInput.SendKeys(username);
            _loginPage.PasswordInput.SendKeys(password);
            _loginPage.LoginButton.Click();

            return new InventoryPage(Driver);
        }
            public LoginPage FailureLogin(string username, string password)
        {
            _loginPage.UsernameInput.SendKeys(username);
            _loginPage.PasswordInput.SendKeys(password);
            _loginPage.LoginButton.Click();

            return _loginPage;
        }
    }
}