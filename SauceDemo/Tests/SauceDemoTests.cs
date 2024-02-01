
using OpenQA.Selenium;

namespace SauceDemo.Tests
{
    internal class SauceDemoTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("https://www.saucedemo.com/"); ;
        }

        [Test]
        public void SauceDemoMultiTest()
        {
            //Driver.Navigate().GoToUrl("https://www.saucedemo.com/"); ;
            Assert.That(Driver.FindElement(By.Id("root")).Displayed);
        }
    }
}
