using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced.Tests
{
    public class DynamicControlsTest : BaseTest
    {
        [Test]
        public void DynamicControlsSuccessTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_controls");

            var buttonRemove = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("button[onclick = 'swapCheckbox()']"));
            var buttonEnable = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("button[onclick = 'swapInput()']"));
            var checkBox = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("input[type='checkbox']"));
            var inputText = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("input[type='text']"));

            Assert.Multiple(() =>
            {
                buttonRemove.Click();

                Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's gone!"));
                Assert.That(WaitsHelper.WaitForElementInvisible(checkBox));
                Assert.That(!inputText.Enabled);

                buttonEnable.Click();

                Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's enabled!"));
                Assert.That(inputText.Enabled);
            });
        }
    }
}