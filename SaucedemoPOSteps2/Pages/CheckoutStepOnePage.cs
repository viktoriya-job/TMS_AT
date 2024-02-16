using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace SaucedemoPOSteps.Pages
{
    public class CheckoutStepOnePage : BasePage
    {
        private static string EndPoint = "/checkout-step-one.html";

        private static readonly By TitleLabelBy = By.ClassName("title");
        private static readonly By FirstnameInputBy = By.Id("first-name");
        private static readonly By LastnameInputBy = By.Id("last-name");
        private static readonly By PostalCodeInputBy = By.Id("postal-code");
        private static readonly By ContinueButtonBy = By.Id("continue");

        public CheckoutStepOnePage(IWebDriver driver) : base(driver) { }
        public CheckoutStepOnePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

        public IWebElement TitleLable() => WaitsHelper.WaitForExists(TitleLabelBy);
        public IWebElement FirstnameInput() => WaitsHelper.WaitForExists(FirstnameInputBy);
        public IWebElement LastnameInput() => WaitsHelper.WaitForExists(LastnameInputBy);
        public IWebElement PostalCodeInput() => WaitsHelper.WaitForExists(PostalCodeInputBy);
        public IWebElement ContinueButton() => WaitsHelper.WaitForExists(ContinueButtonBy);

        public override bool IsPageOpened()
        {
            try
            {
                return TitleLable().Text.Trim() == "Checkout: Your Information";
            }
            catch (Exception)
            {
                return false;
            }
        }
        protected override string GetEndpoint() => EndPoint;
    }
}