using NUnit.Framework.Interfaces;
using SaucedemoPOSimple.Pages;

namespace SaucedemoPOSimple.Tests
{
    public class LoginTest : BaseTest
    {
        [TestCaseSource(typeof(TestData), nameof(TestData.SuccessLoginUsers))]
        public void StandardUserLoginTest(string username, string password)
        {
            LoginPage loginPage = new LoginPage(Driver, true);
            InventoryPage inventoryPage = loginPage.SuccessLogin(username, password);
            Assert.That(inventoryPage.IsPageOpened());
        }

        [Test]
        public void FailureLockedOutUserLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver, true);
            loginPage.FailureLogin("locked_out_user", "secret_sauce");
            Assert.That(loginPage.ErrorLabel.Text.Trim(), Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        }

        [Test]
        public void FailureUnknownUserLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver, true);
            loginPage.FailureLogin("unknown", "qwerty");
            Assert.That(loginPage.ErrorLabel.Text.Trim(), Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        }
    }
}
