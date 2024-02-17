using OpenQA.Selenium;

namespace PageObjectStepsSauceDemo.Pages
{
    public class CheckoutStepTwoPage : BasePage
    {
        private static string _endPoint = "/checkout-step-two.html";

        private static readonly By _titleLabelBy = By.ClassName("title");
        private static readonly By _finishButtonBy = By.Id("finish");

        public CheckoutStepTwoPage(IWebDriver driver) : base(driver) { }
        public CheckoutStepTwoPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

        public IWebElement TitleLable() => WaitsHelper.WaitForExists(_titleLabelBy);
        public IWebElement FinishButton() => WaitsHelper.WaitForExists(_finishButtonBy);

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
        protected override string GetEndpoint() => _endPoint;
    }
}