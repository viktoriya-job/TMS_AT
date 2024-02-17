using PageObjectStepsSauceDemo.Steps;
using PageObjectStepsSauceDemo.Pages;

namespace PageObjectStepsSauceDemo.Tests
{
    public class AddTest : BaseTest
    {
        [Test]
        [Order(4)]
        [Category("PositiveTest")]
        [Category("AddTest")]
        [Description("Проверка добавления товара в корзину на странице inventory")]
        public void AddBikeLiteItemTest()
        {
            InventoryPage inventoryPage = LoginSteps.SuccessLogin();
            Assert.Multiple(() =>
            {
                inventoryPage.ItemsSmall[0].AddItem();
                Assert.That(inventoryPage.ItemsSmall[0].IsItemAddedToCart());
                CartPage CartPage = NavigationSteps.NavigateToCartPage();
                Assert.That(!CartPage.IsCartEmpty()); //надо бы проверять, что в корзине именно нужный товар, но пока так
            });
        }
    }
}