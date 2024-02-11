using OpenQA.Selenium;
using SaucedemoPOSimple.Core;

namespace SaucedemoPOSimple.Tests
{
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    public class BaseTest
    {
        protected IWebDriver Driver { get; private set; }

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver;
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
