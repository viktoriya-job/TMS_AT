using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Wrappers1.Helpers.Configuration;
using Wrappers1.Pages;

namespace Wrappers1.Steps
{
    public class LoginSteps : BaseStep
    {
        private LoginPage _loginPage;
        public LoginSteps(IWebDriver driver) : base(driver)
        {
            _loginPage = new LoginPage(Driver);
        }

        [AllureStep("Enter Username and Password for success login")]
        public InventoryPage SuccessLogin()
        {
            AllureApi.AddTestParameter("login", Configurator.AppSettings.Username);
            AllureApi.AddTestParameter("password", Configurator.AppSettings.Password, ParameterMode.Masked);

            _loginPage.UsernameInput.SendKeys(Configurator.AppSettings.Username);
            _loginPage.PasswordInput.SendKeys(Configurator.AppSettings.Password);
            _loginPage.LoginButton.Click();

            return new InventoryPage(Driver);
        }

        [AllureStep("Enter Username and Password for success login")]
        public InventoryPage SuccessLogin(string username, string password)
        {
            _loginPage.UsernameInput.SendKeys(username);
            _loginPage.PasswordInput.SendKeys(password);
            _loginPage.LoginButton.Click();

            return new InventoryPage(Driver);
        }

        [AllureStep("Enter Username and Password for fail login")]
        public LoginPage FailureLogin(string username, string password)
        {
            _loginPage.UsernameInput.SendKeys(username);
            _loginPage.PasswordInput.SendKeys(password);
            _loginPage.LoginButton.Click();

            return _loginPage;
        }
    }
}