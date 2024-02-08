using OpenQA.Selenium;
using System.Reflection;

namespace SeleniumAdvanced.Tests
{
    public class FileUploadTest : BaseTest
    {
        [Test]
        public void FileUploadSuccessTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

            string location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(location, "Resources", "msg1205352859-4623.jpg");
            var fileUploadInput = WaitsHelper.WaitForExists(By.Id("file-upload"));
            var fileUploadSubmitButton = WaitsHelper.WaitForExists(By.Id("file-submit"));

            fileUploadInput.SendKeys(path);
            fileUploadSubmitButton.Click();

            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("uploaded-files")).Text, Is.EqualTo("msg1205352859-4623.jpg"));
        }
    }
}