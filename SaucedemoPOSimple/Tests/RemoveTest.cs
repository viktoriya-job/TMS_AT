using SaucedemoPOSimple.Helpers.Configuration;
using SaucedemoPOSimple.Pages;
using SaucedemoPOSimple.Pages.ItemsSmall;

namespace SaucedemoPOSimple.Tests
{
    public class RemoveTest : BaseTest
    {
        [Test]
        [Order(5)]
        [Category("PositiveTest")]
        [Category("RemoveTest")]
        [Description("Проверка удаления товара из корзины со страницы inventory")]
        public void RemoveBikeLiteItemTest()
        {
            LoginPage loginPage = new LoginPage(Driver, true);
            InventoryPage inventoryPage = loginPage.SuccessLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            inventoryPage.BikeLiteItemSmall.AddItem();
            inventoryPage.BikeLiteItemSmall.RemoveItem();

            Assert.That(inventoryPage.BikeLiteItemSmall.IsItemNotAddedToCart());
        }
    }
}