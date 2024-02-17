using PageObjectStepsSauceDemo.Pages;
using PageObjectStepsSauceDemo.Helpers.Configuration;
using PageObjectStepsSauceDemo.Steps;

namespace PageObjectStepsSauceDemo.Tests
{
    public class PaymentTest : BaseTest
    {
        [Test]
        [Order(6)]
        [Category("PositiveTest")]
        [Category("PaymentTest")]
        [Description("Проверка успешной оплаты")]
        public void PaymentSimpleTest()
        {
            InventoryPage inventoryPage = LoginSteps.SuccessLogin();
            Assert.Multiple(() =>
            {
                inventoryPage.ItemsSmall[0].AddItem();
                inventoryPage.ItemsSmall[1].AddItem();

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