using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Pages;

namespace PageObjectStepsSauceDemo.Steps
{
    public class OrderSteps : BaseStep
    {
        private CheckoutStepOnePage _checkoutStepOnePage;
        private CheckoutStepTwoPage _checkoutStepTwoPage;
        private InventoryPage _inventoryPage;
        private NavigationSteps _navigationSteps;
        private LoginSteps _loginSteps;

        public OrderSteps(IWebDriver driver) : base(driver)
        {
            _checkoutStepOnePage = new CheckoutStepOnePage(Driver);
            _checkoutStepTwoPage = new CheckoutStepTwoPage(Driver);
            _inventoryPage = new InventoryPage(Driver);
            _navigationSteps = new NavigationSteps(Driver);
            _loginSteps = new LoginSteps(Driver);
        }

        [AllureStep("Add Some Items And Check the Cart")]
        public CartPage AddSomeItemsAndCheckCart()
        {
            _inventoryPage.ItemsSmall[0].AddItem();
            _inventoryPage.ItemsSmall[1].AddItem();

            CartPage cartPage = _navigationSteps.NavigateToCartPage();
            //НЕ РЕАЛИЗОВАНО - проверка на то, что в корзине именно нужные товары
            Assert.That(cartPage.IsPageOpened);

            return cartPage;
        }

        [AllureStep("Input Recipient Details")]
        public CheckoutStepTwoPage InputRecipientDetails()
        {
            _checkoutStepOnePage.FirstnameInput.SendKeys("A");
            _checkoutStepOnePage.LastnameInput.SendKeys("B");
            _checkoutStepOnePage.PostalCodeInput.SendKeys("C");

            return new CheckoutStepTwoPage(Driver, true);
        }

        [AllureStep("Finish Order")]
        public FinishPage FinishOrder()
        {
            _checkoutStepTwoPage.FinishButton.Click();
            return new FinishPage(Driver);
        }
    }
}