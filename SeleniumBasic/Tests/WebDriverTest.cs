
using OpenQA.Selenium;
using SeleniumBasic.Core;

namespace SeleniumBasic.Tests
{
    [TestFixture]
    public class WebDriverTest
    {
        [Test]
        public void SimpleDriverTest()
        {
            IWebDriver webDriver = new SimpleDriver().Driver;
            webDriver.Navigate().GoToUrl("http://onliner.by");
            webDriver.Manage().Window.Maximize();
            webDriver.Quit();
        }

        [Test]
        public void AdvancedDriverTest()
        {
            IWebDriver webDriver = new AdvancedDriver().GetChromeDriver();
            webDriver.Navigate().GoToUrl("http://onliner.by");
            webDriver.Quit();
        }

        //[Test]
        //public void FactoryDriverTest()
        //{
        //    IWebDriver webDriver = new Browser().Driver!;
        //    webDriver.Navigate().GoToUrl("http://onliner.by");
        //    webDriver.Quit();
        //}
    }
}
