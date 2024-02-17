using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Helpers.Configuration;
using PageObjectStepsSauceDemo.Pages;

namespace PageObjectStepsSauceDemo.Steps
{
    public class NavigationSteps : BaseStep
    {
        public NavigationSteps(IWebDriver driver) : base(driver) { }


        public LoginPage NavigateToLoginPage() => LoginPage;
        public CartPage NavigateToCartPage() => new CartPage(Driver, true);
    }
}
