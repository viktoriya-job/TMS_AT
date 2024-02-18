using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Wrappers1.Pages;

namespace Wrappers1.Steps
{
    public class NavigationSteps : BaseStep
    {
        public NavigationSteps(IWebDriver driver) : base(driver) { }

        [AllureStep("Navigate to Cart")]
        public CartPage NavigateToCartPage()
        {
            CartPage cartPage = new CartPage(Driver, true);
            Assert.That(cartPage.IsPageOpened());
            return cartPage;
        }

        [AllureStep("Navigate to page 'Checkout Step One'")]
        public CheckoutStepOnePage NavigateToCheckoutStepOnePage()
        {
            CheckoutStepOnePage checkoutStepOnePage = new CheckoutStepOnePage(Driver, true);
            Assert.That(checkoutStepOnePage.IsPageOpened());
            return checkoutStepOnePage;
        }

        [AllureStep("Navigate to page 'Checkout Step Two'")]
        public CheckoutStepTwoPage NavigateToCheckoutStepTwoPage()
        {
            CheckoutStepTwoPage checkoutStepTwoPage = new CheckoutStepTwoPage(Driver, true);
            Assert.That(checkoutStepTwoPage.IsPageOpened());
            return checkoutStepTwoPage;
        }
    }
}