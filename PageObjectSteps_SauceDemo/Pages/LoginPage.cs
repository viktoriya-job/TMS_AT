using OpenQA.Selenium;

namespace PageObjectStepsSauceDemo.Pages
{
    public class LoginPage : BasePage
    {
        private static string _endPoint = "";

        private static readonly By _usernameInputBy = By.Id("user-name");
        private static readonly By _passwordInputBy = By.Id("password");
        private static readonly By _loginButtonBy = By.Id("login-button");
        private static readonly By _errorLabelBy = By.CssSelector("[data-test='error']");

        public LoginPage(IWebDriver driver) : base(driver) { }
        public LoginPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

        public IWebElement UsernameInput => WaitsHelper.WaitForExists(_usernameInputBy);
        public IWebElement PasswordInput => WaitsHelper.WaitForExists(_passwordInputBy);
        public IWebElement LoginButton => WaitsHelper.WaitForExists(_loginButtonBy);
        public IWebElement ErrorLabel => WaitsHelper.WaitForExists(_errorLabelBy);

        protected override string GetEndpoint() => _endPoint;
        public override bool IsPageOpened()
        {
            try
            {
                return LoginButton.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}