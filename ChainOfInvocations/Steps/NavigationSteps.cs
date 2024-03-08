using ChainOfInvocations.Pages;
using OpenQA.Selenium;

namespace ChainOfInvocations.Steps;

public class NavigationSteps(IWebDriver driver) : BaseSteps(driver)
{
    public LoginPage NavigateToLoginPage() => new LoginPage(Driver, true);
    public DashboardPage NavigateToDashboardPage() => new DashboardPage(Driver, true);

    public DashboardPage SuccessfulLogin(string username, string password) => Login<DashboardPage>(username, password);
    public LoginPage IncorrectLogin(string username, string password) => Login<LoginPage>(username, password);

    private T Login<T>(string username, string password) where T : BasePage
    {
        LoginPage = new LoginPage(Driver);
        LoginPage.EmailInput.SendKeys(username);
        LoginPage.PswInput.SendKeys(password);
        LoginPage.LoginInButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}