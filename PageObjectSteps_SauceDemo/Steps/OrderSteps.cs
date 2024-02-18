using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Wrappers.Pages;

namespace Wrappers.Steps
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

        [AllureStep("Input Recipient Details")]
        public void InputRecipientDetails()
        {
            _checkoutStepOnePage.FirstnameInput.SendKeys("A");
            _checkoutStepOnePage.LastnameInput.SendKeys("B");
            _checkoutStepOnePage.PostalCodeInput.SendKeys("C");
        }

        [AllureStep("Finish Order")]
        public FinishPage FinishOrder()
        {
            _checkoutStepTwoPage.FinishButton.Click();
            return new FinishPage(Driver);
        }
    }
}