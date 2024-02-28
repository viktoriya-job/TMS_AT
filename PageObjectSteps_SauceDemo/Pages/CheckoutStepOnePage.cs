using NUnit.Allure.Attributes;
using OpenQA.Selenium;

namespace PageObjectStepsSauceDemo.Pages
{
    public class CheckoutStepOnePage : BasePage
    {
        private static string _endPoint = "/checkout-step-one.html";

        private static readonly By _titleLabelBy = By.ClassName("title");
        private static readonly By _firstnameInputBy = By.Id("first-name");
        private static readonly By _lastnameInputBy = By.Id("last-name");
        private static readonly By _postalCodeInputBy = By.Id("postal-code");
        private static readonly By _continueButtonBy = By.Id("continue");

        public CheckoutStepOnePage(IWebDriver driver) : base(driver) { }
        public CheckoutStepOnePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

        public IWebElement TitleLable => WaitsHelper.WaitForExists(_titleLabelBy);
        public IWebElement FirstnameInput => WaitsHelper.WaitForExists(_firstnameInputBy);
        public IWebElement LastnameInput => WaitsHelper.WaitForExists(_lastnameInputBy);
        public IWebElement PostalCodeInput => WaitsHelper.WaitForExists(_postalCodeInputBy);
        public IWebElement ContinueButton => WaitsHelper.WaitForExists(_continueButtonBy);

        [AllureStep("Checking is the CheckoutStepOne page opened")]
        public override bool IsPageOpened()
        {
            try
            {
                return TitleLable.Text.Trim() == "Checkout: Your Information";
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected override string GetEndpoint() => _endPoint;
    }
}