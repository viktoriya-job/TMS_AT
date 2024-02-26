using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Helpers;
using PageObjectStepsSauceDemo.Pages.ItemsSmall;

namespace PageObjectStepsSauceDemo.Pages
{
    public class InventoryPage : BasePage
    {
        private static string _endPoint = "/inventory.html";
        private static readonly By _titleLabelBy = By.ClassName("title");

        public InventoryPage(IWebDriver driver) : base(driver) 
        {
            Driver = driver;
        }

        public IWebElement TitleLable => WaitsHelper.WaitForExists(_titleLabelBy);
        public SauceLabsBikeLightItemSmall sauceLabsBikeLightItemSmall = new (Driver);

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