using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Pages;

namespace PageObjectStepsSauceDemo.Steps
{
    public class NavigationSteps : BaseStep
    {
        public NavigationSteps(IWebDriver driver) : base(driver) {}

        [AllureStep("Navigate to cart")]
        public CartPage NavigateToCartPage() => new CartPage(Driver, true);

        [AllureStep("Navigate to page Checkout Step One")]
        public CheckoutStepOnePage NavigateToCheckoutStepOnePage() => new CheckoutStepOnePage(Driver, true);
        
        [AllureStep("Navigate to page Checkout Step Two")]
        public CheckoutStepTwoPage NavigateToCheckoutStepTwoPage() => new CheckoutStepTwoPage(Driver, true);
    }
}