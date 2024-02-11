using SaucedemoPOSimple.Helpers.Configuration;
using SaucedemoPOSimple.Pages;
using SaucedemoPOSimple.Pages.ItemsSmall;

namespace SaucedemoPOSimple.Tests
{
    public class AddTest : BaseTest
    {
        [Test]
        public void AddOneItemTest()
        {
            LoginPage loginPage = new LoginPage(Driver, true);
            InventoryPage inventoryPage = loginPage.SuccessLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            inventoryPage.BikeLiteItemSmall.AddItem();

            Assert.That(inventoryPage.BikeLiteItemSmall.IsItemAddedToCart());
        }
    }
}
