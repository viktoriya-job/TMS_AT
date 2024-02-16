﻿using NUnit.Framework.Interfaces;
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
            NavigationSteps.SuccessLogin(username, password);
            //UserSteps.SuccessLogin(username, password);

            Assert.That(NavigationSteps.InventoryPage.IsPageOpened());
        }

        //[Test]
        //[Order(2)]
        //[Category("NegativeTest")]
        //[Category("LoginTest")]
        //public void FailureLockedOutUserLoginTest()
        //{
        //    LoginPage loginPage = new LoginPage(Driver, true);
        //    loginPage.FailureLogin("locked_out_user", "secret_sauce");
        //    Assert.That(loginPage.ErrorLabel.Text.Trim(), Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        //}

        //[Test]
        //[Order(3)]
        //[Category("NegativeTest")]
        //[Category("LoginTest")]
        //public void FailureUnknownUserLoginTest()
        //{
        //    LoginPage loginPage = new LoginPage(Driver, true);
        //    loginPage.FailureLogin("unknown", "qwerty");
        //    Assert.That(loginPage.ErrorLabel.Text.Trim(), Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        //}
    }
}
