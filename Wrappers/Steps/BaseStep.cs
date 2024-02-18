using OpenQA.Selenium;

namespace Wrappers1.Steps
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