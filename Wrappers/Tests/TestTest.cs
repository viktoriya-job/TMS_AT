using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Wrappers.Elements;
using Wrappers.Helpers.Configuration;
using Wrappers.Pages.ProjectPages;


namespace Wrappers.Tests
{
    public class TestTest : BaseTest
    {
        [Test]
        public void Test()
        {
            UserSteps
                .SuccessfulLogin();

            AddTestCasePage addTestCasePage = new AddTestCasePage(Driver, true);
            //Console.WriteLine(addTestCasePage.TypeDropDown.DropElement.GetCssValue("display"));
            Console.WriteLine(addTestCasePage.TypeDropDown.DropDownMenuDisplayed);

            addTestCasePage.TypeDropDown.Click();
            Console.WriteLine(addTestCasePage.TypeDropDown.DropDownMenuDisplayed);
            //Console.WriteLine(addTestCasePage.TypeDropDown.DropElement.GetCssValue("display"));
        }
    }
}
