using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Pages;

namespace PageObjectStepsSauceDemo.Steps
{
    public class OrderSteps : BaseStep
    {
        private InventoryPage _inventoryPage;
        private CheckoutStepOnePage _checkoutStepOnePage;
        private CheckoutStepTwoPage _checkoutStepTwoPage;

        public OrderSteps(IWebDriver driver) : base(driver) 
        {
            _checkoutStepOnePage = new CheckoutStepOnePage(Driver);
            _checkoutStepTwoPage = new CheckoutStepTwoPage(Driver);
            _inventoryPage = new InventoryPage(Driver);
        }

        public InventoryPage AddItemToCart()
        {
            _inventoryPage.SauceLabsBoltTShirtItemSmall.AddItem();
            Assert.That(_inventoryPage.SauceLabsBoltTShirtItemSmall.IsItemAddedToCart);

            return _inventoryPage;
        }

        [AllureStep("Input Recipient Details")]
        public CheckoutStepOnePage InputRecipientDetails()
        {
            _checkoutStepOnePage.FirstnameInput.SendKeys("A");
            _checkoutStepOnePage.LastnameInput.SendKeys("B");
            _checkoutStepOnePage.PostalCodeInput.SendKeys("C");

            return _checkoutStepOnePage;
        }

        [AllureStep("Finish Order")]
        public FinishPage FinishOrder()
        {
            _checkoutStepTwoPage.FinishButton.Click();

            return new FinishPage(Driver);
        }
    }
}