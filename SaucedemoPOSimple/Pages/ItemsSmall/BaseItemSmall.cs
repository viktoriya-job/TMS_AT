using OpenQA.Selenium;
using SaucedemoPOSimple.Helpers;
using SaucedemoPOSimple.Helpers.Configuration;

namespace SaucedemoPOSimple.Pages.ItemsSmall
{
    public abstract class BaseItemSmall : BasePage
    {
        protected BaseItemSmall(IWebDriver driver) : base(driver)
        {
        }

        public abstract bool IsItemAddedToCart();
        public abstract bool IsItemNotAddedToCart();
        public abstract void AddItem();
        public abstract void RemoveItem();
    }
}