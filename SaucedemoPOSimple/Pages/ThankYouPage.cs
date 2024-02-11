using OpenQA.Selenium;

namespace SaucedemoPOSimple.Pages
{
    public class ThankYouPage : BasePage
    {
        private static string EndPoint = "/checkout-complete.html";

        private static readonly By CompleteMessageBy = By.ClassName("complete-header");
        private static readonly By BackButtonBy = By.Id("back-to-products");

        public ThankYouPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement CompleteMessage => WaitsHelper.WaitForExists(CompleteMessageBy);
        public IWebElement BackButton => WaitsHelper.WaitForExists(BackButtonBy);

        public override bool IsPageOpened() => CompleteMessage.Displayed && BackButton.Displayed;

        protected override string GetEndpoint() => EndPoint;
    }
}