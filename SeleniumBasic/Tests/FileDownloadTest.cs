using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumAdvanced.Core;
using SeleniumExtras.WaitHelpers;
using System.Reflection;
using System.Threading;

namespace SeleniumAdvanced.Tests
{
    internal class FileDownloadTest : BaseTest
    {
        [Test]
        public void FileDownloadSuccessTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/download");

            string fileName = "text.txt";
            string filePath = Path.Combine(DriverFactory.PathForDownload, fileName);

            WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText(fileName)).Click();

            Assert.That(WaitsHelper.WaitFileForExist(filePath, TimeSpan.FromSeconds(10)));
        }
    }
}