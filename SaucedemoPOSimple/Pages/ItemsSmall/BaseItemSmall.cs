using OpenQA.Selenium;
using SaucedemoPOSimple.Helpers;
using SaucedemoPOSimple.Helpers.Configuration;

namespace SaucedemoPOSimple.Pages.ItemsSmall
{
    public abstract class BaseItemSmall
    {
        protected WaitsHelper WaitsHelper { get; private set; }
        public abstract bool IsItemAddedToCart();
        public abstract void AddItem();
        public abstract void RemoveItem();

    }
}
