using OpenQA.Selenium;

namespace SaucedemoPOSimple.Pages.ItemsSmall
{
    public class BackpackItemSmall : BaseItemSmall
    {
        private static readonly By ItemLinkBy = By.Id("item_4_title_link");
        private static readonly By AddButtonBy = By.Id("add-to-cart-sauce-labs-backpack");
        private static readonly By RemoveButtonBy = By.Id("remove-sauce-labs-backpack");

        public BackpackItemSmall(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement ItemLink => WaitsHelper.WaitForExists(ItemLinkBy);
        public IWebElement AddButton => WaitsHelper.WaitForExists(AddButtonBy);
        public IWebElement RemoveButton => WaitsHelper.WaitForExists(RemoveButtonBy);

        public override bool IsItemAddedToCart() => RemoveButton.Enabled;
        public override bool IsItemNotAddedToCart() => AddButton.Enabled;

        public override void AddItem() => AddButton.Click();
        public override void RemoveItem() => RemoveButton.Click();

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        protected override string GetEndpoint()
        {
            throw new NotImplementedException();
        }
    }
}