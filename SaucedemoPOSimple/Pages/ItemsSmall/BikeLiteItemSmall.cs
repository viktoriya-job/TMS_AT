using OpenQA.Selenium;

namespace SaucedemoPOSimple.Pages.ItemsSmall
{
    public class BikeLiteItemSmall : BaseItemSmall
    {
        private static readonly By ItemLinkBy = By.Id("item_0_title_link");
        private static readonly By AddButtonBy = By.Id("add-to-cart-sauce-labs-bike-light");
        private static readonly By RemoveButtonBy = By.Id("remove-sauce-labs-bike-light");

        public IWebElement ItemLink => WaitsHelper.WaitForExists(ItemLinkBy);
        public IWebElement AddButton => WaitsHelper.WaitForExists(AddButtonBy);
        public IWebElement RemoveButton => WaitsHelper.WaitForExists(RemoveButtonBy);

        public override bool IsItemAddedToCart() => RemoveButton.Enabled;// && !AddButton.Enabled;

        public override void AddItem() => AddButton.Click();
        public override void RemoveItem() => RemoveButton.Click();
    }
}
