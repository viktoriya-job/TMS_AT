using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Pages;

namespace PageObjectStepsSauceDemo.Steps
{
    public class OrderSteps : BaseStep
    {
        private CheckoutStepOnePage _checkoutStepOnePage;
        private CheckoutStepTwoPage _checkoutStepTwoPage;

        public OrderSteps(IWebDriver driver) : base(driver) 
        {
            _checkoutStepOnePage = new CheckoutStepOnePage(Driver);
            _checkoutStepTwoPage = new CheckoutStepTwoPage(Driver);
        }
        
        public void InputRecipientDetails()
        {
            _checkoutStepOnePage.FirstnameInput.SendKeys("A");
            _checkoutStepOnePage.LastnameInput.SendKeys("B");
            _checkoutStepOnePage.PostalCodeInput.SendKeys("C");
        }

        public FinishPage FinishOrder()
        {
            _checkoutStepTwoPage.FinishButton.Click();
            return new FinishPage(Driver);
        }
    }
}