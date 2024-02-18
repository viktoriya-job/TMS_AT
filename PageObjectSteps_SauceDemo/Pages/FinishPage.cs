using OpenQA.Selenium;

namespace Wrappers.Pages
{
    public class FinishPage : BasePage
    {
        private static string _endPoint = "/checkout-complete.html";

        private static readonly By _titleLabelBy = By.ClassName("title");
        private static readonly By _completeMessageBy = By.ClassName("complete-header");
        private static readonly By _backButtonBy = By.Id("back-to-products");

        public FinishPage(IWebDriver driver) : base(driver) { }
        public FinishPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

        public IWebElement TitleLable => WaitsHelper.WaitForExists(_titleLabelBy);
        public IWebElement CompleteMessage => WaitsHelper.WaitForExists(_completeMessageBy);
        public IWebElement BackButton => WaitsHelper.WaitForExists(_backButtonBy);

        public override bool IsPageOpened()
        {
            try
            {
                return
                    CompleteMessage.Displayed
                    && BackButton.Displayed
                    && TitleLable.Text.Trim() == "Checkout: Complete!";
            }
            catch (Exception)
            {
                return false;
            }
        }
        protected override string GetEndpoint() => _endPoint;
    }
}