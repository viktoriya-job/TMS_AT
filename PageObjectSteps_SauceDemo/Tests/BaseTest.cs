using Allure.Net.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Core;
using System.Text;
using Wrappers.Helpers.Configuration;
using Wrappers.Steps;

namespace Wrappers.Tests
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
            try
            {
                if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
                {
                    Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                    byte[] screenshotBytes = screenshot.AsByteArray;

                    AllureApi.AddAttachment("Screenshot", "image/png", screenshotBytes);
                    AllureApi.AddAttachment("error.txt", "text/plain", Encoding.UTF8.GetBytes(TestContext.CurrentContext.Result.Message));
                }
            }

            finally
            {
                Driver.Quit();
            }
        }
    }
}