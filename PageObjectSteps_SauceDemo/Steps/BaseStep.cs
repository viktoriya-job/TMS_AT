using OpenQA.Selenium;

namespace PageObjectStepsSauceDemo.Steps
{
    public class BaseStep
    {
        protected IWebDriver Driver;

        public BaseStep(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}