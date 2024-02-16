using Allure.Net.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using SaucedemoPOSimple.Core;

namespace SaucedemoPOSimple.Tests
{
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    [AllureNUnit]
    public class BaseTest
    {
        protected IWebDriver Driver { get; private set; }

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

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