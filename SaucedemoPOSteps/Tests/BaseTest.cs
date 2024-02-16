using Allure.Net.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using SaucedemoPOSteps.Core;
using SaucedemoPOSteps.Helpers;
using SaucedemoPOSteps.Helpers.Configuration;
using SaucedemoPOSteps.Steps;

namespace SaucedemoPOSteps.Tests
{
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    [AllureNUnit]
    public class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        protected WaitsHelper WaitsHelper { get; private set; }
        protected NavigationSteps NavigationSteps;
        //protected UserSteps UserSteps;
        //protected OrderSteps OrderSteps;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver;
            WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

            NavigationSteps = new NavigationSteps(Driver);
            //UserSteps = new UserSteps(Driver);
            //OrderSteps = new OrderSteps(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}