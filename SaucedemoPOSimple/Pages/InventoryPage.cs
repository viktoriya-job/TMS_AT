using OpenQA.Selenium;
using SaucedemoPOSimple.Pages.ItemsSmall;
using System.Collections.ObjectModel;

namespace SaucedemoPOSimple.Pages
{
    public class InventoryPage : BasePage
    {
        public BackpackItemSmall BackpackItemSmall { get; } = new BackpackItemSmall();
        public BikeLiteItemSmall BikeLiteItemSmall { get; } = new BikeLiteItemSmall();
        private static string EndPoint = "/inventory.html";

        private static readonly By TitleLabelBy = By.ClassName("title");

        public InventoryPage(IWebDriver? driver) : base(driver)
        {
        }
        public InventoryPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public IWebElement Title => WaitsHelper.WaitForExists(TitleLabelBy);

        public override bool IsPageOpened() => Title.Displayed;

        protected override string GetEndpoint() => EndPoint;
    }
}
