using OpenQA.Selenium;

namespace PageObjectStepsSauceDemo.Pages
{
    public class ThankYouPage : BasePage
    {
        private static string EndPoint = "/checkout-complete.html";

        private static readonly By CompleteMessageBy = By.ClassName("complete-header");
        private static readonly By BackButtonBy = By.Id("back-to-products");

        public ThankYouPage(IWebDriver driver) : base(driver) { }
        public ThankYouPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

        public IWebElement CompleteMessage() => WaitsHelper.WaitForExists(CompleteMessageBy);
        public IWebElement BackButton() => WaitsHelper.WaitForExists(BackButtonBy);

        public override bool IsPageOpened()
        {
            try
            {
                return CompleteMessage().Displayed && BackButton().Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }
        protected override string GetEndpoint() => EndPoint;
    }
}