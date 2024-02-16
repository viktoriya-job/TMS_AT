﻿using OpenQA.Selenium;
using SaucedemoPOSteps.Helpers.Configuration;
using SaucedemoPOSteps.Core;

namespace SaucedemoPOSteps.Core
{
    public class Browser
    {
        public IWebDriver? Driver { get; }

        public Browser()
        {
            Driver = Configurator.BrowserType?.ToLower() switch
            {
                "chrome" => new DriverFactory().GetChromeDriver(),
                "firefox" => new DriverFactory().GetFirefoxDriver(),
                _ => Driver
            } ?? throw new InvalidOperationException("Browser is not supported.");

            Driver?.Manage().Window.Maximize();
            Driver?.Manage().Cookies.DeleteAllCookies();
            //Driver!.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }
    }
}