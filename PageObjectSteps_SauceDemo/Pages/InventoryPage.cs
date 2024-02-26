using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Helpers;

namespace PageObjectStepsSauceDemo.Pages
{
    public class InventoryPage : BasePage
    {
        private static string _endPoint = "/inventory.html";
        private static readonly By _titleLabelBy = By.ClassName("title");
        private static readonly By _itemsSmallBy = By.ClassName("inventory_item");
        public List<ItemSmall> ItemsSmall { get; set; }

        public InventoryPage(IWebDriver? driver) : base(driver) 
        {
            ItemsSmall = new List<ItemSmall>();
            foreach (var item in WaitsHelper.WaitForAllVisibleElementsLocatedBy(_itemsSmallBy))
            {
                ItemsSmall.Add(new ItemSmall(driver, item));
            }
        }
        public IWebElement TitleLable => WaitsHelper.WaitForExists(_titleLabelBy);

        public override bool IsPageOpened()
        {
            try
            {
                return TitleLable.Text.Trim() == "Products";
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected override string GetEndpoint() => _endPoint;
    }
}