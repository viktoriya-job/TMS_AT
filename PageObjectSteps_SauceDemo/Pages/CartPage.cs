using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Pages.ItemsSmall;
using System.Collections.ObjectModel;

namespace PageObjectStepsSauceDemo.Pages
{
    public class CartPage : BasePage
    {
        private static string EndPoint = "/cart.html";

        private static readonly By TitleLabelBy = By.ClassName("title");
        private static readonly By CheckoutButtonBy = By.Id("checkout");
        private static readonly By CartItemsBy = By.ClassName("cart_item");

        public CartPage(IWebDriver driver) : base(driver) { }
        public CartPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

        public IWebElement TitleLable() => WaitsHelper.WaitForExists(TitleLabelBy);
        public IWebElement CheckoutButton() => WaitsHelper.WaitForExists(CheckoutButtonBy);
        public ReadOnlyCollection<IWebElement> CartItems() => Driver.FindElements(CartItemsBy);

        public override bool IsPageOpened()
        {
            try
            {
                return TitleLable().Text.Trim() == "Your Cart";
            }
            catch (Exception)
            {
                return false;
            }
        }
        protected override string GetEndpoint() => EndPoint;
        public bool IsCartEmpty() => CartItems().Count.Equals(0);
    }
}