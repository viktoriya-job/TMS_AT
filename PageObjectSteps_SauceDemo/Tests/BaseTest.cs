﻿using Allure.Net.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using PageObjectStepsSauceDemo.Core;
using PageObjectStepsSauceDemo.Steps;

namespace PageObjectStepsSauceDemo.Tests
{
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    [AllureNUnit]
    public class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        protected NavigationSteps NavigationSteps { get; private set; }
        protected LoginSteps LoginSteps { get; private set; }

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver;
            LoginSteps = new LoginSteps(Driver);
            NavigationSteps = new NavigationSteps(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}