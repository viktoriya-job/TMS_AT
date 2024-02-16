using OpenQA.Selenium;
using SaucedemoPOSteps.Pages;
using SaucedemoPOSteps.Helpers.Configuration;

namespace SaucedemoPOSteps.Steps
{
    public class NavigationSteps : BaseStep
    {
        public NavigationSteps(IWebDriver driver) : base(driver) { }


        public LoginPage NavigateToLoginPage() => LoginPage;
        public CartPage NavigateToCartPage() => new CartPage(Driver, true);
    }
}
