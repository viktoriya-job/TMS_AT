using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjectSimple.Helpers;
using PageObjectSimple.Helpers.Configuration;
using SeleniumAdvanced.Core;

namespace PageObjectSimple.Tests
{
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    public class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        protected WaitsHelper WaitsHelper { get; private set; }

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver!;
            WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}