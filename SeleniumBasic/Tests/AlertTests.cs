using OpenQA.Selenium;

namespace SeleniumAdvanced.Tests
{
    internal class AlertTests : BaseTest
    {
        [Test]
        public void InfoAdlertTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/javascript_alerts");

            Driver.FindElement(By.XPath("//button[. = 'Click for JS Alert']")).Click();

            IAlert alert = Driver.SwitchTo().Alert();

            Assert.That(alert.Text, Is.EqualTo("I am a JS Alert"));

            Thread.Sleep(2000);

            alert.Accept();
        }

        [Test]
        public void ConfirmAlertTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/javascript_alerts");

            Driver.FindElement(By.XPath("//button[. = 'Click for JS Confirm']")).Click();
            IAlert alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo("I am a JS Confirm"));
            Thread.Sleep(3000);
            alert.Dismiss();

            Driver.FindElement(By.XPath("//button[. = 'Click for JS Confirm']")).Click();
            IAlert alert1 = Driver.SwitchTo().Alert();
            Thread.Sleep(3000);
            alert1.Accept();
        }

        [Test]
        public void PromptAlertTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/javascript_alerts");

            Driver.FindElement(By.XPath("//button[. = 'Click for JS Prompt']")).Click();

            IAlert alert = Driver.SwitchTo().Alert();

            Assert.That(alert.Text, Is.EqualTo("I am a JS prompt"));

            alert.SendKeys("Everything is OK!");
            Thread.Sleep(3000);
            alert.Accept();
        }
    }
}