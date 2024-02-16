using SaucedemoPOSteps.Helpers.Configuration;
using SaucedemoPOSteps.Pages.ItemsSmall;
using SaucedemoPOSteps.Pages;

namespace SaucedemoPOSteps.Tests
{
    public class AddTest : BaseTest
    {
        //[Test]
        //[Order(4)]
        //[Category("PositiveTest")]
        //[Category("AddTest")]
        //[Description("Проверка добавления товара в корзину на странице inventory")]
        //public void AddBikeLiteItemTest()
        //{
        //    LoginPage loginPage = new LoginPage(Driver, true);
        //    InventoryPage inventoryPage = loginPage.SuccessLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        //    inventoryPage.BikeLiteItemSmall.AddItem();

        //    Assert.Multiple(() =>
        //    {
        //        Assert.That(inventoryPage.BikeLiteItemSmall.IsItemAddedToCart());

        //        CartPage cartPage = new CartPage(Driver, true);
        //        Assert.That(!cartPage.IsCartEmpty()); //надо бы проверять, что в корзине именно нужный товар, но пока так
        //    });
        //}
    }
}