using OpenQA.Selenium;
using SaucedemoPOSimple.Pages.ItemsSmall;
using System.Collections.ObjectModel;

namespace SaucedemoPOSimple.Pages
{
    public class InventoryPage : BasePage
    {
        private static string EndPoint = "/inventory.html";

        private static readonly By TitleLabelBy = By.ClassName("title");

        public InventoryPage(IWebDriver? driver) : base(driver)
        {
        }
        public InventoryPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public IWebElement Title => WaitsHelper.WaitForExists(TitleLabelBy);
        public BackpackItemSmall BackpackItemSmall => new BackpackItemSmall(Driver);
        public BikeLiteItemSmall BikeLiteItemSmall => new BikeLiteItemSmall(Driver);

        public override bool IsPageOpened() => Title.Displayed;

        protected override string GetEndpoint() => EndPoint;
    }
}