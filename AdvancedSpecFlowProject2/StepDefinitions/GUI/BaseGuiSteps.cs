using CoreProject.Core;
using OpenQA.Selenium;

namespace AdvancedSpecFlowProject2.StepDefinitions.GUI
{

    public class BaseGuiSteps
    {
        protected IWebDriver Driver { get; }
        protected ScenarioContext ScenarioContext { get; }

        public BaseGuiSteps(Browser browser, ScenarioContext scenarioContext)
        {
            Driver = browser.Driver;
            ScenarioContext = scenarioContext;
        }
    }
}
