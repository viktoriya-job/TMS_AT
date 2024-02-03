
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

                Assert.That(Driver.FindElements(By.LinkText("https://www.saucedemo.com/")).Count == 0);
                
                Assert.That(Driver.FindElements(By.PartialLinkText("https")).Count == 0);

                //By Css
                Assert.That(Driver.FindElements(By.CssSelector(".form_group")).Count == 2);
                
                Assert.That(Driver.FindElement(By.CssSelector(".submit-button.btn_action")).Displayed);
                
                Assert.That(Driver.FindElement(By.CssSelector(".login_container .login_wrapper-inner")).Displayed);
                
                Assert.That(Driver.FindElement(By.CssSelector("#login_button_container")).Displayed);
                
                Assert.That(Driver.FindElement(By.CssSelector("form")).Displayed);
                
                Assert.That(Driver.FindElements(By.CssSelector("input.form_input")).Count == 2);

                Assert.That(Driver.FindElement(By.CssSelector("[type='submit']")).Displayed);

                Assert.That(Driver.FindElement(By.CssSelector("[class~='btn_action']")).Displayed);

                Assert.That(Driver.FindElement(By.CssSelector("[name|='user']")).Displayed);
                
                Assert.That(Driver.FindElement(By.CssSelector("[data-test^='login-b']")).Displayed);

                Assert.That(Driver.FindElement(By.CssSelector("[data-test$='button']")).Displayed);
                
                Assert.That(Driver.FindElement(By.CssSelector("[data-test*='n-b']")).Displayed);

                //By XPath
                Assert.That(Driver.FindElement(By.XPath("//input[@id='login-button']")).Displayed);

                Assert.That(Driver.FindElement(By.XPath("//*[text()='visual_user']")).Displayed);

                Assert.That(Driver.FindElement(By.XPath("//input[contains(@name,'user')]")).Displayed);

                Assert.That(Driver.FindElement(By.XPath("//h4[contains(text(),'Password')]")).Displayed);

                Assert.That(Driver.FindElement(By.XPath("//input[@type='submit']/ancestor::form")).Displayed);

                Assert.That(Driver.FindElement(By.XPath("//div[@class='login_credentials_wrap']/descendant::h4[contains(text(),'Accepted')]")).Displayed);

                Assert.That(Driver.FindElement(By.XPath("//div[@class='error-message-container']/following::input")).Displayed);

                Assert.That(Driver.FindElement(By.XPath("//div[@class='login_credentials_wrap']/parent::div")).Displayed);
                
                Assert.That(Driver.FindElement(By.XPath("//div[@class='error-message-container']/preceding::input[@type='text']")).Displayed);
               
                Assert.That(Driver.FindElement(By.XPath("//input[@class='input_error form_input' and @type='password']")).Displayed);
            });

        }
    }
}
