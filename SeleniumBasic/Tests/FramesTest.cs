using OpenQA.Selenium;

namespace SeleniumAdvanced.Tests
{
    public class FramesTest : BaseTest
    {
        [Test]
        public void FramesSuccessTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/frames");

            WaitsHelper.WaitForExists(By.LinkText("iFrame")).Click();

            Driver.SwitchTo().Frame(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("mce_0_ifr")));

            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.TagName("p")).Text, Is.EqualTo("Your content goes here."));
        }
    }
}