using Allure.Net.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Core;
using PageObjectStepsSauceDemo.Helpers.Configuration;
using PageObjectStepsSauceDemo.Steps;

namespace PageObjectStepsSauceDemo.Tests
{
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    [AllureNUnit]
    public class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        protected NavigationSteps NavigationSteps;
        protected LoginSteps LoginSteps;
        protected OrderSteps OrderSteps;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver;
            LoginSteps = new LoginSteps(Driver);
            NavigationSteps = new NavigationSteps(Driver);
            OrderSteps = new OrderSteps(Driver);

            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}