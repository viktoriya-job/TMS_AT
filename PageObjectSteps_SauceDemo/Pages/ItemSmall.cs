using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Helpers;

namespace PageObjectStepsSauceDemo.Pages
{
    public class ItemSmall : BasePage
    {
        private IWebElement _element;

        private static readonly By _itemTitleBy = By.ClassName("inventory_item_name");
        private static readonly By _addButtonBy = By.ClassName("btn_primary");
        private static readonly By _removeButtonBy = By.ClassName("btn_secondary");

        public ItemSmall(IWebDriver? driver, IWebElement element) : base(driver)
        {
            _element = element;
        }

        public IWebElement ItemTitle => WaitsHelper.WaitChildElement(_element, _itemTitleBy);
        public IWebElement AddButton => WaitsHelper.WaitChildElement(_element, _addButtonBy);
        public IWebElement RemoveButton => WaitsHelper.WaitChildElement(_element, _removeButtonBy);
        
        public bool IsItemAddedToCart() => RemoveButton.Enabled;
        public bool IsItemNotAddedToCart() => AddButton.Enabled;

        [AllureStep("Add item")]
        public void AddItem() => AddButton.Click();

        [AllureStep("Remove Item")]
        public void RemoveItem() => RemoveButton.Click();

        public override bool IsPageOpened() => ItemTitle.Displayed;
        protected override string GetEndpoint()
        {
            throw new NotImplementedException();
        }
    }
}