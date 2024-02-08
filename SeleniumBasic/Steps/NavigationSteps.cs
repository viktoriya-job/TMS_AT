﻿using OpenQA.Selenium;
using PageObjectSimple.Pages;

namespace PageObjectSimple.Steps
{
    public class NavigationSteps : BaseSteps
    {
        public NavigationSteps(IWebDriver driver) : base(driver)
        {
        }

        public LoginPage NavigateToLoginPage()
        {
            return new LoginPage(Driver, true);
        }

        public DashboardPage SuccessfulLogin(string username, string psw)
        {
            Login(username, psw);
            return DashboardPage;
        }

        public LoginPage IncorrectLogin(string username, string psw)
        {
            Login(username, psw);
            return LoginPage;
        }

        private void Login(string username, string psw)
        {
            LoginPage.EmailInput().SendKeys(username);
            LoginPage.PswInput().SendKeys(psw);
            LoginPage.LoginInButton().Click();
        }
    }
}