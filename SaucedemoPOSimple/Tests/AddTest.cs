using SaucedemoPOSimple.Helpers.Configuration;
using SaucedemoPOSimple.Pages;
using SaucedemoPOSimple.Pages.ItemsSmall;

namespace SaucedemoPOSimple.Tests
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
            LoginPage loginPage = new LoginPage(Driver, true);
            InventoryPage inventoryPage = loginPage.SuccessLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            inventoryPage.BikeLiteItemSmall.AddItem();

            Assert.That(inventoryPage.BikeLiteItemSmall.IsItemAddedToCart());
        }
    }
}