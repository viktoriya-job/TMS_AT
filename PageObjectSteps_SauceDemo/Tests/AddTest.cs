using PageObjectStepsSauceDemo.Steps;
using PageObjectStepsSauceDemo.Pages;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace PageObjectStepsSauceDemo.Tests
{
    public class AddTest : BaseTest
    {
        [Test]
        [Order(4)]
        [Category("PositiveTest")]
        [Category("AddTest")]
        [Description("Проверка добавления товара в корзину на странице inventory")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSuite("OrderSuite")]
        public void AddItemTest()
        {
            InventoryPage inventoryPage = LoginSteps.SuccessLogin();
            Assert.Multiple(() =>
            {
                inventoryPage.ItemsSmall[0].AddItem();
                Assert.That(inventoryPage.ItemsSmall[0].IsItemAddedToCart());

                CartPage CartPage = NavigationSteps.NavigateToCartPage();
                //надо бы проверять, что в корзине именно нужный товар, но пока так
                Assert.That(!CartPage.IsCartEmpty());
            });
        }
    }
}