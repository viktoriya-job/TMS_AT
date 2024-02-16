using OpenQA.Selenium;
using SaucedemoPOSteps.Pages;

namespace SaucedemoPOSteps.Steps
{
    public class NavigationSteps : BaseStep
    {

        public NavigationSteps(IWebDriver driver) : base(driver) { }

        public LoginPage NavigateToLoginPage()
        {
            return LoginPage;
        }

        public InventoryPage NavigateToInventoryPage()
        {
            return new InventoryPage(Driver, true);
        }

        //public LoginPage NavigateToLoginPage() => LoginPage;
        //public InventoryPage NavigateToInventoryPage() => InventoryPage;
        //public CartPage NavigateToCartPage() => CartPage;
        //public CheckoutStepOnePage NavigateToCheckoutStepOnePage() => CheckoutStepOnePage;
        //public CheckoutStepTwoPage NavigateToCheckoutStepTwoPage() => CheckoutStepTwoPage;

        private void Login(string username, string password)
        {
            LoginPage.UsernameInput().SendKeys(username);
            LoginPage.PasswordInput().SendKeys(password);
            LoginPage.LoginButton().Click();
        }

        public void SuccessLogin(string username, string password)
        {
            //Login(username, password);
            //NavigateToInventoryPage();
            LoginPage.UsernameInput().SendKeys(username);
            LoginPage.PasswordInput().SendKeys(password);
            LoginPage.LoginButton().Click();

        }

        //public InventoryPage SuccessLogin(string username, string password)
        //{
        //    Login(username, password);
        //    return new InventoryPage(Driver, true);
        //}
    }
}