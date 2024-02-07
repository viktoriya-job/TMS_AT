using System.Collections.ObjectModel;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced.Tests
{
    public class ContextMenuTest : BaseTest
    {
        [Test]
        public void ContextMenuSuccessTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/context_menu");

            var targetElement = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("hot-spot"));
            var actions = new Actions(Driver);

            actions
                .MoveToElement(targetElement, 10, 10)
                .ContextClick()
                .Build()
                .Perform();

            IAlert alert = Driver.SwitchTo().Alert();

            Assert.Multiple(() =>
            {
                Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));

                alert.Accept();

                Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.ClassName("example")).Displayed);
            });
        }
    }
}