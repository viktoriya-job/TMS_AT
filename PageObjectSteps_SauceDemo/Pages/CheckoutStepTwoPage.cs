using OpenQA.Selenium;

namespace PageObjectStepsSauceDemo.Pages
{
    public class CheckoutStepTwoPage : BasePage
    {
        private static string EndPoint = "/checkout-step-two.html";

        private static readonly By TitleLabelBy = By.ClassName("title");
        private static readonly By FinishButtonBy = By.Id("finish");

        public CheckoutStepTwoPage(IWebDriver driver) : base(driver) { }
        public CheckoutStepTwoPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

        public IWebElement TitleLable() => WaitsHelper.WaitForExists(TitleLabelBy);
        public IWebElement FinishButton() => WaitsHelper.WaitForExists(FinishButtonBy);

        public override bool IsPageOpened()
        {
            try
            {
                return TitleLable().Text.Trim() == "Checkout: Overview";
            }
            catch (Exception)
            {
                return false;
            }
        }
        protected override string GetEndpoint() => EndPoint;
    }
}