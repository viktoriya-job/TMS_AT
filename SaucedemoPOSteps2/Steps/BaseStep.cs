using OpenQA.Selenium;
using SaucedemoPOSteps.Pages;

namespace SaucedemoPOSteps.Steps
{
    public class BaseStep
    {
        protected IWebDriver Driver;
        protected LoginPage LoginPage { get; private set; }

        public BaseStep(IWebDriver driver)
        {
            Driver = driver;
            LoginPage = new LoginPage(Driver, true);
        }
    }
}