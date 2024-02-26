using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Helpers;
using PageObjectStepsSauceDemo.Pages.ItemsSmall;

namespace PageObjectStepsSauceDemo.Pages
{
    public class InventoryPage : BasePage
    {
        private static string _endPoint = "/inventory.html";
        private static readonly By _titleLabelBy = By.ClassName("title");

        public InventoryPage(IWebDriver driver) : base(driver) { }

        public IWebElement TitleLable => WaitsHelper.WaitForExists(_titleLabelBy);
        public SauceLabsBikeLightItemSmall SauceLabsBikeLightItemSmall => new (Driver);
        public SauceLabsBackpackItemSmall BackpackItemSmall => new (Driver);
        public SauceLabsBoltTShirtItemSmall SauceLabsBoltTShirtItemSmall => new (Driver);
        public SauceLabsOnesieItemSmall SauceLabsOnesieItemSmall => new (Driver);

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