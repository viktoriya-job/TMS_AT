using Task1.Steps;
using Task1.Helpers.Configuration;
using Task1.Pages;

namespace Task1.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessLoginTest()
    {
        DashboardPage dashboardPage = NavigationSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(dashboardPage.IsPageOpened);
    }

    [Test]
    public void InvalidUsernameLoginTest()
    {
        // Проверка
        Assert.That(
            NavigationSteps
                .IncorrectLogin("ssdd", "12345")
                .GetErrorLabelText(),
            Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }
}