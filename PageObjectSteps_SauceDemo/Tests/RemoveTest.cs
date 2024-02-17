using PageObjectStepsSauceDemo.Helpers.Configuration;
using PageObjectStepsSauceDemo.Pages;

namespace PageObjectStepsSauceDemo.Tests
{
    public class RemoveTest : BaseTest
    {
        [Test]
        [Order(5)]
        [Category("PositiveTest")]
        [Category("RemoveTest")]
        [Description("Проверка удаления товара из корзины со страницы inventory")]
        public void RemoveItemTest()
        {
            InventoryPage inventoryPage = LoginSteps.SuccessLogin();
            Assert.Multiple(() =>
            {
                inventoryPage.ItemsSmall[0].AddItem();
                inventoryPage.ItemsSmall[0].RemoveItem();
                Assert.That(inventoryPage.ItemsSmall[0].IsItemNotAddedToCart());

                CartPage CartPage = NavigationSteps.NavigateToCartPage();
                Assert.That(CartPage.IsCartEmpty());
            });
        }
    }
}