using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using PageObjectStepsSauceDemo.Helpers.Configuration;
using Wrappers.Pages;

namespace Wrappers.Tests
{
    public class RemoveTest : BaseTest
    {
        [Test]
        [Order(5)]
        [Category("PositiveTest")]
        [Category("RemoveTest")]
        [Description("Проверка удаления товара из корзины со страницы inventory")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSuite("OrderSuite")]
        public void RemoveItemTest()
        {
            InventoryPage inventoryPage = LoginSteps.SuccessLogin();
            ItemSmall itemToRemove = inventoryPage.ItemsSmall[0];

            AllureApi.AddTestParameter("Item to remove", itemToRemove.ItemTitle.Text);
            Assert.Multiple(() =>
            {
                itemToRemove.AddItem();
                itemToRemove.RemoveItem();
                Assert.That(itemToRemove.IsItemNotAddedToCart());

                CartPage CartPage = NavigationSteps.NavigateToCartPage();
                Assert.That(CartPage.IsCartEmpty());
            });
        }
    }
}