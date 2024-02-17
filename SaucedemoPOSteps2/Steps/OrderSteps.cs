using OpenQA.Selenium;
using SaucedemoPOSteps.Data;
using SaucedemoPOSteps.Pages;
using SaucedemoPOSteps.Pages.ItemsSmall;

namespace SaucedemoPOSteps.Steps
{
    public class OrderSteps : BaseStep
    {
        public OrderSteps(IWebDriver driver) : base(driver) { }

        public void AddProductsToCartFromInventoryPage(List<ProductNames> Products)
        {
            foreach (var product in Products)
            {
                switch(product)
                {
                    case ProductNames.Backpack:
                        new InventoryPage(Driver).BackpackItemSmall().AddItem();
                        break;

                    case ProductNames.BikeLite:
                        new InventoryPage(Driver).BikeLiteItemSmall().AddItem();
                        break;
                }
            }
        }

        //public void AddProductsToCartFromInventoryPage()
        //{
        //    new InventoryPage(Driver).BikeLiteItemSmall().AddItem();
        //}

        public void RemoveProductFromCart()
        {

        }
    }
}
