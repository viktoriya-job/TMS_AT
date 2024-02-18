using PageObjectStepsSauceDemo.Steps;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using Wrappers1.Pages;

namespace Wrappers1.Tests
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
            ItemSmall itemToAdd = inventoryPage.ItemsSmall[0];

            AllureApi.AddTestParameter("Item to add", itemToAdd.ItemTitle.Text);

            Assert.Multiple(() =>
            {
                inventoryPage.ItemsSmall[0].AddItem();
                Assert.That(itemToAdd.IsItemAddedToCart());

                CartPage CartPage = NavigationSteps.NavigateToCartPage();
                //надо бы проверять, что в корзине именно нужный товар, но пока так
                Assert.That(!CartPage.IsCartEmpty());
            });
        }
    }
}