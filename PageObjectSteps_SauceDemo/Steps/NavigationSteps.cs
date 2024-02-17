using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Pages;

namespace PageObjectStepsSauceDemo.Steps
{
    public class NavigationSteps : BaseStep
    {
        public NavigationSteps(IWebDriver driver) : base(driver) { }

        public LoginPage NavigateToLoginPage() => LoginPage;
        public CartPage NavigateToCartPage() => new CartPage(Driver, true);
        public CheckoutStepOnePage NavigateToCheckoutStepOnePage => new CheckoutStepOnePage(Driver, true);
        public CheckoutStepTwoPage NavigateToCheckoutStepTwoPage => new CheckoutStepTwoPage(Driver, true);
    }
}