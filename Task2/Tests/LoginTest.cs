using Task2.Steps;
using Task2.Pages;

namespace Task2.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessLoginTest()
    {
        DashboardPage dashboardPage = NavigationSteps
            .SuccessfulLogin(Admin);

        Assert.That(dashboardPage.IsPageOpened);
    }
}