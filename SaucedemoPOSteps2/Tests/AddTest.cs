using SaucedemoPOSteps.Pages.ItemsSmall;
using SaucedemoPOSteps.Steps;
using SaucedemoPOSteps.Pages;
using SaucedemoPOSteps.Data;
using SaucedemoPOSteps.Helpers.Configuration;

namespace SaucedemoPOSteps.Tests
{
    public class AddTest : BaseTest
    {
        //[Test]
        //[Order(4)]
        //[Category("PositiveTest")]
        //[Category("AddTest")]
        //[Description("Проверка добавления товара в корзину на странице inventory")]
        //public void AddBikeLiteItemTest1()
        //{
        //    NavigationSteps.NavigateToLoginPage();
        //    InventoryPage InventoryPage = LoginSteps.SuccessLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        //    OrderSteps.AddProductsToCartFromInventoryPage();

        //    Assert.Multiple(() =>
        //    {
        //        Assert.That(InventoryPage.BikeLiteItemSmall().IsItemAddedToCart());
        //        CartPage CartPage = NavigationSteps.NavigateToCartPage();
        //        Assert.That(!CartPage.IsCartEmpty()); //надо бы проверять, что в корзине именно нужный товар, но пока так
        //    });
        //}

        [Test]
        [Order(4)]
        [Category("PositiveTest")]
        [Category("AddTest")]
        [Description("Проверка добавления товара в корзину на странице inventory")]
        public void AddBikeLiteItemTest()
        {
            NavigationSteps.NavigateToLoginPage();
            InventoryPage InventoryPage = LoginSteps.SuccessLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            OrderSteps.AddProductsToCartFromInventoryPage(
                new List<ProductNames> 
                {
                    ProductNames.BikeLite 
                });

            Assert.Multiple(() =>
            {
                Assert.That(InventoryPage.BikeLiteItemSmall().IsItemAddedToCart());
                CartPage CartPage = NavigationSteps.NavigateToCartPage();
                Assert.That(!CartPage.IsCartEmpty()); //надо бы проверять, что в корзине именно нужный товар, но пока так
            });
        }
    }
}