using Task3.Steps;
using Task3.Pages;

namespace Task3.Tests;

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