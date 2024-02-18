using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Wrappers.Pages
{
    public class CartPage : BasePage
    {
        private static string _endPoint = "/cart.html";

        private static readonly By _titleLabelBy = By.ClassName("title");
        private static readonly By _checkoutButtonBy = By.Id("checkout");
        private static readonly By _cartItemsBy = By.ClassName("cart_item");

        public CartPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

        public IWebElement TitleLable => WaitsHelper.WaitForExists(_titleLabelBy);
        public IWebElement CheckoutButton => WaitsHelper.WaitForExists(_checkoutButtonBy);
        public ReadOnlyCollection<IWebElement> CartItems => Driver.FindElements(_cartItemsBy);

        public override bool IsPageOpened()
        {
            try
            {
                return TitleLable.Text.Trim() == "Your Cart";
            }
            catch (Exception)
            {
                return false;
            }
        }
        protected override string GetEndpoint() => _endPoint;

        [AllureStep("Checking is the cart is empty")]
        public bool IsCartEmpty() => CartItems.Count.Equals(0);
    }
}