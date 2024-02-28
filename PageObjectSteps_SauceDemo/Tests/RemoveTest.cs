using Allure.Net.Commons;
using NUnit.Allure.Attributes;
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
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSuite("OrderSuite")]
        public void RemoveItemTest()
        {
            InventoryPage inventoryPage = LoginSteps.SuccessLogin();
            AllureApi.AddTestParameter("Item to remove", inventoryPage.SauceLabsBoltTShirtItemSmall.ItemTitle.Text);

            Assert.Multiple(() =>
            {
                inventoryPage.SauceLabsBoltTShirtItemSmall.AddItem();
                inventoryPage.SauceLabsBoltTShirtItemSmall.RemoveItem();
                Assert.That(inventoryPage.SauceLabsBoltTShirtItemSmall.IsItemNotAddedToCart);

                CartPage CartPage = NavigationSteps.NavigateToCartPage();
                Assert.That(CartPage.IsCartEmpty());
            });
        }
    }
}