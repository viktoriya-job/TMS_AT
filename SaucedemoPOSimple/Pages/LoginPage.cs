using OpenQA.Selenium;

namespace SaucedemoPOSimple.Pages
{
    public class LoginPage : BasePage
    {
        private static string EndPoint = "";

        private static readonly By UsernameInputBy = By.Id("user-name");
        private static readonly By PasswordInputBy = By.Id("password");
        private static readonly By LoginButtonBy = By.Id("login-button");
        private static readonly By ErrorLabelBy = By.CssSelector("[data-test='error']");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public LoginPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public IWebElement UsernameInput => WaitsHelper.WaitForExists(UsernameInputBy);
        public IWebElement PasswordInput => WaitsHelper.WaitForExists(PasswordInputBy);
        public IWebElement LoginButton => WaitsHelper.WaitForExists(LoginButtonBy);
        public IWebElement ErrorLabel => WaitsHelper.WaitForExists(ErrorLabelBy);

        protected override string GetEndpoint() => EndPoint;

        public override bool IsPageOpened() => LoginButton.Displayed;

        public InventoryPage SuccessLogin(string username, string password)
        {
            UsernameInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            LoginButton.Click();

            return new InventoryPage(Driver);
        }

        public LoginPage FailureLogin(string username, string password)
        {
            UsernameInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            LoginButton.Click();

            return this;
        }
    }
}
