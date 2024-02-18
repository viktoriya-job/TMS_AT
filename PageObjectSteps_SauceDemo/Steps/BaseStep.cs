using OpenQA.Selenium;

namespace Wrappers.Steps
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