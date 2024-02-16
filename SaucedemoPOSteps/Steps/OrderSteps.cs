using SaucedemoPOSteps.Pages.ItemsSmall;
using SaucedemoPOSteps.Pages;

using OpenQA.Selenium;

namespace SaucedemoPOSteps.Steps
{
    public class OrderSteps : BaseStep
    {
        //CheckoutStepOnePage CheckoutStepOnePage;
        //CheckoutStepOnePage = new CheckoutStepOnePage(Driver, true);
        public OrderSteps(IWebDriver driver) : base(driver) { }

        public void AddProductToCart(List<string> Products)
        {
            new NavigationSteps(Driver).NavigateToInventoryPage();

        }

            private void EnterCustomerDetails(string firstname, string lastname, string postalCode)
        {
            CheckoutStepOnePage.FirstnameInput().SendKeys(firstname);
            CheckoutStepOnePage.LastnameInput().SendKeys(lastname);
            CheckoutStepOnePage.PostalCodeInput().SendKeys(postalCode);
            CheckoutStepOnePage.ContinueButton().Click();
        }

        //public CheckoutStepOnePage Checkout()
        //{
        //    CartPage.CheckoutButton().Click();
        //    return CheckoutStepOnePage;
        //}

        //public CheckoutStepTwoPage Continue()
        //{
        //    EnterCustomerDetails("A", "B", "C");
        //    return CheckoutStepTwoPage;
        //}

        //public ThankYouPage Finish()
        //{
        //    CheckoutStepTwoPage.FinishButton().Click();

        //    return new ThankYouPage(Driver, true);
        //}
    }
}