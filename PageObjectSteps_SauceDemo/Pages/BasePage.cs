using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Helpers;
using PageObjectStepsSauceDemo.Helpers.Configuration;

namespace PageObjectStepsSauceDemo.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver { get; private set; }
        protected WaitsHelper WaitsHelper { get; private set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        }

        public BasePage(IWebDriver driver, bool openPageByUrl = false)
        {
            Driver = driver;
            WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

            if (openPageByUrl)
            {
                OpenPageByUrl();
            }
        }

        public abstract bool IsPageOpened();
        protected abstract string GetEndpoint();
        private void OpenPageByUrl()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
        }
    }
}