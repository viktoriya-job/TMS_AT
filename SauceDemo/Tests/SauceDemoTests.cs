
using OpenQA.Selenium;
using System.Xml.Linq;

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
            Assert.Multiple(() =>
            {
                Assert.That(Driver.FindElement(By.Id("root")).Displayed);

                Assert.That(Driver.FindElement(By.Name("password")).Displayed);

                Assert.That(Driver.FindElements(By.ClassName("form_group")).Count == 2);

                Assert.That(Driver.FindElements(By.TagName("input")).Count == 3);

                //Assert.IsFalse(Driver.FindElement(By.LinkText("https")).Displayed);
                //Assert.IsFalse(Driver.FindElement(By.PartialLinkText("https")).Displayed);

                Assert.That(Driver.FindElements(By.CssSelector(".form_group")).Count == 2);
                
                Assert.That(Driver.FindElement(By.CssSelector(".submit-button.btn_action")).Displayed);
                
                Assert.That(Driver.FindElement(By.CssSelector(".login_container .login_wrapper-inner")).Displayed);
                
                Assert.That(Driver.FindElement(By.CssSelector("#login_button_container")).Displayed);
                
                Assert.That(Driver.FindElement(By.CssSelector("form")).Displayed);
                
                Assert.That(Driver.FindElements(By.CssSelector("input.form_input")).Count == 2);

                Assert.That(Driver.FindElement(By.CssSelector("[type='submit']")).Displayed);

                Assert.IsTrue(Driver.FindElement(By.CssSelector("[class~='btn_action']")).Enabled);

                Assert.IsTrue(Driver.FindElement(By.CssSelector("[name|='user']")).Enabled);
                
                Assert.IsTrue(Driver.FindElement(By.CssSelector("[data-test^='login-b']")).Enabled);

                Assert.IsTrue(Driver.FindElement(By.CssSelector("[data-test$='button']")).Enabled);
                
                Assert.IsTrue(Driver.FindElement(By.CssSelector("[data-test*='n-b']")).Enabled);
            });

        }
    }
}
