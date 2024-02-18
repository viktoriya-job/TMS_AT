using PageObjectStepsSauceDemo.Pages;
using PageObjectStepsSauceDemo.Helpers.Configuration;
using PageObjectStepsSauceDemo.Steps;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace PageObjectStepsSauceDemo.Tests
{
    public class PaymentTest : BaseTest
    {
        [Test]
        [Order(6)]
        [Category("PositiveTest")]
        [Category("PaymentTest")]
        [Description("Проверка успешной оплаты")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSuite("OrderSuite")]
        public void PaymentSimpleTest()
        {
            InventoryPage inventoryPage = LoginSteps.SuccessLogin();
            ItemSmall itemToAdd1 = inventoryPage.ItemsSmall[0];
            ItemSmall itemToAdd2 = inventoryPage.ItemsSmall[1];

            AllureApi.AddTestParameter("Item to add", itemToAdd1.ItemTitle.Text);
            AllureApi.AddTestParameter("Item to add", itemToAdd2.ItemTitle.Text);

            Assert.Multiple(() =>
            {
                itemToAdd1.AddItem();
                itemToAdd2.AddItem();

                NavigationSteps.NavigateToCartPage(); 
                //НЕ РЕАЛИЗОВАНО - проверка на то, что в корзине именно нужные товары

                NavigationSteps.NavigateToCheckoutStepOnePage();
                OrderSteps.InputRecipientDetails();

                NavigationSteps.NavigateToCheckoutStepTwoPage();
                //НЕ РЕАЛИЗОВАНО - проверка на то, что в заказе именно нужные товары, корректная сумма и тд

                FinishPage finishPage = OrderSteps.FinishOrder();
                Assert.That(finishPage.IsPageOpened());

                CartPage cartPage = NavigationSteps.NavigateToCartPage();
                Assert.That(cartPage.IsCartEmpty);
            });
        }
    }
}