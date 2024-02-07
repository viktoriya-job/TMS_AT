

using PageObjectSimple.Helpers.Configuration;
using PageObjectSimple.Steps;

namespace PageObjectSimple.Tests
{
    public class LoginTest : BaseTest
    {
        [Test]
        public void SuccessLoginTest()
        {
            NavigationSteps.NavigateToLoginPage();
            NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            Assert.IsTrue(NavigationSteps.DashboardPage.IsPageOpened());
        }
    }
}