using SaucedemoPOSteps.Data;
using SaucedemoPOSteps.Pages;
using SaucedemoPOSteps.Steps;

namespace SaucedemoPOSteps.Tests
{
    public class LoginTest : BaseTest
    {
        [TestCaseSource(typeof(TestData), nameof(TestData.SuccessLoginUsers))]
        [Order(1)]
        [Category("PositiveTest")]
        [Category("LoginTest")]
        [Description("Проверка успешного входа в систему")]
        public void UserLoginTest(string username, string password)
        {
            NavigationSteps.NavigateToLoginPage();

            Assert.That(
                LoginSteps
                .SuccessLogin(username, password)
                .IsPageOpened());
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.LockedOutLoginUsers))]
        [Order(2)]
        [Category("NegativeTest")]
        [Category("LoginTest")]
        [Description("Проверка логина заблокированного пользователя")]
        public void FailureLockedOutUserLoginTest(string username, string password)
        {
            NavigationSteps.NavigateToLoginPage();

            Assert.That(
                LoginSteps
                .FailureLogin(username, password)
                .ErrorLabel().Text.Trim(), Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.UnknownLoginUsers))]
        [Order(3)]
        [Category("NegativeTest")]
        [Category("LoginTest")]
        [Description("Проверка логина неизвестного пользователя")]
        public void FailureUnknownUserLoginTest(string username, string password)
        {
            NavigationSteps.NavigateToLoginPage();

            Assert.That(
                LoginSteps.FailureLogin(username, password)
                .ErrorLabel().Text.Trim(), Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        }
    }
}