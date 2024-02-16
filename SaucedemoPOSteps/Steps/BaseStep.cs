using OpenQA.Selenium;
using SaucedemoPOSteps.Pages;

namespace SaucedemoPOSteps.Steps
{
    public class BaseStep
    {
        public IWebDriver Driver;

        public LoginPage LoginPage => new LoginPage(Driver);
        public InventoryPage InventoryPage => new InventoryPage(Driver);
        //public CartPage CartPage => new CartPage(Driver, true);
        public CheckoutStepOnePage CheckoutStepOnePage => new CheckoutStepOnePage(Driver);
        //public CheckoutStepTwoPage CheckoutStepTwoPage => new CheckoutStepTwoPage(Driver, true);
        //public ThankYouPage ThankYouPage => new ThankYouPage(Driver, true);

        public BaseStep(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}