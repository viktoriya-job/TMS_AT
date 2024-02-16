using OpenQA.Selenium;
using SaucedemoPOSteps.Pages;
using SaucedemoPOSteps.Pages.ItemsSmall;

namespace SaucedemoPOSteps.Steps
{
    public class OrderSteps : BaseStep
    {
        public OrderSteps(IWebDriver driver) : base(driver) { }

        //public void AddProductsToCartFromInventoryPage(List<string> Products)
        //{
        //    new InventoryPage(Driver).BikeLiteItemSmall().AddItem();
        //}

        public void AddProductsToCartFromInventoryPage()
        {
            new InventoryPage(Driver).BikeLiteItemSmall().AddItem();
        }

        public void RemoveProductFromCart()
        {

        }
    }
}
